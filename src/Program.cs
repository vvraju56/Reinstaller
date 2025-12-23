using System;
using System.Drawing;
using System.Windows.Forms;

namespace Reinstaller
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetApplicationIcon();
        }

        private void SetApplicationIcon()
        {
            try
            {
                Icon appIcon = new Icon("src/assets/icon.ico");
                this.Icon = appIcon;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Could not load icon: {ex.Message}");
            }
        }

        private void InitializeComponent()
        {
            this.Text = "Reinstaller";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }

    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}