namespace LiczbyPierwsze.WinForms
{
    partial class MainWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDolny = new System.Windows.Forms.TextBox();
            this.tbGorny = new System.Windows.Forms.TextBox();
            this.btnGener = new System.Windows.Forms.Button();
            this.tbWynik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbWynik = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.btnGener);
            this.panel1.Controls.Add(this.tbGorny);
            this.panel1.Controls.Add(this.tbDolny);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dolny zakres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Górny zakres";
            // 
            // tbDolny
            // 
            this.tbDolny.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbDolny.Location = new System.Drawing.Point(167, 10);
            this.tbDolny.Name = "tbDolny";
            this.tbDolny.Size = new System.Drawing.Size(104, 26);
            this.tbDolny.TabIndex = 2;
            this.tbDolny.Text = "2";
            // 
            // tbGorny
            // 
            this.tbGorny.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbGorny.Location = new System.Drawing.Point(167, 55);
            this.tbGorny.Name = "tbGorny";
            this.tbGorny.Size = new System.Drawing.Size(104, 26);
            this.tbGorny.TabIndex = 3;
            this.tbGorny.Text = "20";
            // 
            // btnGener
            // 
            this.btnGener.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGener.Location = new System.Drawing.Point(314, 12);
            this.btnGener.Name = "btnGener";
            this.btnGener.Size = new System.Drawing.Size(159, 67);
            this.btnGener.TabIndex = 4;
            this.btnGener.Text = "Generuj liczby";
            this.btnGener.UseVisualStyleBackColor = true;
            this.btnGener.Click += new System.EventHandler(this.btnGener_Click);
            // 
            // tbWynik
            // 
            this.tbWynik.BackColor = System.Drawing.Color.White;
            this.tbWynik.Location = new System.Drawing.Point(0, 106);
            this.tbWynik.Multiline = true;
            this.tbWynik.Name = "tbWynik";
            this.tbWynik.ReadOnly = true;
            this.tbWynik.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbWynik.Size = new System.Drawing.Size(385, 346);
            this.tbWynik.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(410, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ilość liczb pierwszych:";
            // 
            // lbWynik
            // 
            this.lbWynik.AutoSize = true;
            this.lbWynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbWynik.ForeColor = System.Drawing.Color.Navy;
            this.lbWynik.Location = new System.Drawing.Point(632, 201);
            this.lbWynik.Name = "lbWynik";
            this.lbWynik.Size = new System.Drawing.Size(0, 24);
            this.lbWynik.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbWynik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbWynik);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Liczby Pierwsze 2019 v1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbGorny;
        private System.Windows.Forms.TextBox tbDolny;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGener;
        private System.Windows.Forms.TextBox tbWynik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbWynik;
    }
}

