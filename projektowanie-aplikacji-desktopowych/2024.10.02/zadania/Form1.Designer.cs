namespace zadania
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = SystemColors.ButtonShadow;
            radioButton1.Enabled = false;
            radioButton1.ForeColor = SystemColors.ControlLightLight;
            radioButton1.Location = new Point(297, 54);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(144, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Sortowanie Bąbelkowe";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = SystemColors.ButtonShadow;
            radioButton2.Enabled = false;
            radioButton2.ForeColor = SystemColors.ControlLightLight;
            radioButton2.Location = new Point(297, 79);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(174, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Sortowanie QuickSort Hoare";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.BackColor = SystemColors.ButtonShadow;
            radioButton3.Enabled = false;
            radioButton3.ForeColor = SystemColors.ControlLightLight;
            radioButton3.Location = new Point(297, 104);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(184, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Sortowanie QuickSort Lomuto";
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(351, 144);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Sortuj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(140, 120);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Losuj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 80);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 6;
            label1.Text = "Podaj ilosc liczb w liscie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(34, 270);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 7;
            label2.Text = "Lista to:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Location = new Point(249, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(273, 186);
            panel1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 363);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Sortowanie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
    }
}
