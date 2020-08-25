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
    public partial class DropDownButton : UserControl
    {
        public DropDownButton()
        {
            InitializeComponent();
            MinimumSize = new Size(281, 60);
            Panel.Size = MinimumSize;
        }

        public int SubButtonsNumber
        {
            get
            {
                int count = 0;
                for (int i = 0; i < Panel.Controls.Count; i++)
                {
                    if (Panel.Controls[i] is SubHomeButton)
                    {
                        count++;
                    }
                }
                return count;
            }
            set
            { 
                if (value > Panel.Controls.Count)
                {
                    for (int i = Panel.Controls.Count; i <= value; i++)
                    {
                        SubHomeButton newSB = new SubHomeButton();
                        this.MaximumSize += new Size(0, 34);
                        Panel.MaximumSize = this.MaximumSize;
                        newSB.Location = new Point(0, 60 + (Panel.Controls.Count - 1) * 34);
                        this.Panel.Controls.Add(newSB);
                        newSB.BText = "";
                        newSB.BringToFront();
                        newSB.Show();
                    }
                }
                else
                {
                    for (int i = 0; i < Panel.Controls.Count; i++)
                    {
                        if (Panel.Controls[i] is SubHomeButton)
                            Panel.Controls.RemoveAt(i);
                    }
                    this.MaximumSize = this.MinimumSize;
                    Panel.MaximumSize = this.MaximumSize;
                    for (int i = 0; i < value; i++)
                    {
                        SubHomeButton newSB = new SubHomeButton();
                        this.MaximumSize = new Size(this.MaximumSize.Width, this.MaximumSize.Height + 34);
                        Panel.MaximumSize = this.MaximumSize;
                        newSB.Location = new Point(0, 60 + i * 34);
                        this.Panel.Controls.Add(newSB);
                        newSB.BText = "";
                        newSB.BringToFront();
                        newSB.Show();
                    }
                }
            }
        }

        public string[] SubButtonsNames
        {
            get
            {
                if (Panel.Controls.Count > 1)
                {
                    string[] names = new string[Panel.Controls.Count - 1];
                    int i = 0;
                    while (i < names.Length)
                    {
                        if (Panel.Controls[i] is SubHomeButton)
                        {
                            if ((Panel.Controls[i] as SubHomeButton).BText != null) names[i] = (Panel.Controls[i] as SubHomeButton).BText;
                            else names[i] = "";
                            i++;
                        }
                    }
                    return names;
                }
                else return null;
            }
            set
            {
                if (value != null && value.Length == SubButtonsNumber)
                {
                    if (Panel.Controls.Count > 1)
                    {
                        string[] names = value;
                        int i = 0;
                        while (i < names.Length)
                        {
                            if (Panel.Controls[i] is SubHomeButton)
                            {
                                if (names[i] != null) (Panel.Controls[i] as SubHomeButton).BText = names[i];
                                else (Panel.Controls[i] as SubHomeButton).BText = "";
                                i++;
                            }
                        }
                    }
                }
            }
        }

        public string BHeaderText
        {
            get { return this.BtnHeader.BText; }
            set { this.BtnHeader.BText = value; }
        }
        public Image BHeaderImage
        {
            get { return this.BtnHeader.BImage; }
            set { this.BtnHeader.BImage = value; }
        }

        public void BMaximize() 
        {
            this.Size = MaximumSize;
            Panel.Size = Panel.MaximumSize;
        }
        public void BMinimize()
        {
            this.Size = MinimumSize;
            Panel.Size = Panel.MinimumSize;
        }

        public event EventHandler BClick;
        private void Btn_Click(object sender, EventArgs e)
        {
            if (this.BClick != null)
            { this.BClick(this, e); }
        }
    }
}
