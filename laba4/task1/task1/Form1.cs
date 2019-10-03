using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontStyle fs = new FontStyle();
            string f = checkedListBox1.SelectedItem.ToString();
            switch (f)
            {
                case "Bold":
                    fs = FontStyle.Bold;
                    break;
                case "Italic":
                    fs = FontStyle.Italic;
                    break;
                case "Underline":
                    fs = FontStyle.Underline;
                    break;
            }
            Font font = new Font("Arial", 18, fs);
            label1.Font = font;
        }
    }
}