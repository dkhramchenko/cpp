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

namespace task6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int pbw;
        private int pbh;

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                listBox1.Items.Clear();
                foreach (string str in openFileDialog1.FileNames)
                {
                    listBox1.Items.Add(str);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string picture = listBox1.SelectedItem.ToString();
            pictureBox1.Image = new Bitmap(picture);
            if (pictureBox1.Image.Width > pbw || pictureBox1.Image.Height > pbh)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbw = pictureBox1.Width;
            pbh = pictureBox1.Height;
        }
    }
}
