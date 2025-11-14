namespace MasterScore
{
    partial class FormPergunta
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
            txtPergunta = new TextBox();
            btnResA = new Button();
            lblResA = new Label();
            lblResB = new Label();
            btnResB = new Button();
            lblResD = new Label();
            btnResD = new Button();
            lblResC = new Label();
            btnResC = new Button();
            btnPerguntar = new Button();
            btnLoja = new Button();
            SuspendLayout();
            // 
            // txtPergunta
            // 
            txtPergunta.BackColor = SystemColors.MenuText;
            txtPergunta.ForeColor = SystemColors.Window;
            txtPergunta.Location = new Point(33, 22);
            txtPergunta.Multiline = true;
            txtPergunta.Name = "txtPergunta";
            txtPergunta.Size = new Size(717, 103);
            txtPergunta.TabIndex = 0;
            txtPergunta.TextChanged += txtPergunta_TextChanged;
            // 
            // btnResA
            // 
            btnResA.Location = new Point(33, 177);
            btnResA.Name = "btnResA";
            btnResA.Size = new Size(75, 23);
            btnResA.TabIndex = 1;
            btnResA.Text = "A)";
            btnResA.UseVisualStyleBackColor = true;
            btnResA.Click += btnResA_Click;
            // 
            // lblResA
            // 
            lblResA.AutoSize = true;
            lblResA.Location = new Point(114, 181);
            lblResA.Name = "lblResA";
            lblResA.Size = new Size(65, 15);
            lblResA.TabIndex = 3;
            lblResA.Text = "Resposta A";
            // 
            // lblResB
            // 
            lblResB.AutoSize = true;
            lblResB.Location = new Point(114, 232);
            lblResB.Name = "lblResB";
            lblResB.Size = new Size(64, 15);
            lblResB.TabIndex = 5;
            lblResB.Text = "Resposta B";
            // 
            // btnResB
            // 
            btnResB.Location = new Point(33, 228);
            btnResB.Name = "btnResB";
            btnResB.Size = new Size(75, 23);
            btnResB.TabIndex = 4;
            btnResB.Text = "B)";
            btnResB.UseVisualStyleBackColor = true;
            btnResB.Click += btnResB_Click;
            // 
            // lblResD
            // 
            lblResD.AutoSize = true;
            lblResD.Location = new Point(114, 337);
            lblResD.Name = "lblResD";
            lblResD.Size = new Size(65, 15);
            lblResD.TabIndex = 9;
            lblResD.Text = "Resposta D";
            // 
            // btnResD
            // 
            btnResD.Location = new Point(33, 333);
            btnResD.Name = "btnResD";
            btnResD.Size = new Size(75, 23);
            btnResD.TabIndex = 8;
            btnResD.Text = "D)";
            btnResD.UseVisualStyleBackColor = true;
            btnResD.Click += btnResD_Click;
            // 
            // lblResC
            // 
            lblResC.AutoSize = true;
            lblResC.Location = new Point(114, 286);
            lblResC.Name = "lblResC";
            lblResC.Size = new Size(65, 15);
            lblResC.TabIndex = 7;
            lblResC.Text = "Resposta C";
            // 
            // btnResC
            // 
            btnResC.Location = new Point(33, 282);
            btnResC.Name = "btnResC";
            btnResC.Size = new Size(75, 23);
            btnResC.TabIndex = 6;
            btnResC.Text = "C)";
            btnResC.UseVisualStyleBackColor = true;
            btnResC.Click += btnResC_Click;
            // 
            // btnPerguntar
            // 
            btnPerguntar.Location = new Point(583, 142);
            btnPerguntar.Name = "btnPerguntar";
            btnPerguntar.Size = new Size(167, 23);
            btnPerguntar.TabIndex = 10;
            btnPerguntar.Text = "Pedir pergunta";
            btnPerguntar.UseVisualStyleBackColor = true;
            btnPerguntar.Click += btnPerguntar_Click;
            // 
            // btnLoja
            // 
            btnLoja.Location = new Point(674, 415);
            btnLoja.Name = "btnLoja";
            btnLoja.Size = new Size(114, 23);
            btnLoja.TabIndex = 11;
            btnLoja.Text = "Ir para loja";
            btnLoja.UseVisualStyleBackColor = true;
            btnLoja.Click += btnLoja_Click;
            // 
            // FormPergunta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoja);
            Controls.Add(btnPerguntar);
            Controls.Add(lblResD);
            Controls.Add(btnResD);
            Controls.Add(lblResC);
            Controls.Add(btnResC);
            Controls.Add(lblResB);
            Controls.Add(btnResB);
            Controls.Add(lblResA);
            Controls.Add(btnResA);
            Controls.Add(txtPergunta);
            Name = "FormPergunta";
            Text = "FormPergunta";
            Load += FormPergunta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPergunta;
        private Button btnResA;
        private Label lblResA;
        private Label lblResB;
        private Button btnResB;
        private Label lblResD;
        private Button btnResD;
        private Label lblResC;
        private Button btnResC;
        private Button btnPerguntar;
        private Button btnLoja;
    }
}