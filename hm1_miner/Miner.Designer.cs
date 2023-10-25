namespace hm1_miner
{
    partial class Miner
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            groupBox_Minefield = new GroupBox();
            groupBox_Minefield.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(27, 34);
            button1.Name = "button1";
            button1.Size = new Size(30, 29);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Click1;
            // 
            // button2
            // 
            button2.Location = new Point(63, 34);
            button2.Name = "button2";
            button2.Size = new Size(30, 29);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_Click2;
            // 
            // button3
            // 
            button3.Location = new Point(99, 34);
            button3.Name = "button3";
            button3.Size = new Size(30, 29);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_Click3;
            // 
            // button4
            // 
            button4.Location = new Point(27, 69);
            button4.Name = "button4";
            button4.Size = new Size(30, 29);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_Click4;
            // 
            // button5
            // 
            button5.Location = new Point(63, 69);
            button5.Name = "button5";
            button5.Size = new Size(30, 29);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_Click5;
            // 
            // button6
            // 
            button6.Location = new Point(99, 69);
            button6.Name = "button6";
            button6.Size = new Size(30, 29);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_Click6;
            // 
            // button7
            // 
            button7.Location = new Point(27, 104);
            button7.Name = "button7";
            button7.Size = new Size(30, 29);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_Click7;
            // 
            // button8
            // 
            button8.Location = new Point(63, 104);
            button8.Name = "button8";
            button8.Size = new Size(30, 29);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_Click8;
            // 
            // button9
            // 
            button9.Location = new Point(99, 104);
            button9.Name = "button9";
            button9.Size = new Size(30, 29);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_Click9;
            // 
            // groupBox_Minefield
            // 
            groupBox_Minefield.Controls.Add(button9);
            groupBox_Minefield.Controls.Add(button8);
            groupBox_Minefield.Controls.Add(button7);
            groupBox_Minefield.Controls.Add(button6);
            groupBox_Minefield.Controls.Add(button5);
            groupBox_Minefield.Controls.Add(button4);
            groupBox_Minefield.Controls.Add(button3);
            groupBox_Minefield.Controls.Add(button2);
            groupBox_Minefield.Controls.Add(button1);
            groupBox_Minefield.Location = new Point(65, 82);
            groupBox_Minefield.Name = "groupBox_Minefield";
            groupBox_Minefield.Size = new Size(156, 175);
            groupBox_Minefield.TabIndex = 9;
            groupBox_Minefield.TabStop = false;
            groupBox_Minefield.Text = "Minefield";
            // 
            // Miner
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 329);
            Controls.Add(groupBox_Minefield);
            Name = "Miner";
            Text = "Miner";
            groupBox_Minefield.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private GroupBox groupBox_Minefield;
    }
}