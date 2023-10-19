using System;
using System.IO;
using System.Collections;
using System.Reflection.Metadata;
namespace Program
{
    public class B : IComparable<B>
    {
        private double dtb;
        private int Position;
        public B(double dtb, int Position)
        {
            this.dtb = dtb;
            this.Position = Position;
        }
        public int CompareTo(B b)
        {
            if (this.dtb > b.dtb)
            {
                return 1;
            }
            else if (this.dtb == b.dtb)
            {
                return 0;
            }
            return -1;
        }
        public static void write_Console(List<B> L, int n, List<string> AL, string s)
        {
            if (s == "false")
            {
                int Count = 1;
                System.Console.WriteLine(AL[L[0].Position]);
                for (int i = 1; i < L.Count; i++)
                {
                    if (L[i].dtb > L[i - 1].dtb)
                    {
                        Count++;
                        if (Count == n + 1)
                        {
                            break;
                        }
                        System.Console.WriteLine(AL[L[i].Position]);
                    }
                    else
                    {
                        System.Console.WriteLine(AL[L[i].Position]);
                    }
                }
            }
            else if (s == "true")
            {
                int Count = 1;
                System.Console.WriteLine(AL[L[L.Count - 1].Position]);
                for (int i = L.Count - 2; i >= 0; i--)
                {
                    if (L[i].dtb < L[i + 1].dtb)
                    {
                        Count++;
                        if (Count == n + 1)
                        {
                            break;
                        }
                        System.Console.WriteLine(AL[L[i].Position]);
                    }
                    else
                    {
                        System.Console.WriteLine(AL[L[i].Position]);
                    }
                }
            }
        }
    }
    public class A : IComparable<A>
    {
        private string Ma_Lop;
        private int Position;
        public A(string Ma_Lop, int Position)
        {
            this.Ma_Lop = Ma_Lop;
            this.Position = Position;
        }
        public int CompareTo (A a2)
        {
            return string.Compare(Ma_Lop, a2.Ma_Lop);
        }
        public void output()
        {
            System.Console.WriteLine(Ma_Lop + " " + Position);
        }
        public static void create_L(List<A> L, ref List<int> L1)
        {
            for (int i = 0; i < L.Count; i++)
            {
                L1.Add(L[i].Position);
            }
        }
        public static void find_Position(List<A> L, string Ma_Lop, ref int a, ref int b)
        {
            for (int i = 0; i < L.Count; i++)
            {
                if (L[i].Ma_Lop == Ma_Lop)
                {
                    a = i;
                    break;
                }
            }
            for (int i = L.Count - 1; i >= 0; i--)
            {
                if (L[i].Ma_Lop == Ma_Lop)
                {
                    b = i;
                    break;
                }
            }
        }
        public static void write(int First_Position, int End_Position, List<string> AL, List<A> L, string Path)
        {
            using (StreamWriter output = new StreamWriter(Path, true))
            {
                for (int i = First_Position; i <= End_Position; i++)
                {
                    output.WriteLine(AL[L[i].Position]);
                }
            }
        }
    }
    class Student
    {
        private string Name;
        private string MSSV;
        private string Ma_Lop;
        private double Diem_Toan;
        private double Diem_Van;
        private double Diem_Anh;
        private string Path;
        public Student(string Path)
        {
            this.Path = Path;
        }
        public void add_To_File()
        {
            if (File.Exists(Path))
            {
                bool a = true;
                using (StreamReader input = new StreamReader(Path))
                {
                    string s = input.ReadLine();
                    if (s == null)
                    {
                        a = false;
                    }
                    input.Close();
                }
                using (StreamWriter output = new StreamWriter(Path, true))
                {
                    // xuống dòng.
                    if (a == true)
                    {
                        output.Write("\n");
                    }
                    // nhập mã số sinh viên.
                    System.Console.Write("MSSV: ");
                    MSSV = System.Console.ReadLine();
                    output.Write(this.MSSV + " ");
                    // nhập họ tên.
                    System.Console.Write("\n" + "Name: ");
                    Name = System.Console.ReadLine();
                    output.Write(this.Name + " ");
                    //nhập mã lớp.
                    System.Console.Write("\n" + "Ma_Lop: ");
                    Ma_Lop = System.Console.ReadLine();
                    output.Write(Ma_Lop + " ");
                    // nhap diem toan.
                    System.Console.Write("\n" + "Diem_Toan: ");
                    Diem_Toan = System.Convert.ToDouble(System.Console.ReadLine());
                    output.Write(Diem_Toan + " ");
                    // nhap diem anh
                    System.Console.Write("\n" + "Diem_Anh: ");
                    Diem_Anh = System.Convert.ToDouble(System.Console.ReadLine());
                    output.Write(Diem_Anh + " ");
                    // nhap diem van.
                    System.Console.Write("\n" + "Diem_Van: ");
                    Diem_Van = System.Convert.ToDouble(System.Console.ReadLine());
                    output.Write(Diem_Van + " ");
                    // ghi diem Trung Binh
                    double dtb = DiemTrungBinh();
                    output.Write(dtb);
                }
            }
        }
        public double DiemTrungBinh()
        {
            return (Diem_Toan + Diem_Anh + Diem_Van) / 3;
        }
        public void Tim_MSSV(string MSSV)
        {
            ArrayList AL = new ArrayList();
            using (StreamReader input = new StreamReader(Path))
            {
                while (true)
                {
                    string Line = input.ReadLine();
                    if (Line == null)
                    {
                        break;
                    }
                    AL.Add(Line);
                }
            }
            
            string [ , ] Matrix = new string[AL.Count, 7];
            for (int i = 0; i < AL.Count; i++)
            {
                string s = AL[i].ToString();
                string[] Array = s.Split(" ");
                for (int j = 0; j < 7; j++)
                {
                    Matrix[i, j] = Array[j];
                }
            }
            for (int i = 0; i < AL.Count; i++)
            {
                if (Matrix[i, 0] == MSSV)
                {
                    System.Console.WriteLine("Sinh vien can tim: ");
                    for (int j = 0; j < 7; j++)
                    {
                        System.Console.Write(Matrix[i, j] + " ");
                    }
                    return;
                }
            }
        }
        public void tim_Ten(string Ten)
        {
            ArrayList AL = new ArrayList();
            using (StreamReader input = new StreamReader(Path))
            {
                while (true)
                {
                    string Line = input.ReadLine();
                    if (Line == null)
                    {
                        break;
                    }
                    AL.Add(Line);
                }
            }
            
            string [ , ] Matrix = new string[AL.Count, 7];
            for (int i = 0; i < AL.Count; i++)
            {
                string s = AL[i].ToString();
                string[] Array = s.Split(" ");
                for (int j = 0; j < 7; j++)
                {
                    Matrix[i, j] = Array[j];
                }
            }
            ArrayList AL1 = new ArrayList();
            for (int i = 0; i < AL.Count; i++)
            {
                if (Matrix[i, 1] == Ten)
                {
                    AL1.Add(AL[i]);
                }
            }
            System.Console.WriteLine("Sinh vien can tim: ");
            for (int i = 0; i < AL1.Count; i++)
            {
                System.Console.WriteLine(AL1[i]);
            }
        }
        public void remove(string MSSV)
        {
            ArrayList AL = new ArrayList();
            using (StreamReader input = new StreamReader(Path))
            {
                while (true)
                {
                    string Line = input.ReadLine();
                    if (Line == null)
                    {
                        break;
                    }
                    AL.Add(Line);
                }
            }
            File.WriteAllText(Path, "");
            string [ , ] Matrix = new string[AL.Count, 7];
            for (int i = 0; i < AL.Count; i++)
            {
                string s = AL[i].ToString();
                string[] Array = s.Split(" ");
                for (int j = 0; j < 7; j++)
                {
                    Matrix[i, j] = Array[j];
                }
            }
            int x = 0;
            for (int i = 0; i < AL.Count; i++)
            {
                if (Matrix[i, 0] == MSSV)
                {
                   x = i;
                }
            }
            using (StreamWriter output = new StreamWriter(Path))
            {
                for (int i = 0; i < AL.Count; i++)
                {
                    if (i != x)
                    {
                        output.WriteLine(AL[i]);
                    }
                }
            }
        }
        public void xuat_Toan_Truong(string Path)
        {
            if (File.Exists(Path))
            {

            }
            using (StreamWriter output = new StreamWriter(Path))
            using (StreamReader input = new StreamReader(this.Path))
            {
                while (true)
                {
                    string s = input.ReadLine();
                    if (s == null)
                    {
                        break;
                    }
                    output.WriteLine(s);
                }
            }
        }
        public void xuat_Theo_Lop(string Path, string Ma_Lop)
        {
            if (File.Exists(Path))
            {

            }
            List<string> AL = new List<string>();
            using (StreamReader input = new StreamReader(this.Path))
            {
                while (true)
                {
                    string Line = input.ReadLine();
                    if (Line == null)
                    {
                        break;
                    }
                    AL.Add(Line);
                }
            }
            string [ , ] Matrix = new string[AL.Count, 7];
            List<int> L = new List<int>();
            for (int i = 0; i < AL.Count; i++)
            {
                string[] Array = AL[i].Split(" ");
                if (Array[2] == Ma_Lop)
                {
                    L.Add(i);
                }
            }
            using (StreamWriter output = new StreamWriter(Path))
            {
                for (int i = 0; i < L.Count; i++)
                {
                    output.WriteLine(AL[L[i]]);
                }
            }
        }
        public void Top_n_Sinh_Vien(int n, string s123)
        {
            List<string> AL = new List<string>();
            using (StreamReader input = new StreamReader(this.Path))
            {
                while (true)
                {
                    string Line = input.ReadLine();
                    if (Line == null)
                    {
                        break;
                    }
                    AL.Add(Line);
                }
            }
            string [ , ] Matrix = new string[AL.Count, 7];
            List<B> L = new List<B>();
            for (int i = 0; i < AL.Count; i++)
            {
                string[] Array = AL[i].Split(" ");
                for (int j = 0; j < 7; j++)
                {
                    Matrix[i, j] = Array[j];
                }
                L.Add(new B(double.Parse(Array[6]), i));
            }
            L.Sort();
            B.write_Console(L, n, AL, s123);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("1. Import");
            System.Console.WriteLine("2. add SinhVien");
            System.Console.WriteLine("3. search MSSV");
            System.Console.WriteLine("4. search Ten");
            System.Console.WriteLine("5. Export All SinhVien");
            System.Console.WriteLine("6. Export class SinhVien");
            System.Console.WriteLine("7. Remove SinhVien");
            System.Console.WriteLine("8. Top n SinhVien");
            System.Console.WriteLine("Choose your option, you must import file input");
            System.Console.WriteLine("your input: ");
            string Path = System.Console.ReadLine();
            Student st = new Student(Path);
            System.Console.WriteLine("Your option: ");
            int x = System.Convert.ToInt16(System.Console.ReadLine());
            if (x == 2)
            {
                st.add_To_File();
            }
            else if (x == 3)
            {
                System.Console.WriteLine("MSSV: ");
                string MSSV = System.Console.ReadLine();
                st.Tim_MSSV(MSSV);
            }
            else if (x == 4)
            {
                System.Console.WriteLine("Ten: ");
                string Ten = System.Console.ReadLine();
                st.tim_Ten(Ten);
            }
            else if (x == 5)
            {
                System.Console.WriteLine("Path: ");
                string Path1 = System.Console.ReadLine();
                st.xuat_Toan_Truong(Path1);
            }
            else if (x == 6)
            {
                System.Console.WriteLine("Path: ");
                string Path1 = System.Console.ReadLine();
                System.Console.WriteLine("Ma Lop: ");
                string Ma_Lop = System.Console.ReadLine();
                st.xuat_Theo_Lop(Path1, Ma_Lop);
            }
            else if (x == 7)
            {
                System.Console.WriteLine("MSSV: ");
                string MSSV = System.Console.ReadLine();
                st.remove(MSSV);
            }
            else if (x == 8)
            {
                System.Console.WriteLine("n: ");
                int n = System.Convert.ToInt16(System.Console.ReadLine());
                System.Console.WriteLine("Path: ");
                string Path1 = System.Console.ReadLine();
                System.Console.WriteLine("true/ false");
                string your_choice = System.Console.ReadLine();
                st.Top_n_Sinh_Vien(n, your_choice);
            }
        }
    }
}