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
            this.MinimumSize = new Size(281, 60);
            this.Panel.MinimumSize = new Size(281, 60);
        }

        public int SubButtonsNumber
        {
            get {
                return this.Panel.Controls.Count - 1; }
            set {
                if (value > Panel.Controls.Count)
                {
                    for (int i = Panel.Controls.Count; i <= value; i++)
                    { 
                        SubHomeButton newSB = new SubHomeButton();
                        this.MaximumSize += new Size(0, 43);
                        Panel.MaximumSize = this.MaximumSize;
                        BResize();
                        newSB.Location = new Point(0, 60 + (Panel.Controls.Count - 1) * 34);
                        this.Panel.Controls.Add(newSB);
                        newSB.BringToFront();
                        newSB.Show();
                    }
                }
                else {
                    for (int i = 0; i <Panel.Controls.Count; i++)
                    {
                        if(Panel.Controls[i] is SubHomeButton)
                        Panel.Controls.RemoveAt(i);
                    }
                    for (int i = 0; i < value; i++)
                    {
                        SubHomeButton newSB = new SubHomeButton();
                        this.MaximumSize += new Size(0, 43);
                        Panel.MaximumSize = this.MaximumSize;
                        BResize();
                        newSB.Location = new Point(0, 60 + (i - 1) * 34);
                        this.Panel.Controls.Add(newSB);
                        newSB.BringToFront();
                        newSB.Show();
                    }
                }
                Panel.MaximumSize = new Size(281, 60 + (Panel.Controls.Count-1) * 34);
                this.MaximumSize= new Size(281, 60 + (Panel.Controls.Count - 1) * 34);

            }
        }


        public string[] SubButtonsNames
        {
            get
            {
                string[] names = new string[Panel.Controls.Count];
                int i = 0;
              while(i < names.Length)
                {
                    if (Panel.Controls[i] is SubHomeButton)
                    {
                        names[i] = (Panel.Controls[i] as SubHomeButton).BText;
                        i++;
                    }
                }
                return names;
            }
            set
            {
                if (Panel.Controls.Count > 1)
                {
                    string[] names = value;
                    int i = 0;
                   while(i < names.Length)
                    {
                        if (Panel.Controls[i] is SubHomeButton)
                            (Panel.Controls[i] as SubHomeButton).BText = names[i];
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

        public void BResize() 
        {
            this.Size = MaximumSize;
            Panel.Size = Panel.MaximumSize;
        }


    }
}
