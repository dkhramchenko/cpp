namespace task1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxProductionYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFoto = new System.Windows.Forms.TextBox();
            this.buttonChooseFoto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSelectedBrand = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSelectedPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSelectedYear = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "фото машин (*.jpg, *.jpeg, *.png)|";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(575, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(678, 754);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(63, 73);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(371, 31);
            this.textBoxBrand.TabIndex = 1;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(63, 196);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(371, 31);
            this.textBoxPrice.TabIndex = 2;
            // 
            // textBoxProductionYear
            // 
            this.textBoxProductionYear.Location = new System.Drawing.Point(58, 339);
            this.textBoxProductionYear.Name = "textBoxProductionYear";
            this.textBoxProductionYear.Size = new System.Drawing.Size(371, 31);
            this.textBoxProductionYear.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Марка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Год выпуска";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Фото";
            // 
            // textBoxFoto
            // 
            this.textBoxFoto.Location = new System.Drawing.Point(68, 495);
            this.textBoxFoto.Name = "textBoxFoto";
            this.textBoxFoto.ReadOnly = true;
            this.textBoxFoto.Size = new System.Drawing.Size(361, 31);
            this.textBoxFoto.TabIndex = 8;
            // 
            // buttonChooseFoto
            // 
            this.buttonChooseFoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonChooseFoto.Location = new System.Drawing.Point(462, 487);
            this.buttonChooseFoto.Name = "buttonChooseFoto";
            this.buttonChooseFoto.Size = new System.Drawing.Size(75, 47);
            this.buttonChooseFoto.TabIndex = 9;
            this.buttonChooseFoto.Text = "..";
            this.buttonChooseFoto.UseVisualStyleBackColor = true;
            this.buttonChooseFoto.Click += new System.EventHandler(this.buttonChooseFoto_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1319, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Вы выбрали:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1319, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Марка";
            // 
            // textBoxSelectedBrand
            // 
            this.textBoxSelectedBrand.Location = new System.Drawing.Point(1324, 112);
            this.textBoxSelectedBrand.Name = "textBoxSelectedBrand";
            this.textBoxSelectedBrand.ReadOnly = true;
            this.textBoxSelectedBrand.Size = new System.Drawing.Size(371, 31);
            this.textBoxSelectedBrand.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1757, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Цена";
            // 
            // textBoxSelectedPrice
            // 
            this.textBoxSelectedPrice.Location = new System.Drawing.Point(1762, 112);
            this.textBoxSelectedPrice.Name = "textBoxSelectedPrice";
            this.textBoxSelectedPrice.ReadOnly = true;
            this.textBoxSelectedPrice.Size = new System.Drawing.Size(188, 31);
            this.textBoxSelectedPrice.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1993, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Год выпуска";
            // 
            // textBoxSelectedYear
            // 
            this.textBoxSelectedYear.Location = new System.Drawing.Point(1998, 112);
            this.textBoxSelectedYear.Name = "textBoxSelectedYear";
            this.textBoxSelectedYear.ReadOnly = true;
            this.textBoxSelectedYear.Size = new System.Drawing.Size(174, 31);
            this.textBoxSelectedYear.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(1324, 196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(983, 570);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(68, 611);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(258, 79);
            this.buttonAdd.TabIndex = 18;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2353, 820);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxSelectedYear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxSelectedPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxSelectedBrand);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonChooseFoto);
            this.Controls.Add(this.textBoxFoto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxProductionYear);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxBrand);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxProductionYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFoto;
        private System.Windows.Forms.Button buttonChooseFoto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSelectedBrand;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSelectedPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSelectedYear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAdd;
    }
}

