namespace View
{
    partial class Users_n_Rewards
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ctlDataUsers_n_Rewards = new System.Windows.Forms.DataGridView();
            this.ctlContextMenuUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolUserMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolUserMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlMenuUsers_n_Rewards = new System.Windows.Forms.MenuStrip();
            this.Users = new System.Windows.Forms.ToolStripMenuItem();
            this.AddU = new System.Windows.Forms.ToolStripMenuItem();
            this.EditU = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveU = new System.Windows.Forms.ToolStripMenuItem();
            this.Rewards = new System.Windows.Forms.ToolStripMenuItem();
            this.AddR = new System.Windows.Forms.ToolStripMenuItem();
            this.EditR = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveR = new System.Windows.Forms.ToolStripMenuItem();
            this.Pages = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ctlDataRewards = new System.Windows.Forms.DataGridView();
            this.ctlContextMenuRewards = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolRewardMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolRewardMenu = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ctlDataUsers_n_Rewards)).BeginInit();
            this.ctlContextMenuUsers.SuspendLayout();
            this.ctlMenuUsers_n_Rewards.SuspendLayout();
            this.Pages.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlDataRewards)).BeginInit();
            this.ctlContextMenuRewards.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctlDataUsers_n_Rewards
            // 
            this.ctlDataUsers_n_Rewards.AllowUserToAddRows = false;
            this.ctlDataUsers_n_Rewards.AllowUserToDeleteRows = false;
            this.ctlDataUsers_n_Rewards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ctlDataUsers_n_Rewards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlDataUsers_n_Rewards.ContextMenuStrip = this.ctlContextMenuUsers;
            this.ctlDataUsers_n_Rewards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlDataUsers_n_Rewards.Location = new System.Drawing.Point(3, 3);
            this.ctlDataUsers_n_Rewards.Name = "ctlDataUsers_n_Rewards";
            this.ctlDataUsers_n_Rewards.Size = new System.Drawing.Size(656, 416);
            this.ctlDataUsers_n_Rewards.TabIndex = 0;
            this.ctlDataUsers_n_Rewards.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ctlDataUsers_n_Rewards_ColumnHeaderMouseClick);
            // 
            // ctlContextMenuUsers
            // 
            this.ctlContextMenuUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolUserMenu,
            this.removeToolUserMenu});
            this.ctlContextMenuUsers.Name = "contextUsers";
            this.ctlContextMenuUsers.Size = new System.Drawing.Size(118, 70);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolUserMenu);
            // 
            // editToolUserMenu
            // 
            this.editToolUserMenu.Name = "editToolUserMenu";
            this.editToolUserMenu.Size = new System.Drawing.Size(117, 22);
            this.editToolUserMenu.Text = "Edit";
            this.editToolUserMenu.Click += new System.EventHandler(this.editToolUserMenu_Click);
            // 
            // removeToolUserMenu
            // 
            this.removeToolUserMenu.Name = "removeToolUserMenu";
            this.removeToolUserMenu.Size = new System.Drawing.Size(117, 22);
            this.removeToolUserMenu.Text = "Remove";
            this.removeToolUserMenu.Click += new System.EventHandler(this.removeToolUserMenu_Click);
            // 
            // ctlMenuUsers_n_Rewards
            // 
            this.ctlMenuUsers_n_Rewards.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Users,
            this.Rewards});
            this.ctlMenuUsers_n_Rewards.Location = new System.Drawing.Point(0, 0);
            this.ctlMenuUsers_n_Rewards.Name = "ctlMenuUsers_n_Rewards";
            this.ctlMenuUsers_n_Rewards.Size = new System.Drawing.Size(670, 24);
            this.ctlMenuUsers_n_Rewards.TabIndex = 1;
            this.ctlMenuUsers_n_Rewards.Text = "menuU_n_R";
            this.ctlMenuUsers_n_Rewards.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // Users
            // 
            this.Users.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddU,
            this.EditU,
            this.RemoveU});
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(47, 20);
            this.Users.Text = "Users";
            this.Users.Click += new System.EventHandler(this.Users_Click);
            // 
            // AddU
            // 
            this.AddU.Name = "AddU";
            this.AddU.Size = new System.Drawing.Size(152, 22);
            this.AddU.Text = "Add";
            this.AddU.Click += new System.EventHandler(this.Add1_Click);
            // 
            // EditU
            // 
            this.EditU.Name = "EditU";
            this.EditU.Size = new System.Drawing.Size(152, 22);
            this.EditU.Text = "Edit";
            this.EditU.Click += new System.EventHandler(this.Edit1_Click);
            // 
            // RemoveU
            // 
            this.RemoveU.Name = "RemoveU";
            this.RemoveU.Size = new System.Drawing.Size(152, 22);
            this.RemoveU.Text = "Remove";
            this.RemoveU.Click += new System.EventHandler(this.Remove1_Click);
            // 
            // Rewards
            // 
            this.Rewards.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddR,
            this.EditR,
            this.RemoveR});
            this.Rewards.Name = "Rewards";
            this.Rewards.Size = new System.Drawing.Size(63, 20);
            this.Rewards.Text = "Rewards";
            // 
            // AddR
            // 
            this.AddR.Name = "AddR";
            this.AddR.Size = new System.Drawing.Size(152, 22);
            this.AddR.Text = "Add";
            this.AddR.Click += new System.EventHandler(this.Add2_Click);
            // 
            // EditR
            // 
            this.EditR.Name = "EditR";
            this.EditR.Size = new System.Drawing.Size(152, 22);
            this.EditR.Text = "Edit";
            this.EditR.Click += new System.EventHandler(this.Edit2_Click);
            // 
            // RemoveR
            // 
            this.RemoveR.Name = "RemoveR";
            this.RemoveR.Size = new System.Drawing.Size(152, 22);
            this.RemoveR.Text = "Remove";
            this.RemoveR.Click += new System.EventHandler(this.Remove2_Click);
            // 
            // Pages
            // 
            this.Pages.Controls.Add(this.tabPage1);
            this.Pages.Controls.Add(this.tabPage2);
            this.Pages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pages.Location = new System.Drawing.Point(0, 24);
            this.Pages.Name = "Pages";
            this.Pages.SelectedIndex = 0;
            this.Pages.Size = new System.Drawing.Size(670, 448);
            this.Pages.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ctlDataUsers_n_Rewards);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(662, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Users";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ctlDataRewards);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(662, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rewards";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ctlDataRewards
            // 
            this.ctlDataRewards.AllowUserToAddRows = false;
            this.ctlDataRewards.AllowUserToDeleteRows = false;
            this.ctlDataRewards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ctlDataRewards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlDataRewards.ContextMenuStrip = this.ctlContextMenuRewards;
            this.ctlDataRewards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlDataRewards.Location = new System.Drawing.Point(3, 3);
            this.ctlDataRewards.Name = "ctlDataRewards";
            this.ctlDataRewards.Size = new System.Drawing.Size(656, 416);
            this.ctlDataRewards.TabIndex = 0;
            this.ctlDataRewards.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ctlDataRewards_ColumnHeaderMouseClick);
            // 
            // ctlContextMenuRewards
            // 
            this.ctlContextMenuRewards.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.editToolRewardMenu,
            this.removeToolRewardMenu});
            this.ctlContextMenuRewards.Name = "contextRewards";
            this.ctlContextMenuRewards.Size = new System.Drawing.Size(118, 70);
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolRewardMenu);
            // 
            // editToolRewardMenu
            // 
            this.editToolRewardMenu.Name = "editToolRewardMenu";
            this.editToolRewardMenu.Size = new System.Drawing.Size(117, 22);
            this.editToolRewardMenu.Text = "Edit";
            this.editToolRewardMenu.Click += new System.EventHandler(this.editToolRewardMenu_Click);
            // 
            // removeToolRewardMenu
            // 
            this.removeToolRewardMenu.Name = "removeToolRewardMenu";
            this.removeToolRewardMenu.Size = new System.Drawing.Size(117, 22);
            this.removeToolRewardMenu.Text = "Remove";
            this.removeToolRewardMenu.Click += new System.EventHandler(this.removeToolRewardMenu_Click);
            // 
            // Users_n_Rewards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 472);
            this.Controls.Add(this.Pages);
            this.Controls.Add(this.ctlMenuUsers_n_Rewards);
            this.MainMenuStrip = this.ctlMenuUsers_n_Rewards;
            this.Name = "Users_n_Rewards";
            this.Text = "Users_n_Rewards";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctlDataUsers_n_Rewards)).EndInit();
            this.ctlContextMenuUsers.ResumeLayout(false);
            this.ctlMenuUsers_n_Rewards.ResumeLayout(false);
            this.ctlMenuUsers_n_Rewards.PerformLayout();
            this.Pages.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctlDataRewards)).EndInit();
            this.ctlContextMenuRewards.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ctlDataUsers_n_Rewards;
        private System.Windows.Forms.MenuStrip ctlMenuUsers_n_Rewards;
        private System.Windows.Forms.ToolStripMenuItem Users;
        private System.Windows.Forms.ToolStripMenuItem AddU;
        private System.Windows.Forms.ToolStripMenuItem EditU;
        private System.Windows.Forms.ToolStripMenuItem RemoveU;
        private System.Windows.Forms.ToolStripMenuItem Rewards;
        private System.Windows.Forms.ToolStripMenuItem AddR;
        private System.Windows.Forms.ToolStripMenuItem EditR;
        private System.Windows.Forms.ToolStripMenuItem RemoveR;
        private System.Windows.Forms.TabControl Pages;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView ctlDataRewards;
        private System.Windows.Forms.ContextMenuStrip ctlContextMenuUsers;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolUserMenu;
        private System.Windows.Forms.ToolStripMenuItem removeToolUserMenu;
        private System.Windows.Forms.ContextMenuStrip ctlContextMenuRewards;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolRewardMenu;
        private System.Windows.Forms.ToolStripMenuItem removeToolRewardMenu;
    }
}

