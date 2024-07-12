using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Winform.UI
{
    public partial class Form_ThongKe : Form
    {
        public Form_ThongKe()
        {
            InitializeComponent();
        }

        public List<Control> GetCtrl()
        {
            List<Control> ctrls = new List<Control>();

            foreach (Control ctrl in pn_Form_ThongKe.Controls)
            {
                ctrls.Add(ctrl);
            }
            return ctrls;
        }
    }
}
