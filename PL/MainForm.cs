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
using Pharmacy.PL;

namespace Pharmacy
{
    public partial class Main : Form
    {
        private bool IsCollapsed;
        InvoiceForm invoiceF;
        HomeForm homeF;



        public Main()
        {
            InitializeComponent();
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

        private void BtnReports_Click(object sender, EventArgs e)
        {
            DesignFunctions.ShowHideReportsOptions(PanelReports);
        }

        private void BtnSalesReports_Click(object sender, EventArgs e)
        {
            DesignFunctions.ShowHideReportsOptions(PanelReports);
        }

        private void BtnBuyReports_Click(object sender, EventArgs e)
        {
            DesignFunctions.ShowHideReportsOptions(PanelReports);
        }



        private bool InvoiceForm()
        {
            throw new NotImplementedException();
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
    }

    class DesignFunctions
        {
            // Show or Hide Sub Reports
            public static void ShowHideReportsOptions(Panel panel)
            {
                if (panel.Visible == false) panel.Visible = true;
                else panel.Visible = false;
            }

            //Move Form
            [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
            private extern static void ReleaseCapture();
            [DllImport("user32.DLL", EntryPoint = "SendMessage")]
            private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
            public static void MoveForm(Form form)
            {
                ReleaseCapture();
                SendMessage(form.Handle, 0x112, 0xf012, 0);
            }

            public static void ClearPanelForms(Panel panel)
            {
                for (int i = 0; i < panel.Controls.Count; i++)
                { panel.Controls[i].Hide(); }
            }

            public static void ShowFormsInPanelForms(Form f, Panel p)
            {
                if (f.Visible == true) { }
                else
                {
                    DesignFunctions.ClearPanelForms(p);
                    if (p.Controls.Contains(f) == false)
                    {
                        f.TopLevel = false;
                        f.Size = p.Size;
                        p.Controls.Add(f);
                        f.Dock = DockStyle.Fill;
                        f.Show();
                    }
                    else { f.Visible = true; }
                }
            }

        }
    }

