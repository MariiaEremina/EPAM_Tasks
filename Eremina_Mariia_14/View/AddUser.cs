using LogicLayer;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class AddUser : Form
    {

        public DateTime BirthDate { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public List<Reward> ResultRewards { get; private set; }
        public List<Reward> rewards;
        public List<Control> controls = new List<Control>();
        public bool edit = false;
        string pat = @"^(\b((?i)[a-z]+)\b)|(\b((?i)[а-я]+)\b)$";

        public Logic pLogic;

        public AddUser(Logic logic)
        {
            InitializeComponent();

            rewards = logic.GetRewards();

            foreach (Reward rew in rewards)
            {
                checkedRewards.Items.Add(rew.Title, false);
            }
        }


        public AddUser(Logic logic, User user)
        {
            InitializeComponent();
            rewards = logic.GetRewards();
            FirstName = user.FirstName;
            LastName = user.LastName;
            BirthDate = user.Birthdate;
            ResultRewards = user.reward;
            edit = true;
            foreach (Reward rew in rewards)
            {
                checkedRewards.Items.Add(rew.Title, user.reward.Exists(r => r.ID == rew.ID));
            }
        }



        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = this.ValidateChildren() ? DialogResult.OK : DialogResult.None;

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void firstName_Validating(object sender, CancelEventArgs e)
        {
            string input = firstName.Text.Trim();

            if (String.IsNullOrEmpty(input))
            {
                errorProvider.SetError(firstName, "Empty string!");
                e.Cancel = true;
            }
            else
            {
                Match m = Regex.Match(input, pat);
                if (m.Success)
                {
                    errorProvider.SetError(firstName, String.Empty);
                    e.Cancel = false;
                }
                else
                {
                    errorProvider.SetError(firstName, "Incorrect!");
                    e.Cancel = true;
                }
            }
        }

        private void lastName_Validating(object sender, CancelEventArgs e)
        {
            string input = lastName.Text.Trim();

            if (String.IsNullOrEmpty(input))
            {
                errorProvider.SetError(lastName, "Empty string!");
                e.Cancel = true;
            }
            else
            {
                Match m = Regex.Match(input, pat);
                if (m.Success)
                {
                    errorProvider.SetError(lastName, String.Empty);
                    e.Cancel = false;
                }
                else
                {
                    errorProvider.SetError(lastName, "Incorrect!");
                    e.Cancel = true;
                }
            }
        }

        private void firstName_Validated(object sender, EventArgs e)
        {
            string workString = firstName.Text.Trim();
            FirstName = workString;
        }

        private void lastName_Validated(object sender, EventArgs e)
        {
            string workString = lastName.Text.Trim();
            foreach (Char ch in workString)
            {
                Char.ToLower(ch);
            }
            Char.ToUpper(workString[0]);
            LastName = workString;
        }

        private void dateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            DateTime input = dateTimePicker.Value;
            int i = input.CompareTo(DateTime.Now);
            int number = DateTime.Now.Year - input.Year;
            if (!(i < 0 && number < 150 && number > 14))
            {
                errorProvider.SetError(dateTimePicker, "Некорректное значение!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(dateTimePicker, String.Empty);
                e.Cancel = false;
            }
        }

        private void dateTimePicker_Validated(object sender, EventArgs e)
        {
            BirthDate = dateTimePicker.Value.Date;
        }

        private void checkedRewards_Validated(object sender, EventArgs e)
        {
            ResultRewards = new List<Reward>();


            for (int i = 0; i < rewards.Count; i++)
            {
                if (checkedRewards.GetItemChecked(i))
                {
                    ResultRewards.Add(rewards[i]);
                }
            }

        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            if (edit)
            {
                firstName.Text = FirstName;
                lastName.Text = LastName;
                dateTimePicker.Value = BirthDate;
            }
        }
    }
}
