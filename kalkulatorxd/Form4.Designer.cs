﻿namespace kalkulatorxd
{
    partial class Form4
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.clockBox = new System.Windows.Forms.PictureBox();
            this.hourBox = new System.Windows.Forms.PictureBox();
            this.minuteBox = new System.Windows.Forms.PictureBox();
            this.secondBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.clockBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondBox)).BeginInit();
            this.SuspendLayout();
            // 
            // clockBox
            // 
            this.clockBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clockBox.BackColor = System.Drawing.Color.Transparent;
            this.clockBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.clockBox.Location = new System.Drawing.Point(12, 21);
            this.clockBox.Name = "clockBox";
            this.clockBox.Size = new System.Drawing.Size(300, 300);
            this.clockBox.TabIndex = 0;
            this.clockBox.TabStop = false;
            this.clockBox.Click += new System.EventHandler(this.clockBox_Click);
            // 
            // hourBox
            // 
            this.hourBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hourBox.BackColor = System.Drawing.Color.Transparent;
            this.hourBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hourBox.Location = new System.Drawing.Point(12, 21);
            this.hourBox.Name = "hourBox";
            this.hourBox.Size = new System.Drawing.Size(300, 300);
            this.hourBox.TabIndex = 1;
            this.hourBox.TabStop = false;
            // 
            // minuteBox
            // 
            this.minuteBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minuteBox.BackColor = System.Drawing.Color.Transparent;
            this.minuteBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minuteBox.Location = new System.Drawing.Point(12, 21);
            this.minuteBox.Name = "minuteBox";
            this.minuteBox.Size = new System.Drawing.Size(300, 300);
            this.minuteBox.TabIndex = 2;
            this.minuteBox.TabStop = false;
            this.minuteBox.Click += new System.EventHandler(this.minuteBox_Click);
            // 
            // secondBox
            // 
            this.secondBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.secondBox.BackColor = System.Drawing.Color.Transparent;
            this.secondBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.secondBox.Location = new System.Drawing.Point(12, 21);
            this.secondBox.Name = "secondBox";
            this.secondBox.Size = new System.Drawing.Size(300, 300);
            this.secondBox.TabIndex = 3;
            this.secondBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form4
            // 
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(350, 350);
            this.Controls.Add(this.clockBox);
            this.Controls.Add(this.hourBox);
            this.Controls.Add(this.minuteBox);
            this.Controls.Add(this.secondBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form4";
            this.Text = "Zegar analogowy";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clockBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox clockBox;
        private System.Windows.Forms.PictureBox hourBox;
        private System.Windows.Forms.PictureBox minuteBox;
        private System.Windows.Forms.PictureBox secondBox;
    }
}

