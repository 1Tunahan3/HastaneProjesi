
namespace HastaneProjesi
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
            this.btnHasta = new System.Windows.Forms.Button();
            this.btnDoktor = new System.Windows.Forms.Button();
            this.btnSekreter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHasta
            // 
            this.btnHasta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHasta.Location = new System.Drawing.Point(34, 175);
            this.btnHasta.Name = "btnHasta";
            this.btnHasta.Size = new System.Drawing.Size(231, 137);
            this.btnHasta.TabIndex = 0;
            this.btnHasta.Text = "Hasta Giriş";
            this.btnHasta.UseVisualStyleBackColor = true;
            this.btnHasta.Click += new System.EventHandler(this.btnHasta_Click);
            // 
            // btnDoktor
            // 
            this.btnDoktor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoktor.Location = new System.Drawing.Point(292, 175);
            this.btnDoktor.Name = "btnDoktor";
            this.btnDoktor.Size = new System.Drawing.Size(222, 137);
            this.btnDoktor.TabIndex = 1;
            this.btnDoktor.Text = "Doktor Girişi";
            this.btnDoktor.UseVisualStyleBackColor = true;
            this.btnDoktor.Click += new System.EventHandler(this.btnDoktor_Click);
            // 
            // btnSekreter
            // 
            this.btnSekreter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSekreter.Location = new System.Drawing.Point(543, 175);
            this.btnSekreter.Name = "btnSekreter";
            this.btnSekreter.Size = new System.Drawing.Size(228, 137);
            this.btnSekreter.TabIndex = 2;
            this.btnSekreter.Text = "Sekreter Girişi";
            this.btnSekreter.UseVisualStyleBackColor = true;
            this.btnSekreter.Click += new System.EventHandler(this.btnSekreter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSekreter);
            this.Controls.Add(this.btnDoktor);
            this.Controls.Add(this.btnHasta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHasta;
        private System.Windows.Forms.Button btnDoktor;
        private System.Windows.Forms.Button btnSekreter;
    }
}

