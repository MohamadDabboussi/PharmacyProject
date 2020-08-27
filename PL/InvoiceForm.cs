using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharmacy.BL;

namespace Pharmacy.PL
{
    public partial class InvoiceForm : Form
    {
        
        public InvoiceForm()
        {
            InitializeComponent();
            Textbox1ID.MouseEnter += DesignFunctions.RemoveTextBunifu;
            Textbox1ID.MouseLeave += DesignFunctions.AddTextBunifu;
            LinkDtataToPL.FillSupplierComboBox(this);
            DateTime dtt= bunifuDatepicker1.Value = DateTime.Now;
            dataGridView11.Columns["Date"].DefaultCellStyle.Format = "dd-MM-yyyy";
        }

        public ComboBox mycombox1 { get; internal set; }

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams handleparam = base.CreateParams;
        //        handleparam.ExStyle |= 0x02000000;
        //        return handleparam;
        //    }
        //}

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            LinkDtataToPL.FillProductsComboBox(this);
            myComboBox11.Show();
            myComboBox11.BringToFront();
        }

        private void myComboBox11_BClick(object sender, EventArgs e)
        {
            LinkDtataToPL.AddRow_InvoiceDataGridView(this);
            myComboBox11.Visible = false;
            button2.Focus();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            LinkDtataToPL.Save_Invoice(this);
        }

        private void dataGridView11_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            LinkDtataToPL.UpdateTotalPrices(sender,e);
        }
    }
}
