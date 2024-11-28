namespace WinFormsApp1
{
    partial class Form4
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
            tbNum1 = new TextBox();
            tbNum2 = new TextBox();
            tbNum3 = new TextBox();
            tbNum4 = new TextBox();
            btnVerificar = new Button();
            SuspendLayout();
            // 
            // tbNum1
            // 
            tbNum1.Location = new Point(55, 47);
            tbNum1.Name = "tbNum1";
            tbNum1.PlaceholderText = "Número 1";
            tbNum1.Size = new Size(100, 23);
            tbNum1.TabIndex = 0;
            // 
            // tbNum2
            // 
            tbNum2.Location = new Point(181, 47);
            tbNum2.Name = "tbNum2";
            tbNum2.PlaceholderText = "Número 2";
            tbNum2.Size = new Size(100, 23);
            tbNum2.TabIndex = 1;
            // 
            // tbNum3
            // 
            tbNum3.Location = new Point(304, 47);
            tbNum3.Name = "tbNum3";
            tbNum3.PlaceholderText = "Número 3";
            tbNum3.Size = new Size(100, 23);
            tbNum3.TabIndex = 2;
            // 
            // tbNum4
            // 
            tbNum4.Location = new Point(430, 47);
            tbNum4.Name = "tbNum4";
            tbNum4.PlaceholderText = "Número 4";
            tbNum4.Size = new Size(100, 23);
            tbNum4.TabIndex = 3;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(80, 207);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(75, 23);
            btnVerificar.TabIndex = 4;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVerificar);
            Controls.Add(tbNum4);
            Controls.Add(tbNum3);
            Controls.Add(tbNum2);
            Controls.Add(tbNum1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNum1;
        private TextBox tbNum2;
        private TextBox tbNum3;
        private TextBox tbNum4;
        private Button btnVerificar;
    }
}