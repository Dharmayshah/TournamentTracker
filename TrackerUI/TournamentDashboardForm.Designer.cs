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
            this.TournamentDashboardLabel = new System.Windows.Forms.Label();
            this.LoadExistingTournamentLabel = new System.Windows.Forms.Label();
            this.LoadExistingTournamentDropDown = new System.Windows.Forms.ComboBox();
            this.LoadTournamentButton = new System.Windows.Forms.Button();
            this.CreateTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TournamentDashboardLabel
            // 
            this.TournamentDashboardLabel.AutoSize = true;
            this.TournamentDashboardLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TournamentDashboardLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TournamentDashboardLabel.Location = new System.Drawing.Point(150, 29);
            this.TournamentDashboardLabel.Name = "TournamentDashboardLabel";
            this.TournamentDashboardLabel.Size = new System.Drawing.Size(372, 46);
            this.TournamentDashboardLabel.TabIndex = 12;
            this.TournamentDashboardLabel.Text = "Tournament Dashboard";
            this.TournamentDashboardLabel.Click += new System.EventHandler(this.CreateTeamLabel_Click);
            // 
            // LoadExistingTournamentLabel
            // 
            this.LoadExistingTournamentLabel.AutoSize = true;
            this.LoadExistingTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoadExistingTournamentLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LoadExistingTournamentLabel.Location = new System.Drawing.Point(182, 120);
            this.LoadExistingTournamentLabel.Name = "LoadExistingTournamentLabel";
            this.LoadExistingTournamentLabel.Size = new System.Drawing.Size(289, 32);
            this.LoadExistingTournamentLabel.TabIndex = 24;
            this.LoadExistingTournamentLabel.Text = "Load Existing Tournament";
            this.LoadExistingTournamentLabel.Click += new System.EventHandler(this.PlaceNumberLabel_Click);
            // 
            // LoadExistingTournamentDropDown
            // 
            this.LoadExistingTournamentDropDown.FormattingEnabled = true;
            this.LoadExistingTournamentDropDown.Location = new System.Drawing.Point(150, 184);
            this.LoadExistingTournamentDropDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoadExistingTournamentDropDown.Name = "LoadExistingTournamentDropDown";
            this.LoadExistingTournamentDropDown.Size = new System.Drawing.Size(337, 28);
            this.LoadExistingTournamentDropDown.TabIndex = 25;
            // 
            // LoadTournamentButton
            // 
            this.LoadTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.LoadTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.LoadTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.LoadTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoadTournamentButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LoadTournamentButton.Location = new System.Drawing.Point(207, 236);
            this.LoadTournamentButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoadTournamentButton.Name = "LoadTournamentButton";
            this.LoadTournamentButton.Size = new System.Drawing.Size(230, 41);
            this.LoadTournamentButton.TabIndex = 32;
            this.LoadTournamentButton.Text = "Load Tournament";
            this.LoadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentButton
            // 
            this.CreateTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateTournamentButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CreateTournamentButton.Location = new System.Drawing.Point(207, 343);
            this.CreateTournamentButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreateTournamentButton.Name = "CreateTournamentButton";
            this.CreateTournamentButton.Size = new System.Drawing.Size(230, 41);
            this.CreateTournamentButton.TabIndex = 33;
            this.CreateTournamentButton.Text = "Create Tournament";
            this.CreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 451);
            this.Controls.Add(this.CreateTournamentButton);
            this.Controls.Add(this.LoadTournamentButton);
            this.Controls.Add(this.LoadExistingTournamentDropDown);
            this.Controls.Add(this.LoadExistingTournamentLabel);
            this.Controls.Add(this.TournamentDashboardLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TournamentDashboardLabel;
        private Label LoadExistingTournamentLabel;
        private ComboBox LoadExistingTournamentDropDown;
        private Button LoadTournamentButton;
        private Button CreateTournamentButton;
    }
}