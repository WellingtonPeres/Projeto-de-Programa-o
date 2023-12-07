
namespace Varios_Jogos_em_um
{
    partial class Yu_gi_oh
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblDeckJogador = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LblNomeDaCartaComputador = new System.Windows.Forms.Label();
            this.LblAtaqueDaCartaComputador = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LblNomeDaCartaJogador = new System.Windows.Forms.Label();
            this.LblAtaqueDaCartaJogador = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblPontosComputador = new System.Windows.Forms.Label();
            this.LblPontosJogador = new System.Windows.Forms.Label();
            this.BtnDuelar = new System.Windows.Forms.Button();
            this.BtnRevanche = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblVitoriaComputador = new System.Windows.Forms.Label();
            this.LblVitoriaJogador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnVoltarMenu
            // 
            this.BtnVoltarMenu.Font = new System.Drawing.Font("Viner Hand ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnVoltarMenu.Location = new System.Drawing.Point(481, 253);
            this.BtnVoltarMenu.Name = "BtnVoltarMenu";
            this.BtnVoltarMenu.Size = new System.Drawing.Size(118, 48);
            this.BtnVoltarMenu.TabIndex = 0;
            this.BtnVoltarMenu.Text = "Menu";
            this.BtnVoltarMenu.UseVisualStyleBackColor = true;
            this.BtnVoltarMenu.Click += new System.EventHandler(this.BtnVoltarMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SaddleBrown;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(14, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 136);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Chocolate;
            this.pictureBox2.Location = new System.Drawing.Point(503, 103);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(95, 136);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PuxarCartaDeck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SaddleBrown;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Deck";
            // 
            // LblDeckJogador
            // 
            this.LblDeckJogador.AutoSize = true;
            this.LblDeckJogador.BackColor = System.Drawing.Color.Chocolate;
            this.LblDeckJogador.Enabled = false;
            this.LblDeckJogador.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblDeckJogador.Location = new System.Drawing.Point(512, 162);
            this.LblDeckJogador.Name = "LblDeckJogador";
            this.LblDeckJogador.Size = new System.Drawing.Size(79, 29);
            this.LblDeckJogador.TabIndex = 4;
            this.LblDeckJogador.Text = "Deck";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.LblNomeDaCartaComputador, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblAtaqueDaCartaComputador, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(115, 103);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(111, 136);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // LblNomeDaCartaComputador
            // 
            this.LblNomeDaCartaComputador.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblNomeDaCartaComputador.Location = new System.Drawing.Point(3, 0);
            this.LblNomeDaCartaComputador.Name = "LblNomeDaCartaComputador";
            this.LblNomeDaCartaComputador.Size = new System.Drawing.Size(105, 101);
            this.LblNomeDaCartaComputador.TabIndex = 0;
            this.LblNomeDaCartaComputador.Text = "?????";
            this.LblNomeDaCartaComputador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblAtaqueDaCartaComputador
            // 
            this.LblAtaqueDaCartaComputador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblAtaqueDaCartaComputador.Location = new System.Drawing.Point(3, 116);
            this.LblAtaqueDaCartaComputador.Name = "LblAtaqueDaCartaComputador";
            this.LblAtaqueDaCartaComputador.Size = new System.Drawing.Size(105, 20);
            this.LblAtaqueDaCartaComputador.TabIndex = 1;
            this.LblAtaqueDaCartaComputador.Text = "?????";
            this.LblAtaqueDaCartaComputador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.LblNomeDaCartaJogador, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.LblAtaqueDaCartaJogador, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(386, 103);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(111, 136);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // LblNomeDaCartaJogador
            // 
            this.LblNomeDaCartaJogador.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblNomeDaCartaJogador.Location = new System.Drawing.Point(3, 0);
            this.LblNomeDaCartaJogador.Name = "LblNomeDaCartaJogador";
            this.LblNomeDaCartaJogador.Size = new System.Drawing.Size(105, 101);
            this.LblNomeDaCartaJogador.TabIndex = 0;
            this.LblNomeDaCartaJogador.Text = "?????";
            this.LblNomeDaCartaJogador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblAtaqueDaCartaJogador
            // 
            this.LblAtaqueDaCartaJogador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblAtaqueDaCartaJogador.Location = new System.Drawing.Point(3, 116);
            this.LblAtaqueDaCartaJogador.Name = "LblAtaqueDaCartaJogador";
            this.LblAtaqueDaCartaJogador.Size = new System.Drawing.Size(105, 20);
            this.LblAtaqueDaCartaJogador.TabIndex = 1;
            this.LblAtaqueDaCartaJogador.Text = "?????";
            this.LblAtaqueDaCartaJogador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkKhaki;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Computador:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkKhaki;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(386, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Jogador:";
            // 
            // LblPontosComputador
            // 
            this.LblPontosComputador.AutoSize = true;
            this.LblPontosComputador.BackColor = System.Drawing.Color.DarkKhaki;
            this.LblPontosComputador.Enabled = false;
            this.LblPontosComputador.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPontosComputador.Location = new System.Drawing.Point(206, 16);
            this.LblPontosComputador.Name = "LblPontosComputador";
            this.LblPontosComputador.Size = new System.Drawing.Size(73, 29);
            this.LblPontosComputador.TabIndex = 9;
            this.LblPontosComputador.Text = "8000";
            // 
            // LblPontosJogador
            // 
            this.LblPontosJogador.AutoSize = true;
            this.LblPontosJogador.BackColor = System.Drawing.Color.DarkKhaki;
            this.LblPontosJogador.Enabled = false;
            this.LblPontosJogador.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPontosJogador.Location = new System.Drawing.Point(527, 16);
            this.LblPontosJogador.Name = "LblPontosJogador";
            this.LblPontosJogador.Size = new System.Drawing.Size(73, 29);
            this.LblPontosJogador.TabIndex = 10;
            this.LblPontosJogador.Text = "8000";
            // 
            // BtnDuelar
            // 
            this.BtnDuelar.Enabled = false;
            this.BtnDuelar.Font = new System.Drawing.Font("Viner Hand ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDuelar.Location = new System.Drawing.Point(239, 125);
            this.BtnDuelar.Name = "BtnDuelar";
            this.BtnDuelar.Size = new System.Drawing.Size(131, 97);
            this.BtnDuelar.TabIndex = 11;
            this.BtnDuelar.Text = "Hora do Duelo";
            this.BtnDuelar.UseVisualStyleBackColor = true;
            this.BtnDuelar.Click += new System.EventHandler(this.BtnDuelar_Click);
            // 
            // BtnRevanche
            // 
            this.BtnRevanche.Enabled = false;
            this.BtnRevanche.Font = new System.Drawing.Font("Viner Hand ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnRevanche.Location = new System.Drawing.Point(221, 253);
            this.BtnRevanche.Name = "BtnRevanche";
            this.BtnRevanche.Size = new System.Drawing.Size(167, 48);
            this.BtnRevanche.TabIndex = 12;
            this.BtnRevanche.Text = "Revanche";
            this.BtnRevanche.UseVisualStyleBackColor = true;
            this.BtnRevanche.Click += new System.EventHandler(this.BtnRevanche_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkKhaki;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Vitórias:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkKhaki;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(383, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Vitórias:";
            // 
            // LblVitoriaComputador
            // 
            this.LblVitoriaComputador.AutoSize = true;
            this.LblVitoriaComputador.BackColor = System.Drawing.Color.DarkKhaki;
            this.LblVitoriaComputador.Enabled = false;
            this.LblVitoriaComputador.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblVitoriaComputador.Location = new System.Drawing.Point(206, 55);
            this.LblVitoriaComputador.Name = "LblVitoriaComputador";
            this.LblVitoriaComputador.Size = new System.Drawing.Size(28, 29);
            this.LblVitoriaComputador.TabIndex = 15;
            this.LblVitoriaComputador.Text = "0";
            // 
            // LblVitoriaJogador
            // 
            this.LblVitoriaJogador.AutoSize = true;
            this.LblVitoriaJogador.BackColor = System.Drawing.Color.DarkKhaki;
            this.LblVitoriaJogador.Enabled = false;
            this.LblVitoriaJogador.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblVitoriaJogador.Location = new System.Drawing.Point(526, 55);
            this.LblVitoriaJogador.Name = "LblVitoriaJogador";
            this.LblVitoriaJogador.Size = new System.Drawing.Size(28, 29);
            this.LblVitoriaJogador.TabIndex = 16;
            this.LblVitoriaJogador.Text = "0";
            // 
            // Yu_gi_oh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(609, 312);
            this.Controls.Add(this.LblVitoriaJogador);
            this.Controls.Add(this.LblVitoriaComputador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnRevanche);
            this.Controls.Add(this.BtnDuelar);
            this.Controls.Add(this.LblPontosJogador);
            this.Controls.Add(this.LblPontosComputador);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.LblDeckJogador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnVoltarMenu);
            this.Name = "Yu_gi_oh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yu_gi_oh";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVoltarMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblDeckJogador;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblPontosComputador;
        private System.Windows.Forms.Label LblPontosJogador;
        private System.Windows.Forms.Button BtnDuelar;
        private System.Windows.Forms.Label LblNomeDaCartaComputador;
        private System.Windows.Forms.Label LblAtaqueDaCartaComputador;
        private System.Windows.Forms.Label LblNomeDaCartaJogador;
        private System.Windows.Forms.Label LblAtaqueDaCartaJogador;
        private System.Windows.Forms.Button BtnRevanche;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblVitoriaComputador;
        private System.Windows.Forms.Label LblVitoriaJogador;
    }
}