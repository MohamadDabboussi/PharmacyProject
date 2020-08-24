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
    public partial class SubHomeButton : UserControl
    {
        public SubHomeButton()
        {
            InitializeComponent();
        }

        public string BText
        {
            get { return this.SubButton.BText; }
            set { this.SubButton.BText = value; }
        }
        public event EventHandler BClick;
        private void BtnHome_Click(object sender, EventArgs e)
        {
            if (this.BClick != null)
            { this.BClick(this, e); }
        }
    }
}
