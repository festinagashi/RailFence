
namespace Projekti1
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
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnDecryption = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnEncryption = new System.Windows.Forms.Button();
            this.TxtPlan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCipher = new System.Windows.Forms.TextBox();
            this.TxtDecipher = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnExit.Location = new System.Drawing.Point(390, 266);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(146, 50);
            this.BtnExit.TabIndex = 13;
            this.BtnExit.Text = "Mbyll";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnDecryption
            // 
            this.BtnDecryption.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDecryption.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnDecryption.Location = new System.Drawing.Point(203, 268);
            this.BtnDecryption.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BtnDecryption.Name = "BtnDecryption";
            this.BtnDecryption.Size = new System.Drawing.Size(146, 50);
            this.BtnDecryption.TabIndex = 12;
            this.BtnDecryption.Text = "Dekripto";
            this.BtnDecryption.UseVisualStyleBackColor = true;
            this.BtnDecryption.Click += new System.EventHandler(this.BtnDecryption_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(15, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "Teksti i dekriptuar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(15, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Teksti i enkriptuar";
            // 
            // BtnEncryption
            // 
            this.BtnEncryption.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEncryption.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnEncryption.Location = new System.Drawing.Point(31, 268);
            this.BtnEncryption.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BtnEncryption.Name = "BtnEncryption";
            this.BtnEncryption.Size = new System.Drawing.Size(146, 50);
            this.BtnEncryption.TabIndex = 9;
            this.BtnEncryption.Text = "Enkripto";
            this.BtnEncryption.UseVisualStyleBackColor = true;
            this.BtnEncryption.Click += new System.EventHandler(this.BtnEncryption_Click);
            // 
            // TxtPlan
            // 
            this.TxtPlan.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtPlan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtPlan.Location = new System.Drawing.Point(248, 14);
            this.TxtPlan.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtPlan.Multiline = true;
            this.TxtPlan.Name = "TxtPlan";
            this.TxtPlan.Size = new System.Drawing.Size(473, 56);
            this.TxtPlan.TabIndex = 8;
            this.TxtPlan.TextChanged += new System.EventHandler(this.TxtPlan_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(15, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Teksti";
            // 
            // TxtCipher
            // 
            this.TxtCipher.Location = new System.Drawing.Point(246, 80);
            this.TxtCipher.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtCipher.Multiline = true;
            this.TxtCipher.Name = "TxtCipher";
            this.TxtCipher.Size = new System.Drawing.Size(475, 56);
            this.TxtCipher.TabIndex = 14;
            // 
            // TxtDecipher
            // 
            this.TxtDecipher.Location = new System.Drawing.Point(246, 148);
            this.TxtDecipher.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtDecipher.Multiline = true;
            this.TxtDecipher.Name = "TxtDecipher";
            this.TxtDecipher.Size = new System.Drawing.Size(475, 56);
            this.TxtDecipher.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(575, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 50);
            this.button1.TabIndex = 16;
            this.button1.Text = "Fshij";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(733, 339);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtDecipher);
            this.Controls.Add(this.TxtCipher);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnDecryption);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnEncryption);
            this.Controls.Add(this.TxtPlan);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "RailFence- Enkriptimi dhe Dekriptimi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnDecryption;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnEncryption;
        private System.Windows.Forms.TextBox TxtPlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCipher;
        private System.Windows.Forms.TextBox TxtDecipher;
        private System.Windows.Forms.Button button1;
    }
}

