using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharmacy.PL.Controls;

namespace Pharmacy.PL
{
    public partial class StocksForm : Form
    {
        public StocksForm()
        {
            InitializeComponent();
        }

        private void BtnEnd_MouseEnter(object sender, EventArgs e)
        {
            DesignFunctions.ControlSize_MouseEnter(sender, e);
        }

        private void BtnEnd_MouseLeave(object sender, EventArgs e)
        {
            DesignFunctions.ControlSize_MouseLeave(sender, e);
        }
        ProductStockInfo ProductInfo;

        private void nButton11_BIDMouseEnter(object sender, EventArgs e)
        {
            foreach (Control a in this.Controls)
                if (a is ProductStockInfo) Controls.Remove(a);
            ProductInfo = new ProductStockInfo();
            ProductInfo.Location = new Point(300,300);
            ProductInfo.Name = "ProductInfo";
            this.Controls.Add(ProductInfo);
            ProductInfo.Show();
            ProductInfo.BringToFront();
        }

        private void nButton11_BIDMouseLeave(object sender, EventArgs e)
        {
            this.Controls.Remove(ProductInfo);
        }

        private void nButton11_BClick(object sender, EventArgs e)
        {
        }
    }
}
