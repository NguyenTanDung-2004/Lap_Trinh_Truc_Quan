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
    public partial class Tim_Sinh_Vien_Theo_Ten : Form
    {
        private List<string> Danh_Sach_Cac_Lop = new List<string>();
        private string Danh_Sach_Cac_Lop_Path = "C:\\Users\\user\\Downloads\\Ngon_Ngu_C_Sharf\\Quản_Lý_Sinh_Viên_sử_dụng_Winform\\Student_Management_Application\\Student_Management_Application\\File\\Danh_Sach_Cac_Lop.txt";
        private string Thu_Muc = "C:\\Users\\user\\Downloads\\Ngon_Ngu_C_Sharf\\Quản_Lý_Sinh_Viên_sử_dụng_Winform\\Student_Management_Application\\Student_Management_Application\\File\\";
        private string Ten;
        private List<string> Danh_Sach_Sinh_Vien = new List<string>();
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
                    if (Array[1] == Ten)
                    {
                        Danh_Sach_Sinh_Vien.Add(Lop);
                        Danh_Sach_Sinh_Vien.Add(Array[0]);
                        Danh_Sach_Sinh_Vien.Add(Array[1]);
                        Danh_Sach_Sinh_Vien.Add(Array[2]);
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
            }
        }
        public Tim_Sinh_Vien_Theo_Ten()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Ten = this.textBox1.Text;
            FlowLayoutPanel flow = new FlowLayoutPanel();
            flow.Location = new Point(322, 209);
            flow.AutoScroll = true;
            flow.Size = new Size(493, 233);
            this.Controls.Add(flow);
            ghi_du_lieu_vao_Danh_Sach_Cac_Lop();
            tim_Sinh_Vien_Trong_Truong();
            for (int i = 0; i < Danh_Sach_Sinh_Vien.Count; i++)
            {
                TextBox tb = new TextBox();
                tb.Size = new Size(100, 38);
                tb.Text = Danh_Sach_Sinh_Vien[i];
                flow.Controls.Add(tb);
            }
        }
    }
}
