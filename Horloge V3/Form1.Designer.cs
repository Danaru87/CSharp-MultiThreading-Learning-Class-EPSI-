namespace Horloge_V3
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rdbtDateHeure = new System.Windows.Forms.RadioButton();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.rdbtHeure = new System.Windows.Forms.RadioButton();
            this.rdbtDate = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lblDateHeure = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // rdbtDateHeure
            // 
            this.rdbtDateHeure.AutoSize = true;
            this.rdbtDateHeure.Location = new System.Drawing.Point(-166, 157);
            this.rdbtDateHeure.Name = "rdbtDateHeure";
            this.rdbtDateHeure.Size = new System.Drawing.Size(92, 17);
            this.rdbtDateHeure.TabIndex = 6;
            this.rdbtDateHeure.TabStop = true;
            this.rdbtDateHeure.Text = "Date et Heure";
            this.rdbtDateHeure.UseVisualStyleBackColor = true;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(565, 169);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 11;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // rdbtHeure
            // 
            this.rdbtHeure.AutoSize = true;
            this.rdbtHeure.Location = new System.Drawing.Point(565, 126);
            this.rdbtHeure.Name = "rdbtHeure";
            this.rdbtHeure.Size = new System.Drawing.Size(54, 17);
            this.rdbtHeure.TabIndex = 10;
            this.rdbtHeure.TabStop = true;
            this.rdbtHeure.Text = "Heure";
            this.rdbtHeure.UseVisualStyleBackColor = true;
            this.rdbtHeure.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbtDate
            // 
            this.rdbtDate.AutoSize = true;
            this.rdbtDate.Location = new System.Drawing.Point(291, 126);
            this.rdbtDate.Name = "rdbtDate";
            this.rdbtDate.Size = new System.Drawing.Size(48, 17);
            this.rdbtDate.TabIndex = 9;
            this.rdbtDate.TabStop = true;
            this.rdbtDate.Text = "Date";
            this.rdbtDate.UseVisualStyleBackColor = true;
            this.rdbtDate.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(24, 126);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(92, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Date et Heure";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lblDateHeure
            // 
            this.lblDateHeure.AutoSize = true;
            this.lblDateHeure.Location = new System.Drawing.Point(273, 9);
            this.lblDateHeure.Name = "lblDateHeure";
            this.lblDateHeure.Size = new System.Drawing.Size(120, 13);
            this.lblDateHeure.TabIndex = 7;
            this.lblDateHeure.Text = "JJ/MM/AAAA hh:mm:ss";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(679, 210);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.rdbtHeure);
            this.Controls.Add(this.rdbtDate);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.lblDateHeure);
            this.Controls.Add(this.rdbtDateHeure);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdbtDateHeure;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.RadioButton rdbtHeure;
        private System.Windows.Forms.RadioButton rdbtDate;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lblDateHeure;
        private System.Windows.Forms.Timer timer1;
    }
}

