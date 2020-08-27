using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.DAL
{
    class Medecines_Functions
    {
    }
    class Invoice_Functions
    {
       
    }
    class InvoiceDetails_functions
    {
        public static bool AddInvoiceDetails(DataLayer dt, object[,] Params)
        {
            int rep = 0;
            try
            {
                rep = dt.ExecuteActionCommand_StoredProcedure("AddInvoiceDetails", Params);
                if (rep > 0) return true;
                else return false;
            }
            catch { return false; }
        }
    }
}
