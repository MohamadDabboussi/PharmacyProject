using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pharmacy.DAL
{

    class Medecines
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
        public string Price { get; set; }
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
    class M_form
    {
        public M_form()
        {
        }

        public int ID { get; set; }
        public string Form1 { get; set; }
        public virtual DataTable Medecines { get; set; }
    }
    class Invoice 
    {
        public Invoice()
        {
        }

        public int ID { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public virtual DataTable InvoiceDetails { get; set; }
        public virtual DataTable Payments { get; set; }
    }

    class InvoiceDetails
    {
        public int InvoiceID { get; set; }
        public int MedecineID { get; set; }
        public int Quantity { get; set; }
        public string UnitPrice { get; set; }
        public Nullable<double> Discount { get; set; }

        public virtual Invoice Invoice { get; set; }
        public virtual Medecines Medecine { get; set; }
    }
    class Payment
    {
        public int ID { get; set; }
        public int InvoiceID { get; set; }
        public Nullable<System.DateTime> PaymentDate { get; set; }
        public string Amount { get; set; }

        public virtual Invoice Invoice { get; set; }
    }
    class Sales
    {
        public Sales()
        {
        }
        public int ID { get; set; }
        public Nullable<System.DateTime> SaleDate { get; set; }
        public virtual DataTable SalesDetails { get; set; }
    }
    class SalesDetails
    {
        public int SaleID { get; set; }
        public int MedecineID { get; set; }
        public int Quantity { get; set; }
        public string UnitPrice { get; set; }
        public Nullable<double> Discount { get; set; }

        public virtual Medecines Medecine { get; set; }
        public virtual Sales Sale { get; set; }
    }
    class Supplier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Supplier()
        {
        }

        public int ID { get; set; }
        public string Supplier1 { get; set; }

        public virtual DataTable Medecines { get; set; }
    }
}
