
namespace Varios_Jogos_em_um
{
    partial class Jokenpo
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
            this.BtnVoltarMenu = new System.Windows.Forms.Button();
            this.PtbPedra = new System.Windows.Forms.PictureBox();
            this.PtbPapel = new System.Windows.Forms.PictureBox();
            this.PtbTesoura = new System.Windows.Forms.PictureBox();
            this.PtbJogadorPedra = new System.Windows.Forms.PictureBox();
            this.PtbComputadorPedra = new System.Windows.Forms.PictureBox();
            this.PtbJogadorTesoura = new System.Windows.Forms.PictureBox();
            this.PtbJogadorPapel = new System.Windows.Forms.PictureBox();
            this.PtbComputadorTesoura = new System.Windows.Forms.PictureBox();
            this.PtbComputadorPapel = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PtbImagemNeutroComputador = new System.Windows.Forms.PictureBox();
            this.PtbImagemNeutroJogador = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblPontosComputador = new System.Windows.Forms.Label();
            this.LblPontosJogador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PtbPedra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbPapel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbTesoura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbJogadorPedra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbComputadorPedra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbJogadorTesoura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbJogadorPapel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbComputadorTesoura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbComputadorPapel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbImagemNeutroComputador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbImagemNeutroJogador)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnVoltarMenu
            // 
            this.BtnVoltarMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnVoltarMenu.Location = new System.Drawing.Point(389, 240);
            this.BtnVoltarMenu.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BtnVoltarMenu.Name = "BtnVoltarMenu";
            this.BtnVoltarMenu.Size = new System.Drawing.Size(99, 52);
            this.BtnVoltarMenu.TabIndex = 0;
            this.BtnVoltarMenu.Text = "Sair";
            this.BtnVoltarMenu.UseVisualStyleBackColor = true;
            this.BtnVoltarMenu.Click += new System.EventHandler(this.BtnVoltarMenu_Click);
            // 
            // PtbPedra
            // 
            this.PtbPedra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PtbPedra.Image = global::Varios_Jogos_em_um.Properties.Resources.Pedra;
            this.PtbPedra.Location = new System.Drawing.Point(22, 190);
            this.PtbPedra.Name = "PtbPedra";
            this.PtbPedra.Size = new System.Drawing.Size(109, 102);
            this.PtbPedra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbPedra.TabIndex = 1;
            this.PtbPedra.TabStop = false;
            this.PtbPedra.Click += new System.EventHandler(this.ImagePedra_Click);
            // 
            // PtbPapel
            // 
            this.PtbPapel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PtbPapel.Image = global::Varios_Jogos_em_um.Properties.Resources.Papel;
            this.PtbPapel.Location = new System.Drawing.Point(146, 190);
            this.PtbPapel.Name = "PtbPapel";
            this.PtbPapel.Size = new System.Drawing.Size(109, 102);
            this.PtbPapel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbPapel.TabIndex = 2;
            this.PtbPapel.TabStop = false;
            this.PtbPapel.Click += new System.EventHandler(this.ImagePapel_Click);
            // 
            // PtbTesoura
            // 
            this.PtbTesoura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PtbTesoura.Image = global::Varios_Jogos_em_um.Properties.Resources.Tesoura;
            this.PtbTesoura.Location = new System.Drawing.Point(271, 190);
            this.PtbTesoura.Name = "PtbTesoura";
            this.PtbTesoura.Size = new System.Drawing.Size(109, 102);
            this.PtbTesoura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbTesoura.TabIndex = 3;
            this.PtbTesoura.TabStop = false;
            this.PtbTesoura.Click += new System.EventHandler(this.ImageTesoura_Click);
            // 
            // PtbJogadorPedra
            // 
            this.PtbJogadorPedra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PtbJogadorPedra.Image = global::Varios_Jogos_em_um.Properties.Resources.Player_Pedra;
            this.PtbJogadorPedra.Location = new System.Drawing.Point(335, 62);
            this.PtbJogadorPedra.Name = "PtbJogadorPedra";
            this.PtbJogadorPedra.Size = new System.Drawing.Size(88, 102);
            this.PtbJogadorPedra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbJogadorPedra.TabIndex = 4;
            this.PtbJogadorPedra.TabStop = false;
            this.PtbJogadorPedra.Visible = false;
            // 
            // PtbComputadorPedra
            // 
            this.PtbComputadorPedra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PtbComputadorPedra.Image = global::Varios_Jogos_em_um.Properties.Resources.IA_Pedra;
            this.PtbComputadorPedra.Location = new System.Drawing.Point(22, 62);
            this.PtbComputadorPedra.Name = "PtbComputadorPedra";
            this.PtbComputadorPedra.Size = new System.Drawing.Size(88, 102);
            this.PtbComputadorPedra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbComputadorPedra.TabIndex = 5;
            this.PtbComputadorPedra.TabStop = false;
            this.PtbComputadorPedra.Visible = false;
            // 
            // PtbJogadorTesoura
            // 
            this.PtbJogadorTesoura.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PtbJogadorTesoura.Image = global::Varios_Jogos_em_um.Properties.Resources.Player_tesoura;
            this.PtbJogadorTesoura.Location = new System.Drawing.Point(335, 62);
            this.PtbJogadorTesoura.Name = "PtbJogadorTesoura";
            this.PtbJogadorTesoura.Size = new System.Drawing.Size(88, 102);
            this.PtbJogadorTesoura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbJogadorTesoura.TabIndex = 9;
            this.PtbJogadorTesoura.TabStop = false;
            this.PtbJogadorTesoura.Visible = false;
            // 
            // PtbJogadorPapel
            // 
            this.PtbJogadorPapel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PtbJogadorPapel.ErrorImage = null;
            this.PtbJogadorPapel.Image = global::Varios_Jogos_em_um.Properties.Resources.Player_Papel;
            this.PtbJogadorPapel.Location = new System.Drawing.Point(335, 62);
            this.PtbJogadorPapel.Name = "PtbJogadorPapel";
            this.PtbJogadorPapel.Size = new System.Drawing.Size(88, 102);
            this.PtbJogadorPapel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbJogadorPapel.TabIndex = 8;
            this.PtbJogadorPapel.TabStop = false;
            this.PtbJogadorPapel.Visible = false;
            // 
            // PtbComputadorTesoura
            // 
            this.PtbComputadorTesoura.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PtbComputadorTesoura.Image = global::Varios_Jogos_em_um.Properties.Resources.IA_Tesoura;
            this.PtbComputadorTesoura.Location = new System.Drawing.Point(22, 62);
            this.PtbComputadorTesoura.Name = "PtbComputadorTesoura";
            this.PtbComputadorTesoura.Size = new System.Drawing.Size(88, 102);
            this.PtbComputadorTesoura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbComputadorTesoura.TabIndex = 7;
            this.PtbComputadorTesoura.TabStop = false;
            this.PtbComputadorTesoura.Visible = false;
            // 
            // PtbComputadorPapel
            // 
            this.PtbComputadorPapel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PtbComputadorPapel.Image = global::Varios_Jogos_em_um.Properties.Resources.IA_Papel;
            this.PtbComputadorPapel.Location = new System.Drawing.Point(22, 62);
            this.PtbComputadorPapel.Name = "PtbComputadorPapel";
            this.PtbComputadorPapel.Size = new System.Drawing.Size(88, 102);
            this.PtbComputadorPapel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbComputadorPapel.TabIndex = 6;
            this.PtbComputadorPapel.TabStop = false;
            this.PtbComputadorPapel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Computador:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(306, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Jogador:";
            // 
            // PtbImagemNeutroComputador
            // 
            this.PtbImagemNeutroComputador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(72)))), ((int)(((byte)(198)))));
            this.PtbImagemNeutroComputador.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PtbImagemNeutroComputador.Location = new System.Drawing.Point(22, 62);
            this.PtbImagemNeutroComputador.Name = "PtbImagemNeutroComputador";
            this.PtbImagemNeutroComputador.Size = new System.Drawing.Size(88, 102);
            this.PtbImagemNeutroComputador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbImagemNeutroComputador.TabIndex = 12;
            this.PtbImagemNeutroComputador.TabStop = false;
            // 
            // PtbImagemNeutroJogador
            // 
            this.PtbImagemNeutroJogador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(72)))), ((int)(((byte)(198)))));
            this.PtbImagemNeutroJogador.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PtbImagemNeutroJogador.Location = new System.Drawing.Point(335, 62);
            this.PtbImagemNeutroJogador.Name = "PtbImagemNeutroJogador";
            this.PtbImagemNeutroJogador.Size = new System.Drawing.Size(88, 102);
            this.PtbImagemNeutroJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbImagemNeutroJogador.TabIndex = 13;
            this.PtbImagemNeutroJogador.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(205, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 31);
            this.label3.TabIndex = 14;
            this.label3.Text = "VS";
            // 
            // LblPontosComputador
            // 
            this.LblPontosComputador.AutoSize = true;
            this.LblPontosComputador.BackColor = System.Drawing.Color.White;
            this.LblPontosComputador.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPontosComputador.Location = new System.Drawing.Point(205, 9);
            this.LblPontosComputador.Name = "LblPontosComputador";
            this.LblPontosComputador.Size = new System.Drawing.Size(29, 31);
            this.LblPontosComputador.TabIndex = 15;
            this.LblPontosComputador.Text = "0";
            // 
            // LblPontosJogador
            // 
            this.LblPontosJogador.AutoSize = true;
            this.LblPontosJogador.BackColor = System.Drawing.Color.White;
            this.LblPontosJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPontosJogador.Location = new System.Drawing.Point(445, 9);
            this.LblPontosJogador.Name = "LblPontosJogador";
            this.LblPontosJogador.Size = new System.Drawing.Size(29, 31);
            this.LblPontosJogador.TabIndex = 16;
            this.LblPontosJogador.Text = "0";
            // 
            // Jokenpo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(72)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(498, 305);
            this.Controls.Add(this.LblPontosJogador);
            this.Controls.Add(this.LblPontosComputador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PtbImagemNeutroJogador);
            this.Controls.Add(this.PtbImagemNeutroComputador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PtbJogadorTesoura);
            this.Controls.Add(this.PtbJogadorPapel);
            this.Controls.Add(this.PtbComputadorTesoura);
            this.Controls.Add(this.PtbComputadorPapel);
            this.Controls.Add(this.PtbComputadorPedra);
            this.Controls.Add(this.PtbJogadorPedra);
            this.Controls.Add(this.PtbTesoura);
            this.Controls.Add(this.PtbPapel);
            this.Controls.Add(this.PtbPedra);
            this.Controls.Add(this.BtnVoltarMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Jokenpo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jokenpo";
            ((System.ComponentModel.ISupportInitialize)(this.PtbPedra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbPapel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbTesoura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbJogadorPedra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbComputadorPedra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbJogadorTesoura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbJogadorPapel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbComputadorTesoura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbComputadorPapel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbImagemNeutroComputador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbImagemNeutroJogador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVoltarMenu;
        private System.Windows.Forms.PictureBox PtbPedra;
        private System.Windows.Forms.PictureBox PtbPapel;
        private System.Windows.Forms.PictureBox PtbTesoura;
        private System.Windows.Forms.PictureBox PtbJogadorPedra;
        private System.Windows.Forms.PictureBox PtbComputadorPedra;
        private System.Windows.Forms.PictureBox PtbJogadorTesoura;
        private System.Windows.Forms.PictureBox PtbJogadorPapel;
        private System.Windows.Forms.PictureBox PtbComputadorTesoura;
        private System.Windows.Forms.PictureBox PtbComputadorPapel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PtbImagemNeutroComputador;
        private System.Windows.Forms.PictureBox PtbImagemNeutroJogador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblPontosComputador;
        private System.Windows.Forms.Label LblPontosJogador;
    }
}