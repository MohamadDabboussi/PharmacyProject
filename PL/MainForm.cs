using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.PL
{
    public partial class Main : Form
    {
        InvoiceForm invoiceF;
        HomeForm homeF;
        StocksForm stockF;



        public Main()
        {
            InitializeComponent();
        }

        //fast open form
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }


        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClose_MouseEnter(object sender, EventArgs e)
        {
            BtnClose.BackColor = Color.Red;
        }

        private void BtnClose_MouseLeave(object sender, EventArgs e)
        {
            BtnClose.BackColor = Color.Transparent;
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnMaximize.Visible = false;
            BtnRestore.Visible = true;
        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnMaximize.Visible = true;
            BtnRestore.Visible = false;
        }

        private void TabHorizontal_MouseDown(object sender, MouseEventArgs e)
        {
            DesignFunctions.MoveForm(this);
        }



        private void BtnInvoice_Click(object sender, EventArgs e)
        {
            if (invoiceF == null) invoiceF = new PL.InvoiceForm();
            DesignFunctions.ShowFormsInPanelForms(invoiceF, PanelForms);
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            if (homeF == null) homeF = new PL.HomeForm();
            DesignFunctions.ShowFormsInPanelForms(homeF, PanelForms);
        }


        private void BtnReports_BClick(object sender, EventArgs e)
        {
            if (PanelReports.Size == PanelReports.MinimumSize)
                PanelReports.Size = PanelReports.MaximumSize;
            else PanelReports.Size = PanelReports.MinimumSize;


        }

        private void BtnStocks_BClick(object sender, EventArgs e)
        {
            if (stockF == null) stockF = new PL.StocksForm();//add refresh form
            DesignFunctions.ShowFormsInPanelForms(stockF, PanelForms);
        }
    }

    
    }

