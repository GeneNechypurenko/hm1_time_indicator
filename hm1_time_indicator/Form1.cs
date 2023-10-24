namespace hm1_time_indicator
{
    public partial class Form1 : Form
    {

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private void UpdateTimeInterval()
        {
            int timeInterval = (int)numericUpDown_Periodic.Value;
            timer.Interval = timeInterval * 1000;
        }
        public Form1()
        {
            InitializeComponent();

            UpdateTimeInterval();

            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void numericUpDown_Periodic_ValueChanged(object sender, EventArgs e)
        {
            UpdateTimeInterval();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;

            if (radioButton_12HourFormat.Checked)
            {
                textBox_TimeDisplay.Text = currentTime.ToString("h:mm:ss tt");
            }
            else if (radioButton_24HoursFormat.Checked)
            {
                textBox_TimeDisplay.Text = currentTime.ToLongTimeString();
            }
        }
        private void radioButton_12HourFormat_CheckedChanged(object sender, EventArgs e)
        {
            Timer_Tick(sender, e);
        }
        private void radioButton_24HoursFormat_CheckedChanged(object sender, EventArgs e)
        {
            Timer_Tick(sender, e);
        }

    }
}