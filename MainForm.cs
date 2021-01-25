using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVGB07_Modul2.Modul2;

namespace DVGB07_Modul2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void LottoButton_Click(object sender, EventArgs e)
        {
            LottoForm form = new LottoForm();
            form.Show();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            CalcForm form = new CalcForm();
            form.Show();
        }
    }
}
