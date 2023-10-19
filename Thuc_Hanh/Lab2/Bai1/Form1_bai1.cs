using System;
namespace Winform;
public partial class Form1 : Form
{
    private Label lb = new Label();
    public Form1()
    {
        InitializeComponent();
        this.Load += new EventHandler(Form1_Load);
        this.Activated += new EventHandler(Form1_Activated);
        this.Shown += new EventHandler(Form1_Shown);
        this.Deactivate += new EventHandler(Form1_Deactivate);
        this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        this.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
        this.Controls.Add(lb);

    // Đặt vị trí cho Label
        lb.Location = new Point(10, 10);
    }
    private void Form1_Load(object sender, EventArgs e)
    {
        MessageBox.Show("Form1 Loaded");
    }

    private void Form1_Activated(object sender, EventArgs e)
    {
        lb.Text = "Activated";
    }

    private void Form1_Shown(object sender, EventArgs e)
    {
        MessageBox.Show("Form1 Shown");
    }

    private void Form1_Deactivate(object sender, EventArgs e)
    {
        lb.Text = "Deactivated";
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
        MessageBox.Show("Form1 Closed");
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        MessageBox.Show("Form1 Closing");
    }
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Form1());
    }    
}
