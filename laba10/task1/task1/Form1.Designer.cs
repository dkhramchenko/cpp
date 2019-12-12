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
            this.richTextBoxBrand = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxPrice = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.richTextBoxCars = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxBrand
            // 
            this.richTextBoxBrand.Location = new System.Drawing.Point(34, 71);
            this.richTextBoxBrand.Name = "richTextBoxBrand";
            this.richTextBoxBrand.Size = new System.Drawing.Size(219, 37);
            this.richTextBoxBrand.TabIndex = 0;
            this.richTextBoxBrand.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Марка";
            // 
            // richTextBoxPrice
            // 
            this.richTextBoxPrice.Location = new System.Drawing.Point(34, 213);
            this.richTextBoxPrice.Name = "richTextBoxPrice";
            this.richTextBoxPrice.Size = new System.Drawing.Size(219, 37);
            this.richTextBoxPrice.TabIndex = 2;
            this.richTextBoxPrice.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Цена";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(34, 338);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(201, 56);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // richTextBoxCars
            // 
            this.richTextBoxCars.Location = new System.Drawing.Point(310, 62);
            this.richTextBoxCars.Name = "richTextBoxCars";
            this.richTextBoxCars.Size = new System.Drawing.Size(439, 346);
            this.richTextBoxCars.TabIndex = 5;
            this.richTextBoxCars.Text = "";
            this.richTextBoxCars.TextChanged += new System.EventHandler(this.RichTextBoxCars_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Автомобили";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBoxCars);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBoxPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxBrand);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxBrand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.RichTextBox richTextBoxCars;
        private System.Windows.Forms.Label label3;
    }
}

