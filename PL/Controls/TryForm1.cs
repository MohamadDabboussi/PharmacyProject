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


namespace Pharmacy.PL.Controls
{
    public partial class TryForm1 : Form
    {
        public TryForm1()
        {
            InitializeComponent();
        }
        DAL.DataLayer dt = new DAL.DataLayer(@"QSC-2019\SQLEXPRESS", "Pharmacy");
        private void DataGridViewDesignsForm_Load(object sender, EventArgs e)
        {

            DataTable medecines;


            medecines = dt.GetData_StoredProcedure("GetMedecinesNamesTest", "medecines");
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource = medecines;

            //this.dataGridView1.Rows.Add("five", "six", "seven", "eight");

            DataTable m = dt.GetData_StoredProcedure("GetMedecinesTest", "m");
            bunifuCustomDataGrid1.DataSource = m;
            DataGridViewCheckBoxColumn chkbx = new DataGridViewCheckBoxColumn();
            chkbx.HeaderText = "CHeckBoc";
            bunifuCustomDataGrid1.Columns.Add(chkbx);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            DataTable medecinesData;
            object[,] Params = new object[2, 1];
            Params[0, 0] = "@M_ID";
            Params[1, 0] = comboBox1.SelectedValue;
            medecinesData = dt.GetData_StoredProcedure("GetMedecineByIDTest", Params, "medecines");
            this.dataGridView11.Rows.Add(medecinesData.Rows[0]["ID"].ToString(), medecinesData.Rows[0]["Name"], medecinesData.Rows[0]["Price"]);
            button2.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.BringToFront();
            button1.Focus();
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                panel1.Visible = true;
                panel1.BringToFront();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (DataGridViewRow r in bunifuCustomDataGrid1.Rows)
            {
                if ((r.Cells[r.Cells.Count - 1]).Value != null)
                    if (((bool)(r.Cells[r.Cells.Count - 1]).Value) == true) i++;
            }
            MessageBox.Show(i.ToString());
        }

        private void dropDownButton1_Click(object sender, EventArgs e)
        {
            if (dropDownButton1.Size == dropDownButton1.MinimumSize) dropDownButton1.BMaximize();
            else dropDownButton1.BMinimize();
            for (int i = 0; i < dropDownButton1.SubButtonsNumber; i++)
            { dropDownButton1.SubButtonsNames[i] = i.ToString(); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dropDownButton1.SubButtonsNumber = int.Parse(textBox1.Text);
            for (int i = 0; i < dropDownButton1.SubButtonsNumber; i++)
            { dropDownButton1.SubButtonsNames[i] = i.ToString(); }
        }
    }
}
