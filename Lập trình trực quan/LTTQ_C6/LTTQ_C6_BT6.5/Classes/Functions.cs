using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTTQ_C6_BT6._5.Classes
{
    internal class Functions
    {
        public static void FillComboBox(ComboBox cb, DataTable dt, string displayCol, string value)
        {
            cb.DataSource = dt;
            cb.DisplayMember = displayCol;
            cb.ValueMember = value;
        }
    }
}
