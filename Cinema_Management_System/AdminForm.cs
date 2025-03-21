using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Management_System
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            staffManageForm1.Hide();
            account_Form1.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            account_Form1.Hide();
            staffManageForm1.Show();     
        }

        private void MovieManage_Btn_Click(object sender, EventArgs e)
        {

        }

        private void CustomerManage_Btn_Click(object sender, EventArgs e)
        {
            account_Form1.Hide();
            staffManageForm1.Show();
        }

        private void ShowTimeManage_Btn_Click(object sender, EventArgs e)
        {

        }
    }
}
