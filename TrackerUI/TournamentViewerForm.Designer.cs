namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.TournamentName = new System.Windows.Forms.Label();
            this.RoundLabel = new System.Windows.Forms.Label();
            this.RoundDropDown = new System.Windows.Forms.ComboBox();
            this.UnplayedOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.MatchUpListBox = new System.Windows.Forms.ListBox();
            this.TeamOneName = new System.Windows.Forms.Label();
            this.TeamOneScoreLabel = new System.Windows.Forms.Label();
            this.TeamOneScoreValue = new System.Windows.Forms.TextBox();
            this.TeamTwoScoreValue = new System.Windows.Forms.TextBox();
            this.TeamTwoScoreLabel = new System.Windows.Forms.Label();
            this.TeamTwoName = new System.Windows.Forms.Label();
            this.VSLabel = new System.Windows.Forms.Label();
            this.ScoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeaderLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.HeaderLabel.Location = new System.Drawing.Point(20, 18);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(178, 37);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Tournament : ";
            // 
            // TournamentName
            // 
            this.TournamentName.AutoSize = true;
            this.TournamentName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TournamentName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TournamentName.Location = new System.Drawing.Point(204, 18);
            this.TournamentName.Name = "TournamentName";
            this.TournamentName.Size = new System.Drawing.Size(113, 37);
            this.TournamentName.TabIndex = 1;
            this.TournamentName.Text = "<none>";
            // 
            // RoundLabel
            // 
            this.RoundLabel.AutoSize = true;
            this.RoundLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoundLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.RoundLabel.Location = new System.Drawing.Point(20, 82);
            this.RoundLabel.Name = "RoundLabel";
            this.RoundLabel.Size = new System.Drawing.Size(73, 30);
            this.RoundLabel.TabIndex = 2;
            this.RoundLabel.Text = "Round";
            this.RoundLabel.Click += new System.EventHandler(this.RoundLabel_Click);
            // 
            // RoundDropDown
            // 
            this.RoundDropDown.FormattingEnabled = true;
            this.RoundDropDown.Location = new System.Drawing.Point(99, 86);
            this.RoundDropDown.Name = "RoundDropDown";
            this.RoundDropDown.Size = new System.Drawing.Size(166, 23);
            this.RoundDropDown.TabIndex = 3;
            // 
            // UnplayedOnlyCheckBox
            // 
            this.UnplayedOnlyCheckBox.AutoSize = true;
            this.UnplayedOnlyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UnplayedOnlyCheckBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UnplayedOnlyCheckBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.UnplayedOnlyCheckBox.Location = new System.Drawing.Point(99, 115);
            this.UnplayedOnlyCheckBox.Name = "UnplayedOnlyCheckBox";
            this.UnplayedOnlyCheckBox.Size = new System.Drawing.Size(166, 34);
            this.UnplayedOnlyCheckBox.TabIndex = 4;
            this.UnplayedOnlyCheckBox.Text = "Unplayed Only";
            this.UnplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // MatchUpListBox
            // 
            this.MatchUpListBox.FormattingEnabled = true;
            this.MatchUpListBox.ItemHeight = 15;
            this.MatchUpListBox.Location = new System.Drawing.Point(20, 167);
            this.MatchUpListBox.Name = "MatchUpListBox";
            this.MatchUpListBox.Size = new System.Drawing.Size(297, 259);
            this.MatchUpListBox.TabIndex = 5;
            // 
            // TeamOneName
            // 
            this.TeamOneName.AutoSize = true;
            this.TeamOneName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamOneName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TeamOneName.Location = new System.Drawing.Point(395, 167);
            this.TeamOneName.Name = "TeamOneName";
            this.TeamOneName.Size = new System.Drawing.Size(107, 30);
            this.TeamOneName.TabIndex = 6;
            this.TeamOneName.Text = "Team One";
            // 
            // TeamOneScoreLabel
            // 
            this.TeamOneScoreLabel.AutoSize = true;
            this.TeamOneScoreLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamOneScoreLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TeamOneScoreLabel.Location = new System.Drawing.Point(395, 207);
            this.TeamOneScoreLabel.Name = "TeamOneScoreLabel";
            this.TeamOneScoreLabel.Size = new System.Drawing.Size(64, 30);
            this.TeamOneScoreLabel.TabIndex = 7;
            this.TeamOneScoreLabel.Text = "Score";
            // 
            // TeamOneScoreValue
            // 
            this.TeamOneScoreValue.Location = new System.Drawing.Point(465, 214);
            this.TeamOneScoreValue.Name = "TeamOneScoreValue";
            this.TeamOneScoreValue.Size = new System.Drawing.Size(100, 23);
            this.TeamOneScoreValue.TabIndex = 8;
            // 
            // TeamTwoScoreValue
            // 
            this.TeamTwoScoreValue.Location = new System.Drawing.Point(465, 343);
            this.TeamTwoScoreValue.Name = "TeamTwoScoreValue";
            this.TeamTwoScoreValue.Size = new System.Drawing.Size(100, 23);
            this.TeamTwoScoreValue.TabIndex = 11;
            // 
            // TeamTwoScoreLabel
            // 
            this.TeamTwoScoreLabel.AutoSize = true;
            this.TeamTwoScoreLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamTwoScoreLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TeamTwoScoreLabel.Location = new System.Drawing.Point(395, 336);
            this.TeamTwoScoreLabel.Name = "TeamTwoScoreLabel";
            this.TeamTwoScoreLabel.Size = new System.Drawing.Size(64, 30);
            this.TeamTwoScoreLabel.TabIndex = 10;
            this.TeamTwoScoreLabel.Text = "Score";
            // 
            // TeamTwoName
            // 
            this.TeamTwoName.AutoSize = true;
            this.TeamTwoName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamTwoName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TeamTwoName.Location = new System.Drawing.Point(395, 296);
            this.TeamTwoName.Name = "TeamTwoName";
            this.TeamTwoName.Size = new System.Drawing.Size(107, 30);
            this.TeamTwoName.TabIndex = 9;
            this.TeamTwoName.Text = "Team One";
            // 
            // VSLabel
            // 
            this.VSLabel.AutoSize = true;
            this.VSLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VSLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.VSLabel.Location = new System.Drawing.Point(465, 257);
            this.VSLabel.Name = "VSLabel";
            this.VSLabel.Size = new System.Drawing.Size(45, 30);
            this.VSLabel.TabIndex = 12;
            this.VSLabel.Text = "V/S";
            // 
            // ScoreButton
            // 
            this.ScoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ScoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ScoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ScoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ScoreButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ScoreButton.Location = new System.Drawing.Point(537, 255);
            this.ScoreButton.Name = "ScoreButton";
            this.ScoreButton.Size = new System.Drawing.Size(94, 42);
            this.ScoreButton.TabIndex = 13;
            this.ScoreButton.Text = "Score";
            this.ScoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 448);
            this.Controls.Add(this.ScoreButton);
            this.Controls.Add(this.VSLabel);
            this.Controls.Add(this.TeamTwoScoreValue);
            this.Controls.Add(this.TeamTwoScoreLabel);
            this.Controls.Add(this.TeamTwoName);
            this.Controls.Add(this.TeamOneScoreValue);
            this.Controls.Add(this.TeamOneScoreLabel);
            this.Controls.Add(this.TeamOneName);
            this.Controls.Add(this.MatchUpListBox);
            this.Controls.Add(this.UnplayedOnlyCheckBox);
            this.Controls.Add(this.RoundDropDown);
            this.Controls.Add(this.RoundLabel);
            this.Controls.Add(this.TournamentName);
            this.Controls.Add(this.HeaderLabel);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament VIewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label HeaderLabel;
        private Label TournamentName;
        private Label RoundLabel;
        private ComboBox RoundDropDown;
        private CheckBox UnplayedOnlyCheckBox;
        private ListBox MatchUpListBox;
        private Label TeamOneName;
        private Label TeamOneScoreLabel;
        private TextBox TeamOneScoreValue;
        private TextBox TeamTwoScoreValue;
        private Label TeamTwoScoreLabel;
        private Label TeamTwoName;
        private Label VSLabel;
        private Button ScoreButton;
    }
}