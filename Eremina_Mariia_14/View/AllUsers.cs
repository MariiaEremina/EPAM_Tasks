using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared;
using LogicLayer;

namespace View
{
    public partial class Users_n_Rewards : Form
    {
        public Logic logic = new Logic();
        private List<User> users = new List<User>();
        private bool sortUsersDirectionUp = true;
        private bool sortRewardsDirectionUp = true;


        public Users_n_Rewards()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ctlDataUsers_n_Rewards.AutoGenerateColumns = false;
            ctlDataRewards.AutoGenerateColumns = false;
            logic.InitRewards();
            logic.InitUsers();
            ctlDataUsers_n_Rewards.DataSource = logic.GetUsers().ToDataTable();
            ctlDataRewards.DataSource = logic.GetRewards().ToDataTable();
            AddColumns();
            AddColumnsReward();

        }

        private void AddColumnsReward()
        {
            DataGridViewTextBoxColumn idColumn1 =
            new DataGridViewTextBoxColumn();
            idColumn1.Name = "Title";
            idColumn1.DataPropertyName = "Title";
            idColumn1.ReadOnly = true;

            DataGridViewTextBoxColumn idColumn2 =
            new DataGridViewTextBoxColumn();
            idColumn2.Name = "Description";
            idColumn2.DataPropertyName = "Description";
            idColumn2.ReadOnly = true;

            DataGridViewTextBoxColumn idColumn3 =
            new DataGridViewTextBoxColumn();
            idColumn3.Name = "ID";
            idColumn3.DataPropertyName = "ID";
            idColumn3.ReadOnly = true;
            idColumn3.Visible = false;

            ctlDataRewards.Columns.Add(idColumn1);
            ctlDataRewards.Columns.Add(idColumn2);
            ctlDataRewards.Columns.Add(idColumn3);
        }

        private void AddColumns()
        {
            DataGridViewTextBoxColumn idColumn1 =
            new DataGridViewTextBoxColumn();
            idColumn1.Name = "FirstName";
            idColumn1.DataPropertyName = "FirstName";
            idColumn1.ReadOnly = true;

            DataGridViewTextBoxColumn idColumn2 =
            new DataGridViewTextBoxColumn();
            idColumn2.Name = "LastName";
            idColumn2.DataPropertyName = "LastName";
            idColumn2.ReadOnly = true;

            DataGridViewTextBoxColumn idColumn3 =
            new DataGridViewTextBoxColumn();
            idColumn3.Name = "Birthdate";
            idColumn3.DataPropertyName = "Birthdate";
            idColumn3.ReadOnly = true;

            DataGridViewTextBoxColumn idColumn4 =
            new DataGridViewTextBoxColumn();
            idColumn4.Name = "Age";
            idColumn4.DataPropertyName = "Age";
            idColumn4.ReadOnly = true;

            DataGridViewTextBoxColumn idColumn5 =
            new DataGridViewTextBoxColumn();
            idColumn5.Name = "Rewards";
            idColumn5.DataPropertyName = "Rewards";
            idColumn5.ReadOnly = true;

            DataGridViewTextBoxColumn idColumn6 =
            new DataGridViewTextBoxColumn();
            idColumn6.Name = "ID";
            idColumn6.DataPropertyName = "ID";
            idColumn6.ReadOnly = true;
            idColumn6.Visible = false;



            ctlDataUsers_n_Rewards.Columns.Add(idColumn1);
            ctlDataUsers_n_Rewards.Columns.Add(idColumn2);
            ctlDataUsers_n_Rewards.Columns.Add(idColumn3);
            ctlDataUsers_n_Rewards.Columns.Add(idColumn4);
            ctlDataUsers_n_Rewards.Columns.Add(idColumn5);
            ctlDataUsers_n_Rewards.Columns.Add(idColumn6);

        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Users_Click(object sender, EventArgs e)
        {

        }

        private void Add1_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void Edit1_Click(object sender, EventArgs e)
        {
            EditUser();
        }

        private void Remove1_Click(object sender, EventArgs e)
        {
            RemoveUser();
        }

        private void Add2_Click(object sender, EventArgs e)
        {
            AddReward();
        }

        private void Edit2_Click(object sender, EventArgs e)
        {
            EditReward();
        }

        private void Remove2_Click(object sender, EventArgs e)
        {
            RemoveReward();
        }

        private void AddUser()
        {
            AddUser add = new AddUser(logic);

            if (add.ShowDialog(this) == DialogResult.OK)
            {
                User user = new User(add.FirstName, add.LastName, add.BirthDate, add.ResultRewards);
                //user.FirstName = add.FirstName;
                //user.LastName = add.LastName;
                //user.Birthdate = add.BirthDate;

                logic.AddUser(user);
            }
            RefreshGrid();
        }

        private void EditUser()
        {
            if (ctlDataUsers_n_Rewards.SelectedCells.Count > 0)
            {
                DataGridViewRow row = ctlDataUsers_n_Rewards.SelectedCells[0].OwningRow;

                var id = (int)row.Cells[5].Value;

                User user = logic.GetUserById(id);
                AddUser edit = new AddUser(logic, user);
                if (edit.ShowDialog(this) == DialogResult.OK)
                {
                    user.FirstName = edit.FirstName;
                    user.LastName = edit.LastName;
                    user.Birthdate = edit.BirthDate;
                    user.reward = edit.ResultRewards;
                    user.RefreshRewards(user.reward);
                    logic.EditUser(user);
                }
            }
            RefreshGrid();
        }

        private void RemoveUser()
        {
            if (ctlDataUsers_n_Rewards.SelectedCells.Count > 0)
            {
                DataGridViewRow row = ctlDataUsers_n_Rewards.SelectedCells[0].OwningRow;

                var id = (int)row.Cells[5].Value;

                User user = logic.GetUserById(id);
                //User user = (User)ctlDataUsers_n_Rewards.SelectedCells[0].OwningRow.DataBoundItem;
                DialogResult result = MessageBox.Show(
                 "Are you sure?",
                 "Remove",
                 MessageBoxButtons.OKCancel,
                 MessageBoxIcon.Information,
                 MessageBoxDefaultButton.Button1
        );

                if (result == DialogResult.OK)
                {
                    logic.RemoveUser(user);
                }
            }
            RefreshGrid();
        }

        private void AddReward()
        {
            AddReward add = new AddReward();

            if (add.ShowDialog(this) == DialogResult.OK)
            {
                Reward reward = new Reward();
                reward.Title = add.Title;
                reward.Description = add.Description;

                logic.AddReward(reward);
            }
            RefreshGrid();
        }

        private void EditReward()
        {

            if (ctlDataRewards.SelectedCells.Count > 0)
            {
                DataGridViewRow row = ctlDataRewards.SelectedCells[0].OwningRow;
                var id = (int)row.Cells[2].Value;

                Reward reward = logic.GetRewardById(id);

                AddReward edit = new AddReward(reward);
                if (edit.ShowDialog(this) == DialogResult.OK)
                {
                    reward.Title = edit.Title;
                    reward.Description = edit.Description;
                    logic.EditReward(reward);
                }
            }
            RefreshGrid();
        }

        private void RemoveReward()
        {
            if (ctlDataRewards.SelectedCells.Count > 0)
            {
                //Reward removeReward = (Reward)ctlDataRewards.SelectedCells[0].OwningRow.DataBoundItem;

                DataGridViewRow row = ctlDataRewards.SelectedCells[0].OwningRow;
                var id = (int)row.Cells[2].Value;

                Reward removeReward = logic.GetRewardById(id);

                DialogResult result = MessageBox.Show(
                    "Are you sure?",
                    "Remove",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1
                    );

                if (result == DialogResult.OK)
                {
                    logic.RemoveReward(removeReward);
                }
                RefreshGrid();
            }
        }

        private void RefreshGrid()
        {

            ctlDataRewards.DataSource = null;
            ctlDataRewards.DataSource = logic.GetRewards().ToDataTable();
            ctlDataUsers_n_Rewards.DataSource = null;
            ctlDataUsers_n_Rewards.DataSource = logic.GetUsers().ToDataTable();
        }

        private void addToolRewardMenu(object sender, EventArgs e)
        {
            AddReward();
        }

        private void addToolUserMenu(object sender, EventArgs e)
        {
            AddUser();
        }

        private void editToolUserMenu_Click(object sender, EventArgs e)
        {
            EditUser();
        }

        private void removeToolUserMenu_Click(object sender, EventArgs e)
        {
            RemoveUser();
        }

        private void editToolRewardMenu_Click(object sender, EventArgs e)
        {
            EditReward();
        }

        private void removeToolRewardMenu_Click(object sender, EventArgs e)
        {
            RemoveReward();
        }

        private void ctlDataUsers_n_Rewards_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (sortUsersDirectionUp)
            {
                ctlDataUsers_n_Rewards.Sort(ctlDataUsers_n_Rewards.Columns[e.ColumnIndex], ListSortDirection.Ascending);
                sortUsersDirectionUp = false;
            }
            else
            {
                ctlDataUsers_n_Rewards.Sort(ctlDataUsers_n_Rewards.Columns[e.ColumnIndex], ListSortDirection.Descending);
                sortUsersDirectionUp = true;
            }
        }

        private void ctlDataRewards_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (sortRewardsDirectionUp)
            {
                ctlDataRewards.Sort(ctlDataRewards.Columns[e.ColumnIndex], ListSortDirection.Ascending);
                sortRewardsDirectionUp = false;
            }
            else
            {
                ctlDataRewards.Sort(ctlDataRewards.Columns[e.ColumnIndex], ListSortDirection.Descending);
                sortRewardsDirectionUp = true;
            }
        }
    }

}
