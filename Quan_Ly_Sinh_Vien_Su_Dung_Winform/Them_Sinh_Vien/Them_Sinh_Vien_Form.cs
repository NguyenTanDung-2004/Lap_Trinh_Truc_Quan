using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Student_Management_Application
{
    public partial class Them_Sinh_Vien_Form : Form
    {
        private List<string> Danh_Sach_Cac_Lop = new List<string>();
        private string Danh_Sach_Cac_Lop_Path = "C:\\Users\\user\\Downloads\\Ngon_Ngu_C_Sharf\\Quản_Lý_Sinh_Viên_sử_dụng_Winform\\Student_Management_Application\\Student_Management_Application\\File\\Danh_Sach_Cac_Lop.txt";
        private string Thu_Muc = "C:\\Users\\user\\Downloads\\Ngon_Ngu_C_Sharf\\Quản_Lý_Sinh_Viên_sử_dụng_Winform\\Student_Management_Application\\Student_Management_Application\\File\\";
        public Them_Sinh_Vien_Form()
        {
            InitializeComponent();
        }
        public void Load_File_And_Write_Into_List(string Path, ref List<string> List)
        {
            using (StreamReader input = new StreamReader(Path)) 
            {
                while (true)
                {
                    string s = input.ReadLine();
                    if (s == null)
                    {
                        return;
                    }
                    List.Add(s);
                }
            }
        }
        public Boolean check_Lop(string s) 
        {
            for (int i = 0; i < Danh_Sach_Cac_Lop.Count; i++) 
            {
                if (s == Danh_Sach_Cac_Lop[i])
                {
                    return true; // tồn tại
                }
            }
            return false; // không tồn tại.
        }
        public void ghi_du_Lieu_Vao_File_Lop(string Ten_Lop)
        {
            string Path = Thu_Muc + Ten_Lop;
            if (File.Exists(Path)) // tạo file nếu chưa tồn tại.
            {

            }
            // sử dụng StreamWriter để ghi dữ liệu vào file.
            using (StreamWriter output = new StreamWriter(Path, true))
            {
                string MSSV = MSSV_TextBox.Text;
                string Ten = Ten_TextBox.Text;
                string Que = Que_TextBox.Text;
                output.Write(MSSV + "-");
                output.Write(Ten + "-");
                output.Write(Que + "\n");
                output.Close();
            }
        }
        public void ghi_du_lieu_vao_file_danh_sach_cac_lop(string Lop)
        {
            //File.WriteAllText(Danh_Sach_Cac_Lop_Path, "");
            using (StreamWriter output = new StreamWriter(Danh_Sach_Cac_Lop_Path, true))
            {
                output.WriteLine(Lop);
                output.Close();
            }
        }
        private void Them_Button_Click(object sender, EventArgs e)
        {
            // lấy ra tên lớp.
            string Lop = Lop_TextBox.Text;
            // đổ dữ liệu vào List.
            Load_File_And_Write_Into_List(Danh_Sach_Cac_Lop_Path, ref Danh_Sach_Cac_Lop);
            ghi_du_Lieu_Vao_File_Lop(Lop);
            if (check_Lop(Lop) == false) 
            {
                ghi_du_lieu_vao_file_danh_sach_cac_lop(Lop);
            }
            MessageBox.Show("Đã thêm thành công!");
        }


    }
}
