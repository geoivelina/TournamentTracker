namespace TrackerUI
{
    partial class CreateTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            this.teamNameValue = new System.Windows.Forms.TextBox();
            this.teamNameLable = new System.Windows.Forms.Label();
            this.headLable = new System.Windows.Forms.Label();
            this.addTeamMemberBtn = new System.Windows.Forms.Button();
            this.selectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.selectTeamMemberLable = new System.Windows.Forms.Label();
            this.AddNewMemberGroupBox = new System.Windows.Forms.GroupBox();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.phoneNumberLable = new System.Windows.Forms.Label();
            this.phoneNumberValue = new System.Windows.Forms.TextBox();
            this.emailLable = new System.Windows.Forms.Label();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.lastNameLable = new System.Windows.Forms.Label();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.firstNameLable = new System.Windows.Forms.Label();
            this.createMemberBtn = new System.Windows.Forms.Button();
            this.teamMembersListBox = new System.Windows.Forms.ListBox();
            this.deleteSelectedMemberBtn = new System.Windows.Forms.Button();
            this.createTeamBtn = new System.Windows.Forms.Button();
            this.AddNewMemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamNameValue
            // 
            this.teamNameValue.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamNameValue.Location = new System.Drawing.Point(41, 163);
            this.teamNameValue.Margin = new System.Windows.Forms.Padding(6);
            this.teamNameValue.Name = "teamNameValue";
            this.teamNameValue.Size = new System.Drawing.Size(557, 51);
            this.teamNameValue.TabIndex = 13;
            // 
            // teamNameLable
            // 
            this.teamNameLable.AutoSize = true;
            this.teamNameLable.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamNameLable.ForeColor = System.Drawing.Color.SteelBlue;
            this.teamNameLable.Location = new System.Drawing.Point(41, 112);
            this.teamNameLable.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.teamNameLable.Name = "teamNameLable";
            this.teamNameLable.Size = new System.Drawing.Size(192, 45);
            this.teamNameLable.TabIndex = 12;
            this.teamNameLable.Text = "Team Name";
            this.teamNameLable.Click += new System.EventHandler(this.teamNameLable_Click);
            // 
            // headLable
            // 
            this.headLable.AutoSize = true;
            this.headLable.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headLable.ForeColor = System.Drawing.Color.SteelBlue;
            this.headLable.Location = new System.Drawing.Point(289, 28);
            this.headLable.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.headLable.Name = "headLable";
            this.headLable.Size = new System.Drawing.Size(272, 62);
            this.headLable.TabIndex = 11;
            this.headLable.Text = "Create Team";
            // 
            // addTeamMemberBtn
            // 
            this.addTeamMemberBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamMemberBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addTeamMemberBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addTeamMemberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamMemberBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addTeamMemberBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.addTeamMemberBtn.Location = new System.Drawing.Point(166, 397);
            this.addTeamMemberBtn.Name = "addTeamMemberBtn";
            this.addTeamMemberBtn.Size = new System.Drawing.Size(204, 60);
            this.addTeamMemberBtn.TabIndex = 19;
            this.addTeamMemberBtn.Text = "Add Member";
            this.addTeamMemberBtn.UseVisualStyleBackColor = true;
            // 
            // selectTeamMemberDropDown
            // 
            this.selectTeamMemberDropDown.FormattingEnabled = true;
            this.selectTeamMemberDropDown.Location = new System.Drawing.Point(41, 312);
            this.selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            this.selectTeamMemberDropDown.Size = new System.Drawing.Size(557, 45);
            this.selectTeamMemberDropDown.TabIndex = 18;
            // 
            // selectTeamMemberLable
            // 
            this.selectTeamMemberLable.AutoSize = true;
            this.selectTeamMemberLable.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTeamMemberLable.ForeColor = System.Drawing.Color.SteelBlue;
            this.selectTeamMemberLable.Location = new System.Drawing.Point(41, 254);
            this.selectTeamMemberLable.Name = "selectTeamMemberLable";
            this.selectTeamMemberLable.Size = new System.Drawing.Size(322, 45);
            this.selectTeamMemberLable.TabIndex = 17;
            this.selectTeamMemberLable.Text = "Select Team Member";
            // 
            // AddNewMemberGroupBox
            // 
            this.AddNewMemberGroupBox.Controls.Add(this.createMemberBtn);
            this.AddNewMemberGroupBox.Controls.Add(this.emailValue);
            this.AddNewMemberGroupBox.Controls.Add(this.phoneNumberLable);
            this.AddNewMemberGroupBox.Controls.Add(this.phoneNumberValue);
            this.AddNewMemberGroupBox.Controls.Add(this.emailLable);
            this.AddNewMemberGroupBox.Controls.Add(this.lastNameValue);
            this.AddNewMemberGroupBox.Controls.Add(this.lastNameLable);
            this.AddNewMemberGroupBox.Controls.Add(this.firstNameValue);
            this.AddNewMemberGroupBox.Controls.Add(this.firstNameLable);
            this.AddNewMemberGroupBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.AddNewMemberGroupBox.Location = new System.Drawing.Point(41, 492);
            this.AddNewMemberGroupBox.Name = "AddNewMemberGroupBox";
            this.AddNewMemberGroupBox.Size = new System.Drawing.Size(557, 414);
            this.AddNewMemberGroupBox.TabIndex = 20;
            this.AddNewMemberGroupBox.TabStop = false;
            this.AddNewMemberGroupBox.Text = "Add New Member";
            // 
            // emailValue
            // 
            this.emailValue.Location = new System.Drawing.Point(227, 263);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(319, 43);
            this.emailValue.TabIndex = 16;
            // 
            // phoneNumberLable
            // 
            this.phoneNumberLable.AutoSize = true;
            this.phoneNumberLable.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneNumberLable.ForeColor = System.Drawing.Color.SteelBlue;
            this.phoneNumberLable.Location = new System.Drawing.Point(15, 199);
            this.phoneNumberLable.Name = "phoneNumberLable";
            this.phoneNumberLable.Size = new System.Drawing.Size(206, 38);
            this.phoneNumberLable.TabIndex = 15;
            this.phoneNumberLable.Text = "Phone Number";
            // 
            // phoneNumberValue
            // 
            this.phoneNumberValue.Location = new System.Drawing.Point(227, 194);
            this.phoneNumberValue.Name = "phoneNumberValue";
            this.phoneNumberValue.Size = new System.Drawing.Size(319, 43);
            this.phoneNumberValue.TabIndex = 14;
            // 
            // emailLable
            // 
            this.emailLable.AutoSize = true;
            this.emailLable.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLable.ForeColor = System.Drawing.Color.SteelBlue;
            this.emailLable.Location = new System.Drawing.Point(15, 263);
            this.emailLable.Name = "emailLable";
            this.emailLable.Size = new System.Drawing.Size(88, 41);
            this.emailLable.TabIndex = 13;
            this.emailLable.Text = "Email";
            // 
            // lastNameValue
            // 
            this.lastNameValue.Location = new System.Drawing.Point(227, 124);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(319, 43);
            this.lastNameValue.TabIndex = 12;
            // 
            // lastNameLable
            // 
            this.lastNameLable.AutoSize = true;
            this.lastNameLable.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameLable.ForeColor = System.Drawing.Color.SteelBlue;
            this.lastNameLable.Location = new System.Drawing.Point(15, 124);
            this.lastNameLable.Name = "lastNameLable";
            this.lastNameLable.Size = new System.Drawing.Size(157, 41);
            this.lastNameLable.TabIndex = 11;
            this.lastNameLable.Text = "Last Name";
            // 
            // firstNameValue
            // 
            this.firstNameValue.Location = new System.Drawing.Point(227, 64);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(319, 43);
            this.firstNameValue.TabIndex = 10;
            // 
            // firstNameLable
            // 
            this.firstNameLable.AutoSize = true;
            this.firstNameLable.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameLable.ForeColor = System.Drawing.Color.SteelBlue;
            this.firstNameLable.Location = new System.Drawing.Point(15, 61);
            this.firstNameLable.Name = "firstNameLable";
            this.firstNameLable.Size = new System.Drawing.Size(160, 41);
            this.firstNameLable.TabIndex = 9;
            this.firstNameLable.Text = "First Name";
            // 
            // createMemberBtn
            // 
            this.createMemberBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createMemberBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createMemberBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createMemberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createMemberBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.createMemberBtn.Location = new System.Drawing.Point(149, 334);
            this.createMemberBtn.Name = "createMemberBtn";
            this.createMemberBtn.Size = new System.Drawing.Size(246, 60);
            this.createMemberBtn.TabIndex = 21;
            this.createMemberBtn.Text = "Create Member";
            this.createMemberBtn.UseVisualStyleBackColor = true;
            // 
            // teamMembersListBox
            // 
            this.teamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamMembersListBox.FormattingEnabled = true;
            this.teamMembersListBox.ItemHeight = 37;
            this.teamMembersListBox.Location = new System.Drawing.Point(683, 163);
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.Size = new System.Drawing.Size(478, 742);
            this.teamMembersListBox.TabIndex = 21;
            // 
            // deleteSelectedMemberBtn
            // 
            this.deleteSelectedMemberBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedMemberBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedMemberBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedMemberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedMemberBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteSelectedMemberBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.deleteSelectedMemberBtn.Location = new System.Drawing.Point(1212, 416);
            this.deleteSelectedMemberBtn.Name = "deleteSelectedMemberBtn";
            this.deleteSelectedMemberBtn.Size = new System.Drawing.Size(137, 90);
            this.deleteSelectedMemberBtn.TabIndex = 22;
            this.deleteSelectedMemberBtn.Text = "Delete Selected";
            this.deleteSelectedMemberBtn.UseVisualStyleBackColor = true;
            // 
            // createTeamBtn
            // 
            this.createTeamBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTeamBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTeamBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTeamBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createTeamBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.createTeamBtn.Location = new System.Drawing.Point(478, 943);
            this.createTeamBtn.Name = "createTeamBtn";
            this.createTeamBtn.Size = new System.Drawing.Size(309, 60);
            this.createTeamBtn.TabIndex = 25;
            this.createTeamBtn.Text = "Create Team";
            this.createTeamBtn.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1382, 1008);
            this.Controls.Add(this.createTeamBtn);
            this.Controls.Add(this.deleteSelectedMemberBtn);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.AddNewMemberGroupBox);
            this.Controls.Add(this.addTeamMemberBtn);
            this.Controls.Add(this.selectTeamMemberDropDown);
            this.Controls.Add(this.selectTeamMemberLable);
            this.Controls.Add(this.teamNameValue);
            this.Controls.Add(this.teamNameLable);
            this.Controls.Add(this.headLable);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team Form";
            this.AddNewMemberGroupBox.ResumeLayout(false);
            this.AddNewMemberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox teamNameValue;
        private Label teamNameLable;
        private Label headLable;
        private Button addTeamMemberBtn;
        private ComboBox selectTeamMemberDropDown;
        private Label selectTeamMemberLable;
        private GroupBox AddNewMemberGroupBox;
        private TextBox emailValue;
        private Label phoneNumberLable;
        private TextBox phoneNumberValue;
        private Label emailLable;
        private TextBox lastNameValue;
        private Label lastNameLable;
        private TextBox firstNameValue;
        private Label firstNameLable;
        private Button createMemberBtn;
        private ListBox teamMembersListBox;
        private Button deleteSelectedMemberBtn;
        private Button createTeamBtn;
    }
}