﻿namespace Jogo_Do_Labirinto
{
    partial class UmForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UmForm));
            this.btnCimaSalaUm = new System.Windows.Forms.Button();
            this.btnDirSalaUm = new System.Windows.Forms.Button();
            this.btnEsqSalaUm = new System.Windows.Forms.Button();
            this.pibPersonagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pibPersonagem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCimaSalaUm
            // 
            this.btnCimaSalaUm.BackColor = System.Drawing.Color.Transparent;
            this.btnCimaSalaUm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCimaSalaUm.BackgroundImage")));
            this.btnCimaSalaUm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCimaSalaUm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCimaSalaUm.Location = new System.Drawing.Point(366, 160);
            this.btnCimaSalaUm.Name = "btnCimaSalaUm";
            this.btnCimaSalaUm.Size = new System.Drawing.Size(75, 76);
            this.btnCimaSalaUm.TabIndex = 0;
            this.btnCimaSalaUm.UseVisualStyleBackColor = false;
            this.btnCimaSalaUm.Click += new System.EventHandler(this.btnCimaSalaUm_Click);
            // 
            // btnDirSalaUm
            // 
            this.btnDirSalaUm.BackColor = System.Drawing.Color.Transparent;
            this.btnDirSalaUm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDirSalaUm.BackgroundImage")));
            this.btnDirSalaUm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDirSalaUm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirSalaUm.Location = new System.Drawing.Point(619, 239);
            this.btnDirSalaUm.Name = "btnDirSalaUm";
            this.btnDirSalaUm.Size = new System.Drawing.Size(75, 76);
            this.btnDirSalaUm.TabIndex = 1;
            this.btnDirSalaUm.UseVisualStyleBackColor = false;
            this.btnDirSalaUm.Click += new System.EventHandler(this.btnDirSalaUm_Click);
            // 
            // btnEsqSalaUm
            // 
            this.btnEsqSalaUm.BackColor = System.Drawing.Color.Transparent;
            this.btnEsqSalaUm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEsqSalaUm.BackgroundImage")));
            this.btnEsqSalaUm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEsqSalaUm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsqSalaUm.Location = new System.Drawing.Point(107, 239);
            this.btnEsqSalaUm.Name = "btnEsqSalaUm";
            this.btnEsqSalaUm.Size = new System.Drawing.Size(75, 76);
            this.btnEsqSalaUm.TabIndex = 2;
            this.btnEsqSalaUm.UseVisualStyleBackColor = false;
            this.btnEsqSalaUm.Click += new System.EventHandler(this.btnEsqSalaUm_Click);
            // 
            // pibPersonagem
            // 
            this.pibPersonagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pibPersonagem.BackColor = System.Drawing.Color.Transparent;
            this.pibPersonagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pibPersonagem.ErrorImage = null;
            this.pibPersonagem.Image = ((System.Drawing.Image)(resources.GetObject("pibPersonagem.Image")));
            this.pibPersonagem.InitialImage = ((System.Drawing.Image)(resources.GetObject("pibPersonagem.InitialImage")));
            this.pibPersonagem.Location = new System.Drawing.Point(300, 239);
            this.pibPersonagem.Margin = new System.Windows.Forms.Padding(0);
            this.pibPersonagem.Name = "pibPersonagem";
            this.pibPersonagem.Size = new System.Drawing.Size(206, 192);
            this.pibPersonagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibPersonagem.TabIndex = 3;
            this.pibPersonagem.TabStop = false;
            // 
            // UmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pibPersonagem);
            this.Controls.Add(this.btnEsqSalaUm);
            this.Controls.Add(this.btnDirSalaUm);
            this.Controls.Add(this.btnCimaSalaUm);
            this.DoubleBuffered = true;
            this.Name = "UmForm";
            this.Text = "UmForm";
            ((System.ComponentModel.ISupportInitialize)(this.pibPersonagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCimaSalaUm;
        private System.Windows.Forms.Button btnDirSalaUm;
        private System.Windows.Forms.Button btnEsqSalaUm;
        private System.Windows.Forms.PictureBox pibPersonagem;
    }
}