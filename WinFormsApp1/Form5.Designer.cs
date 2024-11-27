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
            listBox1 = new ListBox();
            haNegativos_label = new Label();
            primeiro_label = new Label();
            ultimo_label = new Label();
            numero = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(541, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(235, 334);
            listBox1.TabIndex = 0;
            // 
            // haNegativos_label
            // 
            haNegativos_label.AutoSize = true;
            haNegativos_label.Location = new Point(46, 217);
            haNegativos_label.Name = "haNegativos_label";
            haNegativos_label.Size = new Size(38, 15);
            haNegativos_label.TabIndex = 1;
            haNegativos_label.Text = "label1";
            // 
            // primeiro_label
            // 
            primeiro_label.AutoSize = true;
            primeiro_label.Location = new Point(46, 247);
            primeiro_label.Name = "primeiro_label";
            primeiro_label.Size = new Size(38, 15);
            primeiro_label.TabIndex = 2;
            primeiro_label.Text = "label1";
            // 
            // ultimo_label
            // 
            ultimo_label.AutoSize = true;
            ultimo_label.Location = new Point(48, 277);
            ultimo_label.Name = "ultimo_label";
            ultimo_label.Size = new Size(38, 15);
            ultimo_label.TabIndex = 3;
            ultimo_label.Text = "label1";
            // 
            // numero
            // 
            numero.Location = new Point(44, 34);
            numero.Name = "numero";
            numero.Size = new Size(100, 23);
            numero.TabIndex = 4;
            numero.Enter += numero_Enter;
            // 
            // button1
            // 
            button1.Location = new Point(61, 371);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Go";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(numero);
            Controls.Add(ultimo_label);
            Controls.Add(primeiro_label);
            Controls.Add(haNegativos_label);
            Controls.Add(listBox1);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label haNegativos_label;
        private Label primeiro_label;
        private Label ultimo_label;
        private TextBox numero;
        private Button button1;
    }
}