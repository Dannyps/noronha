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
            massa_textBox = new TextBox();
            velocidade_textBox = new TextBox();
            joule_label = new Label();
            kwh__label = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // massa_textBox
            // 
            massa_textBox.Location = new Point(127, 75);
            massa_textBox.Name = "massa_textBox";
            massa_textBox.Size = new Size(100, 23);
            massa_textBox.TabIndex = 0;
            // 
            // velocidade_textBox
            // 
            velocidade_textBox.Location = new Point(127, 127);
            velocidade_textBox.Name = "velocidade_textBox";
            velocidade_textBox.Size = new Size(100, 23);
            velocidade_textBox.TabIndex = 1;
            // 
            // joule_label
            // 
            joule_label.AutoSize = true;
            joule_label.Location = new Point(127, 203);
            joule_label.Name = "joule_label";
            joule_label.Size = new Size(38, 15);
            joule_label.TabIndex = 2;
            joule_label.Text = "label1";
            // 
            // kwh__label
            // 
            kwh__label.AutoSize = true;
            kwh__label.Location = new Point(130, 241);
            kwh__label.Name = "kwh__label";
            kwh__label.Size = new Size(38, 15);
            kwh__label.TabIndex = 3;
            kwh__label.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(125, 303);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Calc";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(kwh__label);
            Controls.Add(joule_label);
            Controls.Add(velocidade_textBox);
            Controls.Add(massa_textBox);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox massa_textBox;
        private TextBox velocidade_textBox;
        private Label joule_label;
        private Label kwh__label;
        private Button button1;
    }
}