namespace todo
{
    partial class Main
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
            textbox_name = new TextBox();
            textarena_aboutMe = new RichTextBox();
            radiobutton_men = new RadioButton();
            radiobutton_women = new RadioButton();
            radiobutton_other = new RadioButton();
            button_save = new Button();
            button_close = new Button();
            button_displayList = new Button();
            label_warning = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textbox_name
            // 
            textbox_name.Location = new Point(167, 25);
            textbox_name.Name = "textbox_name";
            textbox_name.Size = new Size(100, 23);
            textbox_name.TabIndex = 0;
            // 
            // textarena_aboutMe
            // 
            textarena_aboutMe.Location = new Point(64, 177);
            textarena_aboutMe.Name = "textarena_aboutMe";
            textarena_aboutMe.Size = new Size(312, 96);
            textarena_aboutMe.TabIndex = 1;
            textarena_aboutMe.Text = "";
            // 
            // radiobutton_men
            // 
            radiobutton_men.AutoSize = true;
            radiobutton_men.Location = new Point(167, 60);
            radiobutton_men.Name = "radiobutton_men";
            radiobutton_men.Size = new Size(82, 19);
            radiobutton_men.TabIndex = 2;
            radiobutton_men.TabStop = true;
            radiobutton_men.Text = "Mężczyzna";
            radiobutton_men.UseVisualStyleBackColor = true;
            // 
            // radiobutton_women
            // 
            radiobutton_women.AutoSize = true;
            radiobutton_women.Location = new Point(167, 85);
            radiobutton_women.Name = "radiobutton_women";
            radiobutton_women.Size = new Size(65, 19);
            radiobutton_women.TabIndex = 3;
            radiobutton_women.TabStop = true;
            radiobutton_women.Text = "Kobieta";
            radiobutton_women.UseVisualStyleBackColor = true;
            // 
            // radiobutton_other
            // 
            radiobutton_other.AutoSize = true;
            radiobutton_other.Location = new Point(167, 110);
            radiobutton_other.Name = "radiobutton_other";
            radiobutton_other.Size = new Size(156, 19);
            radiobutton_other.TabIndex = 4;
            radiobutton_other.TabStop = true;
            radiobutton_other.Text = "Inne / Wole nie podawać";
            radiobutton_other.UseVisualStyleBackColor = true;
            // 
            // button_save
            // 
            button_save.Location = new Point(133, 290);
            button_save.Name = "button_save";
            button_save.Size = new Size(75, 23);
            button_save.TabIndex = 5;
            button_save.Text = "Zapisz";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += Save_Click;
            // 
            // button_close
            // 
            button_close.Location = new Point(214, 290);
            button_close.Name = "button_close";
            button_close.Size = new Size(75, 23);
            button_close.TabIndex = 6;
            button_close.Text = "Zamknij";
            button_close.UseVisualStyleBackColor = true;
            button_close.Click += Close_Click;
            // 
            // button_displayList
            // 
            button_displayList.Location = new Point(133, 330);
            button_displayList.Name = "button_displayList";
            button_displayList.Size = new Size(156, 23);
            button_displayList.TabIndex = 7;
            button_displayList.Text = "Wyświetl liste";
            button_displayList.UseVisualStyleBackColor = true;
            button_displayList.Click += DisplayList_Click;
            // 
            // label_warning
            // 
            label_warning.AutoSize = true;
            label_warning.Location = new Point(64, 380);
            label_warning.Name = "label_warning";
            label_warning.Size = new Size(0, 15);
            label_warning.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 25);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 9;
            label1.Text = "Imie:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 64);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 10;
            label2.Text = "Płeć";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 159);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 11;
            label3.Text = "O mnie:";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label_warning);
            Controls.Add(button_displayList);
            Controls.Add(button_close);
            Controls.Add(button_save);
            Controls.Add(radiobutton_other);
            Controls.Add(radiobutton_women);
            Controls.Add(radiobutton_men);
            Controls.Add(textarena_aboutMe);
            Controls.Add(textbox_name);
            Name = "Main";
            Text = "Todo 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textbox_name;
        private RichTextBox textarena_aboutMe;
        private RadioButton radiobutton_men;
        private RadioButton radiobutton_women;
        private RadioButton radiobutton_other;
        private Button button_save;
        private Button button_close;
        private Button button_displayList;
        private Label label_warning;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
