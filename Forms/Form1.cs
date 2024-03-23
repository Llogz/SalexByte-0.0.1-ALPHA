using System;
using System.Drawing;
using System.Windows.Forms;

namespace Forms
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int radius = 20; // Установите радиус углов
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddLine(radius, 0, topPanel.Width - radius, 0);
            path.AddArc(topPanel.Width - radius, 0, radius, radius, 270, 90);
            path.AddLine(topPanel.Width, radius, topPanel.Width, topPanel.Height);
            path.AddLine(topPanel.Width, topPanel.Height, 0, topPanel.Height);
            path.AddLine(0, topPanel.Height, 0, radius);
            path.AddArc(0, 0, radius, radius, 180, 90);
            topPanel.Region = new Region(path);
        }



        private Point MouseDownLocation;

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Left = e.X + this.Left - MouseDownLocation.X;
                this.Top = e.Y + this.Top - MouseDownLocation.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Left = e.X + this.Left - MouseDownLocation.X;
                this.Top = e.Y + this.Top - MouseDownLocation.Y;
            }
        }
        private PictureBox Exit;
        private Panel panel1;

        private void kryptonTreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
