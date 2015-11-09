namespace TP1___MultiThread
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
            this.lblDateHeure = new System.Windows.Forms.Label();
            this.rbtnDateHeure = new System.Windows.Forms.RadioButton();
            this.rbtnDate = new System.Windows.Forms.RadioButton();
            this.rbtnHeure = new System.Windows.Forms.RadioButton();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnRafraichir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDateHeure
            // 
            this.lblDateHeure.AutoSize = true;
            this.lblDateHeure.Location = new System.Drawing.Point(228, 46);
            this.lblDateHeure.Name = "lblDateHeure";
            this.lblDateHeure.Size = new System.Drawing.Size(108, 13);
            this.lblDateHeure.TabIndex = 0;
            this.lblDateHeure.Text = "jj/mm/aaaa hh:mm:ss";
            // 
            // rbtnDateHeure
            // 
            this.rbtnDateHeure.AutoSize = true;
            this.rbtnDateHeure.Location = new System.Drawing.Point(46, 180);
            this.rbtnDateHeure.Name = "rbtnDateHeure";
            this.rbtnDateHeure.Size = new System.Drawing.Size(92, 17);
            this.rbtnDateHeure.TabIndex = 1;
            this.rbtnDateHeure.TabStop = true;
            this.rbtnDateHeure.Text = "Date et Heure";
            this.rbtnDateHeure.UseVisualStyleBackColor = true;
            // 
            // rbtnDate
            // 
            this.rbtnDate.AutoSize = true;
            this.rbtnDate.Location = new System.Drawing.Point(251, 180);
            this.rbtnDate.Name = "rbtnDate";
            this.rbtnDate.Size = new System.Drawing.Size(48, 17);
            this.rbtnDate.TabIndex = 2;
            this.rbtnDate.TabStop = true;
            this.rbtnDate.Text = "Date";
            this.rbtnDate.UseVisualStyleBackColor = true;
            // 
            // rbtnHeure
            // 
            this.rbtnHeure.AutoSize = true;
            this.rbtnHeure.Location = new System.Drawing.Point(447, 180);
            this.rbtnHeure.Name = "rbtnHeure";
            this.rbtnHeure.Size = new System.Drawing.Size(54, 17);
            this.rbtnHeure.TabIndex = 3;
            this.rbtnHeure.TabStop = true;
            this.rbtnHeure.Text = "Heure";
            this.rbtnHeure.UseVisualStyleBackColor = true;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(447, 227);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(100, 23);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnRafraichir
            // 
            this.btnRafraichir.Location = new System.Drawing.Point(46, 227);
            this.btnRafraichir.Name = "btnRafraichir";
            this.btnRafraichir.Size = new System.Drawing.Size(75, 23);
            this.btnRafraichir.TabIndex = 5;
            this.btnRafraichir.Text = "Rafraichir";
            this.btnRafraichir.UseVisualStyleBackColor = true;
            this.btnRafraichir.Click += new System.EventHandler(this.btnRafraichir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 262);
            this.Controls.Add(this.btnRafraichir);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.rbtnHeure);
            this.Controls.Add(this.rbtnDate);
            this.Controls.Add(this.rbtnDateHeure);
            this.Controls.Add(this.lblDateHeure);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.form_load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateHeure;
        private System.Windows.Forms.RadioButton rbtnDateHeure;
        private System.Windows.Forms.RadioButton rbtnDate;
        private System.Windows.Forms.RadioButton rbtnHeure;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnRafraichir;
    }
}

