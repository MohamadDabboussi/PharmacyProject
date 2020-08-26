using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharmacy.DAL;

namespace Pharmacy.PL
{
    public partial class InvoiceDetails1 : Form
    {
        InvoiceDetails invoiceDetail = new InvoiceDetails();
        
        public InvoiceDetails1(InvoiceDetails IDetail)
        {
            InitializeComponent();
        }

        private void InvoiceDetails1_Load(object sender, EventArgs e)
        {
            //function fill textbox and controls
            invoiceDetail.InvoiceID = 1;
            invoiceDetail.Quantity = 3;
            invoiceDetail.UnitPrice = 1000;
          
            
            LblInvoiceid2.Text = invoiceDetail.InvoiceID.ToString();
            // load comboBox Values
            ComboBoxMedecine.SelectedValue = invoiceDetail.InvoiceID;
            Textbox1Quantity.Text = invoiceDetail.Quantity.ToString();
            Textbox1PublicPrice.Text = invoiceDetail.UnitPrice.ToString();
            //date
            //VAT
            //price
            //margim
            //function to refresh total when any change happen
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            // refresh DatagridView in invoice reports
            this.Close();
        }

        private void BtnClose_MouseEnter(object sender, EventArgs e)
        {
            DesignFunctions.BtnClose_MouseEnter(sender, e);
        }

        private void BtnClose_MouseLeave(object sender, EventArgs e)
        {
            DesignFunctions.BtnClose_MouseLeave(sender, e);
        }

        private void BtnSaveDetails_Click(object sender, EventArgs e)
        {
            //update invoice detail
            // function CalcTotal(price,quantity)
            (splitContainerTotal.Panel2.Controls[0]).Text = (float.Parse(Textbox1Price.Text) * int.Parse(Textbox1Quantity.Text)).ToString();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            DesignFunctions.MoveForm(this);
        }
    }
}
