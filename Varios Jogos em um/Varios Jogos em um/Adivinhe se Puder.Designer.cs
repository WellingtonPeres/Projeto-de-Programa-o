
namespace Varios_Jogos_em_um
{
    partial class AdivinheSePuder
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.BtnVoltarMenu = new System.Windows.Forms.Button();
            this.LblTituloInterativo = new System.Windows.Forms.Label();
            this.TxtChutarValorAleatorio = new System.Windows.Forms.TextBox();
            this.BtnGerarValorAleatorio = new System.Windows.Forms.Button();
            this.LtbNumerosTentados = new System.Windows.Forms.ListBox();
            this.LblNumeroTentativas = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Miriam CLM", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(330, 49);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(117, 27);
            label1.TabIndex = 2;
            label1.Text = "Tentativas:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Miriam CLM", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(158, 255);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(186, 27);
            label2.TabIndex = 5;
            label2.Text = "Número Tentados";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Miriam CLM", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(301, -68);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(0, 27);
            label3.TabIndex = 7;
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnVoltarMenu
            // 
            this.BtnVoltarMenu.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnVoltarMenu.Location = new System.Drawing.Point(397, 342);
            this.BtnVoltarMenu.Name = "BtnVoltarMenu";
            this.BtnVoltarMenu.Size = new System.Drawing.Size(93, 43);
            this.BtnVoltarMenu.TabIndex = 0;
            this.BtnVoltarMenu.Text = "Menu";
            this.BtnVoltarMenu.UseVisualStyleBackColor = true;
            this.BtnVoltarMenu.Click += new System.EventHandler(this.BtnVoltarMenu_Click);
            // 
            // LblTituloInterativo
            // 
            this.LblTituloInterativo.Font = new System.Drawing.Font("Miriam CLM", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTituloInterativo.Location = new System.Drawing.Point(12, 9);
            this.LblTituloInterativo.Name = "LblTituloInterativo";
            this.LblTituloInterativo.Size = new System.Drawing.Size(302, 107);
            this.LblTituloInterativo.TabIndex = 1;
            this.LblTituloInterativo.Text = "Adivinhe se Puder";
            this.LblTituloInterativo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtChutarValorAleatorio
            // 
            this.TxtChutarValorAleatorio.Enabled = false;
            this.TxtChutarValorAleatorio.Font = new System.Drawing.Font("Miriam CLM", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtChutarValorAleatorio.Location = new System.Drawing.Point(201, 131);
            this.TxtChutarValorAleatorio.Name = "TxtChutarValorAleatorio";
            this.TxtChutarValorAleatorio.Size = new System.Drawing.Size(100, 51);
            this.TxtChutarValorAleatorio.TabIndex = 3;
            this.TxtChutarValorAleatorio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtChutarValorAleatorio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtChutarValorAleatorio_KeyDown);
            // 
            // BtnGerarValorAleatorio
            // 
            this.BtnGerarValorAleatorio.Font = new System.Drawing.Font("Miriam CLM", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnGerarValorAleatorio.Location = new System.Drawing.Point(201, 188);
            this.BtnGerarValorAleatorio.Name = "BtnGerarValorAleatorio";
            this.BtnGerarValorAleatorio.Size = new System.Drawing.Size(100, 52);
            this.BtnGerarValorAleatorio.TabIndex = 4;
            this.BtnGerarValorAleatorio.Text = "Jogar";
            this.BtnGerarValorAleatorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGerarValorAleatorio.UseVisualStyleBackColor = true;
            this.BtnGerarValorAleatorio.Click += new System.EventHandler(this.BtnGerarValorAleatorio_Click);
            // 
            // LtbNumerosTentados
            // 
            this.LtbNumerosTentados.Font = new System.Drawing.Font("Miriam CLM", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LtbNumerosTentados.FormattingEnabled = true;
            this.LtbNumerosTentados.ItemHeight = 29;
            this.LtbNumerosTentados.Location = new System.Drawing.Point(191, 285);
            this.LtbNumerosTentados.Name = "LtbNumerosTentados";
            this.LtbNumerosTentados.Size = new System.Drawing.Size(120, 91);
            this.LtbNumerosTentados.TabIndex = 6;
            // 
            // LblNumeroTentativas
            // 
            this.LblNumeroTentativas.AutoSize = true;
            this.LblNumeroTentativas.Font = new System.Drawing.Font("Miriam CLM", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblNumeroTentativas.Location = new System.Drawing.Point(452, 46);
            this.LblNumeroTentativas.Name = "LblNumeroTentativas";
            this.LblNumeroTentativas.Size = new System.Drawing.Size(26, 29);
            this.LblNumeroTentativas.TabIndex = 8;
            this.LblNumeroTentativas.Text = "3";
            // 
            // AdivinheSePuder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(502, 397);
            this.Controls.Add(this.LblNumeroTentativas);
            this.Controls.Add(label3);
            this.Controls.Add(this.LtbNumerosTentados);
            this.Controls.Add(label2);
            this.Controls.Add(this.BtnGerarValorAleatorio);
            this.Controls.Add(this.TxtChutarValorAleatorio);
            this.Controls.Add(label1);
            this.Controls.Add(this.LblTituloInterativo);
            this.Controls.Add(this.BtnVoltarMenu);
            this.Name = "AdivinheSePuder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adivinhe se Puder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVoltarMenu;
        private System.Windows.Forms.Label LblTituloInterativo;
        private System.Windows.Forms.TextBox TxtChutarValorAleatorio;
        private System.Windows.Forms.Button BtnGerarValorAleatorio;
        private System.Windows.Forms.ListBox LtbNumerosTentados;
        private System.Windows.Forms.Label LblNumeroTentativas;
    }
}