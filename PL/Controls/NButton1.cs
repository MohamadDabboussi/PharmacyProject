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
    public partial class NButton1 : UserControl
    {
        public NButton1()
        {
            InitializeComponent();
        }

        public string BText
        {
            get { return this.BtnText.Text; }
            set { this.BtnText.Text = value; }
        }

        public string BID
        {
            get { return this.BtnID.Text; }
            set { this.BtnID.Text = value; }
        }

        public event EventHandler BClick;

        private void BtnHome_Click(object sender, EventArgs e)
        {
            if (this.BClick != null)
            { this.BClick(this, e); }
        }

    }
}
