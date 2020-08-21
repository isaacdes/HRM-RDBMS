using System;
using System.Windows.Forms;

namespace HRM
{
    public partial class DepartmentModule : Form
    {
        public DepartmentModule()
        {
            InitializeComponent();
        }

        private void DepartmentModule_Load(object sender, EventArgs e)
        {
           // this.Close();
            Add_Dept b1 = new Add_Dept();
            b1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void del_dept_Click(object sender, EventArgs e)
        {

        }

        private void edit_dept_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Edit_Dept b4 = new Edit_Dept();
            b4.ShowDialog();

        }

        private void view_dept_Click(object sender, EventArgs e)
        {

        }
    }
}

