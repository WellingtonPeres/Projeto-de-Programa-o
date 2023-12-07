
namespace Varios_Jogos_em_um
{
    partial class Jogo_da_Forca
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnVoltarMenu
            // 
            this.BtnVoltarMenu.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnVoltarMenu.Location = new System.Drawing.Point(113, 121);
            this.BtnVoltarMenu.Name = "BtnVoltarMenu";
            this.BtnVoltarMenu.Size = new System.Drawing.Size(115, 43);
            this.BtnVoltarMenu.TabIndex = 0;
            this.BtnVoltarMenu.Text = "Menu";
            this.BtnVoltarMenu.UseVisualStyleBackColor = true;
            this.BtnVoltarMenu.Click += new System.EventHandler(this.BtnVoltarMenu_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 109);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jogo Feito no  .NET Framework";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Jogo_da_Forca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 176);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnVoltarMenu);
            this.Name = "Jogo_da_Forca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo_da_Forca";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnVoltarMenu;
        private System.Windows.Forms.Label label1;
    }
}