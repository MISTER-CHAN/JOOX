using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joox
{
    public partial class Lyric : Form
    {
        public Lyric()
        {
            InitializeComponent();
            SetWindowLong(Handle, -20, 0x20 | 0x80000);
            new Joox(this).Show();
        }

        private void Lyric_Load(object sender, EventArgs e)
        {
            Width = Screen.PrimaryScreen.Bounds.Width;
            Location = new Point(0, Screen.PrimaryScreen.Bounds.Height - Height * 2);
        }

        private void Lyric_Resize(object sender, EventArgs e)
        {
            if (WindowState ==  FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                FormBorderStyle = FormBorderStyle.None;
            }
        }

        [DllImport("user32.dll")]
        public static extern uint SetWindowLong(IntPtr h, int n, uint x);
    }
}
