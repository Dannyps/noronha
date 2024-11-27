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
            taxaJuro_textBox = new TextBox();
            label1 = new Label();
            button1 = new Button();
            valorInicial_textBox = new TextBox();
            prazo_textBox = new TextBox();
            montanteFinal = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // taxaJuro_textBox
            // 
            taxaJuro_textBox.Location = new Point(170, 106);
            taxaJuro_textBox.Name = "taxaJuro_textBox";
            taxaJuro_textBox.Size = new Size(100, 23);
            taxaJuro_textBox.TabIndex = 0;
            taxaJuro_textBox.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(223, 120);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(170, 295);
            button1.Name = "button1";
            button1.Size = new Size(182, 23);
            button1.TabIndex = 2;
            button1.Text = "Ação";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // valorInicial_textBox
            // 
            valorInicial_textBox.Location = new Point(170, 58);
            valorInicial_textBox.Name = "valorInicial_textBox";
            valorInicial_textBox.Size = new Size(100, 23);
            valorInicial_textBox.TabIndex = 3;
            // 
            // prazo_textBox
            // 
            prazo_textBox.Location = new Point(170, 154);
            prazo_textBox.Name = "prazo_textBox";
            prazo_textBox.Size = new Size(100, 23);
            prazo_textBox.TabIndex = 4;
            // 
            // montanteFinal
            // 
            montanteFinal.AutoSize = true;
            montanteFinal.Location = new Point(79, 222);
            montanteFinal.Name = "montanteFinal";
            montanteFinal.Size = new Size(38, 15);
            montanteFinal.TabIndex = 5;
            montanteFinal.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 58);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 6;
            label2.Text = "Valor Inicial";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 103);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 7;
            label3.Text = "Taxa";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 154);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 8;
            label4.Text = "Prazo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(montanteFinal);
            Controls.Add(prazo_textBox);
            Controls.Add(valorInicial_textBox);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(taxaJuro_textBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox taxaJuro_textBox;
        private Label label1;
        private Button button1;
        private TextBox valorInicial_textBox;
        private TextBox prazo_textBox;
        private Label montanteFinal;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
