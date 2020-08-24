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
    public partial class HomeButtonMirror1 : UserControl
    {
        public HomeButtonMirror1()
        {
            InitializeComponent();
        }


        public event EventHandler BClick;


        public string BText
        {
            get { return this.BtnHome.Text; }
            set { this.BtnHome.Text = value; }
        }
        public Image BImage
        {
            get { return this.BtnHome.Image; }
            set { this.BtnHome.Image = value; }
        }
        public Font BfonyStyle
        {
            get { return this.BtnHome.Font; }
            set { this.BtnHome.Font = value; }
        }
        public Color BBackColor
        {
            get { return this.BtnHome.BackColor; }
            set { this.BtnHome.BackColor = value; }
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            if (this.BClick != null)
            { this.BClick(this, e); }
        }
    }
}
