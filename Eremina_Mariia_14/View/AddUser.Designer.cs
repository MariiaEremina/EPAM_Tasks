namespace View
{
    partial class AddUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lFirstName = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lLastName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lBirthdate = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblRewards = new System.Windows.Forms.Label();
            this.checkedRewards = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lFirstName
            // 
            this.lFirstName.AutoSize = true;
            this.lFirstName.Location = new System.Drawing.Point(14, 62);
            this.lFirstName.Name = "lFirstName";
            this.lFirstName.Size = new System.Drawing.Size(54, 13);
            this.lFirstName.TabIndex = 0;
            this.lFirstName.Text = "FirstName";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(107, 59);
            this.firstName.MaxLength = 50;
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(191, 20);
            this.firstName.TabIndex = 1;
            this.firstName.Validating += new System.ComponentModel.CancelEventHandler(this.firstName_Validating);
            this.firstName.Validated += new System.EventHandler(this.firstName_Validated);
            // 
            // lLastName
            // 
            this.lLastName.AutoSize = true;
            this.lLastName.Location = new System.Drawing.Point(13, 125);
            this.lLastName.Name = "lLastName";
            this.lLastName.Size = new System.Drawing.Size(55, 13);
            this.lLastName.TabIndex = 2;
            this.lLastName.Text = "LastName";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(107, 122);
            this.lastName.MaxLength = 50;
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(191, 20);
            this.lastName.TabIndex = 3;
            this.lastName.Validating += new System.ComponentModel.CancelEventHandler(this.lastName_Validating);
            this.lastName.Validated += new System.EventHandler(this.lastName_Validated);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(107, 322);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "Save";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(272, 322);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(107, 177);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(191, 20);
            this.dateTimePicker.TabIndex = 12;
            this.dateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePicker_Validating);
            this.dateTimePicker.Validated += new System.EventHandler(this.dateTimePicker_Validated);
            // 
            // lBirthdate
            // 
            this.lBirthdate.AutoSize = true;
            this.lBirthdate.Location = new System.Drawing.Point(13, 177);
            this.lBirthdate.Name = "lBirthdate";
            this.lBirthdate.Size = new System.Drawing.Size(49, 13);
            this.lBirthdate.TabIndex = 13;
            this.lBirthdate.Text = "Birthdate";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lblRewards
            // 
            this.lblRewards.AutoSize = true;
            this.lblRewards.Location = new System.Drawing.Point(13, 220);
            this.lblRewards.Name = "lblRewards";
            this.lblRewards.Size = new System.Drawing.Size(49, 13);
            this.lblRewards.TabIndex = 14;
            this.lblRewards.Text = "Rewards";
            // 
            // checkedRewards
            // 
            this.checkedRewards.FormattingEnabled = true;
            this.checkedRewards.Location = new System.Drawing.Point(107, 220);
            this.checkedRewards.Name = "checkedRewards";
            this.checkedRewards.Size = new System.Drawing.Size(191, 94);
            this.checkedRewards.TabIndex = 15;
            this.checkedRewards.Validated += new System.EventHandler(this.checkedRewards_Validated);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(393, 376);
            this.Controls.Add(this.checkedRewards);
            this.Controls.Add(this.lblRewards);
            this.Controls.Add(this.lBirthdate);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.lLastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.lFirstName);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.AddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lFirstName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label lLastName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lBirthdate;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblRewards;
        private System.Windows.Forms.CheckedListBox checkedRewards;
    }
}