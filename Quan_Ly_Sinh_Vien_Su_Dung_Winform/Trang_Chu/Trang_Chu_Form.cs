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
    public partial class Trang_Chu_Form : Form
    {
        public Trang_Chu_Form()
        {
            InitializeComponent();
        }
        /*
         * 1. Thêm sinh viên.
2. Xóa sinh viên.
3. Tìm sinh viên.
4. Chỉnh sửa sinh viên.
5. Danh sách toàn trường (Theo lớp).
6. Danh sách theo lớp.
        */
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            string s = cb.SelectedItem.ToString();
            DialogResult MessageBox_Result = MessageBox.Show("Bạn muốn lựa chọn chức này?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            if (MessageBox_Result == DialogResult.No || MessageBox_Result == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                if (s == "1. Thêm sinh viên.")
                {
                    Them_Sinh_Vien_Form obj = new Them_Sinh_Vien_Form();
                    obj.Show();
                }
                else if (s == "2. Xóa sinh viên.")
                {
                    Xoa_Form obj = new Xoa_Form();
                    obj.Show();
                }
                else if (s == "3. Tìm sinh viên.")
                {
                    Tim_Sinh_Vien obj = new Tim_Sinh_Vien();
                    obj.Show();
                }
                else if (s == "4. Chỉnh sửa sinh viên.")
                {

                }
                else if (s == "5. Danh sách toàn trường (Theo lớp).")
                {

                }
                else
                {

                }
            }
        }
    }
}
