namespace HelloCSharpWin
{
    partial class Calculator
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
            NumButton1 = new Button();
            NumButton2 = new Button();
            NumScreen = new Label();
            NumPlus = new Button();
            NumButton7 = new Button();
            NumButton3 = new Button();
            NumButton8 = new Button();
            NumButton6 = new Button();
            NumButton5 = new Button();
            NumButton4 = new Button();
            NumButton9 = new Button();
            NumButton0 = new Button();
            button1 = new Button();
            NumClear = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // NumButton1
            // 
            NumButton1.BackColor = SystemColors.Info;
            NumButton1.Font = new Font("맑은 고딕", 12F);
            NumButton1.Location = new Point(73, 418);
            NumButton1.Name = "NumButton1";
            NumButton1.Size = new Size(88, 84);
            NumButton1.TabIndex = 0;
            NumButton1.Text = "1";
            NumButton1.UseVisualStyleBackColor = false;
            NumButton1.Click += NumButton1_Click;
            // 
            // NumButton2
            // 
            NumButton2.BackColor = SystemColors.Info;
            NumButton2.Font = new Font("맑은 고딕", 12F);
            NumButton2.Location = new Point(210, 418);
            NumButton2.Name = "NumButton2";
            NumButton2.Size = new Size(83, 84);
            NumButton2.TabIndex = 1;
            NumButton2.Text = "2";
            NumButton2.UseVisualStyleBackColor = false;
            NumButton2.Click += NumButton1_Click;
            // 
            // NumScreen
            // 
            NumScreen.BackColor = SystemColors.Window;
            NumScreen.BorderStyle = BorderStyle.Fixed3D;
            NumScreen.Font = new Font("맑은 고딕", 16F);
            NumScreen.Location = new Point(73, 41);
            NumScreen.Name = "NumScreen";
            NumScreen.Size = new Size(583, 81);
            NumScreen.TabIndex = 2;
            NumScreen.Text = "0";
            NumScreen.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NumPlus
            // 
            NumPlus.BackColor = SystemColors.ActiveCaption;
            NumPlus.Font = new Font("맑은 고딕", 14F);
            NumPlus.Location = new Point(474, 432);
            NumPlus.Name = "NumPlus";
            NumPlus.Size = new Size(182, 70);
            NumPlus.TabIndex = 3;
            NumPlus.Text = "+";
            NumPlus.UseVisualStyleBackColor = false;
            NumPlus.Click += NumPlus_Click;
            // 
            // NumButton7
            // 
            NumButton7.BackColor = SystemColors.Info;
            NumButton7.Font = new Font("맑은 고딕", 12F);
            NumButton7.Location = new Point(73, 199);
            NumButton7.Name = "NumButton7";
            NumButton7.Size = new Size(83, 84);
            NumButton7.TabIndex = 5;
            NumButton7.Text = "7";
            NumButton7.UseVisualStyleBackColor = false;
            NumButton7.Click += NumButton1_Click;
            // 
            // NumButton3
            // 
            NumButton3.BackColor = SystemColors.Info;
            NumButton3.Font = new Font("맑은 고딕", 12F);
            NumButton3.Location = new Point(339, 418);
            NumButton3.Name = "NumButton3";
            NumButton3.Size = new Size(88, 84);
            NumButton3.TabIndex = 4;
            NumButton3.Text = "3";
            NumButton3.UseVisualStyleBackColor = false;
            NumButton3.Click += NumButton1_Click;
            // 
            // NumButton8
            // 
            NumButton8.BackColor = SystemColors.Info;
            NumButton8.Font = new Font("맑은 고딕", 12F);
            NumButton8.Location = new Point(205, 199);
            NumButton8.Name = "NumButton8";
            NumButton8.Size = new Size(83, 84);
            NumButton8.TabIndex = 9;
            NumButton8.Text = "8";
            NumButton8.UseVisualStyleBackColor = false;
            NumButton8.Click += NumButton1_Click;
            // 
            // NumButton6
            // 
            NumButton6.BackColor = SystemColors.Info;
            NumButton6.Font = new Font("맑은 고딕", 12F);
            NumButton6.Location = new Point(339, 308);
            NumButton6.Name = "NumButton6";
            NumButton6.Size = new Size(88, 84);
            NumButton6.TabIndex = 8;
            NumButton6.Text = "6";
            NumButton6.UseVisualStyleBackColor = false;
            NumButton6.Click += NumButton1_Click;
            // 
            // NumButton5
            // 
            NumButton5.BackColor = SystemColors.Info;
            NumButton5.Font = new Font("맑은 고딕", 12F);
            NumButton5.Location = new Point(210, 308);
            NumButton5.Name = "NumButton5";
            NumButton5.Size = new Size(83, 84);
            NumButton5.TabIndex = 7;
            NumButton5.Text = "5";
            NumButton5.UseVisualStyleBackColor = false;
            NumButton5.Click += NumButton1_Click;
            // 
            // NumButton4
            // 
            NumButton4.BackColor = SystemColors.Info;
            NumButton4.Font = new Font("맑은 고딕", 12F);
            NumButton4.Location = new Point(73, 308);
            NumButton4.Name = "NumButton4";
            NumButton4.Size = new Size(88, 84);
            NumButton4.TabIndex = 6;
            NumButton4.Text = "4";
            NumButton4.UseVisualStyleBackColor = false;
            NumButton4.Click += NumButton1_Click;
            // 
            // NumButton9
            // 
            NumButton9.BackColor = SystemColors.Info;
            NumButton9.Font = new Font("맑은 고딕", 12F);
            NumButton9.Location = new Point(339, 199);
            NumButton9.Name = "NumButton9";
            NumButton9.Size = new Size(88, 84);
            NumButton9.TabIndex = 10;
            NumButton9.Text = "9";
            NumButton9.UseVisualStyleBackColor = false;
            NumButton9.Click += NumButton1_Click;
            // 
            // NumButton0
            // 
            NumButton0.BackColor = SystemColors.Info;
            NumButton0.Font = new Font("맑은 고딕", 12F);
            NumButton0.Location = new Point(210, 537);
            NumButton0.Name = "NumButton0";
            NumButton0.Size = new Size(83, 84);
            NumButton0.TabIndex = 12;
            NumButton0.Text = "0";
            NumButton0.UseVisualStyleBackColor = false;
            NumButton0.Click += NumButton1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("맑은 고딕", 14F);
            button1.Location = new Point(474, 356);
            button1.Name = "button1";
            button1.Size = new Size(182, 70);
            button1.TabIndex = 13;
            button1.Text = "-";
            button1.UseVisualStyleBackColor = false;
            button1.Click += NumPlus_Click;
            // 
            // NumClear
            // 
            NumClear.BackColor = SystemColors.ActiveCaption;
            NumClear.Font = new Font("맑은 고딕", 14F);
            NumClear.Location = new Point(339, 139);
            NumClear.Name = "NumClear";
            NumClear.Size = new Size(88, 42);
            NumClear.TabIndex = 14;
            NumClear.Text = "C";
            NumClear.UseVisualStyleBackColor = false;
            NumClear.Click += NumClear_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 128);
            button2.Font = new Font("맑은 고딕", 14F);
            button2.Location = new Point(474, 551);
            button2.Name = "button2";
            button2.Size = new Size(182, 70);
            button2.TabIndex = 15;
            button2.Text = "=";
            button2.UseVisualStyleBackColor = false;
            button2.Click += NumPlus_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("맑은 고딕", 14F);
            button3.Location = new Point(474, 280);
            button3.Name = "button3";
            button3.Size = new Size(182, 70);
            button3.TabIndex = 16;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += NumPlus_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Font = new Font("맑은 고딕", 14F);
            button4.Location = new Point(474, 204);
            button4.Name = "button4";
            button4.Size = new Size(182, 70);
            button4.TabIndex = 17;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = false;
            button4.Click += NumPlus_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 705);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(NumClear);
            Controls.Add(button1);
            Controls.Add(NumButton0);
            Controls.Add(NumButton9);
            Controls.Add(NumButton8);
            Controls.Add(NumButton6);
            Controls.Add(NumButton5);
            Controls.Add(NumButton4);
            Controls.Add(NumButton7);
            Controls.Add(NumButton3);
            Controls.Add(NumPlus);
            Controls.Add(NumScreen);
            Controls.Add(NumButton2);
            Controls.Add(NumButton1);
            Name = "Calculator";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button NumButton1;
        private Button NumButton2;
        private Label NumScreen;
        private Button NumPlus;
        private Button NumButton7;
        private Button NumButton3;
        private Button NumButton8;
        private Button NumButton6;
        private Button NumButton5;
        private Button NumButton4;
        private Button NumButton9;
        private Button NumButton0;
        private Button button1;
        private Button NumClear;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
