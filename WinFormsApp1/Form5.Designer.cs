namespace WinFormsApp1
{
    partial class Form5
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
            lbNums = new ListBox();
            lblHaNegativos = new Label();
            lblPrimeiro = new Label();
            lblUltimo = new Label();
            tbNumero = new TextBox();
            btnGo = new Button();
            SuspendLayout();
            // 
            // lbNums
            // 
            lbNums.FormattingEnabled = true;
            lbNums.ItemHeight = 15;
            lbNums.Location = new Point(541, 12);
            lbNums.Name = "lbNums";
            lbNums.Size = new Size(235, 334);
            lbNums.TabIndex = 0;
            // 
            // lblHaNegativos
            // 
            lblHaNegativos.AutoSize = true;
            lblHaNegativos.Location = new Point(46, 217);
            lblHaNegativos.Name = "lblHaNegativos";
            lblHaNegativos.Size = new Size(78, 15);
            lblHaNegativos.TabIndex = 1;
            lblHaNegativos.Text = "Há Negativos";
            // 
            // lblPrimeiro
            // 
            lblPrimeiro.AutoSize = true;
            lblPrimeiro.Location = new Point(46, 247);
            lblPrimeiro.Name = "lblPrimeiro";
            lblPrimeiro.Size = new Size(52, 15);
            lblPrimeiro.TabIndex = 2;
            lblPrimeiro.Text = "Primeiro";
            // 
            // lblUltimo
            // 
            lblUltimo.AutoSize = true;
            lblUltimo.Location = new Point(48, 277);
            lblUltimo.Name = "lblUltimo";
            lblUltimo.Size = new Size(43, 15);
            lblUltimo.TabIndex = 3;
            lblUltimo.Text = "Último";
            // 
            // tbNumero
            // 
            tbNumero.Location = new Point(44, 34);
            tbNumero.Name = "tbNumero";
            tbNumero.PlaceholderText = "Número";
            tbNumero.Size = new Size(100, 23);
            tbNumero.TabIndex = 4;
            // 
            // btnGo
            // 
            btnGo.Location = new Point(48, 371);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(75, 23);
            btnGo.TabIndex = 5;
            btnGo.Text = "Go";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnGo_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGo);
            Controls.Add(tbNumero);
            Controls.Add(lblUltimo);
            Controls.Add(lblPrimeiro);
            Controls.Add(lblHaNegativos);
            Controls.Add(lbNums);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbNums;
        private Label lblHaNegativos;
        private Label lblPrimeiro;
        private Label lblUltimo;
        private TextBox tbNumero;
        private Button btnGo;
    }
}