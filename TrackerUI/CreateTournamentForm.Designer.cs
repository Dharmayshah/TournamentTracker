namespace TrackerUI
{
    partial class TeamOneScoreLabel
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
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.TournamentNameValue = new System.Windows.Forms.TextBox();
            this.TournamentNameLabel = new System.Windows.Forms.Label();
            this.EntryFeeLabel = new System.Windows.Forms.Label();
            this.EntryFeeValue = new System.Windows.Forms.TextBox();
            this.SelectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.SelectTeamLabel = new System.Windows.Forms.Label();
            this.CreateNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.AddTeamButton = new System.Windows.Forms.Button();
            this.CreatePrizeButton = new System.Windows.Forms.Button();
            this.TournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.TournamentPlayerLabel = new System.Windows.Forms.Label();
            this.DeleteSelectedPlayer = new System.Windows.Forms.Button();
            this.DeleteSelectedPrizeButton = new System.Windows.Forms.Button();
            this.PrizesLabel = new System.Windows.Forms.Label();
            this.PrizesListBox = new System.Windows.Forms.ListBox();
            this.CreateTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeaderLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.HeaderLabel.Location = new System.Drawing.Point(23, 20);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(262, 37);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "Create Tournament : ";
            // 
            // TournamentNameValue
            // 
            this.TournamentNameValue.Location = new System.Drawing.Point(27, 109);
            this.TournamentNameValue.Name = "TournamentNameValue";
            this.TournamentNameValue.Size = new System.Drawing.Size(258, 35);
            this.TournamentNameValue.TabIndex = 10;
            this.TournamentNameValue.TextChanged += new System.EventHandler(this.TeamOneScoreValue_TextChanged);
            // 
            // TournamentNameLabel
            // 
            this.TournamentNameLabel.AutoSize = true;
            this.TournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TournamentNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TournamentNameLabel.Location = new System.Drawing.Point(27, 76);
            this.TournamentNameLabel.Name = "TournamentNameLabel";
            this.TournamentNameLabel.Size = new System.Drawing.Size(186, 30);
            this.TournamentNameLabel.TabIndex = 9;
            this.TournamentNameLabel.Text = "Tournament Name";
            this.TournamentNameLabel.Click += new System.EventHandler(this.TeamOneScoreLabel_Click);
            // 
            // EntryFeeLabel
            // 
            this.EntryFeeLabel.AutoSize = true;
            this.EntryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EntryFeeLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.EntryFeeLabel.Location = new System.Drawing.Point(23, 169);
            this.EntryFeeLabel.Name = "EntryFeeLabel";
            this.EntryFeeLabel.Size = new System.Drawing.Size(98, 30);
            this.EntryFeeLabel.TabIndex = 11;
            this.EntryFeeLabel.Text = "Entry Fee";
            // 
            // EntryFeeValue
            // 
            this.EntryFeeValue.Location = new System.Drawing.Point(127, 169);
            this.EntryFeeValue.Name = "EntryFeeValue";
            this.EntryFeeValue.Size = new System.Drawing.Size(158, 35);
            this.EntryFeeValue.TabIndex = 12;
            this.EntryFeeValue.Text = "0";
            // 
            // SelectTeamDropDown
            // 
            this.SelectTeamDropDown.FormattingEnabled = true;
            this.SelectTeamDropDown.Location = new System.Drawing.Point(27, 265);
            this.SelectTeamDropDown.Name = "SelectTeamDropDown";
            this.SelectTeamDropDown.Size = new System.Drawing.Size(258, 38);
            this.SelectTeamDropDown.TabIndex = 14;
            // 
            // SelectTeamLabel
            // 
            this.SelectTeamLabel.AutoSize = true;
            this.SelectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectTeamLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SelectTeamLabel.Location = new System.Drawing.Point(27, 232);
            this.SelectTeamLabel.Name = "SelectTeamLabel";
            this.SelectTeamLabel.Size = new System.Drawing.Size(123, 30);
            this.SelectTeamLabel.TabIndex = 13;
            this.SelectTeamLabel.Text = "Select Team";
            // 
            // CreateNewTeamLink
            // 
            this.CreateNewTeamLink.AutoSize = true;
            this.CreateNewTeamLink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateNewTeamLink.Location = new System.Drawing.Point(186, 244);
            this.CreateNewTeamLink.Name = "CreateNewTeamLink";
            this.CreateNewTeamLink.Size = new System.Drawing.Size(99, 15);
            this.CreateNewTeamLink.TabIndex = 15;
            this.CreateNewTeamLink.TabStop = true;
            this.CreateNewTeamLink.Text = "Create New Team";
            // 
            // AddTeamButton
            // 
            this.AddTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AddTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AddTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AddTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddTeamButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddTeamButton.Location = new System.Drawing.Point(79, 309);
            this.AddTeamButton.Name = "AddTeamButton";
            this.AddTeamButton.Size = new System.Drawing.Size(166, 31);
            this.AddTeamButton.TabIndex = 16;
            this.AddTeamButton.Text = "Add Team";
            this.AddTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeButton
            // 
            this.CreatePrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreatePrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreatePrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreatePrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatePrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreatePrizeButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CreatePrizeButton.Location = new System.Drawing.Point(79, 346);
            this.CreatePrizeButton.Name = "CreatePrizeButton";
            this.CreatePrizeButton.Size = new System.Drawing.Size(166, 31);
            this.CreatePrizeButton.TabIndex = 17;
            this.CreatePrizeButton.Text = "Create Prize";
            this.CreatePrizeButton.UseVisualStyleBackColor = true;
            // 
            // TournamentPlayersListBox
            // 
            this.TournamentPlayersListBox.FormattingEnabled = true;
            this.TournamentPlayersListBox.ItemHeight = 30;
            this.TournamentPlayersListBox.Location = new System.Drawing.Point(322, 109);
            this.TournamentPlayersListBox.Name = "TournamentPlayersListBox";
            this.TournamentPlayersListBox.Size = new System.Drawing.Size(284, 124);
            this.TournamentPlayersListBox.TabIndex = 18;
            this.TournamentPlayersListBox.SelectedIndexChanged += new System.EventHandler(this.TournamentPlayersListBox_SelectedIndexChanged);
            // 
            // TournamentPlayerLabel
            // 
            this.TournamentPlayerLabel.AutoSize = true;
            this.TournamentPlayerLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TournamentPlayerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TournamentPlayerLabel.Location = new System.Drawing.Point(322, 76);
            this.TournamentPlayerLabel.Name = "TournamentPlayerLabel";
            this.TournamentPlayerLabel.Size = new System.Drawing.Size(147, 30);
            this.TournamentPlayerLabel.TabIndex = 19;
            this.TournamentPlayerLabel.Text = "Team / Players";
            // 
            // DeleteSelectedPlayer
            // 
            this.DeleteSelectedPlayer.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DeleteSelectedPlayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DeleteSelectedPlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DeleteSelectedPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedPlayer.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteSelectedPlayer.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.DeleteSelectedPlayer.Location = new System.Drawing.Point(612, 309);
            this.DeleteSelectedPlayer.Name = "DeleteSelectedPlayer";
            this.DeleteSelectedPlayer.Size = new System.Drawing.Size(107, 80);
            this.DeleteSelectedPlayer.TabIndex = 20;
            this.DeleteSelectedPlayer.Text = "Delete Selected";
            this.DeleteSelectedPlayer.UseVisualStyleBackColor = true;
            // 
            // DeleteSelectedPrizeButton
            // 
            this.DeleteSelectedPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DeleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DeleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DeleteSelectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteSelectedPrizeButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.DeleteSelectedPrizeButton.Location = new System.Drawing.Point(612, 135);
            this.DeleteSelectedPrizeButton.Name = "DeleteSelectedPrizeButton";
            this.DeleteSelectedPrizeButton.Size = new System.Drawing.Size(107, 80);
            this.DeleteSelectedPrizeButton.TabIndex = 23;
            this.DeleteSelectedPrizeButton.Text = "Delete Selected";
            this.DeleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // PrizesLabel
            // 
            this.PrizesLabel.AutoSize = true;
            this.PrizesLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrizesLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PrizesLabel.Location = new System.Drawing.Point(322, 248);
            this.PrizesLabel.Name = "PrizesLabel";
            this.PrizesLabel.Size = new System.Drawing.Size(147, 30);
            this.PrizesLabel.TabIndex = 22;
            this.PrizesLabel.Text = "Team / Players";
            // 
            // PrizesListBox
            // 
            this.PrizesListBox.FormattingEnabled = true;
            this.PrizesListBox.ItemHeight = 30;
            this.PrizesListBox.Location = new System.Drawing.Point(322, 281);
            this.PrizesListBox.Name = "PrizesListBox";
            this.PrizesListBox.Size = new System.Drawing.Size(284, 124);
            this.PrizesListBox.TabIndex = 21;
            // 
            // CreateTournamentButton
            // 
            this.CreateTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateTournamentButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CreateTournamentButton.Location = new System.Drawing.Point(277, 434);
            this.CreateTournamentButton.Name = "CreateTournamentButton";
            this.CreateTournamentButton.Size = new System.Drawing.Size(192, 31);
            this.CreateTournamentButton.TabIndex = 24;
            this.CreateTournamentButton.Text = "Create Tournament";
            this.CreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TeamOneScoreLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 498);
            this.Controls.Add(this.CreateTournamentButton);
            this.Controls.Add(this.DeleteSelectedPrizeButton);
            this.Controls.Add(this.PrizesLabel);
            this.Controls.Add(this.PrizesListBox);
            this.Controls.Add(this.DeleteSelectedPlayer);
            this.Controls.Add(this.TournamentPlayerLabel);
            this.Controls.Add(this.TournamentPlayersListBox);
            this.Controls.Add(this.CreatePrizeButton);
            this.Controls.Add(this.AddTeamButton);
            this.Controls.Add(this.CreateNewTeamLink);
            this.Controls.Add(this.SelectTeamDropDown);
            this.Controls.Add(this.SelectTeamLabel);
            this.Controls.Add(this.EntryFeeValue);
            this.Controls.Add(this.EntryFeeLabel);
            this.Controls.Add(this.TournamentNameValue);
            this.Controls.Add(this.TournamentNameLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TeamOneScoreLabel";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label HeaderLabel;
        private TextBox TournamentNameValue;
        private Label TournamentNameLabel;
        private Label EntryFeeLabel;
        private TextBox EntryFeeValue;
        private ComboBox SelectTeamDropDown;
        private Label SelectTeamLabel;
        private LinkLabel CreateNewTeamLink;
        private Button AddTeamButton;
        private Button CreatePrizeButton;
        private ListBox TournamentPlayersListBox;
        private Label TournamentPlayerLabel;
        private Button DeleteSelectedPlayer;
        private Button DeleteSelectedPrizeButton;
        private Label PrizesLabel;
        private ListBox PrizesListBox;
        private Button CreateTournamentButton;
    }
}