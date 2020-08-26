using Pharmacy.PL.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.BL
{
    class Filling
    {
        public static void FillComboBox(ComboBox comboBox, DataTable dt, string ValueMember, string DisplayMember)
        {
            comboBox.DataSource = dt;
            comboBox.DisplayMember = DisplayMember;
            comboBox.ValueMember = ValueMember;
        }

        public static void FillComboBox(MyComboBox1 comboBox, DataTable dt, string ValueMember, string DisplayMember)
        {
            comboBox.ComboBoxDataSource = dt;
            comboBox.ComboBoxDisplayMember = DisplayMember;
            comboBox.ComboBoxValueMember = ValueMember;
        }


    }
    class Transform
    {
        public static DataTable DataGridViewToDataTable(DataGridView dataGridView)
        {
            DataTable dt = new DataTable();
            dt = dataGridView.DataSource as DataTable;
            return dt;
        }
        public static DataTable DataGridViewToDataTableByLoop(DataGridView dgv)
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                dt.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }
            return dt;
        }

        public static string DateTimeToString(DateTime myDateTime) 
        {
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
            return sqlFormattedDate;
        }
        public static DateTime StringToDate(string s)
        {
            return DateTime.ParseExact(s, "yyyyMMdd", CultureInfo.InvariantCulture);
        }
        public static DateTime StringToDateTime(string s)
        {
            return DateTime.ParseExact(s, "yyyyMMddHHmmss", CultureInfo.InvariantCulture);
        }
    }
}
