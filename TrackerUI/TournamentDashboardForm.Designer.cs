namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashboardForm));
            this.headLable = new System.Windows.Forms.Label();
            this.loadExistingTournamnetDropDown = new System.Windows.Forms.ComboBox();
            this.loadExistingTournamentLable = new System.Windows.Forms.Label();
            this.loadTournamnetBtn = new System.Windows.Forms.Button();
            this.createTournamentBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headLable
            // 
            this.headLable.AutoSize = true;
            this.headLable.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headLable.ForeColor = System.Drawing.Color.SteelBlue;
            this.headLable.Location = new System.Drawing.Point(183, 61);
            this.headLable.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.headLable.Name = "headLable";
            this.headLable.Size = new System.Drawing.Size(488, 62);
            this.headLable.TabIndex = 13;
            this.headLable.Text = "Tournament Dashboard";
            // 
            // loadExistingTournamnetDropDown
            // 
            this.loadExistingTournamnetDropDown.FormattingEnabled = true;
            this.loadExistingTournamnetDropDown.Location = new System.Drawing.Point(137, 243);
            this.loadExistingTournamnetDropDown.Name = "loadExistingTournamnetDropDown";
            this.loadExistingTournamnetDropDown.Size = new System.Drawing.Size(557, 45);
            this.loadExistingTournamnetDropDown.TabIndex = 20;
            // 
            // loadExistingTournamentLable
            // 
            this.loadExistingTournamentLable.AutoSize = true;
            this.loadExistingTournamentLable.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadExistingTournamentLable.ForeColor = System.Drawing.Color.SteelBlue;
            this.loadExistingTournamentLable.Location = new System.Drawing.Point(226, 183);
            this.loadExistingTournamentLable.Name = "loadExistingTournamentLable";
            this.loadExistingTournamentLable.Size = new System.Drawing.Size(394, 45);
            this.loadExistingTournamentLable.TabIndex = 19;
            this.loadExistingTournamentLable.Text = "Load Existing Tournament";
            // 
            // loadTournamnetBtn
            // 
            this.loadTournamnetBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.loadTournamnetBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.loadTournamnetBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.loadTournamnetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTournamnetBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loadTournamnetBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.loadTournamnetBtn.Location = new System.Drawing.Point(298, 310);
            this.loadTournamnetBtn.Name = "loadTournamnetBtn";
            this.loadTournamnetBtn.Size = new System.Drawing.Size(274, 60);
            this.loadTournamnetBtn.TabIndex = 21;
            this.loadTournamnetBtn.Text = "Load Tournamnet";
            this.loadTournamnetBtn.UseVisualStyleBackColor = true;
            // 
            // createTournamentBtn
            // 
            this.createTournamentBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createTournamentBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.createTournamentBtn.Location = new System.Drawing.Point(293, 478);
            this.createTournamentBtn.Name = "createTournamentBtn";
            this.createTournamentBtn.Size = new System.Drawing.Size(279, 100);
            this.createTournamentBtn.TabIndex = 27;
            this.createTournamentBtn.Text = "Create Tournament";
            this.createTournamentBtn.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(841, 619);
            this.Controls.Add(this.createTournamentBtn);
            this.Controls.Add(this.loadTournamnetBtn);
            this.Controls.Add(this.loadExistingTournamnetDropDown);
            this.Controls.Add(this.loadExistingTournamentLable);
            this.Controls.Add(this.headLable);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboards";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headLable;
        private ComboBox loadExistingTournamnetDropDown;
        private Label loadExistingTournamentLable;
        private Button loadTournamnetBtn;
        private Button createTournamentBtn;
    }
}