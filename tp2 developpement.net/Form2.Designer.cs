namespace tp2_developpement.net
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_forme2 = new System.Windows.Forms.TextBox();
            this.btn_form1 = new System.Windows.Forms.Button();
            this.btn_quitter2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "le texte entré est :";
            // 
            // txt_forme2
            // 
            this.txt_forme2.Location = new System.Drawing.Point(109, 33);
            this.txt_forme2.Name = "txt_forme2";
            this.txt_forme2.Size = new System.Drawing.Size(149, 20);
            this.txt_forme2.TabIndex = 1;
            this.txt_forme2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_form1
            // 
            this.btn_form1.Location = new System.Drawing.Point(48, 126);
            this.btn_form1.Name = "btn_form1";
            this.btn_form1.Size = new System.Drawing.Size(104, 28);
            this.btn_form1.TabIndex = 2;
            this.btn_form1.Text = "Retour au forme 1";
            this.btn_form1.UseVisualStyleBackColor = true;
            this.btn_form1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_quitter2
            // 
            this.btn_quitter2.Location = new System.Drawing.Point(248, 126);
            this.btn_quitter2.Name = "btn_quitter2";
            this.btn_quitter2.Size = new System.Drawing.Size(102, 28);
            this.btn_quitter2.TabIndex = 3;
            this.btn_quitter2.Text = "Quitter";
            this.btn_quitter2.UseVisualStyleBackColor = true;
            this.btn_quitter2.Click += new System.EventHandler(this.btn_quitter2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(562, 261);
            this.Controls.Add(this.btn_quitter2);
            this.Controls.Add(this.btn_form1);
            this.Controls.Add(this.txt_forme2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2 partie 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_forme2;
        private System.Windows.Forms.Button btn_form1;
        private System.Windows.Forms.Button btn_quitter2;
    }
}