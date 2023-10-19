using System;
namespace Bai2;

public partial class Form1 : Form
{
   private Random random = new Random();
        private Button changeColorButton;

        public Form1()
        {
            InitializeComponent();

            // Tạo nút "Change Color" và đặt thuộc tính
            changeColorButton = new Button();
            changeColorButton.Text = "Change Color";
            changeColorButton.Location = new Point(10, 10);

            // Đăng ký sự kiện Click cho nút "Change Color"
            changeColorButton.Click += new EventHandler(ChangeColorButton_Click);

            // Thêm nút vào form
            this.Controls.Add(changeColorButton);
        }

        private void ChangeColorButton_Click(object sender, EventArgs e)
        {
            // Tạo một màu ngẫu nhiên
            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

            // Đặt màu nền của form thành màu ngẫu nhiên
            this.BackColor = randomColor;
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
}
