namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbTaxaJuro = new TextBox();
            label1 = new Label();
            btnCalc = new Button();
            tbValorInicial = new TextBox();
            tbPrazo = new TextBox();
            lblMontanteFinal = new Label();
            lblValorInicial = new Label();
            lblTaxaJuro = new Label();
            lblPrazo = new Label();
            SuspendLayout();
            // 
            // tbTaxaJuro
            // 
            tbTaxaJuro.Location = new Point(170, 106);
            tbTaxaJuro.Name = "tbTaxaJuro";
            tbTaxaJuro.Size = new Size(100, 23);
            tbTaxaJuro.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(223, 120);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(170, 295);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(182, 23);
            btnCalc.TabIndex = 2;
            btnCalc.Text = "Ação";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // tbValorInicial
            // 
            tbValorInicial.Location = new Point(170, 58);
            tbValorInicial.Name = "tbValorInicial";
            tbValorInicial.Size = new Size(100, 23);
            tbValorInicial.TabIndex = 3;
            // 
            // tbPrazo
            // 
            tbPrazo.Location = new Point(170, 154);
            tbPrazo.Name = "tbPrazo";
            tbPrazo.Size = new Size(100, 23);
            tbPrazo.TabIndex = 4;
            // 
            // lblMontanteFinal
            // 
            lblMontanteFinal.AutoSize = true;
            lblMontanteFinal.Location = new Point(79, 222);
            lblMontanteFinal.Name = "lblMontanteFinal";
            lblMontanteFinal.Size = new Size(87, 15);
            lblMontanteFinal.TabIndex = 5;
            lblMontanteFinal.Text = "Montante Final";
            // 
            // lblValorInicial
            // 
            lblValorInicial.AutoSize = true;
            lblValorInicial.Location = new Point(79, 58);
            lblValorInicial.Name = "lblValorInicial";
            lblValorInicial.Size = new Size(67, 15);
            lblValorInicial.TabIndex = 6;
            lblValorInicial.Text = "Valor Inicial";
            // 
            // lblTaxaJuro
            // 
            lblTaxaJuro.AutoSize = true;
            lblTaxaJuro.Location = new Point(79, 103);
            lblTaxaJuro.Name = "lblTaxaJuro";
            lblTaxaJuro.Size = new Size(30, 15);
            lblTaxaJuro.TabIndex = 7;
            lblTaxaJuro.Text = "Taxa";
            // 
            // lblPrazo
            // 
            lblPrazo.AutoSize = true;
            lblPrazo.Location = new Point(81, 154);
            lblPrazo.Name = "lblPrazo";
            lblPrazo.Size = new Size(36, 15);
            lblPrazo.TabIndex = 8;
            lblPrazo.Text = "Prazo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPrazo);
            Controls.Add(lblTaxaJuro);
            Controls.Add(lblValorInicial);
            Controls.Add(lblMontanteFinal);
            Controls.Add(tbPrazo);
            Controls.Add(tbValorInicial);
            Controls.Add(btnCalc);
            Controls.Add(label1);
            Controls.Add(tbTaxaJuro);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbTaxaJuro;
        private Label label1;
        private Button btnCalc;
        private TextBox tbValorInicial;
        private TextBox tbPrazo;
        private Label lblMontanteFinal;
        private Label lblValorInicial;
        private Label lblTaxaJuro;
        private Label lblPrazo;
    }
}
