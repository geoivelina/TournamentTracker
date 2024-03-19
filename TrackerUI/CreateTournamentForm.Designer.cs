namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.headLable = new System.Windows.Forms.Label();
            this.tournamentNameValue = new System.Windows.Forms.TextBox();
            this.tournamentNameLable = new System.Windows.Forms.Label();
            this.entryFeeValue = new System.Windows.Forms.TextBox();
            this.entryFeeLable = new System.Windows.Forms.Label();
            this.selectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.selectTeamLable = new System.Windows.Forms.Label();
            this.createNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.addTeamBtn = new System.Windows.Forms.Button();
            this.createPrizeBtn = new System.Windows.Forms.Button();
            this.tournametPlayersLable = new System.Windows.Forms.Label();
            this.tournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.deleteSelectedPlayersBtn = new System.Windows.Forms.Button();
            this.deleteSelectedPrizeBtn = new System.Windows.Forms.Button();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.prizesLable = new System.Windows.Forms.Label();
            this.createTournamentBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headLable
            // 
            this.headLable.AutoSize = true;
            this.headLable.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headLable.ForeColor = System.Drawing.Color.SteelBlue;
            this.headLable.Location = new System.Drawing.Point(410, 59);
            this.headLable.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.headLable.Name = "headLable";
            this.headLable.Size = new System.Drawing.Size(403, 62);
            this.headLable.TabIndex = 1;
            this.headLable.Text = "Create Tournament";
            // 
            // tournamentNameValue
            // 
            this.tournamentNameValue.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentNameValue.Location = new System.Drawing.Point(86, 229);
            this.tournamentNameValue.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tournamentNameValue.Name = "tournamentNameValue";
            this.tournamentNameValue.Size = new System.Drawing.Size(454, 51);
            this.tournamentNameValue.TabIndex = 10;
            // 
            // tournamentNameLable
            // 
            this.tournamentNameLable.AutoSize = true;
            this.tournamentNameLable.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentNameLable.ForeColor = System.Drawing.Color.SteelBlue;
            this.tournamentNameLable.Location = new System.Drawing.Point(86, 177);
            this.tournamentNameLable.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.tournamentNameLable.Name = "tournamentNameLable";
            this.tournamentNameLable.Size = new System.Drawing.Size(298, 46);
            this.tournamentNameLable.TabIndex = 9;
            this.tournamentNameLable.Text = "Tournament Name";
            // 
            // entryFeeValue
            // 
            this.entryFeeValue.Location = new System.Drawing.Point(256, 316);
            this.entryFeeValue.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.entryFeeValue.Name = "entryFeeValue";
            this.entryFeeValue.Size = new System.Drawing.Size(231, 43);
            this.entryFeeValue.TabIndex = 12;
            this.entryFeeValue.Text = "0";
            // 
            // entryFeeLable
            // 
            this.entryFeeLable.AutoSize = true;
            this.entryFeeLable.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entryFeeLable.ForeColor = System.Drawing.Color.SteelBlue;
            this.entryFeeLable.Location = new System.Drawing.Point(86, 313);
            this.entryFeeLable.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.entryFeeLable.Name = "entryFeeLable";
            this.entryFeeLable.Size = new System.Drawing.Size(158, 46);
            this.entryFeeLable.TabIndex = 11;
            this.entryFeeLable.Text = "Entry Fee";
            // 
            // selectTeamDropDown
            // 
            this.selectTeamDropDown.FormattingEnabled = true;
            this.selectTeamDropDown.Location = new System.Drawing.Point(86, 456);
            this.selectTeamDropDown.Name = "selectTeamDropDown";
            this.selectTeamDropDown.Size = new System.Drawing.Size(454, 45);
            this.selectTeamDropDown.TabIndex = 14;
            // 
            // selectTeamLable
            // 
            this.selectTeamLable.AutoSize = true;
            this.selectTeamLable.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTeamLable.ForeColor = System.Drawing.Color.SteelBlue;
            this.selectTeamLable.Location = new System.Drawing.Point(86, 398);
            this.selectTeamLable.Name = "selectTeamLable";
            this.selectTeamLable.Size = new System.Drawing.Size(198, 46);
            this.selectTeamLable.TabIndex = 13;
            this.selectTeamLable.Text = "Select Team";
            // 
            // createNewTeamLink
            // 
            this.createNewTeamLink.AutoSize = true;
            this.createNewTeamLink.Location = new System.Drawing.Point(388, 404);
            this.createNewTeamLink.Name = "createNewTeamLink";
            this.createNewTeamLink.Size = new System.Drawing.Size(152, 38);
            this.createNewTeamLink.TabIndex = 15;
            this.createNewTeamLink.TabStop = true;
            this.createNewTeamLink.Text = "create new";
            // 
            // addTeamBtn
            // 
            this.addTeamBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addTeamBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addTeamBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addTeamBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.addTeamBtn.Location = new System.Drawing.Point(211, 541);
            this.addTeamBtn.Name = "addTeamBtn";
            this.addTeamBtn.Size = new System.Drawing.Size(204, 60);
            this.addTeamBtn.TabIndex = 16;
            this.addTeamBtn.Text = "Add Team";
            this.addTeamBtn.UseVisualStyleBackColor = true;
            // 
            // createPrizeBtn
            // 
            this.createPrizeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPrizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createPrizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createPrizeBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.createPrizeBtn.Location = new System.Drawing.Point(211, 638);
            this.createPrizeBtn.Name = "createPrizeBtn";
            this.createPrizeBtn.Size = new System.Drawing.Size(204, 60);
            this.createPrizeBtn.TabIndex = 17;
            this.createPrizeBtn.Text = "Create Prize";
            this.createPrizeBtn.UseVisualStyleBackColor = true;
            // 
            // tournametPlayersLable
            // 
            this.tournametPlayersLable.AutoSize = true;
            this.tournametPlayersLable.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournametPlayersLable.ForeColor = System.Drawing.Color.SteelBlue;
            this.tournametPlayersLable.Location = new System.Drawing.Point(614, 177);
            this.tournametPlayersLable.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.tournametPlayersLable.Name = "tournametPlayersLable";
            this.tournametPlayersLable.Size = new System.Drawing.Size(248, 46);
            this.tournametPlayersLable.TabIndex = 18;
            this.tournametPlayersLable.Text = "Teams / Players";
            // 
            // tournamentPlayersListBox
            // 
            this.tournamentPlayersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentPlayersListBox.FormattingEnabled = true;
            this.tournamentPlayersListBox.ItemHeight = 37;
            this.tournamentPlayersListBox.Location = new System.Drawing.Point(621, 230);
            this.tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            this.tournamentPlayersListBox.Size = new System.Drawing.Size(362, 187);
            this.tournamentPlayersListBox.TabIndex = 19;
            // 
            // deleteSelectedPlayersBtn
            // 
            this.deleteSelectedPlayersBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedPlayersBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedPlayersBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedPlayersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPlayersBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteSelectedPlayersBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.deleteSelectedPlayersBtn.Location = new System.Drawing.Point(1048, 269);
            this.deleteSelectedPlayersBtn.Name = "deleteSelectedPlayersBtn";
            this.deleteSelectedPlayersBtn.Size = new System.Drawing.Size(137, 90);
            this.deleteSelectedPlayersBtn.TabIndex = 20;
            this.deleteSelectedPlayersBtn.Text = "Delete Selected";
            this.deleteSelectedPlayersBtn.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedPrizeBtn
            // 
            this.deleteSelectedPrizeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedPrizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedPrizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedPrizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPrizeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteSelectedPrizeBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.deleteSelectedPrizeBtn.Location = new System.Drawing.Point(1048, 556);
            this.deleteSelectedPrizeBtn.Name = "deleteSelectedPrizeBtn";
            this.deleteSelectedPrizeBtn.Size = new System.Drawing.Size(137, 94);
            this.deleteSelectedPrizeBtn.TabIndex = 23;
            this.deleteSelectedPrizeBtn.Text = "Delete Selected";
            this.deleteSelectedPrizeBtn.UseVisualStyleBackColor = true;
            // 
            // prizesListBox
            // 
            this.prizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 37;
            this.prizesListBox.Location = new System.Drawing.Point(621, 511);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(362, 187);
            this.prizesListBox.TabIndex = 22;
            // 
            // prizesLable
            // 
            this.prizesLable.AutoSize = true;
            this.prizesLable.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prizesLable.ForeColor = System.Drawing.Color.SteelBlue;
            this.prizesLable.Location = new System.Drawing.Point(614, 458);
            this.prizesLable.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.prizesLable.Name = "prizesLable";
            this.prizesLable.Size = new System.Drawing.Size(92, 46);
            this.prizesLable.TabIndex = 21;
            this.prizesLable.Text = "Prize";
            // 
            // createTournamentBtn
            // 
            this.createTournamentBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createTournamentBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.createTournamentBtn.Location = new System.Drawing.Point(467, 755);
            this.createTournamentBtn.Name = "createTournamentBtn";
            this.createTournamentBtn.Size = new System.Drawing.Size(309, 60);
            this.createTournamentBtn.TabIndex = 24;
            this.createTournamentBtn.Text = "Create Tournament";
            this.createTournamentBtn.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 838);
            this.Controls.Add(this.createTournamentBtn);
            this.Controls.Add(this.deleteSelectedPrizeBtn);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.prizesLable);
            this.Controls.Add(this.deleteSelectedPlayersBtn);
            this.Controls.Add(this.tournamentPlayersListBox);
            this.Controls.Add(this.tournametPlayersLable);
            this.Controls.Add(this.createPrizeBtn);
            this.Controls.Add(this.addTeamBtn);
            this.Controls.Add(this.createNewTeamLink);
            this.Controls.Add(this.selectTeamDropDown);
            this.Controls.Add(this.selectTeamLable);
            this.Controls.Add(this.entryFeeValue);
            this.Controls.Add(this.entryFeeLable);
            this.Controls.Add(this.tournamentNameValue);
            this.Controls.Add(this.tournamentNameLable);
            this.Controls.Add(this.headLable);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "CreateTournamentForm";
            this.Text = "CreateTournamentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headLable;
        private TextBox tournamentNameValue;
        private Label tournamentNameLable;
        private TextBox entryFeeValue;
        private Label entryFeeLable;
        private ComboBox selectTeamDropDown;
        private Label selectTeamLable;
        private LinkLabel createNewTeamLink;
        private Button addTeamBtn;
        private Button createPrizeBtn;
        private Label tournametPlayersLable;
        private ListBox tournamentPlayersListBox;
        private Button deleteSelectedPlayersBtn;
        private Button deleteSelectedPrizeBtn;
        private ListBox prizesListBox;
        private Label prizesLable;
        private Button createTournamentBtn;
    }
}