﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Car car1 = new Car(price: 10000, brand: "bmw");
            richTextBox1.Text += "Тестирование именованных параметров:\n" + car1.CarText();
            
            Car car2 = new Car(price: 5000);
            richTextBox1.Text += "Тестирование параметров поумолчанию:\n" + car2.CarText();

            Car car3 = new Car(price: 9000);
            int[] crashes = new int[] { 3, 5, 4, 2, 3 };
            int test = 7;
            car3.AverageCrashes(ref test, crashes);
            richTextBox1.Text += 
            String.Format(
                "Тестрирование передачи параметра по ссылке:\n" +
                "Среднее количество аварий: {0}; test: {1}\n",
                car3.crashes.Average(), test
                );
            string resume;
            double res;
            car3.AverageCrashes(crashes: crashes, res: out res, resume: out resume);
            richTextBox1.Text +=
                String.Format(
                    "Тестирование out параметров:\nСреднее количество аварий: {0}; Состояние: {1}",
                    res, resume
                    );
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
