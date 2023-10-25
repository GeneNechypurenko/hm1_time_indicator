using System;
using System.Runtime.CompilerServices;

namespace hm1_miner
{
    public partial class Miner : Form
    {
        MineField mineField;
        public Miner()
        {
            InitializeComponent();
            mineField = new MineField();
            button1.Click += button_Click1;
            button2.Click += button_Click2;
            button3.Click += button_Click3;
            button4.Click += button_Click4;
            button5.Click += button_Click5;
            button6.Click += button_Click6;
            button7.Click += button_Click7;
            button8.Click += button_Click8;
            button9.Click += button_Click9;
        }
        private void button_Click1(object sender, EventArgs e)
        {
            if (mineField[0, 0])
            {
                button1.Text = "X";
                this.BackColor = Color.Red;
                MessageBox.Show("BOOM! GETREKT!");
            }
            else
            {
                int mineCount = 0;

                if (mineField[0, 1]) { mineCount++; }
                if (mineField[1, 0]) { mineCount++; }

                if (mineCount == 0) { button1.Text = "0"; }
                else if (mineCount == 1) { button1.Text = "1"; }
                else if (mineCount == 2) { button1.Text = "2"; }
                else if (mineCount == 3) { button1.Text = "3"; }
            }
        }

        private void button_Click2(object sender, EventArgs e)
        {
            if (mineField[0, 1])
            {
                button2.Text = "X";
                this.BackColor = Color.Red;
                MessageBox.Show("BOOM! GETREKT!");
            }
            else
            {
                int mineCount = 0;

                if (mineField[0, 0]) { mineCount++; }
                if (mineField[1, 1]) { mineCount++; }
                if (mineField[0, 2]) { mineCount++; }

                if (mineCount == 0) { button2.Text = "0"; }
                else if (mineCount == 1) { button2.Text = "1"; }
                else if (mineCount == 2) { button2.Text = "2"; }
                else if (mineCount == 3) { button2.Text = "3"; }
            }
        }

        private void button_Click3(object sender, EventArgs e)
        {
            if (mineField[0, 2])
            {
                button3.Text = "X";
                this.BackColor = Color.Red;
                MessageBox.Show("BOOM! GETREKT!");
            }
            else
            {
                int mineCount = 0;

                if (mineField[0, 1]) { mineCount++; }
                if (mineField[1, 2]) { mineCount++; }

                if (mineCount == 0) { button3.Text = "0"; }
                else if (mineCount == 1) { button3.Text = "1"; }
                else if (mineCount == 2) { button3.Text = "2"; }
                else if (mineCount == 3) { button3.Text = "3"; }
            }
        }

        private void button_Click4(object sender, EventArgs e)
        {
            if (mineField[1, 0])
            {
                button4.Text = "X";
                this.BackColor = Color.Red;
                MessageBox.Show("BOOM! GETREKT!");
            }
            else
            {
                int mineCount = 0;

                if (mineField[0, 0]) { mineCount++; }
                if (mineField[1, 1]) { mineCount++; }
                if (mineField[2, 0]) { mineCount++; }

                if (mineCount == 0) { button4.Text = "0"; }
                else if (mineCount == 1) { button4.Text = "1"; }
                else if (mineCount == 2) { button4.Text = "2"; }
                else if (mineCount == 3) { button4.Text = "3"; }
            }
        }

        private void button_Click5(object sender, EventArgs e)
        {
            if (mineField[1, 1])
            {
                button5.Text = "X";
                this.BackColor = Color.Red;
                MessageBox.Show("BOOM! GETREKT!");
            }
            else
            {
                int mineCount = 0;

                if (mineField[1, 0]) { mineCount++; }
                if (mineField[0, 1]) { mineCount++; }
                if (mineField[2, 1]) { mineCount++; }
                if (mineField[1, 2]) { mineCount++; }

                if (mineCount == 0) { button5.Text = "0"; }
                else if (mineCount == 1) { button5.Text = "1"; }
                else if (mineCount == 2) { button5.Text = "2"; }
                else if (mineCount == 3) { button5.Text = "3"; }
            }
        }

        private void button_Click6(object sender, EventArgs e)
        {
            if (mineField[1, 2])
            {
                button6.Text = "X";
                this.BackColor = Color.Red;
                MessageBox.Show("BOOM! GETREKT!");
            }
            else
            {
                int mineCount = 0;

                if (mineField[0, 2]) { mineCount++; }
                if (mineField[2, 1]) { mineCount++; }
                if (mineField[2, 2]) { mineCount++; }

                if (mineCount == 0) { button6.Text = "0"; }
                else if (mineCount == 1) { button6.Text = "1"; }
                else if (mineCount == 2) { button6.Text = "2"; }
                else if (mineCount == 3) { button6.Text = "3"; }
            }
        }

        private void button_Click7(object sender, EventArgs e)
        {
            if (mineField[2, 0])
            {
                button7.Text = "X";
                this.BackColor = Color.Red;
                MessageBox.Show("BOOM! GETREKT!");
            }
            else
            {
                int mineCount = 0;

                if (mineField[1, 0]) { mineCount++; }
                if (mineField[2, 1]) { mineCount++; }

                if (mineCount == 0) { button7.Text = "0"; }
                else if (mineCount == 1) { button7.Text = "1"; }
                else if (mineCount == 2) { button7.Text = "2"; }
                else if (mineCount == 3) { button7.Text = "3"; }
            }
        }

        private void button_Click8(object sender, EventArgs e)
        {
            if (mineField[2, 1])
            {
                button8.Text = "X";
                this.BackColor = Color.Red;
                MessageBox.Show("BOOM! GETREKT!");
            }
            else
            {
                int mineCount = 0;

                if (mineField[2, 0]) { mineCount++; }
                if (mineField[1, 1]) { mineCount++; }
                if (mineField[2, 2]) { mineCount++; }

                if (mineCount == 0) { button8.Text = "0"; }
                else if (mineCount == 1) { button8.Text = "1"; }
                else if (mineCount == 2) { button8.Text = "2"; }
                else if (mineCount == 3) { button8.Text = "3"; }
            }
        }

        private void button_Click9(object sender, EventArgs e)
        {
            if (mineField[2, 2])
            {
                button9.Text = "X";
                this.BackColor = Color.Red;
                MessageBox.Show("BOOM! GETREKT!");
            }
            else
            {
                int mineCount = 0;

                if (mineField[2, 1]) { mineCount++; }
                if (mineField[1, 2]) { mineCount++; }

                if (mineCount == 0) { button9.Text = "0"; }
                else if (mineCount == 1) { button9.Text = "1"; }
                else if (mineCount == 2) { button9.Text = "2"; }
                else if (mineCount == 3) { button9.Text = "3"; }
            }
        }
    }
}