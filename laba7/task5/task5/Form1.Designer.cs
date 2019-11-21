namespace task5
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTovar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStoimost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxVes = new System.Windows.Forms.TextBox();
            this.Zapisat = new System.Windows.Forms.Button();
            this.buttonOchistit = new System.Windows.Forms.Button();
            this.buttonZapisatVFail = new System.Windows.Forms.Button();
            this.buttonProchitatIzFaila = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Товар";
            // 
            // textBoxTovar
            // 
            this.textBoxTovar.Location = new System.Drawing.Point(54, 87);
            this.textBoxTovar.Name = "textBoxTovar";
            this.textBoxTovar.Size = new System.Drawing.Size(537, 31);
            this.textBoxTovar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Стоимость";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Вес";
            // 
            // textBoxStoimost
            // 
            this.textBoxStoimost.Location = new System.Drawing.Point(54, 234);
            this.textBoxStoimost.Name = "textBoxStoimost";
            this.textBoxStoimost.Size = new System.Drawing.Size(537, 31);
            this.textBoxStoimost.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Дата поступления";
            // 
            // textBoxVes
            // 
            this.textBoxVes.Location = new System.Drawing.Point(54, 378);
            this.textBoxVes.Name = "textBoxVes";
            this.textBoxVes.Size = new System.Drawing.Size(537, 31);
            this.textBoxVes.TabIndex = 6;
            // 
            // Zapisat
            // 
            this.Zapisat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Zapisat.Location = new System.Drawing.Point(54, 632);
            this.Zapisat.Name = "Zapisat";
            this.Zapisat.Size = new System.Drawing.Size(537, 68);
            this.Zapisat.TabIndex = 8;
            this.Zapisat.Text = "Записать";
            this.Zapisat.UseVisualStyleBackColor = true;
            this.Zapisat.Click += new System.EventHandler(this.Zapisat_Click);
            // 
            // buttonOchistit
            // 
            this.buttonOchistit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOchistit.Location = new System.Drawing.Point(54, 753);
            this.buttonOchistit.Name = "buttonOchistit";
            this.buttonOchistit.Size = new System.Drawing.Size(537, 74);
            this.buttonOchistit.TabIndex = 9;
            this.buttonOchistit.Text = "Очистить окна ввода";
            this.buttonOchistit.UseVisualStyleBackColor = true;
            this.buttonOchistit.Click += new System.EventHandler(this.buttonOchistit_Click);
            // 
            // buttonZapisatVFail
            // 
            this.buttonZapisatVFail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonZapisatVFail.Location = new System.Drawing.Point(1887, 61);
            this.buttonZapisatVFail.Name = "buttonZapisatVFail";
            this.buttonZapisatVFail.Size = new System.Drawing.Size(260, 82);
            this.buttonZapisatVFail.TabIndex = 10;
            this.buttonZapisatVFail.Text = "Записать в файл";
            this.buttonZapisatVFail.UseVisualStyleBackColor = true;
            this.buttonZapisatVFail.Click += new System.EventHandler(this.buttonZapisatVFail_Click);
            // 
            // buttonProchitatIzFaila
            // 
            this.buttonProchitatIzFaila.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonProchitatIzFaila.Location = new System.Drawing.Point(1887, 202);
            this.buttonProchitatIzFaila.Name = "buttonProchitatIzFaila";
            this.buttonProchitatIzFaila.Size = new System.Drawing.Size(260, 89);
            this.buttonProchitatIzFaila.TabIndex = 11;
            this.buttonProchitatIzFaila.Text = "Прочитать из файла";
            this.buttonProchitatIzFaila.UseVisualStyleBackColor = true;
            this.buttonProchitatIzFaila.Click += new System.EventHandler(this.buttonProchitatIzFaila_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(704, 46);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1082, 805);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(54, 539);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(537, 31);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2206, 907);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonProchitatIzFaila);
            this.Controls.Add(this.buttonZapisatVFail);
            this.Controls.Add(this.buttonOchistit);
            this.Controls.Add(this.Zapisat);
            this.Controls.Add(this.textBoxVes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxStoimost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTovar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Метод String.Format()";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTovar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStoimost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxVes;
        private System.Windows.Forms.Button Zapisat;
        private System.Windows.Forms.Button buttonOchistit;
        private System.Windows.Forms.Button buttonZapisatVFail;
        private System.Windows.Forms.Button buttonProchitatIzFaila;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

