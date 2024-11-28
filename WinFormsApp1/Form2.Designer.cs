namespace WinFormsApp1
{
    partial class Form2
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
            tbM1 = new TextBox();
            tbM2 = new TextBox();
            tbM3 = new TextBox();
            lblM1 = new Label();
            lblM2 = new Label();
            lblM3 = new Label();
            btnCalc = new Button();
            lblMedia = new Label();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // tbM1
            // 
            tbM1.Location = new Point(133, 86);
            tbM1.Name = "tbM1";
            tbM1.Size = new Size(100, 23);
            tbM1.TabIndex = 0;
            // 
            // tbM2
            // 
            tbM2.Location = new Point(133, 128);
            tbM2.Name = "tbM2";
            tbM2.Size = new Size(100, 23);
            tbM2.TabIndex = 1;
            // 
            // tbM3
            // 
            tbM3.Location = new Point(133, 172);
            tbM3.Name = "tbM3";
            tbM3.Size = new Size(100, 23);
            tbM3.TabIndex = 2;
            // 
            // lblM1
            // 
            lblM1.AutoSize = true;
            lblM1.Location = new Point(52, 89);
            lblM1.Name = "lblM1";
            lblM1.Size = new Size(24, 15);
            lblM1.TabIndex = 3;
            lblM1.Text = "M1";
            // 
            // lblM2
            // 
            lblM2.AutoSize = true;
            lblM2.Location = new Point(52, 136);
            lblM2.Name = "lblM2";
            lblM2.Size = new Size(24, 15);
            lblM2.TabIndex = 4;
            lblM2.Text = "M2";
            // 
            // lblM3
            // 
            lblM3.AutoSize = true;
            lblM3.Location = new Point(52, 177);
            lblM3.Name = "lblM3";
            lblM3.Size = new Size(24, 15);
            lblM3.TabIndex = 5;
            lblM3.Text = "M3";
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(52, 299);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(75, 23);
            btnCalc.TabIndex = 6;
            btnCalc.Text = "Calcular";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += button1_Click;
            // 
            // lblMedia
            // 
            lblMedia.AutoSize = true;
            lblMedia.Location = new Point(55, 223);
            lblMedia.Name = "lblMedia";
            lblMedia.Size = new Size(40, 15);
            lblMedia.TabIndex = 7;
            lblMedia.Text = "Média";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(55, 251);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 8;
            lblResultado.Text = "Resultado";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(lblMedia);
            Controls.Add(btnCalc);
            Controls.Add(lblM3);
            Controls.Add(lblM2);
            Controls.Add(lblM1);
            Controls.Add(tbM3);
            Controls.Add(tbM2);
            Controls.Add(tbM1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbM1;
        private TextBox tbM2;
        private TextBox tbM3;
        private Label lblM1;
        private Label lblM2;
        private Label lblM3;
        private Button btnCalc;
        private Label lblMedia;
        private Label lblResultado;
    }
}