
namespace CommonControls
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chkConfirmed = new System.Windows.Forms.CheckBox();
            this.btnConfirmed = new System.Windows.Forms.Button();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDisplayCity = new System.Windows.Forms.Button();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnShowDate = new System.Windows.Forms.Button();
            this.btnChangeChecked = new System.Windows.Forms.Button();
            this.numUnitInStock = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnShowNumValue = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitInStock)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(71, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(243, 23);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sayı 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sayı 2:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Topla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // chkConfirmed
            // 
            this.chkConfirmed.AutoSize = true;
            this.chkConfirmed.Location = new System.Drawing.Point(71, 183);
            this.chkConfirmed.Name = "chkConfirmed";
            this.chkConfirmed.Size = new System.Drawing.Size(159, 19);
            this.chkConfirmed.TabIndex = 6;
            this.chkConfirmed.Text = "Okudum kabul ediyorum";
            this.chkConfirmed.UseVisualStyleBackColor = true;
            // 
            // btnConfirmed
            // 
            this.btnConfirmed.Location = new System.Drawing.Point(155, 208);
            this.btnConfirmed.Name = "btnConfirmed";
            this.btnConfirmed.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmed.TabIndex = 7;
            this.btnConfirmed.Text = "Tamam";
            this.btnConfirmed.UseVisualStyleBackColor = true;
            this.btnConfirmed.Click += new System.EventHandler(this.btnConfirmed_Click);
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Items.AddRange(new object[] {
            "İstanbul",
            "Ankara",
            "Antalya",
            "İzmir"});
            this.cmbCity.Location = new System.Drawing.Point(550, 55);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(121, 23);
            this.cmbCity.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Şehir Seçiniz";
            // 
            // btnDisplayCity
            // 
            this.btnDisplayCity.Location = new System.Drawing.Point(590, 99);
            this.btnDisplayCity.Name = "btnDisplayCity";
            this.btnDisplayCity.Size = new System.Drawing.Size(81, 23);
            this.btnDisplayCity.TabIndex = 10;
            this.btnDisplayCity.Text = "Şehri Göster";
            this.btnDisplayCity.UseVisualStyleBackColor = true;
            this.btnDisplayCity.Click += new System.EventHandler(this.btnDisplayCity_Click);
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(473, 140);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(200, 23);
            this.dtpDateOfBirth.TabIndex = 11;
            this.dtpDateOfBirth.ValueChanged += new System.EventHandler(this.dtpDateOfBirth_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Doğum Tarihi";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnShowDate
            // 
            this.btnShowDate.Location = new System.Drawing.Point(579, 179);
            this.btnShowDate.Name = "btnShowDate";
            this.btnShowDate.Size = new System.Drawing.Size(92, 23);
            this.btnShowDate.TabIndex = 13;
            this.btnShowDate.Text = "Tarihi Göster";
            this.btnShowDate.UseVisualStyleBackColor = true;
            this.btnShowDate.Click += new System.EventHandler(this.btnShowDate_Click);
            // 
            // btnChangeChecked
            // 
            this.btnChangeChecked.Location = new System.Drawing.Point(155, 237);
            this.btnChangeChecked.Name = "btnChangeChecked";
            this.btnChangeChecked.Size = new System.Drawing.Size(75, 23);
            this.btnChangeChecked.TabIndex = 14;
            this.btnChangeChecked.Text = "Değiştir";
            this.btnChangeChecked.UseVisualStyleBackColor = true;
            this.btnChangeChecked.Click += new System.EventHandler(this.btnChangeChecked_Click);
            // 
            // numUnitInStock
            // 
            this.numUnitInStock.DecimalPlaces = 4;
            this.numUnitInStock.Location = new System.Drawing.Point(473, 239);
            this.numUnitInStock.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numUnitInStock.Name = "numUnitInStock";
            this.numUnitInStock.Size = new System.Drawing.Size(197, 23);
            this.numUnitInStock.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ürün Adedi";
            // 
            // btnShowNumValue
            // 
            this.btnShowNumValue.Location = new System.Drawing.Point(563, 278);
            this.btnShowNumValue.Name = "btnShowNumValue";
            this.btnShowNumValue.Size = new System.Drawing.Size(107, 23);
            this.btnShowNumValue.TabIndex = 17;
            this.btnShowNumValue.Text = "Sayıyı Görüntüle";
            this.btnShowNumValue.UseVisualStyleBackColor = true;
            this.btnShowNumValue.Click += new System.EventHandler(this.btnShowNumValue_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(473, 328);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(197, 23);
            this.maskedTextBox1.TabIndex = 18;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.btnShowNumValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numUnitInStock);
            this.Controls.Add(this.btnChangeChecked);
            this.Controls.Add(this.btnShowDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.btnDisplayCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.btnConfirmed);
            this.Controls.Add(this.chkConfirmed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Windows Forms Kontrolleri";
            this.Load += new System.EventHandler(this.labelNumber01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUnitInStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkConfirmed;
        private System.Windows.Forms.Button btnConfirmed;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDisplayCity;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnShowDate;
        private System.Windows.Forms.Button btnChangeChecked;
        private System.Windows.Forms.NumericUpDown numUnitInStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnShowNumValue;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

