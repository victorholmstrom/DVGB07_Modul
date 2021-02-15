
namespace DVGB07_Modul2
{
    partial class MainForm
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
            this.Modul2Label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CalcButton = new System.Windows.Forms.Button();
            this.LottoButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Modul2Label
            // 
            this.Modul2Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Modul2Label.AutoSize = true;
            this.Modul2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modul2Label.Location = new System.Drawing.Point(168, 23);
            this.Modul2Label.Name = "Modul2Label";
            this.Modul2Label.Size = new System.Drawing.Size(89, 25);
            this.Modul2Label.TabIndex = 0;
            this.Modul2Label.Text = "Modul 2";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.CalcButton);
            this.panel1.Controls.Add(this.LottoButton);
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 342);
            this.panel1.TabIndex = 1;
            // 
            // CalcButton
            // 
            this.CalcButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CalcButton.Location = new System.Drawing.Point(173, 47);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(84, 23);
            this.CalcButton.TabIndex = 1;
            this.CalcButton.Text = "Calculator";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // LottoButton
            // 
            this.LottoButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LottoButton.Location = new System.Drawing.Point(173, 18);
            this.LottoButton.Name = "LottoButton";
            this.LottoButton.Size = new System.Drawing.Size(84, 23);
            this.LottoButton.TabIndex = 0;
            this.LottoButton.Text = "Lotto";
            this.LottoButton.UseVisualStyleBackColor = true;
            this.LottoButton.Click += new System.EventHandler(this.LottoButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 405);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Modul2Label);
            this.MinimumSize = new System.Drawing.Size(136, 188);
            this.Name = "MainForm";
            this.Text = "DVGB07";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Modul2Label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Button LottoButton;
    }
}

