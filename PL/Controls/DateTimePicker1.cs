using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.PL.Controls
{
    public partial class DateTimePicker1 : Component
    {
        public DateTimePicker1()
        {
            InitializeComponent();
        }

        public DateTimePicker1(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
