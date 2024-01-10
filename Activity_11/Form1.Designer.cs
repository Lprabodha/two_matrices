namespace Activity_11
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            textInput01 = new TextBox();
            textInput02 = new TextBox();
            btnInsert1 = new Button();
            btnInsert2 = new Button();
            listBoxResult01 = new ListBox();
            listBoxResult02 = new ListBox();
            listBoxResult03 = new ListBox();
            button4 = new Button();
            btnClear_Click = new Button();
            SuspendLayout();
            // 
            // textInput01
            // 
            textInput01.Location = new Point(3, 3);
            textInput01.Name = "textInput01";
            textInput01.Size = new Size(190, 23);
            textInput01.TabIndex = 0;
            textInput01.KeyPress += textInput01_KeyPress;
            // 
            // textInput02
            // 
            textInput02.Location = new Point(193, 2);
            textInput02.Name = "textInput02";
            textInput02.Size = new Size(190, 23);
            textInput02.TabIndex = 1;
            textInput02.KeyPress += textInput02_KeyPress;
            // 
            // btnInsert1
            // 
            btnInsert1.Location = new Point(1, 25);
            btnInsert1.Name = "btnInsert1";
            btnInsert1.Size = new Size(195, 28);
            btnInsert1.TabIndex = 3;
            btnInsert1.Text = "Add";
            btnInsert1.UseVisualStyleBackColor = true;
            btnInsert1.Click += btnInsert1_Click;
            // 
            // btnInsert2
            // 
            btnInsert2.Location = new Point(191, 26);
            btnInsert2.Name = "btnInsert2";
            btnInsert2.Size = new Size(195, 28);
            btnInsert2.TabIndex = 4;
            btnInsert2.Text = "Add";
            btnInsert2.UseVisualStyleBackColor = true;
            btnInsert2.Click += btnInsert2_Click;
            // 
            // listBoxResult01
            // 
            listBoxResult01.FormattingEnabled = true;
            listBoxResult01.ItemHeight = 15;
            listBoxResult01.Location = new Point(4, 54);
            listBoxResult01.Name = "listBoxResult01";
            listBoxResult01.Size = new Size(188, 244);
            listBoxResult01.TabIndex = 6;
            // 
            // listBoxResult02
            // 
            listBoxResult02.FormattingEnabled = true;
            listBoxResult02.ItemHeight = 15;
            listBoxResult02.Location = new Point(193, 54);
            listBoxResult02.Name = "listBoxResult02";
            listBoxResult02.Size = new Size(188, 244);
            listBoxResult02.TabIndex = 7;
            // 
            // listBoxResult03
            // 
            listBoxResult03.FormattingEnabled = true;
            listBoxResult03.ItemHeight = 15;
            listBoxResult03.Location = new Point(383, 54);
            listBoxResult03.Name = "listBoxResult03";
            listBoxResult03.Size = new Size(188, 244);
            listBoxResult03.TabIndex = 8;
            // 
            // button4
            // 
            button4.Location = new Point(382, 25);
            button4.Name = "button4";
            button4.Size = new Size(195, 28);
            button4.TabIndex = 9;
            button4.Text = "Display";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnDisplay_Click;
            // 
            // btnClear_Click
            // 
            btnClear_Click.Location = new Point(383, -2);
            btnClear_Click.Name = "btnClear_Click";
            btnClear_Click.Size = new Size(195, 28);
            btnClear_Click.TabIndex = 10;
            btnClear_Click.Text = "Clear";
            btnClear_Click.UseVisualStyleBackColor = true;
            btnClear_Click.Click += clear_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 301);
            Controls.Add(btnClear_Click);
            Controls.Add(button4);
            Controls.Add(listBoxResult03);
            Controls.Add(listBoxResult02);
            Controls.Add(listBoxResult01);
            Controls.Add(btnInsert2);
            Controls.Add(btnInsert1);
            Controls.Add(textInput02);
            Controls.Add(textInput01);
            Name = "Form1";
            Text = "Activity11";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox textInput01;
        private TextBox textInput02;
        private Button btnInsert1;
        private Button btnInsert2;
        private ListBox listBoxResult01;
        private ListBox listBoxResult02;
        private ListBox listBoxResult03;
        private Button button4;
        private Button btnClear_Click;
    }
}
