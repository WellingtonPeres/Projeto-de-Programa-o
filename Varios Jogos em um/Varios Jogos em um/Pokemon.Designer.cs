
namespace Varios_Jogos_em_um
{
    partial class Pokemon
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
            this.PgbPikachu = new System.Windows.Forms.ProgressBar();
            this.PgbPokemon = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblNomePokemon = new System.Windows.Forms.Label();
            this.BtnAtaque = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LblAtaquePikachu = new System.Windows.Forms.Label();
            this.BtnProcurarAdiversario = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LblLevelPikachu = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblLevelPokemon = new System.Windows.Forms.Label();
            this.LblStatusAtaque = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblAtaquePokemon = new System.Windows.Forms.Label();
            this.PgbBarraEvoluir = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnVoltarMenu
            // 
            this.BtnVoltarMenu.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnVoltarMenu.Location = new System.Drawing.Point(277, 269);
            this.BtnVoltarMenu.Name = "BtnVoltarMenu";
            this.BtnVoltarMenu.Size = new System.Drawing.Size(90, 38);
            this.BtnVoltarMenu.TabIndex = 0;
            this.BtnVoltarMenu.Text = "Menu";
            this.BtnVoltarMenu.UseVisualStyleBackColor = true;
            this.BtnVoltarMenu.Click += new System.EventHandler(this.BtnVoltarMenu_Click);
            // 
            // PgbPikachu
            // 
            this.PgbPikachu.Location = new System.Drawing.Point(12, 79);
            this.PgbPikachu.Maximum = 20;
            this.PgbPikachu.Name = "PgbPikachu";
            this.PgbPikachu.Size = new System.Drawing.Size(100, 23);
            this.PgbPikachu.TabIndex = 1;
            this.PgbPikachu.Value = 20;
            // 
            // PgbPokemon
            // 
            this.PgbPokemon.Location = new System.Drawing.Point(147, 31);
            this.PgbPokemon.Maximum = 20;
            this.PgbPokemon.Name = "PgbPokemon";
            this.PgbPokemon.Size = new System.Drawing.Size(100, 23);
            this.PgbPokemon.TabIndex = 2;
            this.PgbPokemon.Value = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox1.Location = new System.Drawing.Point(12, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 84);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox2.Location = new System.Drawing.Point(147, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 62);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pikachu";
            // 
            // LblNomePokemon
            // 
            this.LblNomePokemon.AutoSize = true;
            this.LblNomePokemon.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblNomePokemon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblNomePokemon.Location = new System.Drawing.Point(147, 9);
            this.LblNomePokemon.Name = "LblNomePokemon";
            this.LblNomePokemon.Size = new System.Drawing.Size(68, 19);
            this.LblNomePokemon.TabIndex = 6;
            this.LblNomePokemon.Text = "Squirtle";
            // 
            // BtnAtaque
            // 
            this.BtnAtaque.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAtaque.Location = new System.Drawing.Point(12, 198);
            this.BtnAtaque.Name = "BtnAtaque";
            this.BtnAtaque.Size = new System.Drawing.Size(132, 40);
            this.BtnAtaque.TabIndex = 7;
            this.BtnAtaque.Text = "Combate";
            this.BtnAtaque.UseVisualStyleBackColor = true;
            this.BtnAtaque.Click += new System.EventHandler(this.BtnAtaque_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(253, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ataque";
            // 
            // LblAtaquePikachu
            // 
            this.LblAtaquePikachu.AutoSize = true;
            this.LblAtaquePikachu.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblAtaquePikachu.Location = new System.Drawing.Point(187, 163);
            this.LblAtaquePikachu.Name = "LblAtaquePikachu";
            this.LblAtaquePikachu.Size = new System.Drawing.Size(29, 32);
            this.LblAtaquePikachu.TabIndex = 11;
            this.LblAtaquePikachu.Text = "5";
            // 
            // BtnProcurarAdiversario
            // 
            this.BtnProcurarAdiversario.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnProcurarAdiversario.Enabled = false;
            this.BtnProcurarAdiversario.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnProcurarAdiversario.Location = new System.Drawing.Point(12, 241);
            this.BtnProcurarAdiversario.Name = "BtnProcurarAdiversario";
            this.BtnProcurarAdiversario.Size = new System.Drawing.Size(132, 66);
            this.BtnProcurarAdiversario.TabIndex = 16;
            this.BtnProcurarAdiversario.Text = "Procurar adiversário";
            this.BtnProcurarAdiversario.UseVisualStyleBackColor = true;
            this.BtnProcurarAdiversario.Click += new System.EventHandler(this.BtnProcurarAdiversario_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(118, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ataque";
            // 
            // LblLevelPikachu
            // 
            this.LblLevelPikachu.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblLevelPikachu.Location = new System.Drawing.Point(50, -1);
            this.LblLevelPikachu.Name = "LblLevelPikachu";
            this.LblLevelPikachu.Size = new System.Drawing.Size(28, 32);
            this.LblLevelPikachu.TabIndex = 18;
            this.LblLevelPikachu.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Lvl:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(249, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 19);
            this.label7.TabIndex = 21;
            this.label7.Text = "Lvl:";
            // 
            // LblLevelPokemon
            // 
            this.LblLevelPokemon.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblLevelPokemon.Location = new System.Drawing.Point(287, -1);
            this.LblLevelPokemon.Name = "LblLevelPokemon";
            this.LblLevelPokemon.Size = new System.Drawing.Size(28, 32);
            this.LblLevelPokemon.TabIndex = 20;
            this.LblLevelPokemon.Text = "1";
            // 
            // LblStatusAtaque
            // 
            this.LblStatusAtaque.AutoSize = true;
            this.LblStatusAtaque.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblStatusAtaque.Location = new System.Drawing.Point(150, 229);
            this.LblStatusAtaque.Name = "LblStatusAtaque";
            this.LblStatusAtaque.Size = new System.Drawing.Size(166, 22);
            this.LblStatusAtaque.TabIndex = 22;
            this.LblStatusAtaque.Text = "--------------------------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(150, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 22);
            this.label5.TabIndex = 23;
            this.label5.Text = "Status de Ataque:";
            // 
            // LblAtaquePokemon
            // 
            this.LblAtaquePokemon.AutoSize = true;
            this.LblAtaquePokemon.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblAtaquePokemon.Location = new System.Drawing.Point(322, 93);
            this.LblAtaquePokemon.Name = "LblAtaquePokemon";
            this.LblAtaquePokemon.Size = new System.Drawing.Size(29, 32);
            this.LblAtaquePokemon.TabIndex = 24;
            this.LblAtaquePokemon.Text = "5";
            // 
            // PgbBarraEvoluir
            // 
            this.PgbBarraEvoluir.Location = new System.Drawing.Point(12, 31);
            this.PgbBarraEvoluir.Maximum = 30;
            this.PgbBarraEvoluir.Name = "PgbBarraEvoluir";
            this.PgbBarraEvoluir.Size = new System.Drawing.Size(100, 23);
            this.PgbBarraEvoluir.TabIndex = 25;
            // 
            // Pokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 314);
            this.Controls.Add(this.PgbBarraEvoluir);
            this.Controls.Add(this.LblAtaquePokemon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblStatusAtaque);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblLevelPokemon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblLevelPikachu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnProcurarAdiversario);
            this.Controls.Add(this.LblAtaquePikachu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnAtaque);
            this.Controls.Add(this.LblNomePokemon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PgbPokemon);
            this.Controls.Add(this.PgbPikachu);
            this.Controls.Add(this.BtnVoltarMenu);
            this.Name = "Pokemon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokemon";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVoltarMenu;
        private System.Windows.Forms.ProgressBar PgbPikachu;
        private System.Windows.Forms.ProgressBar PgbPokemon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblNomePokemon;
        private System.Windows.Forms.Button BtnAtaque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblAtaquePikachu;
        private System.Windows.Forms.Button BtnProcurarAdiversario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblLevelPikachu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblLevelPokemon;
        private System.Windows.Forms.Label LblStatusAtaque;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblAtaquePokemon;
        private System.Windows.Forms.ProgressBar PgbBarraEvoluir;
    }
}