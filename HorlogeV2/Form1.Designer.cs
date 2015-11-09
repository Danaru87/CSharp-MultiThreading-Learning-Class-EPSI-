namespace HorlogeV2
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
            this.lblDateHeure = new System.Windows.Forms.Label();
            this.rdbtDateHeure = new System.Windows.Forms.RadioButton();
            this.rdbtDate = new System.Windows.Forms.RadioButton();
            this.rdbtHeure = new System.Windows.Forms.RadioButton();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDateHeure
            // 
            this.lblDateHeure.AutoSize = true;
            this.lblDateHeure.Location = new System.Drawing.Point(262, 29);
            this.lblDateHeure.Name = "lblDateHeure";
            this.lblDateHeure.Size = new System.Drawing.Size(120, 13);
            this.lblDateHeure.TabIndex = 0;
            this.lblDateHeure.Text = "JJ/MM/AAAA hh:mm:ss";
            // 
            // rdbtDateHeure
            // 
            this.rdbtDateHeure.AutoSize = true;
            this.rdbtDateHeure.Location = new System.Drawing.Point(13, 146);
            this.rdbtDateHeure.Name = "rdbtDateHeure";
            this.rdbtDateHeure.Size = new System.Drawing.Size(92, 17);
            this.rdbtDateHeure.TabIndex = 1;
            this.rdbtDateHeure.TabStop = true;
            this.rdbtDateHeure.Text = "Date et Heure";
            this.rdbtDateHeure.UseVisualStyleBackColor = true;
            this.rdbtDateHeure.CheckedChanged += new System.EventHandler(this.rdbtDateHeure_CheckedChanged);
            // 
            // rdbtDate
            // 
            this.rdbtDate.AutoSize = true;
            this.rdbtDate.Location = new System.Drawing.Point(280, 146);
            this.rdbtDate.Name = "rdbtDate";
            this.rdbtDate.Size = new System.Drawing.Size(48, 17);
            this.rdbtDate.TabIndex = 2;
            this.rdbtDate.TabStop = true;
            this.rdbtDate.Text = "Date";
            this.rdbtDate.UseVisualStyleBackColor = true;
            this.rdbtDate.CheckedChanged += new System.EventHandler(this.rdbtDateHeure_CheckedChanged);
            // 
            // rdbtHeure
            // 
            this.rdbtHeure.AutoSize = true;
            this.rdbtHeure.Location = new System.Drawing.Point(554, 146);
            this.rdbtHeure.Name = "rdbtHeure";
            this.rdbtHeure.Size = new System.Drawing.Size(54, 17);
            this.rdbtHeure.TabIndex = 3;
            this.rdbtHeure.TabStop = true;
            this.rdbtHeure.Text = "Heure";
            this.rdbtHeure.UseVisualStyleBackColor = true;
            this.rdbtHeure.CheckedChanged += new System.EventHandler(this.rdbtDateHeure_CheckedChanged);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(554, 189);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 392);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.rdbtHeure);
            this.Controls.Add(this.rdbtDate);
            this.Controls.Add(this.rdbtDateHeure);
            this.Controls.Add(this.lblDateHeure);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.form_load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateHeure;
        private System.Windows.Forms.RadioButton rdbtDateHeure;
        private System.Windows.Forms.RadioButton rdbtDate;
        private System.Windows.Forms.RadioButton rdbtHeure;
        private System.Windows.Forms.Button btnQuitter;
    }
}