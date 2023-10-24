namespace hm1_time_indicator
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
            groupBox_TimeFormat = new GroupBox();
            radioButton_24HoursFormat = new RadioButton();
            radioButton_12HourFormat = new RadioButton();
            groupBox_Periodic = new GroupBox();
            label_Periodic = new Label();
            textBox_TimeDisplay = new TextBox();
            numericUpDown_Periodic = new NumericUpDown();
            groupBox_TimeFormat.SuspendLayout();
            groupBox_Periodic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Periodic).BeginInit();
            SuspendLayout();
            // 
            // groupBox_TimeFormat
            // 
            groupBox_TimeFormat.Controls.Add(radioButton_24HoursFormat);
            groupBox_TimeFormat.Controls.Add(radioButton_12HourFormat);
            groupBox_TimeFormat.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox_TimeFormat.Location = new Point(242, 21);
            groupBox_TimeFormat.Name = "groupBox_TimeFormat";
            groupBox_TimeFormat.Size = new Size(126, 124);
            groupBox_TimeFormat.TabIndex = 2;
            groupBox_TimeFormat.TabStop = false;
            groupBox_TimeFormat.Text = "Time Format:";
            // 
            // radioButton_24HoursFormat
            // 
            radioButton_24HoursFormat.AutoSize = true;
            radioButton_24HoursFormat.Location = new Point(6, 76);
            radioButton_24HoursFormat.Name = "radioButton_24HoursFormat";
            radioButton_24HoursFormat.Size = new Size(46, 23);
            radioButton_24HoursFormat.TabIndex = 1;
            radioButton_24HoursFormat.TabStop = true;
            radioButton_24HoursFormat.Text = "24";
            radioButton_24HoursFormat.UseVisualStyleBackColor = true;
            // 
            // radioButton_12HourFormat
            // 
            radioButton_12HourFormat.AutoSize = true;
            radioButton_12HourFormat.Location = new Point(6, 33);
            radioButton_12HourFormat.Name = "radioButton_12HourFormat";
            radioButton_12HourFormat.Size = new Size(44, 23);
            radioButton_12HourFormat.TabIndex = 0;
            radioButton_12HourFormat.TabStop = true;
            radioButton_12HourFormat.Text = "12";
            radioButton_12HourFormat.UseVisualStyleBackColor = true;
            // 
            // groupBox_Periodic
            // 
            groupBox_Periodic.Controls.Add(label_Periodic);
            groupBox_Periodic.Controls.Add(textBox_TimeDisplay);
            groupBox_Periodic.Controls.Add(numericUpDown_Periodic);
            groupBox_Periodic.Location = new Point(26, 21);
            groupBox_Periodic.Name = "groupBox_Periodic";
            groupBox_Periodic.Size = new Size(210, 124);
            groupBox_Periodic.TabIndex = 3;
            groupBox_Periodic.TabStop = false;
            // 
            // label_Periodic
            // 
            label_Periodic.AutoSize = true;
            label_Periodic.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label_Periodic.Location = new Point(6, 40);
            label_Periodic.Name = "label_Periodic";
            label_Periodic.Size = new Size(112, 19);
            label_Periodic.TabIndex = 2;
            label_Periodic.Text = "Переодичность:";
            // 
            // textBox_TimeDisplay
            // 
            textBox_TimeDisplay.BackColor = SystemColors.Info;
            textBox_TimeDisplay.Enabled = false;
            textBox_TimeDisplay.Location = new Point(6, 76);
            textBox_TimeDisplay.Name = "textBox_TimeDisplay";
            textBox_TimeDisplay.Size = new Size(191, 27);
            textBox_TimeDisplay.TabIndex = 1;
            textBox_TimeDisplay.TextAlign = HorizontalAlignment.Center;
            // 
            // numericUpDown_Periodic
            // 
            numericUpDown_Periodic.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown_Periodic.Location = new Point(136, 36);
            numericUpDown_Periodic.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_Periodic.Name = "numericUpDown_Periodic";
            numericUpDown_Periodic.Size = new Size(61, 27);
            numericUpDown_Periodic.TabIndex = 0;
            numericUpDown_Periodic.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_Periodic.ValueChanged += numericUpDown_Periodic_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 165);
            Controls.Add(groupBox_Periodic);
            Controls.Add(groupBox_TimeFormat);
            Name = "Form1";
            Text = "Time Indicator";
            groupBox_TimeFormat.ResumeLayout(false);
            groupBox_TimeFormat.PerformLayout();
            groupBox_Periodic.ResumeLayout(false);
            groupBox_Periodic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Periodic).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox_TimeFormat;
        private GroupBox groupBox_Periodic;
        private NumericUpDown numericUpDown_Periodic;
        private RadioButton radioButton_24HoursFormat;
        private RadioButton radioButton_12HourFormat;
        private Label label_Periodic;
        private TextBox textBox_TimeDisplay;
    }
}