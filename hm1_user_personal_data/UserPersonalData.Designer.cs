namespace hm1_user_personal_data
{
    partial class UserPersonalData
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
            maskedTextBox_UserName = new MaskedTextBox();
            label_UserName = new Label();
            groupBox_UserWeight = new GroupBox();
            numericUpDown_UserWeight = new NumericUpDown();
            groupBox_UserAge = new GroupBox();
            numericUpDown_UserAge = new NumericUpDown();
            comboBox_CountrySelection = new ComboBox();
            listBox_UserList = new ListBox();
            button_Confirm = new Button();
            groupBox_UserWeight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_UserWeight).BeginInit();
            groupBox_UserAge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_UserAge).BeginInit();
            SuspendLayout();
            // 
            // maskedTextBox_UserName
            // 
            maskedTextBox_UserName.Location = new Point(72, 33);
            maskedTextBox_UserName.Name = "maskedTextBox_UserName";
            maskedTextBox_UserName.Size = new Size(164, 27);
            maskedTextBox_UserName.TabIndex = 0;
            // 
            // label_UserName
            // 
            label_UserName.AutoSize = true;
            label_UserName.Location = new Point(15, 35);
            label_UserName.Name = "label_UserName";
            label_UserName.Size = new Size(55, 20);
            label_UserName.TabIndex = 1;
            label_UserName.Text = "Name:";
            // 
            // groupBox_UserWeight
            // 
            groupBox_UserWeight.Controls.Add(numericUpDown_UserWeight);
            groupBox_UserWeight.Location = new Point(127, 109);
            groupBox_UserWeight.Name = "groupBox_UserWeight";
            groupBox_UserWeight.Size = new Size(109, 74);
            groupBox_UserWeight.TabIndex = 2;
            groupBox_UserWeight.TabStop = false;
            groupBox_UserWeight.Text = "Weight:";
            // 
            // numericUpDown_UserWeight
            // 
            numericUpDown_UserWeight.Location = new Point(6, 26);
            numericUpDown_UserWeight.Name = "numericUpDown_UserWeight";
            numericUpDown_UserWeight.Size = new Size(97, 27);
            numericUpDown_UserWeight.TabIndex = 1;
            // 
            // groupBox_UserAge
            // 
            groupBox_UserAge.Controls.Add(numericUpDown_UserAge);
            groupBox_UserAge.Location = new Point(12, 109);
            groupBox_UserAge.Name = "groupBox_UserAge";
            groupBox_UserAge.Size = new Size(109, 74);
            groupBox_UserAge.TabIndex = 3;
            groupBox_UserAge.TabStop = false;
            groupBox_UserAge.Text = "Age:";
            // 
            // numericUpDown_UserAge
            // 
            numericUpDown_UserAge.Location = new Point(6, 26);
            numericUpDown_UserAge.Name = "numericUpDown_UserAge";
            numericUpDown_UserAge.Size = new Size(97, 27);
            numericUpDown_UserAge.TabIndex = 0;
            // 
            // comboBox_CountrySelection
            // 
            comboBox_CountrySelection.FormattingEnabled = true;
            comboBox_CountrySelection.Items.AddRange(new object[] { "Ukraine", "USA", "United Kingdom", "Poland", "Germany", "France", "Moldova", "Romain", "Bulgaria", "Finland", "Norway", "Sweden", "Denmark", "Switzerland", "Spain", "Portugal", "Macedonia", "Croatia", "Austria", "Australia", "Canada", "Albania", "Andora", "Italy" });
            comboBox_CountrySelection.Location = new Point(12, 75);
            comboBox_CountrySelection.Name = "comboBox_CountrySelection";
            comboBox_CountrySelection.Size = new Size(224, 28);
            comboBox_CountrySelection.TabIndex = 4;
            comboBox_CountrySelection.Text = "select country";
            // 
            // listBox_UserList
            // 
            listBox_UserList.FormattingEnabled = true;
            listBox_UserList.ItemHeight = 20;
            listBox_UserList.Location = new Point(250, 29);
            listBox_UserList.Name = "listBox_UserList";
            listBox_UserList.Size = new Size(194, 204);
            listBox_UserList.TabIndex = 5;
            // 
            // button_Confirm
            // 
            button_Confirm.Location = new Point(72, 193);
            button_Confirm.Name = "button_Confirm";
            button_Confirm.Size = new Size(94, 45);
            button_Confirm.TabIndex = 6;
            button_Confirm.Text = "Confirm";
            button_Confirm.UseVisualStyleBackColor = true;
            button_Confirm.Click += button_Confirm_Click;
            // 
            // UserPersonalData
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 259);
            Controls.Add(button_Confirm);
            Controls.Add(listBox_UserList);
            Controls.Add(comboBox_CountrySelection);
            Controls.Add(groupBox_UserAge);
            Controls.Add(groupBox_UserWeight);
            Controls.Add(label_UserName);
            Controls.Add(maskedTextBox_UserName);
            Name = "UserPersonalData";
            Text = "User Personal Data";
            groupBox_UserWeight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown_UserWeight).EndInit();
            groupBox_UserAge.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown_UserAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBox_UserName;
        private Label label_UserName;
        private GroupBox groupBox_UserWeight;
        private NumericUpDown numericUpDown_UserWeight;
        private GroupBox groupBox_UserAge;
        private NumericUpDown numericUpDown_UserAge;
        private ComboBox comboBox_CountrySelection;
        private ListBox listBox_UserList;
        private Button button_Confirm;
    }
}