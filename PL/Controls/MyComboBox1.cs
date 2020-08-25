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
    public partial class MyComboBox1 : UserControl
    {
        public MyComboBox1()
        {
            InitializeComponent();
        }


        public string ComboBoxDataSource
        {
            set { this.comboBox1.DataSource = value; }
        }
        public string ComboBoxDisplayMember
        {
            get { return this.comboBox1.DisplayMember; }
            set { this.comboBox1.DisplayMember = value; }
        }
        public string ComboBoxValueMember
        {
            get { return this.comboBox1.ValueMember; }
            set { this.comboBox1.ValueMember = value; }
        }
        public object ComboBoxSelectedValue
        {
            get { return this.comboBox1.SelectedValue; }
            set { this.comboBox1.SelectedValue = value; }
        }
        public event EventHandler BClick;
        private void Btn_Click(object sender, EventArgs e)
        {
            if (this.BClick != null)
            { this.BClick(this, e); }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            BtnClose.BackColor = Color.FromArgb(44, 49, 53);
        }

        private void BtnClose_MouseEnter(object sender, EventArgs e)
        {
            DesignFunctions.BtnClose_MouseEnter(sender, e);
        }
        private void BtnClose_MouseLeave(object sender, EventArgs e)
        {
            DesignFunctions.BtnClose_MouseLeave(sender, e);
        }

        private void Tab_MouseDown(object sender, MouseEventArgs e)
        {
            DesignFunctions.MoveControl(this);
        }
    }
}
