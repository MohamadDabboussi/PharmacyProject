﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.PL
{
    class DesignFunctions
    {

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

        //Move Control
         public static void MoveControl(UserControl uc)
        {
            ReleaseCapture();
            SendMessage(uc.Handle, 0x112, 0xf012, 0);
        }

        public static void ClearPanelForms(Panel panel)
            {
                for (int i = 0; i < panel.Controls.Count; i++)
                { panel.Controls[i].Hide(); }
            }

        // Add and show form in Main form
        public static void ShowFormsInPanelForms(Form f, Panel p)
            {
                if (f.Visible == true) { }
                else
                {
                    ClearPanelForms(p);
                    if (p.Controls.Contains(f) == false)
                    {
                        f.TopLevel = false;
                        f.Size = p.Size;
                        p.Controls.Add(f);
                        f.Dock = DockStyle.Fill;
                        f.Show();
                    }
                    else { f.Visible = true; }
                }
            }
        public static void BtnClose_MouseEnter(object sender, EventArgs e)
        {
            PictureBox b = (PictureBox)sender;
            b.BackColor = Color.Red;
        }
        public static void BtnClose_MouseLeave(object sender, EventArgs e)
        {
            PictureBox b = (PictureBox)sender;
            b.BackColor = Color.FromArgb(44, 49, 53); ;
        }
    }
}