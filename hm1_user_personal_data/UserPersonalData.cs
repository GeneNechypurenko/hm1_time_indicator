namespace hm1_user_personal_data
{
    public partial class UserPersonalData : Form
    {
        List<User> users = new List<User>();
        public UserPersonalData()
        {
            InitializeComponent();
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            string name = maskedTextBox_UserName.Text;
            int age = (int)numericUpDown_UserAge.Value;
            decimal weight = numericUpDown_UserWeight.Value;
            string country = comboBox_CountrySelection.Text;

            User user = new User()
            {
                Name = name,
                Age = age,
                Weight = weight,
                Country = country
            };

            users.Add(user);
            listBox_UserList.Items.Add(user.ToString());

            maskedTextBox_UserName.Clear();
            numericUpDown_UserAge.Value = numericUpDown_UserAge.Minimum;
            numericUpDown_UserWeight.Value = numericUpDown_UserWeight.Minimum;
            comboBox_CountrySelection.SelectedIndex = -1;
        }
    }
}