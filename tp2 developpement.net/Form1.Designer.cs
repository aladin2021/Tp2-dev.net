namespace tp2_developpement.net
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_form1 = new System.Windows.Forms.TextBox();
            this.btn_forme2 = new System.Windows.Forms.Button();
            this.btn_quitter1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrer un texte :";
            // 
            // txt_form1
            // 
            this.txt_form1.Location = new System.Drawing.Point(133, 24);
            this.txt_form1.Name = "txt_form1";
            this.txt_form1.Size = new System.Drawing.Size(153, 20);
            this.txt_form1.TabIndex = 1;
            this.txt_form1.TextChanged += new System.EventHandler(this.txt_form1_TextChanged);
            // 
            // btn_forme2
            // 
            this.btn_forme2.Location = new System.Drawing.Point(44, 142);
            this.btn_forme2.Name = "btn_forme2";
            this.btn_forme2.Size = new System.Drawing.Size(96, 23);
            this.btn_forme2.TabIndex = 2;
            this.btn_forme2.Text = "Aller au forme 2";
            this.btn_forme2.UseVisualStyleBackColor = true;
            this.btn_forme2.Click += new System.EventHandler(this.btn_forme2_Click);
            // 
            // btn_quitter1
            // 
            this.btn_quitter1.Location = new System.Drawing.Point(211, 142);
            this.btn_quitter1.Name = "btn_quitter1";
            this.btn_quitter1.Size = new System.Drawing.Size(75, 23);
            this.btn_quitter1.TabIndex = 3;
            this.btn_quitter1.Text = "Quitter";
            this.btn_quitter1.UseVisualStyleBackColor = true;
            this.btn_quitter1.Click += new System.EventHandler(this.btn_quitter1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(423, 261);
            this.Controls.Add(this.btn_quitter1);
            this.Controls.Add(this.btn_forme2);
            this.Controls.Add(this.txt_form1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1 partie1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_form1;
        private System.Windows.Forms.Button btn_forme2;
        private System.Windows.Forms.Button btn_quitter1;
    }
}

