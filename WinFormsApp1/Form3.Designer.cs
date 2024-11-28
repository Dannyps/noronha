namespace WinFormsApp1
{
    partial class Form3
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
            tbMassa = new TextBox();
            tbVelocidade = new TextBox();
            lblJoule = new Label();
            lblKwh = new Label();
            btnCalc = new Button();
            SuspendLayout();
            // 
            // tbMassa
            // 
            tbMassa.Location = new Point(127, 75);
            tbMassa.Name = "tbMassa";
            tbMassa.PlaceholderText = "Massa";
            tbMassa.Size = new Size(100, 23);
            tbMassa.TabIndex = 0;
            // 
            // tbVelocidade
            // 
            tbVelocidade.Location = new Point(127, 127);
            tbVelocidade.Name = "tbVelocidade";
            tbVelocidade.PlaceholderText = "Velocidade";
            tbVelocidade.Size = new Size(100, 23);
            tbVelocidade.TabIndex = 1;
            // 
            // lblJoule
            // 
            lblJoule.AutoSize = true;
            lblJoule.Location = new Point(127, 203);
            lblJoule.Name = "lblJoule";
            lblJoule.Size = new Size(34, 15);
            lblJoule.TabIndex = 2;
            lblJoule.Text = "Joule";
            // 
            // lblKwh
            // 
            lblKwh.AutoSize = true;
            lblKwh.Location = new Point(131, 241);
            lblKwh.Name = "lblKwh";
            lblKwh.Size = new Size(30, 15);
            lblKwh.TabIndex = 3;
            lblKwh.Text = "Kwh";
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(125, 303);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(75, 23);
            btnCalc.TabIndex = 4;
            btnCalc.Text = "Calcular";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalc);
            Controls.Add(lblKwh);
            Controls.Add(lblJoule);
            Controls.Add(tbVelocidade);
            Controls.Add(tbMassa);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbMassa;
        private TextBox tbVelocidade;
        private Label lblJoule;
        private Label lblKwh;
        private Button btnCalc;
    }
}