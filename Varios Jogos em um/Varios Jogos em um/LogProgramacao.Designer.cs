
namespace Varios_Jogos_em_um
{
    partial class LogProgramacao
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ProximaQuestao = new System.Windows.Forms.Button();
            this.btn_Desistir = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rbt_RespostaD = new System.Windows.Forms.RadioButton();
            this.rbt_RespostaC = new System.Windows.Forms.RadioButton();
            this.rbt_RespostaB = new System.Windows.Forms.RadioButton();
            this.rbt_RespostaA = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_pergunta = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.btn_ProximaQuestao);
            this.panel1.Controls.Add(this.btn_Desistir);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 461);
            this.panel1.TabIndex = 0;
            // 
            // btn_ProximaQuestao
            // 
            this.btn_ProximaQuestao.Location = new System.Drawing.Point(431, 407);
            this.btn_ProximaQuestao.Name = "btn_ProximaQuestao";
            this.btn_ProximaQuestao.Size = new System.Drawing.Size(75, 23);
            this.btn_ProximaQuestao.TabIndex = 7;
            this.btn_ProximaQuestao.Text = "Proxima";
            this.btn_ProximaQuestao.UseVisualStyleBackColor = true;
            this.btn_ProximaQuestao.Click += new System.EventHandler(this.btn_ProximaQuestao_Click);
            // 
            // btn_Desistir
            // 
            this.btn_Desistir.Location = new System.Drawing.Point(278, 407);
            this.btn_Desistir.Name = "btn_Desistir";
            this.btn_Desistir.Size = new System.Drawing.Size(75, 23);
            this.btn_Desistir.TabIndex = 8;
            this.btn_Desistir.Text = "Desistir";
            this.btn_Desistir.UseVisualStyleBackColor = true;
            this.btn_Desistir.Click += new System.EventHandler(this.btn_Desistir_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.rbt_RespostaD, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.rbt_RespostaC, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.rbt_RespostaB, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.rbt_RespostaA, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 225);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(784, 150);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // rbt_RespostaD
            // 
            this.rbt_RespostaD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbt_RespostaD.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbt_RespostaD.Location = new System.Drawing.Point(395, 78);
            this.rbt_RespostaD.Name = "rbt_RespostaD";
            this.rbt_RespostaD.Size = new System.Drawing.Size(386, 69);
            this.rbt_RespostaD.TabIndex = 4;
            this.rbt_RespostaD.Text = "Resposta 4";
            this.rbt_RespostaD.UseVisualStyleBackColor = true;
            // 
            // rbt_RespostaC
            // 
            this.rbt_RespostaC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbt_RespostaC.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbt_RespostaC.Location = new System.Drawing.Point(3, 78);
            this.rbt_RespostaC.Name = "rbt_RespostaC";
            this.rbt_RespostaC.Size = new System.Drawing.Size(386, 69);
            this.rbt_RespostaC.TabIndex = 3;
            this.rbt_RespostaC.Text = "Resposta 3";
            this.rbt_RespostaC.UseVisualStyleBackColor = true;
            // 
            // rbt_RespostaB
            // 
            this.rbt_RespostaB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbt_RespostaB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbt_RespostaB.Location = new System.Drawing.Point(395, 3);
            this.rbt_RespostaB.Name = "rbt_RespostaB";
            this.rbt_RespostaB.Size = new System.Drawing.Size(386, 69);
            this.rbt_RespostaB.TabIndex = 2;
            this.rbt_RespostaB.Text = "Resposta 2";
            this.rbt_RespostaB.UseVisualStyleBackColor = true;
            // 
            // rbt_RespostaA
            // 
            this.rbt_RespostaA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbt_RespostaA.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbt_RespostaA.Location = new System.Drawing.Point(3, 3);
            this.rbt_RespostaA.Name = "rbt_RespostaA";
            this.rbt_RespostaA.Size = new System.Drawing.Size(386, 69);
            this.rbt_RespostaA.TabIndex = 1;
            this.rbt_RespostaA.Text = "Resposta 1";
            this.rbt_RespostaA.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_pergunta, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 75);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 150);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // lbl_pergunta
            // 
            this.lbl_pergunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(29)))));
            this.lbl_pergunta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_pergunta.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_pergunta.Location = new System.Drawing.Point(3, 0);
            this.lbl_pergunta.Name = "lbl_pergunta";
            this.lbl_pergunta.Size = new System.Drawing.Size(582, 150);
            this.lbl_pergunta.TabIndex = 0;
            this.lbl_pergunta.Text = "Pergunta";
            this.lbl_pergunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 75);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(784, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lógica de Programação";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogProgramacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel1);
            this.Name = "LogProgramacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Time";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ProximaQuestao;
        private System.Windows.Forms.Button btn_Desistir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton rbt_RespostaD;
        private System.Windows.Forms.RadioButton rbt_RespostaC;
        private System.Windows.Forms.RadioButton rbt_RespostaB;
        private System.Windows.Forms.RadioButton rbt_RespostaA;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_pergunta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}