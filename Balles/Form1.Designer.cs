namespace Balles
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
            this.balle3 = new Balles.Balle();
            this.balle2 = new Balles.Balle();
            this.balle1 = new Balles.Balle();
            ((System.ComponentModel.ISupportInitialize)(this.balle3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balle1)).BeginInit();
            this.SuspendLayout();
            // 
            // balle3
            // 
            this.balle3.Image = global::Balles.Properties.Resources.Balle_Rouge;
            this.balle3.Location = new System.Drawing.Point(162, 107);
            this.balle3.Name = "balle3";
            this.balle3.Size = new System.Drawing.Size(100, 100);
            this.balle3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.balle3.TabIndex = 3;
            this.balle3.TabStop = false;
            // 
            // balle2
            // 
            this.balle2.Image = global::Balles.Properties.Resources.Balle_Bleue;
            this.balle2.Location = new System.Drawing.Point(330, 232);
            this.balle2.Name = "balle2";
            this.balle2.Size = new System.Drawing.Size(100, 100);
            this.balle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.balle2.TabIndex = 2;
            this.balle2.TabStop = false;
            // 
            // balle1
            // 
            this.balle1.Image = global::Balles.Properties.Resources.Balle_Jaune;
            this.balle1.Location = new System.Drawing.Point(509, 88);
            this.balle1.Name = "balle1";
            this.balle1.Size = new System.Drawing.Size(100, 100);
            this.balle1.TabIndex = 1;
            this.balle1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 576);
            this.Controls.Add(this.balle3);
            this.Controls.Add(this.balle2);
            this.Controls.Add(this.balle1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.balle3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balle1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Balle balle1;
        private Balle balle2;
        private Balle balle3;
    }
}

