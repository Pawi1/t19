namespace todo
{
    partial class DisplayList
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
            button_return = new Button();
            label1 = new Label();
            dataGrid_list = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGrid_list).BeginInit();
            SuspendLayout();
            // 
            // button_return
            // 
            button_return.Location = new Point(26, 404);
            button_return.Name = "button_return";
            button_return.Size = new Size(75, 23);
            button_return.TabIndex = 1;
            button_return.Text = "Powrót";
            button_return.UseVisualStyleBackColor = true;
            button_return.Click += Button_return_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 26);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 2;
            label1.Text = "Lista osób:";
            // 
            // dataGrid_list
            // 
            dataGrid_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_list.Location = new Point(38, 70);
            dataGrid_list.Name = "dataGrid_list";
            dataGrid_list.Size = new Size(547, 258);
            dataGrid_list.TabIndex = 3;
            // 
            // DisplayList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 450);
            Controls.Add(dataGrid_list);
            Controls.Add(label1);
            Controls.Add(button_return);
            Name = "DisplayList";
            Text = "Todo 2 - Wyświetl liste osób";
            ((System.ComponentModel.ISupportInitialize)dataGrid_list).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_return;
        private Label label1;
        private DataGridView dataGrid_list;
    }
}