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

namespace Pharmacy
{
    public partial class Main : Form
    {
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
            DesignFunctions.ShowHideReportsOptions(panelReports);
        }

        private void BtnSalesReports_Click(object sender, EventArgs e)
        {
            DesignFunctions.ShowHideReportsOptions(panelReports);
        }

        private void BtnBuyReports_Click(object sender, EventArgs e)
        {
            DesignFunctions.ShowHideReportsOptions(panelReports);
        }
    }

    class DesignFunctions
    {
        // Show or Hide Sub Reports
        public static void ShowHideReportsOptions(Panel panel)
        { if (panel.Visible == false) panel.Visible = true;
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

    }
}
