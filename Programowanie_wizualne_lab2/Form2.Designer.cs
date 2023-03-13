namespace Programowanie_wizualne_lab2
{
    partial class Form2
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
            this.radio3TB = new System.Windows.Forms.RadioButton();
            this.radio1TB = new System.Windows.Forms.RadioButton();
            this.radio2TB = new System.Windows.Forms.RadioButton();
            this.checkMysz = new System.Windows.Forms.CheckBox();
            this.checkGrafika = new System.Windows.Forms.CheckBox();
            this.checkPort = new System.Windows.Forms.CheckBox();
            this.checkKamera = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.labelCena = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radio3TB
            // 
            this.radio3TB.AutoSize = true;
            this.radio3TB.Location = new System.Drawing.Point(111, 136);
            this.radio3TB.Name = "radio3TB";
            this.radio3TB.Size = new System.Drawing.Size(55, 24);
            this.radio3TB.TabIndex = 0;
            this.radio3TB.TabStop = true;
            this.radio3TB.Text = "3TB";
            this.radio3TB.UseVisualStyleBackColor = true;
            this.radio3TB.CheckedChanged += new System.EventHandler(this.radio3TB_CheckedChanged);
            // 
            // radio1TB
            // 
            this.radio1TB.AutoSize = true;
            this.radio1TB.Location = new System.Drawing.Point(111, 195);
            this.radio1TB.Name = "radio1TB";
            this.radio1TB.Size = new System.Drawing.Size(55, 24);
            this.radio1TB.TabIndex = 1;
            this.radio1TB.TabStop = true;
            this.radio1TB.Text = "1TB";
            this.radio1TB.UseVisualStyleBackColor = true;
            this.radio1TB.CheckedChanged += new System.EventHandler(this.radio1TB_CheckedChanged);
            // 
            // radio2TB
            // 
            this.radio2TB.AutoSize = true;
            this.radio2TB.Location = new System.Drawing.Point(111, 253);
            this.radio2TB.Name = "radio2TB";
            this.radio2TB.Size = new System.Drawing.Size(55, 24);
            this.radio2TB.TabIndex = 2;
            this.radio2TB.TabStop = true;
            this.radio2TB.Text = "2TB";
            this.radio2TB.UseVisualStyleBackColor = true;
            this.radio2TB.CheckedChanged += new System.EventHandler(this.radio2TB_CheckedChanged);
            // 
            // checkMysz
            // 
            this.checkMysz.AutoSize = true;
            this.checkMysz.Location = new System.Drawing.Point(393, 90);
            this.checkMysz.Name = "checkMysz";
            this.checkMysz.Size = new System.Drawing.Size(64, 24);
            this.checkMysz.TabIndex = 3;
            this.checkMysz.Text = "Mysz";
            this.checkMysz.UseVisualStyleBackColor = true;
            this.checkMysz.CheckedChanged += new System.EventHandler(this.checkMysz_CheckedChanged);
            // 
            // checkGrafika
            // 
            this.checkGrafika.AutoSize = true;
            this.checkGrafika.Location = new System.Drawing.Point(393, 253);
            this.checkGrafika.Name = "checkGrafika";
            this.checkGrafika.Size = new System.Drawing.Size(165, 24);
            this.checkGrafika.TabIndex = 4;
            this.checkGrafika.Text = "Wbudowana grafika";
            this.checkGrafika.UseVisualStyleBackColor = true;
            this.checkGrafika.CheckedChanged += new System.EventHandler(this.checkGrafika_CheckedChanged);
            // 
            // checkPort
            // 
            this.checkPort.AutoSize = true;
            this.checkPort.Location = new System.Drawing.Point(393, 195);
            this.checkPort.Name = "checkPort";
            this.checkPort.Size = new System.Drawing.Size(103, 24);
            this.checkPort.TabIndex = 5;
            this.checkPort.Text = "Port USB-C";
            this.checkPort.UseVisualStyleBackColor = true;
            this.checkPort.CheckedChanged += new System.EventHandler(this.checkPort_CheckedChanged);
            // 
            // checkKamera
            // 
            this.checkKamera.AutoSize = true;
            this.checkKamera.Location = new System.Drawing.Point(393, 136);
            this.checkKamera.Name = "checkKamera";
            this.checkKamera.Size = new System.Drawing.Size(82, 24);
            this.checkKamera.TabIndex = 6;
            this.checkKamera.Text = "Kamera";
            this.checkKamera.UseVisualStyleBackColor = true;
            this.checkKamera.CheckedChanged += new System.EventHandler(this.checkKamera_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "RTX 3660",
            "GTX 1600Ti",
            "RTX 4090"});
            this.comboBox1.Location = new System.Drawing.Point(84, 344);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.Location = new System.Drawing.Point(593, 321);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(120, 67);
            this.buttonZapisz.TabIndex = 8;
            this.buttonZapisz.Text = "Zapisz i wróć";
            this.buttonZapisz.UseVisualStyleBackColor = true;
            this.buttonZapisz.Click += new System.EventHandler(this.buttonZapisz_Click);
            // 
            // labelCena
            // 
            this.labelCena.AutoSize = true;
            this.labelCena.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCena.Location = new System.Drawing.Point(407, 321);
            this.labelCena.Name = "labelCena";
            this.labelCena.Size = new System.Drawing.Size(121, 67);
            this.labelCena.TabIndex = 9;
            this.labelCena.Text = "0,00";
            this.labelCena.Click += new System.EventHandler(this.labelCena_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(94, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 46);
            this.label1.TabIndex = 10;
            this.label1.Text = "DYSK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(74, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 35);
            this.label2.TabIndex = 11;
            this.label2.Text = "Karty graficzne";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCena);
            this.Controls.Add(this.buttonZapisz);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkKamera);
            this.Controls.Add(this.checkPort);
            this.Controls.Add(this.checkGrafika);
            this.Controls.Add(this.checkMysz);
            this.Controls.Add(this.radio2TB);
            this.Controls.Add(this.radio1TB);
            this.Controls.Add(this.radio3TB);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton radio3TB;
        private RadioButton radio1TB;
        private RadioButton radio2TB;
        private CheckBox checkMysz;
        private CheckBox checkGrafika;
        private CheckBox checkPort;
        private CheckBox checkKamera;
        private ComboBox comboBox1;
        private Button buttonZapisz;
        private Label labelCena;
        private Label label1;
        private Label label2;
    }
}