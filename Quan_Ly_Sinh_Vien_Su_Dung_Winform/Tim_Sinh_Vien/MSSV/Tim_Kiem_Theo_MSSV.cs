using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_Application
{
    public partial class Tim_Kiem_Theo_MSSV : Form
    {
        private List<string> Danh_Sach_Cac_Lop = new List<string>();
        private string Danh_Sach_Cac_Lop_Path = "C:\\Users\\user\\Downloads\\Ngon_Ngu_C_Sharf\\Quản_Lý_Sinh_Viên_sử_dụng_Winform\\Student_Management_Application\\Student_Management_Application\\File\\Danh_Sach_Cac_Lop.txt";
        private string Thu_Muc = "C:\\Users\\user\\Downloads\\Ngon_Ngu_C_Sharf\\Quản_Lý_Sinh_Viên_sử_dụng_Winform\\Student_Management_Application\\Student_Management_Application\\File\\";
        private int Index = -1;
        private Boolean check = false;
        private string MSSV;
        private string Lop;
        private string Ten;
        private string Que;
        public void ghi_du_lieu_vao_Danh_Sach_Cac_Lop()
        {
            using (StreamReader input = new StreamReader(Danh_Sach_Cac_Lop_Path))
            {
                while (true)
                {
                    string s = input.ReadLine();
                    if (s == null)
                    {
                        break;
                    }
                    Danh_Sach_Cac_Lop.Add(s);
                }
                input.Close();
            }

        }
        public void tim_Sinh_Vien_trong_Lop(string Lop)
        {
            string Path = Thu_Muc + Lop;
            int Count = 0;
            using (StreamReader input = new StreamReader(Path))
            {
                while (true)
                {
                    string s = input.ReadLine();
                    if (s == null)
                    {
                        break;
                    }
                    string[] Array = s.Split('-');
                    if (Array[0] == MSSV)
                    {
                        Ten = Array[1];
                        Que = Array[2];
                        Index = Count;
                        check = true;
                        break;

                    }
                    Count++;
                }
                input.Close();
            }
        }
        public void tim_Sinh_Vien_Trong_Truong()
        {
            for (int i = 0; i < Danh_Sach_Cac_Lop.Count; i++)
            {
                tim_Sinh_Vien_trong_Lop(Danh_Sach_Cac_Lop[i]);
                if (check == true)
                {
                    Lop = Danh_Sach_Cac_Lop[i];
                    return;
                }
            }
        }
        public Tim_Kiem_Theo_MSSV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.MSSV = textBox1.Text;
            ghi_du_lieu_vao_Danh_Sach_Cac_Lop();
            tim_Sinh_Vien_Trong_Truong();
            this.label4.Text = Ten;
            this.label5.Text = Lop;
            this.label7.Text = Que;
        }
    }
}
