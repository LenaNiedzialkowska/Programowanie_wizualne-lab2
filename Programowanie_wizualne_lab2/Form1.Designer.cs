namespace Programowanie_wizualne_lab2
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
            this.components = new System.ComponentModel.Container();
            this.buttonKomputer = new System.Windows.Forms.Button();
            this.buttonMonitor = new System.Windows.Forms.Button();
            this.labelCena = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonKomputer
            // 
            this.buttonKomputer.Location = new System.Drawing.Point(120, 172);
            this.buttonKomputer.Name = "buttonKomputer";
            this.buttonKomputer.Size = new System.Drawing.Size(138, 98);
            this.buttonKomputer.TabIndex = 0;
            this.buttonKomputer.Text = "Komputer";
            this.buttonKomputer.UseVisualStyleBackColor = true;
            this.buttonKomputer.Click += new System.EventHandler(this.buttonKomputer_Click);
            // 
            // buttonMonitor
            // 
            this.buttonMonitor.Location = new System.Drawing.Point(297, 172);
            this.buttonMonitor.Name = "buttonMonitor";
            this.buttonMonitor.Size = new System.Drawing.Size(123, 98);
            this.buttonMonitor.TabIndex = 1;
            this.buttonMonitor.Text = "Monitor";
            this.buttonMonitor.UseVisualStyleBackColor = true;
            this.buttonMonitor.Click += new System.EventHandler(this.buttonMonitor_Click);
            // 
            // labelCena
            // 
            this.labelCena.AutoSize = true;
            this.labelCena.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCena.Location = new System.Drawing.Point(477, 203);
            this.labelCena.Name = "labelCena";
            this.labelCena.Size = new System.Drawing.Size(56, 67);
            this.labelCena.TabIndex = 2;
            this.labelCena.Text = "0";
            this.labelCena.Click += new System.EventHandler(this.labelCena_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCena);
            this.Controls.Add(this.buttonMonitor);
            this.Controls.Add(this.buttonKomputer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonKomputer;
        private Button buttonMonitor;
        private Label labelCena;
        private System.Windows.Forms.Timer timer1;
    }
}