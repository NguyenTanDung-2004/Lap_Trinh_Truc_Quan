namespace Bai3;

public partial class Form1 : Form
{
    private ColorDialog colorDialog;
        private MenuStrip menuStrip;
        private ToolStripMenuItem formatMenu;

        public Form1()
        {
            InitializeComponent();

            // Khởi tạo hộp thoại ColorDialog
            colorDialog = new ColorDialog();

            // Tạo MenuStrip
            menuStrip = new MenuStrip();
            this.Controls.Add(menuStrip);

            // Tạo menu Format
            formatMenu = new ToolStripMenuItem("Format");
            menuStrip.Items.Add(formatMenu);

            // Tạo MenuItem "Color" và đăng ký sự kiện Click
            ToolStripMenuItem colorMenuItem = new ToolStripMenuItem("Color");
            colorMenuItem.Click += ColorMenuItem_Click;
            formatMenu.DropDownItems.Add(colorMenuItem);
        }

        private void ColorMenuItem_Click(object sender, EventArgs e)
        {
            // Mở hộp thoại ColorDialog
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy màu đã chọn
                Color selectedColor = colorDialog.Color;

                // Đặt màu nền của Form thành màu đã chọn
                this.BackColor = selectedColor;
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
}
