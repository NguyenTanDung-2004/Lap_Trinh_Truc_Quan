using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_Application
{
    public partial class Tim_Sinh_Vien : Form
    {
        private string s;
        public Tim_Sinh_Vien()
        {
            InitializeComponent();
            
        }
        /*
         *1. Theo Tên.
2. Theo MSSV.
         */
        private void button1_Click(object sender, EventArgs e)
        {
            if (s == "1. Theo Tên.")
            {
                Tim_Sinh_Vien_Theo_Ten obj = new Tim_Sinh_Vien_Theo_Ten();
                obj.Show();
            }
            else if (s == "2. Theo MSSV.")
            {
                Tim_Kiem_Theo_MSSV obj = new Tim_Kiem_Theo_MSSV();
                
                obj.Show();
            }
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            this.s = cb.SelectedItem.ToString();
        }
    }
}
