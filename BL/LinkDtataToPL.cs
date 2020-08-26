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
        public static void FillProductsComboBox(InvoiceForm f) 
        {
            DataTable medecines;
            medecines = dt.GetData_StoredProcedure("GetMedecinesNames", "medecines");
            Filling.FillComboBox(f.myComboBox11, medecines, "ID", "Name");
        }
        public static void AddRow_InvoiceDataGridView(InvoiceForm f)
        {
            DataTable medecinesData;
            object[,] Params = new object[2, 1];
            Params[0, 0] = "@M_ID";
            Params[1, 0] = f.myComboBox11.ComboBoxSelectedValue;
            medecinesData = dt.GetData_StoredProcedure("GetMedecineByID_Invoice", Params, "medecines");
            //DataGridViewRow row = (DataGridViewRow)f.dataGridView11.Rows[0].Clone();
            string id= medecinesData.Rows[0]["ID"].ToString();
            string name= (string)medecinesData.Rows[0]["Name"];
            string Price= medecinesData.Rows[0]["Price"].ToString();
            string Discount= medecinesData.Rows[0]["Discount"].ToString()+"%";
            string quantity = "2";
            string TotalPrice = ((float.Parse(Price)) * ((100 - float.Parse(Discount.Replace("%","")))/100) * (int.Parse(quantity))).ToString();
            f.dataGridView11.Rows.Add(id,name,"","",quantity,Price,Discount,TotalPrice);
           // f.dataGridView11.DataSource = medecinesData;

        }
        #endregion


        #region InvoiceDetailsForm

        #endregion
    }
}
