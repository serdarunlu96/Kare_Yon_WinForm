namespace Kare_Yon_WinForm
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
            ustLabel = new Label();
            btnHareket = new Button();
            btnSag = new Button();
            btnSol = new Button();
            btnAsagi = new Button();
            btnYukari = new Button();
            altLabel = new Label();
            solLabel = new Label();
            sagLabel = new Label();
            SuspendLayout();
            // 
            // ustLabel
            // 
            ustLabel.Cursor = Cursors.No;
            ustLabel.ForeColor = SystemColors.ControlLightLight;
            ustLabel.Location = new Point(265, 9);
            ustLabel.Name = "ustLabel";
            ustLabel.Size = new Size(534, 10);
            ustLabel.TabIndex = 7;
            // 
            // btnHareket
            // 
            btnHareket.BackColor = SystemColors.ActiveCaption;
            btnHareket.Location = new Point(312, 172);
            btnHareket.Name = "btnHareket";
            btnHareket.Size = new Size(77, 62);
            btnHareket.TabIndex = 13;
            btnHareket.UseVisualStyleBackColor = false;
            // 
            // btnSag
            // 
            btnSag.Location = new Point(194, 171);
            btnSag.Name = "btnSag";
            btnSag.Size = new Size(75, 64);
            btnSag.TabIndex = 12;
            btnSag.Text = "Sag";
            btnSag.UseVisualStyleBackColor = true;
            btnSag.Click += btnSag_Click_1;
            // 
            // btnSol
            // 
            btnSol.Location = new Point(31, 171);
            btnSol.Name = "btnSol";
            btnSol.Size = new Size(75, 64);
            btnSol.TabIndex = 11;
            btnSol.Text = "Sol";
            btnSol.UseVisualStyleBackColor = true;
            btnSol.Click += btnSol_Click_1;
            // 
            // btnAsagi
            // 
            btnAsagi.Location = new Point(113, 171);
            btnAsagi.Name = "btnAsagi";
            btnAsagi.Size = new Size(75, 64);
            btnAsagi.TabIndex = 10;
            btnAsagi.Text = "Asagi";
            btnAsagi.UseVisualStyleBackColor = true;
            btnAsagi.Click += btnAsagi_Click_1;
            // 
            // btnYukari
            // 
            btnYukari.Location = new Point(113, 101);
            btnYukari.Name = "btnYukari";
            btnYukari.Size = new Size(75, 64);
            btnYukari.TabIndex = 9;
            btnYukari.Text = "Yukari";
            btnYukari.UseVisualStyleBackColor = true;
            btnYukari.Click += btnYukari_Click_1;
            // 
            // altLabel
            // 
            altLabel.Cursor = Cursors.No;
            altLabel.ForeColor = SystemColors.ControlLightLight;
            altLabel.Location = new Point(265, 248);
            altLabel.Name = "altLabel";
            altLabel.Size = new Size(534, 10);
            altLabel.TabIndex = 14;
            // 
            // solLabel
            // 
            solLabel.Cursor = Cursors.No;
            solLabel.ForeColor = SystemColors.ControlLightLight;
            solLabel.Location = new Point(282, 9);
            solLabel.Name = "solLabel";
            solLabel.Size = new Size(10, 249);
            solLabel.TabIndex = 15;
            // 
            // sagLabel
            // 
            sagLabel.Cursor = Cursors.No;
            sagLabel.ForeColor = SystemColors.ControlLightLight;
            sagLabel.Location = new Point(778, 9);
            sagLabel.Name = "sagLabel";
            sagLabel.Size = new Size(10, 249);
            sagLabel.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 267);
            Controls.Add(sagLabel);
            Controls.Add(solLabel);
            Controls.Add(altLabel);
            Controls.Add(btnHareket);
            Controls.Add(btnSag);
            Controls.Add(btnSol);
            Controls.Add(btnAsagi);
            Controls.Add(btnYukari);
            Controls.Add(ustLabel);
            Name = "Form1";
            Text = "KARE OYUNU";
            ResumeLayout(false);
        }

        #endregion
        private Label ustLabel;
        private Button btnHareket;
        private Button btnSag;
        private Button btnSol;
        private Button btnAsagi;
        private Button btnYukari;
        private Label altLabel;
        private Label solLabel;
        private Label sagLabel;
    }
}