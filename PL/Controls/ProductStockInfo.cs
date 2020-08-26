using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.PL.Controls
{
    public partial class ProductStockInfo : UserControl
    {
        public ProductStockInfo()
        {
            InitializeComponent();
        }

        private void NButton2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            DesignFunctions.MoveControl(this);
        }
    }
}
