namespace sigma
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
            dateTimePicker_sigma = new DateTimePicker();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // dateTimePicker_sigma
            // 
            dateTimePicker_sigma.CustomFormat = "";
            dateTimePicker_sigma.Location = new Point(175, 29);
            dateTimePicker_sigma.Name = "dateTimePicker_sigma";
            dateTimePicker_sigma.Size = new Size(200, 23);
            dateTimePicker_sigma.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(47, 35);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 1;
            label1.Text = "Podaj swoje urodziny:";
            // 
            // button1
            // 
            button1.Location = new Point(116, 70);
            button1.Name = "button1";
            button1.Size = new Size(190, 23);
            button1.TabIndex = 2;
            button1.Text = "Sprawdź czy jesteś sigmą";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 142);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dateTimePicker_sigma);
            Name = "Form1";
            Text = "Urodziny sigma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker_sigma;
        private Label label1;
        private Button button1;
    }
}
