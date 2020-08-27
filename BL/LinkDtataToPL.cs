using Pharmacy.PL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy.DAL;
using System.Data;
using System.Windows.Forms;

namespace Pharmacy.BL
{
    class LinkDtataToPL
    {
        public static DataLayer dt = new DataLayer(@"QSC-2019\SQLEXPRESS", "Pharmacy");

        #region InvoiceForm
        public static void FillSupplierComboBox(InvoiceForm f)
        {
            DataTable suppliers;
            suppliers = dt.GetData_StoredProcedure("GetSuppliersNames", "suppliers");
            Filling.FillComboBox(f.comboBox1, suppliers, "ID", "Supplier");
        }
        public static void FillProductsComboBox(InvoiceForm f) 
        {
            DataTable medecines;
            try
            {
                if (f.comboBox1.SelectedValue == null)
                    MessageBox.Show("please select a Supplier");
                else
                {
                    object[,] Params = new object[2, 1];
                    Params[0, 0] = "@S_ID";
                    Params[1, 0] = f.comboBox1.SelectedValue;
                    medecines = dt.GetData_StoredProcedure("GetMedecinesINDVBySupplier", Params, "medecines");
                    medecines.Columns.Add("Info");
                    foreach (DataRow item in medecines.Rows)
                    {
                        item["Info"] = item["Name"].ToString() +"  -  "+item["Dosage"].ToString() +"  -  "+item["Volume"].ToString();
                    }
                    Filling.FillComboBox(f.myComboBox11, medecines, "ID", "Info");
                }
            }
            catch { MessageBox.Show("ERROR!!"); }
        }
        public static void AddRow_InvoiceDataGridView(InvoiceForm f)
        {
            DataTable medecinesData;
            object[,] Params = new object[2, 1];
            Params[0, 0] = "@M_ID";
            Params[1, 0] = f.myComboBox11.ComboBoxSelectedValue;
            medecinesData = dt.GetData_StoredProcedure("GetMedecineByID_Invoice", Params, "medecines");
            string id= medecinesData.Rows[0]["ID"].ToString();
            string name= (string)medecinesData.Rows[0]["Name"];
            string Price= medecinesData.Rows[0]["Price"].ToString();
            string Discount= medecinesData.Rows[0]["Discount"].ToString()+"%";
            string quantity = "1";
            string VAT = "0";
            string TotalPrice = ((float.Parse(Price)) * ((100 - float.Parse(Discount.Replace("%","")))/100) * (int.Parse(quantity))).ToString();
            f.dataGridView11.Rows.Add(id,name,"",VAT,quantity,Price,Discount,TotalPrice);
        }

        public static void UpdateTotalPrices(object sender,EventArgs e) 
        {
            PL.Controls.DataGridView1 dataGridView1 = (PL.Controls.DataGridView1)sender;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                string VAT = r.Cells["VAT"].Value.ToString();
                string Price = r.Cells["Price"].Value.ToString();
                string Discount = r.Cells["Discount"].Value.ToString();
                string quantity = r.Cells["Quantity"].Value.ToString();
                float tp = (float.Parse(Price)) * ((100 - float.Parse(Discount.Replace("%", ""))) / 100) * (int.Parse(quantity));
                string TotalPrice =(((float.Parse(VAT.Replace("%", "")) / 100)*tp)+tp).ToString();
                r.Cells["TotalPrice"].Value = TotalPrice;
            }
        }
        public static void Save_Invoice(InvoiceForm f) 
        {
            //save Invoice
            try
            {
                if (f.bunifuDatepicker1.Value != null && (f.Textbox1ID.Text != "" || f.Textbox1ID.Text != null))
                {
                   //save Invoiec
                   int InvID = int.Parse(f.Textbox1ID.Text);
                   DateTime InvDate = f.bunifuDatepicker1.Value;
                   int InvSupplier=int.Parse(f.comboBox1.SelectedValue.ToString());
                   Invoice inv = new Invoice(InvID,InvDate,InvSupplier);
                   inv.AddInvoice(dt);
                    //save InvoiceDetails
                    InvoiceDetails invDetails;
                     foreach (DataGridViewRow r in f.dataGridView11.Rows)
                        {
                            string MedecineID = r.Cells["ProductID"].Value.ToString();
                            string VAT = r.Cells["VAT"].Value.ToString();
                            string Price = r.Cells["Price"].Value.ToString();
                            string Discount = r.Cells["Discount"].Value.ToString();
                            string quantity = r.Cells["Quantity"].Value.ToString();
                            string expiryDate = r.Cells["Date"].Value.ToString();
                            invDetails = new InvoiceDetails(MedecineID, InvID, quantity, Price, VAT.Replace("%", ""), expiryDate, Discount.Replace("%", ""));
                            invDetails.AddInvoiceDetails(dt);
                            Stocks.UpdateStocks(dt, int.Parse(MedecineID), int.Parse(quantity));
                        }
                }
                else { MessageBox.Show("Please Fill ID and Date "); }
            }
            catch
            {
                //ADD DELETE FUNCTION
                MessageBox.Show("ERROR!!");
            }

        }
        #endregion


        #region InvoiceDetailsForm

        #endregion
    }
}
