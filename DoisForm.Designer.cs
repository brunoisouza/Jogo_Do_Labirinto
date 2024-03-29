﻿namespace Jogo_Do_Labirinto
{
    partial class DoisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoisForm));
            this.btnEsq = new System.Windows.Forms.Button();
            this.btnDir = new System.Windows.Forms.Button();
            this.btnCima = new System.Windows.Forms.Button();
            this.btnBaixo = new System.Windows.Forms.Button();
            this.pibPersonagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pibPersonagem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEsq
            // 
            this.btnEsq.BackColor = System.Drawing.Color.Transparent;
            this.btnEsq.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEsq.BackgroundImage")));
            this.btnEsq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEsq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsq.Location = new System.Drawing.Point(81, 255);
            this.btnEsq.Name = "btnEsq";
            this.btnEsq.Size = new System.Drawing.Size(75, 76);
            this.btnEsq.TabIndex = 5;
            this.btnEsq.UseVisualStyleBackColor = false;
            this.btnEsq.Click += new System.EventHandler(this.btnEsqSalaUm_Click);
            // 
            // btnDir
            // 
            this.btnDir.BackColor = System.Drawing.Color.Transparent;
            this.btnDir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDir.BackgroundImage")));
            this.btnDir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDir.Location = new System.Drawing.Point(674, 273);
            this.btnDir.Name = "btnDir";
            this.btnDir.Size = new System.Drawing.Size(75, 76);
            this.btnDir.TabIndex = 4;
            this.btnDir.UseVisualStyleBackColor = false;
            this.btnDir.Click += new System.EventHandler(this.btnDir_Click);
            // 
            // btnCima
            // 
            this.btnCima.BackColor = System.Drawing.Color.Transparent;
            this.btnCima.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCima.BackgroundImage")));
            this.btnCima.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCima.Location = new System.Drawing.Point(364, 92);
            this.btnCima.Name = "btnCima";
            this.btnCima.Size = new System.Drawing.Size(75, 76);
            this.btnCima.TabIndex = 3;
            this.btnCima.UseVisualStyleBackColor = false;
            this.btnCima.Click += new System.EventHandler(this.btnCima_Click);
            // 
            // btnBaixo
            // 
            this.btnBaixo.BackColor = System.Drawing.Color.Transparent;
            this.btnBaixo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBaixo.BackgroundImage")));
            this.btnBaixo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBaixo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaixo.Location = new System.Drawing.Point(364, 336);
            this.btnBaixo.Name = "btnBaixo";
            this.btnBaixo.Size = new System.Drawing.Size(75, 76);
            this.btnBaixo.TabIndex = 6;
            this.btnBaixo.UseVisualStyleBackColor = false;
            this.btnBaixo.Click += new System.EventHandler(this.btnBaixo_Click);
            // 
            // pibPersonagem
            // 
            this.pibPersonagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pibPersonagem.BackColor = System.Drawing.Color.Transparent;
            this.pibPersonagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pibPersonagem.ErrorImage = null;
            this.pibPersonagem.Image = ((System.Drawing.Image)(resources.GetObject("pibPersonagem.Image")));
            this.pibPersonagem.InitialImage = ((System.Drawing.Image)(resources.GetObject("pibPersonagem.InitialImage")));
            this.pibPersonagem.Location = new System.Drawing.Point(442, 255);
            this.pibPersonagem.Margin = new System.Windows.Forms.Padding(0);
            this.pibPersonagem.Name = "pibPersonagem";
            this.pibPersonagem.Size = new System.Drawing.Size(206, 192);
            this.pibPersonagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibPersonagem.TabIndex = 7;
            this.pibPersonagem.TabStop = false;
            // 
            // DoisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pibPersonagem);
            this.Controls.Add(this.btnBaixo);
            this.Controls.Add(this.btnEsq);
            this.Controls.Add(this.btnDir);
            this.Controls.Add(this.btnCima);
            this.Name = "DoisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoisForm";
            ((System.ComponentModel.ISupportInitialize)(this.pibPersonagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEsq;
        private System.Windows.Forms.Button btnDir;
        private System.Windows.Forms.Button btnCima;
        private System.Windows.Forms.Button btnBaixo;
        private System.Windows.Forms.PictureBox pibPersonagem;
    }
}