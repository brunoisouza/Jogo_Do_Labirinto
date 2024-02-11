namespace Jogo_Do_Labirinto
{
    partial class CincoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CincoForm));
            this.pibVilao = new System.Windows.Forms.PictureBox();
            this.lblDesafio = new System.Windows.Forms.Label();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.lblRespostaUm = new System.Windows.Forms.Label();
            this.lblRespostaDois = new System.Windows.Forms.Label();
            this.btnEsq = new System.Windows.Forms.Button();
            this.btnDir = new System.Windows.Forms.Button();
            this.btnCima = new System.Windows.Forms.Button();
            this.pibPersonagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pibVilao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibPersonagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pibVilao
            // 
            this.pibVilao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pibVilao.BackColor = System.Drawing.Color.Transparent;
            this.pibVilao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pibVilao.ErrorImage = null;
            this.pibVilao.Image = ((System.Drawing.Image)(resources.GetObject("pibVilao.Image")));
            this.pibVilao.InitialImage = ((System.Drawing.Image)(resources.GetObject("pibVilao.InitialImage")));
            this.pibVilao.Location = new System.Drawing.Point(284, 129);
            this.pibVilao.Margin = new System.Windows.Forms.Padding(0);
            this.pibVilao.Name = "pibVilao";
            this.pibVilao.Size = new System.Drawing.Size(206, 192);
            this.pibVilao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibVilao.TabIndex = 4;
            this.pibVilao.TabStop = false;
            // 
            // lblDesafio
            // 
            this.lblDesafio.AutoSize = true;
            this.lblDesafio.BackColor = System.Drawing.Color.Transparent;
            this.lblDesafio.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesafio.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblDesafio.Location = new System.Drawing.Point(81, 9);
            this.lblDesafio.Name = "lblDesafio";
            this.lblDesafio.Size = new System.Drawing.Size(639, 74);
            this.lblDesafio.TabIndex = 5;
            this.lblDesafio.Text = "Eu Sou o Zorg! Para você continuar, \r\nterá que acertar a resposta do meu desafio!" +
    "";
            this.lblDesafio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnContinuar.Location = new System.Drawing.Point(671, 400);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(117, 38);
            this.btnContinuar.TabIndex = 6;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // lblRespostaUm
            // 
            this.lblRespostaUm.AutoSize = true;
            this.lblRespostaUm.BackColor = System.Drawing.Color.Transparent;
            this.lblRespostaUm.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespostaUm.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblRespostaUm.Location = new System.Drawing.Point(38, 380);
            this.lblRespostaUm.Name = "lblRespostaUm";
            this.lblRespostaUm.Size = new System.Drawing.Size(167, 37);
            this.lblRespostaUm.TabIndex = 7;
            this.lblRespostaUm.Text = "Resposta1";
            this.lblRespostaUm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblRespostaUm.Click += new System.EventHandler(this.lblRespostaUm_Click);
            // 
            // lblRespostaDois
            // 
            this.lblRespostaDois.AutoSize = true;
            this.lblRespostaDois.BackColor = System.Drawing.Color.Transparent;
            this.lblRespostaDois.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespostaDois.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblRespostaDois.Location = new System.Drawing.Point(305, 380);
            this.lblRespostaDois.Name = "lblRespostaDois";
            this.lblRespostaDois.Size = new System.Drawing.Size(169, 37);
            this.lblRespostaDois.TabIndex = 8;
            this.lblRespostaDois.Text = "Resposta2";
            this.lblRespostaDois.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblRespostaDois.Click += new System.EventHandler(this.lblRespostaDois_Click);
            // 
            // btnEsq
            // 
            this.btnEsq.BackColor = System.Drawing.Color.Transparent;
            this.btnEsq.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEsq.BackgroundImage")));
            this.btnEsq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEsq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsq.Location = new System.Drawing.Point(66, 178);
            this.btnEsq.Name = "btnEsq";
            this.btnEsq.Size = new System.Drawing.Size(75, 76);
            this.btnEsq.TabIndex = 14;
            this.btnEsq.UseVisualStyleBackColor = false;
            this.btnEsq.Click += new System.EventHandler(this.btnEsq_Click);
            // 
            // btnDir
            // 
            this.btnDir.BackColor = System.Drawing.Color.Transparent;
            this.btnDir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDir.BackgroundImage")));
            this.btnDir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDir.Location = new System.Drawing.Point(659, 196);
            this.btnDir.Name = "btnDir";
            this.btnDir.Size = new System.Drawing.Size(75, 76);
            this.btnDir.TabIndex = 13;
            this.btnDir.UseVisualStyleBackColor = false;
            this.btnDir.Click += new System.EventHandler(this.btnDir_Click);
            // 
            // btnCima
            // 
            this.btnCima.BackColor = System.Drawing.Color.Transparent;
            this.btnCima.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCima.BackgroundImage")));
            this.btnCima.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCima.Location = new System.Drawing.Point(379, 178);
            this.btnCima.Name = "btnCima";
            this.btnCima.Size = new System.Drawing.Size(75, 76);
            this.btnCima.TabIndex = 12;
            this.btnCima.UseVisualStyleBackColor = false;
            this.btnCima.Click += new System.EventHandler(this.btnCima_Click);
            // 
            // pibPersonagem
            // 
            this.pibPersonagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pibPersonagem.BackColor = System.Drawing.Color.Transparent;
            this.pibPersonagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pibPersonagem.ErrorImage = null;
            this.pibPersonagem.Image = ((System.Drawing.Image)(resources.GetObject("pibPersonagem.Image")));
            this.pibPersonagem.InitialImage = ((System.Drawing.Image)(resources.GetObject("pibPersonagem.InitialImage")));
            this.pibPersonagem.Location = new System.Drawing.Point(462, 291);
            this.pibPersonagem.Margin = new System.Windows.Forms.Padding(0);
            this.pibPersonagem.Name = "pibPersonagem";
            this.pibPersonagem.Size = new System.Drawing.Size(206, 192);
            this.pibPersonagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibPersonagem.TabIndex = 15;
            this.pibPersonagem.TabStop = false;
            // 
            // CincoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.pibVilao);
            this.Controls.Add(this.lblRespostaDois);
            this.Controls.Add(this.pibPersonagem);
            this.Controls.Add(this.btnEsq);
            this.Controls.Add(this.btnDir);
            this.Controls.Add(this.btnCima);
            this.Controls.Add(this.lblRespostaUm);
            this.Controls.Add(this.lblDesafio);
            this.Name = "CincoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CincoForm";
            ((System.ComponentModel.ISupportInitialize)(this.pibVilao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibPersonagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pibVilao;
        private System.Windows.Forms.Label lblDesafio;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Label lblRespostaUm;
        private System.Windows.Forms.Label lblRespostaDois;
        private System.Windows.Forms.Button btnEsq;
        private System.Windows.Forms.Button btnDir;
        private System.Windows.Forms.Button btnCima;
        private System.Windows.Forms.PictureBox pibPersonagem;
    }
}