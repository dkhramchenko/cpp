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

        private void Form1_Load(object sender, EventArgs e)
        {
            ICargoCarrier lorry = new Lorry("iveco", 100000, 50000, 2500, 55, 15);
            richTextBox1.Text += ((Lorry)lorry).CarText();
            richTextBox1.Text +=
                String.Format("\nЗапас хода: {0}км; \nМаксимальная длина груза: {1}м; Максимальная масса груза: {2}кг",
                ((Lorry)lorry).TankRange(), ((Lorry)lorry).MaxCargoLength(), ((Lorry)lorry).MaxCargoWeight());
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
