using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM
{
    public partial class Edit_Dept : Form
    {
        public Edit_Dept()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DepartmentModule b2 = new DepartmentModule();
            //this.Hide();
            b2.ShowDialog();

        }

        private void Edit_Dept_Load(object sender, EventArgs e)
        {

        }
    }
}
