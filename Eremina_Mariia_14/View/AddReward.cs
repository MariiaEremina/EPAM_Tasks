using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class AddReward : Form
    {

        public string Title { get; private set; }
        public string Description { get; private set; }

        public AddReward()
        {
            InitializeComponent();
        }

        public AddReward(Reward reward)
        {
            InitializeComponent();
            Title = reward.Title;
            Description = reward.Description;
            tbTitle.Text = Title;
            tbDescription.Text = Description;
        }

        private void tbTitle_Validated(object sender, EventArgs e)
        {
            Title = tbTitle.Text.Trim();
        }

        private void tbTitle_Validating(object sender, CancelEventArgs e)
        {
            string input = tbTitle.Text.Trim();

            if (String.IsNullOrEmpty(input))
            {
                errorProvider.SetError(tbTitle, "Некорректное значение!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tbTitle, String.Empty);
                e.Cancel = false;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            DialogResult = this.ValidateChildren() ? DialogResult.OK : DialogResult.None;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbDescription_Validating(object sender, CancelEventArgs e)
        {
            string input = tbTitle.Text.Trim();

            if (input.Length > 250)
            {
                errorProvider.SetError(tbTitle, "Слишком длинное описание!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(tbTitle, String.Empty);
                e.Cancel = false;
            }
        }

        private void tbDescription_Validated(object sender, EventArgs e)
        {
            Description = tbDescription.Text.Trim();
        }
    }
}
