using Pharmacy.BL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pharmacy.DAL
{

    public class Medecines
    {
        public Medecines()
        {
        }

        #region properties

        public string ATC { get; set; }
        public string B_G { get; set; }
        public string Ingredients { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Dosage { get; set; }
        public string Volume { get; set; }
        public Nullable<int> m_form { get; set; }
        public string Way_of_use { get; set; }
        public Nullable<int> Supplier { get; set; }
        public string Laboratory { get; set; }
        public string Manufacturing_country { get; set; }
        public float Price { get; set; }
        public Nullable<double> Percentage_of_gain { get; set; }
        public Nullable<double> Plus_margin_gain { get; set; }
        public string Stratum { get; set; }
        public string Responsible_Party_Name { get; set; }
        public string Responsible_Party_Country { get; set; }
        public Nullable<System.DateTime> Exch_date { get; set; }

        public virtual M_form M_form { get; set; }
        public virtual DataTable InvoiceDetails { get; set; }
        public virtual Supplier Supplier1 { get; set; }
        public virtual DataTable SalesDetails { get; set; }

        #endregion

        #region functions
        public static DataTable GetMedecines(DataLayer dt) 
        {
            DataTable medecines=  dt.GetData_StoredProcedure("GetMedecinesTest", "Medecines");
            return medecines;
        }


        #endregion


    }
    public class M_form
    {
        public M_form()
        {
        }

        public int ID { get; set; }
        public string Form1 { get; set; }
        public virtual DataTable Medecines { get; set; }
    }
    public class Invoice 
    {
        public Invoice()
        {
        }
        public Invoice(int ID,DateTime InvoiceDate,int? supplier)
        {
            this.ID = ID;
            this.InvoiceDate = InvoiceDate;
            this.Supplier = supplier;
        }

        public int ID { get; set; }
        public DateTime InvoiceDate { get; set; }
        public bool IsPayed { get; set; }
        public int? Supplier { get; set; }
        public virtual DataTable InvoiceDetails { get; set; }
        public virtual DataTable Payments { get; set; }

        #region functions
        public bool AddInvoice(DataLayer dt)
        {
            int rep = 0;
            try
            {
                object[,] Params = new object[2, 4];
                Params[0, 0] = "@InvoiceID";
                Params[1, 0] = this.ID;
                Params[0, 1] = "@InvoiceDate";
                Params[1, 1] = Transform.DateToString(this.InvoiceDate);
                Params[0, 2] = "@IsPayed";
                Params[1, 2] = 0;
                Params[0, 3] = "@SupplierID";
                Params[1, 3] = this.Supplier;
                rep = dt.ExecuteActionCommand_StoredProcedure("AddInvoice", Params);
                if (rep > 0) return true;
                else return false;
            }
            catch { return false; }
        }
        #endregion
    }

    public class InvoiceDetails
    {
        public InvoiceDetails() { }
        public InvoiceDetails(int MedecineID, int InvoiceID, int Quantity, float UnitPrice, float VAT, DateTime ExpiryDate,float discount)
        {
            this.MedecineID = MedecineID;
            this.InvoiceID = InvoiceID;
            this.Quantity = Quantity;
            this.UnitPrice = UnitPrice;
            this.VAT = VAT;
            this.ExpiryDate = ExpiryDate;
            this.Discount = discount;
        }
        public InvoiceDetails(string MedecineID, int InvoiceID, string Quantity, string UnitPrice, string VAT, string ExpiryDate, string discount)
        {
            this.MedecineID =int.Parse(MedecineID);
            this.InvoiceID = InvoiceID;
            this.Quantity = int.Parse(Quantity);
            this.UnitPrice = float.Parse(UnitPrice);
            this.VAT =float.Parse(VAT);
            this.ExpiryDate =Transform.StringToDate(ExpiryDate);
            this.Discount =float.Parse(discount);
        }
        public int InvoiceID { get; set; }
        public int MedecineID { get; set; }
        public int Quantity { get; set; }
        public float UnitPrice { get; set; }
        public float VAT { get; set; }
        public DateTime ExpiryDate { get; set; }
        public float Discount { get; set; }

        public virtual Invoice Invoice { get; set; }
        public virtual Medecines Medecine { get; set; }//function


        #region functions
        public bool AddInvoiceDetails(DataLayer dt)
        {
            int rep = 0;
            try
            {
                object[,] Params = new object[2, 7];
                Params[0, 0] = "@InvoiceID";
                Params[1, 0] = this.InvoiceID;
                Params[0, 1] = "@MedecineID";
                Params[1, 1] = this.MedecineID;
                Params[0, 2] = "@Quantity";
                Params[1, 2] = this.Quantity;
                Params[0, 3] = "@UnitPrice";
                Params[1, 3] = this.UnitPrice;
                Params[0, 4] = "@Discount";
                Params[1, 4] = this.Discount;
                Params[0, 5] = "@VAT";
                Params[1, 5] = this.VAT;
                Params[0, 6] = "@ExpiryDate";
                Params[1, 6] =Transform.DateToString(this.ExpiryDate);
                rep = dt.ExecuteActionCommand_StoredProcedure("AddInvoiceDetails", Params);
                if (rep > 0) return true;
                else return false;
            }
            catch { return false; }
        }
        #endregion
    }
    public class Payment
    {
        public int ID { get; set; }
        public int InvoiceID { get; set; }
        public Nullable<System.DateTime> PaymentDate { get; set; }
        public string Amount { get; set; }

        public virtual Invoice Invoice { get; set; }
    }
    public class Sales
    {
        public Sales()
        {
        }
        public int ID { get; set; }
        public Nullable<System.DateTime> SaleDate { get; set; }
        public virtual DataTable SalesDetails { get; set; }
    }
    public class SalesDetails
    {
        public int SaleID { get; set; }
        public int MedecineID { get; set; }
        public int Quantity { get; set; }
        public string UnitPrice { get; set; }
        public Nullable<double> Discount { get; set; }

        public virtual Medecines Medecine { get; set; }
        public virtual Sales Sale { get; set; }
    }
    public class Supplier
    {
        public Supplier()
        {
        }

        public int ID { get; set; }
        public string Supplier1 { get; set; }

        public virtual DataTable Medecines { get; set; }
    }

    public class Stocks 
    {
        public Stocks() { }
        public Stocks(int ID)
        {
            this.ID = ID;
        }
        public Stocks(DataLayer dt,int ID)
        {
            this.ID = ID;
            this.Quantity = GetQuantity(dt);
        }
        #region Properties
        public int ID { get; set; }
        public int Quantity { get; set; }
        #endregion
        #region functions
        public int GetQuantity(DataLayer dt) 
        {
            object[,] Params = new object[2, 2];
            Params[0, 0] = "@M_ID";
            Params[1, 0] = this.ID;
            object Qty = dt.GetValue_Query("PriceAveragePerUnit", Params);
            return (int.Parse(Qty.ToString()));
        }
        public bool UpdateStocks(DataLayer dt, int AddedQuantity)
        {
            int rep = 0;
            try
            {
                object[,] Params = new object[2, 2];
                Params[0, 0] = "@M_ID";
                Params[1, 0] = this.ID;
                Params[0, 1] = "@Qty";
                Params[1, 1] = AddedQuantity;
                rep = dt.ExecuteActionCommand_StoredProcedure("UpdateStocks", Params);
                if (rep > 0) return true;
                else return false;
            }
            catch { return false; }
        }
        public static bool UpdateStocks(DataLayer dt,int M_ID,int AddedQuantity)
        {
            int rep = 0;
            try
            {
                object[,] Params = new object[2, 2];
                Params[0, 0] = "@M_ID";
                Params[1, 0] = M_ID;
                Params[0, 1] = "@Qty";
                Params[1, 1] = AddedQuantity;
                rep = dt.ExecuteActionCommand_StoredProcedure("UpdateStocks", Params);
                if (rep > 0) return true;
                else return false;
            }
            catch { return false; }
        }
        #endregion

    }

}
