namespace Chap6Tp2
{
    partial class GestionGastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionGastro));
            this.Group1 = new System.Windows.Forms.GroupBox();
            this.Group2 = new System.Windows.Forms.GroupBox();
            this.Group3 = new System.Windows.Forms.GroupBox();
            this.btnReinitialiser = new System.Windows.Forms.Button();
            this.optEntree1 = new System.Windows.Forms.RadioButton();
            this.optEntree2 = new System.Windows.Forms.RadioButton();
            this.optEntree3 = new System.Windows.Forms.RadioButton();
            this.optPlats1 = new System.Windows.Forms.RadioButton();
            this.optPlats2 = new System.Windows.Forms.RadioButton();
            this.optPlats3 = new System.Windows.Forms.RadioButton();
            this.optDessert1 = new System.Windows.Forms.RadioButton();
            this.optDessert2 = new System.Windows.Forms.RadioButton();
            this.optDessert3 = new System.Windows.Forms.RadioButton();
            this.optDessert4 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.lblEntree = new System.Windows.Forms.Label();
            this.lblPlat = new System.Windows.Forms.Label();
            this.lblDessert = new System.Windows.Forms.Label();
            this.btnAfficherChoix = new System.Windows.Forms.Button();
            this.Group1.SuspendLayout();
            this.Group2.SuspendLayout();
            this.Group3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Group1
            // 
            this.Group1.BackColor = System.Drawing.Color.PaleGreen;
            this.Group1.Controls.Add(this.optEntree3);
            this.Group1.Controls.Add(this.optEntree2);
            this.Group1.Controls.Add(this.optEntree1);
            this.Group1.Location = new System.Drawing.Point(26, 24);
            this.Group1.Name = "Group1";
            this.Group1.Size = new System.Drawing.Size(243, 131);
            this.Group1.TabIndex = 0;
            this.Group1.TabStop = false;
            this.Group1.Text = "Entrées";
            // 
            // Group2
            // 
            this.Group2.BackColor = System.Drawing.Color.LimeGreen;
            this.Group2.Controls.Add(this.optPlats3);
            this.Group2.Controls.Add(this.optPlats2);
            this.Group2.Controls.Add(this.optPlats1);
            this.Group2.Location = new System.Drawing.Point(26, 178);
            this.Group2.Name = "Group2";
            this.Group2.Size = new System.Drawing.Size(243, 130);
            this.Group2.TabIndex = 1;
            this.Group2.TabStop = false;
            this.Group2.Text = "Plats";
            // 
            // Group3
            // 
            this.Group3.BackColor = System.Drawing.Color.ForestGreen;
            this.Group3.Controls.Add(this.optDessert4);
            this.Group3.Controls.Add(this.optDessert3);
            this.Group3.Controls.Add(this.optDessert2);
            this.Group3.Controls.Add(this.optDessert1);
            this.Group3.Location = new System.Drawing.Point(26, 337);
            this.Group3.Name = "Group3";
            this.Group3.Size = new System.Drawing.Size(243, 130);
            this.Group3.TabIndex = 2;
            this.Group3.TabStop = false;
            this.Group3.Text = "Desserts";
            // 
            // btnReinitialiser
            // 
            this.btnReinitialiser.Location = new System.Drawing.Point(76, 489);
            this.btnReinitialiser.Name = "btnReinitialiser";
            this.btnReinitialiser.Size = new System.Drawing.Size(149, 28);
            this.btnReinitialiser.TabIndex = 3;
            this.btnReinitialiser.Text = "Réinitialiser";
            this.btnReinitialiser.UseVisualStyleBackColor = true;
            this.btnReinitialiser.Click += new System.EventHandler(this.btnReinitialiser_Click);
            // 
            // optEntree1
            // 
            this.optEntree1.AutoSize = true;
            this.optEntree1.Location = new System.Drawing.Point(50, 34);
            this.optEntree1.Name = "optEntree1";
            this.optEntree1.Size = new System.Drawing.Size(92, 17);
            this.optEntree1.TabIndex = 0;
            this.optEntree1.Text = "Tatin d\'endive";
            this.optEntree1.UseVisualStyleBackColor = true;
            // 
            // optEntree2
            // 
            this.optEntree2.AutoSize = true;
            this.optEntree2.Location = new System.Drawing.Point(50, 57);
            this.optEntree2.Name = "optEntree2";
            this.optEntree2.Size = new System.Drawing.Size(115, 17);
            this.optEntree2.TabIndex = 1;
            this.optEntree2.TabStop = true;
            this.optEntree2.Text = "Soupe de poissons";
            this.optEntree2.UseVisualStyleBackColor = true;
            // 
            // optEntree3
            // 
            this.optEntree3.AutoSize = true;
            this.optEntree3.Location = new System.Drawing.Point(50, 80);
            this.optEntree3.Name = "optEntree3";
            this.optEntree3.Size = new System.Drawing.Size(145, 17);
            this.optEntree3.TabIndex = 2;
            this.optEntree3.TabStop = true;
            this.optEntree3.Text = "Crème brûlée au foie gras";
            this.optEntree3.UseVisualStyleBackColor = true;
            // 
            // optPlats1
            // 
            this.optPlats1.AutoSize = true;
            this.optPlats1.Location = new System.Drawing.Point(50, 35);
            this.optPlats1.Name = "optPlats1";
            this.optPlats1.Size = new System.Drawing.Size(95, 17);
            this.optPlats1.TabIndex = 4;
            this.optPlats1.TabStop = true;
            this.optPlats1.Text = "Wok de poulet";
            this.optPlats1.UseVisualStyleBackColor = true;
            // 
            // optPlats2
            // 
            this.optPlats2.AutoSize = true;
            this.optPlats2.Location = new System.Drawing.Point(50, 58);
            this.optPlats2.Name = "optPlats2";
            this.optPlats2.Size = new System.Drawing.Size(104, 17);
            this.optPlats2.TabIndex = 5;
            this.optPlats2.TabStop = true;
            this.optPlats2.Text = "Dos de cabillaud";
            this.optPlats2.UseVisualStyleBackColor = true;
            // 
            // optPlats3
            // 
            this.optPlats3.AutoSize = true;
            this.optPlats3.Location = new System.Drawing.Point(50, 81);
            this.optPlats3.Name = "optPlats3";
            this.optPlats3.Size = new System.Drawing.Size(145, 17);
            this.optPlats3.TabIndex = 6;
            this.optPlats3.TabStop = true;
            this.optPlats3.Text = "Magret de canard au miel";
            this.optPlats3.UseVisualStyleBackColor = true;
            // 
            // optDessert1
            // 
            this.optDessert1.AutoSize = true;
            this.optDessert1.Location = new System.Drawing.Point(50, 26);
            this.optDessert1.Name = "optDessert1";
            this.optDessert1.Size = new System.Drawing.Size(117, 17);
            this.optDessert1.TabIndex = 2;
            this.optDessert1.TabStop = true;
            this.optDessert1.Text = "Brochette d\'ananas";
            this.optDessert1.UseVisualStyleBackColor = true;
            // 
            // optDessert2
            // 
            this.optDessert2.AutoSize = true;
            this.optDessert2.Location = new System.Drawing.Point(50, 49);
            this.optDessert2.Name = "optDessert2";
            this.optDessert2.Size = new System.Drawing.Size(85, 17);
            this.optDessert2.TabIndex = 3;
            this.optDessert2.TabStop = true;
            this.optDessert2.Text = "Café liégeois";
            this.optDessert2.UseVisualStyleBackColor = true;
            // 
            // optDessert3
            // 
            this.optDessert3.AutoSize = true;
            this.optDessert3.Location = new System.Drawing.Point(50, 72);
            this.optDessert3.Name = "optDessert3";
            this.optDessert3.Size = new System.Drawing.Size(121, 17);
            this.optDessert3.TabIndex = 4;
            this.optDessert3.TabStop = true;
            this.optDessert3.Text = "Mousse au chocolat";
            this.optDessert3.UseVisualStyleBackColor = true;
            // 
            // optDessert4
            // 
            this.optDessert4.AutoSize = true;
            this.optDessert4.Location = new System.Drawing.Point(50, 95);
            this.optDessert4.Name = "optDessert4";
            this.optDessert4.Size = new System.Drawing.Size(136, 17);
            this.optDessert4.TabIndex = 5;
            this.optDessert4.TabStop = true;
            this.optDessert4.Text = "Crème brûlée à l\'orange";
            this.optDessert4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDessert);
            this.groupBox1.Controls.Add(this.lblPlat);
            this.groupBox1.Controls.Add(this.lblEntree);
            this.groupBox1.Location = new System.Drawing.Point(466, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 184);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Votre choix:";
            // 
            // pbxImage
            // 
            this.pbxImage.Image = ((System.Drawing.Image)(resources.GetObject("pbxImage.Image")));
            this.pbxImage.Location = new System.Drawing.Point(466, 24);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(224, 218);
            this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImage.TabIndex = 5;
            this.pbxImage.TabStop = false;
            // 
            // lblEntree
            // 
            this.lblEntree.BackColor = System.Drawing.Color.PaleGreen;
            this.lblEntree.Location = new System.Drawing.Point(6, 41);
            this.lblEntree.Name = "lblEntree";
            this.lblEntree.Size = new System.Drawing.Size(100, 23);
            this.lblEntree.TabIndex = 0;
            // 
            // lblPlat
            // 
            this.lblPlat.BackColor = System.Drawing.Color.LimeGreen;
            this.lblPlat.Location = new System.Drawing.Point(6, 86);
            this.lblPlat.Name = "lblPlat";
            this.lblPlat.Size = new System.Drawing.Size(100, 23);
            this.lblPlat.TabIndex = 1;
            // 
            // lblDessert
            // 
            this.lblDessert.BackColor = System.Drawing.Color.ForestGreen;
            this.lblDessert.Location = new System.Drawing.Point(6, 132);
            this.lblDessert.Name = "lblDessert";
            this.lblDessert.Size = new System.Drawing.Size(100, 23);
            this.lblDessert.TabIndex = 2;
            // 
            // btnAfficherChoix
            // 
            this.btnAfficherChoix.Location = new System.Drawing.Point(466, 254);
            this.btnAfficherChoix.Name = "btnAfficherChoix";
            this.btnAfficherChoix.Size = new System.Drawing.Size(224, 23);
            this.btnAfficherChoix.TabIndex = 6;
            this.btnAfficherChoix.Text = "Afficher le choix";
            this.btnAfficherChoix.UseVisualStyleBackColor = true;
            this.btnAfficherChoix.Click += new System.EventHandler(this.btnAfficherChoix_Click);
            // 
            // GestionGastro
            // 
            this.AcceptButton = this.btnAfficherChoix;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 529);
            this.Controls.Add(this.btnAfficherChoix);
            this.Controls.Add(this.pbxImage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReinitialiser);
            this.Controls.Add(this.Group3);
            this.Controls.Add(this.Group2);
            this.Controls.Add(this.Group1);
            this.Name = "GestionGastro";
            this.Text = "Menu Gastronomique";
            this.Group1.ResumeLayout(false);
            this.Group1.PerformLayout();
            this.Group2.ResumeLayout(false);
            this.Group2.PerformLayout();
            this.Group3.ResumeLayout(false);
            this.Group3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Group1;
        private System.Windows.Forms.GroupBox Group2;
        private System.Windows.Forms.GroupBox Group3;
        private System.Windows.Forms.Button btnReinitialiser;
        private System.Windows.Forms.RadioButton optEntree3;
        private System.Windows.Forms.RadioButton optEntree2;
        private System.Windows.Forms.RadioButton optEntree1;
        private System.Windows.Forms.RadioButton optPlats3;
        private System.Windows.Forms.RadioButton optPlats2;
        private System.Windows.Forms.RadioButton optPlats1;
        private System.Windows.Forms.RadioButton optDessert4;
        private System.Windows.Forms.RadioButton optDessert3;
        private System.Windows.Forms.RadioButton optDessert2;
        private System.Windows.Forms.RadioButton optDessert1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDessert;
        private System.Windows.Forms.Label lblPlat;
        private System.Windows.Forms.Label lblEntree;
        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.Button btnAfficherChoix;
    }
}

