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
            this.TeamNameValue = new System.Windows.Forms.TextBox();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.CreateTeamLabel = new System.Windows.Forms.Label();
            this.AddMemberButton = new System.Windows.Forms.Button();
            this.SelectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.SelectTeamMemberLabel = new System.Windows.Forms.Label();
            this.AddNewMemberGroupBox = new System.Windows.Forms.GroupBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameValue = new System.Windows.Forms.TextBox();
            this.LastNameValue = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.EmailValue = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.ContactNumberValue = new System.Windows.Forms.TextBox();
            this.ContactNumberLabel = new System.Windows.Forms.Label();
            this.CreateMemberButton = new System.Windows.Forms.Button();
            this.TeamMemberListBox = new System.Windows.Forms.ListBox();
            this.DeleteSelectedMemberButton = new System.Windows.Forms.Button();
            this.CreateTeamButton = new System.Windows.Forms.Button();
            this.AddNewMemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeamNameValue
            // 
            this.TeamNameValue.Location = new System.Drawing.Point(24, 105);
            this.TeamNameValue.Name = "TeamNameValue";
            this.TeamNameValue.Size = new System.Drawing.Size(331, 23);
            this.TeamNameValue.TabIndex = 13;
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TeamNameLabel.Location = new System.Drawing.Point(24, 72);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(124, 30);
            this.TeamNameLabel.TabIndex = 12;
            this.TeamNameLabel.Text = "Team Name";
            // 
            // CreateTeamLabel
            // 
            this.CreateTeamLabel.AutoSize = true;
            this.CreateTeamLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateTeamLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CreateTeamLabel.Location = new System.Drawing.Point(24, 23);
            this.CreateTeamLabel.Name = "CreateTeamLabel";
            this.CreateTeamLabel.Size = new System.Drawing.Size(163, 37);
            this.CreateTeamLabel.TabIndex = 11;
            this.CreateTeamLabel.Text = "Create Team";
            // 
            // AddMemberButton
            // 
            this.AddMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AddMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AddMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AddMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddMemberButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddMemberButton.Location = new System.Drawing.Point(116, 193);
            this.AddMemberButton.Name = "AddMemberButton";
            this.AddMemberButton.Size = new System.Drawing.Size(166, 31);
            this.AddMemberButton.TabIndex = 19;
            this.AddMemberButton.Text = "Add Member";
            this.AddMemberButton.UseVisualStyleBackColor = true;
            // 
            // SelectTeamMemberDropDown
            // 
            this.SelectTeamMemberDropDown.FormattingEnabled = true;
            this.SelectTeamMemberDropDown.Location = new System.Drawing.Point(24, 164);
            this.SelectTeamMemberDropDown.Name = "SelectTeamMemberDropDown";
            this.SelectTeamMemberDropDown.Size = new System.Drawing.Size(331, 23);
            this.SelectTeamMemberDropDown.TabIndex = 18;
            // 
            // SelectTeamMemberLabel
            // 
            this.SelectTeamMemberLabel.AutoSize = true;
            this.SelectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectTeamMemberLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SelectTeamMemberLabel.Location = new System.Drawing.Point(24, 131);
            this.SelectTeamMemberLabel.Name = "SelectTeamMemberLabel";
            this.SelectTeamMemberLabel.Size = new System.Drawing.Size(207, 30);
            this.SelectTeamMemberLabel.TabIndex = 17;
            this.SelectTeamMemberLabel.Text = "Select Team Member";
            this.SelectTeamMemberLabel.Click += new System.EventHandler(this.SelectTeamMemberLabel_Click);
            // 
            // AddNewMemberGroupBox
            // 
            this.AddNewMemberGroupBox.Controls.Add(this.CreateMemberButton);
            this.AddNewMemberGroupBox.Controls.Add(this.ContactNumberValue);
            this.AddNewMemberGroupBox.Controls.Add(this.ContactNumberLabel);
            this.AddNewMemberGroupBox.Controls.Add(this.EmailValue);
            this.AddNewMemberGroupBox.Controls.Add(this.EmailLabel);
            this.AddNewMemberGroupBox.Controls.Add(this.LastNameValue);
            this.AddNewMemberGroupBox.Controls.Add(this.LastNameLabel);
            this.AddNewMemberGroupBox.Controls.Add(this.FirstNameValue);
            this.AddNewMemberGroupBox.Controls.Add(this.FirstNameLabel);
            this.AddNewMemberGroupBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddNewMemberGroupBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddNewMemberGroupBox.Location = new System.Drawing.Point(20, 243);
            this.AddNewMemberGroupBox.Name = "AddNewMemberGroupBox";
            this.AddNewMemberGroupBox.Size = new System.Drawing.Size(335, 241);
            this.AddNewMemberGroupBox.TabIndex = 20;
            this.AddNewMemberGroupBox.TabStop = false;
            this.AddNewMemberGroupBox.Text = "Add New Member";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FirstNameLabel.Location = new System.Drawing.Point(6, 53);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(86, 20);
            this.FirstNameLabel.TabIndex = 9;
            this.FirstNameLabel.Text = "First Name";
            // 
            // FirstNameValue
            // 
            this.FirstNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstNameValue.Location = new System.Drawing.Point(137, 50);
            this.FirstNameValue.Name = "FirstNameValue";
            this.FirstNameValue.Size = new System.Drawing.Size(173, 26);
            this.FirstNameValue.TabIndex = 21;
            // 
            // LastNameValue
            // 
            this.LastNameValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastNameValue.Location = new System.Drawing.Point(137, 88);
            this.LastNameValue.Name = "LastNameValue";
            this.LastNameValue.Size = new System.Drawing.Size(173, 29);
            this.LastNameValue.TabIndex = 23;
            this.LastNameValue.TextChanged += new System.EventHandler(this.LastNameValue_TextChanged);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LastNameLabel.Location = new System.Drawing.Point(6, 92);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(86, 20);
            this.LastNameLabel.TabIndex = 22;
            this.LastNameLabel.Text = "Last Name";
            // 
            // EmailValue
            // 
            this.EmailValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailValue.Location = new System.Drawing.Point(137, 129);
            this.EmailValue.Name = "EmailValue";
            this.EmailValue.Size = new System.Drawing.Size(173, 29);
            this.EmailValue.TabIndex = 25;
            this.EmailValue.TextChanged += new System.EventHandler(this.EmailValue_TextChanged);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.EmailLabel.Location = new System.Drawing.Point(6, 133);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(48, 20);
            this.EmailLabel.TabIndex = 24;
            this.EmailLabel.Text = "Email";
            this.EmailLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // ContactNumberValue
            // 
            this.ContactNumberValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContactNumberValue.Location = new System.Drawing.Point(137, 170);
            this.ContactNumberValue.Name = "ContactNumberValue";
            this.ContactNumberValue.Size = new System.Drawing.Size(173, 29);
            this.ContactNumberValue.TabIndex = 27;
            this.ContactNumberValue.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // ContactNumberLabel
            // 
            this.ContactNumberLabel.AutoSize = true;
            this.ContactNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContactNumberLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ContactNumberLabel.Location = new System.Drawing.Point(6, 174);
            this.ContactNumberLabel.Name = "ContactNumberLabel";
            this.ContactNumberLabel.Size = new System.Drawing.Size(125, 20);
            this.ContactNumberLabel.TabIndex = 26;
            this.ContactNumberLabel.Text = "Contact Number";
            this.ContactNumberLabel.Click += new System.EventHandler(this.ContactNumberLabel_Click);
            // 
            // CreateMemberButton
            // 
            this.CreateMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateMemberButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CreateMemberButton.Location = new System.Drawing.Point(96, 204);
            this.CreateMemberButton.Name = "CreateMemberButton";
            this.CreateMemberButton.Size = new System.Drawing.Size(166, 31);
            this.CreateMemberButton.TabIndex = 28;
            this.CreateMemberButton.Text = "Create Member";
            this.CreateMemberButton.UseVisualStyleBackColor = true;
            this.CreateMemberButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // TeamMemberListBox
            // 
            this.TeamMemberListBox.FormattingEnabled = true;
            this.TeamMemberListBox.ItemHeight = 15;
            this.TeamMemberListBox.Location = new System.Drawing.Point(419, 105);
            this.TeamMemberListBox.Name = "TeamMemberListBox";
            this.TeamMemberListBox.Size = new System.Drawing.Size(284, 319);
            this.TeamMemberListBox.TabIndex = 21;
            // 
            // DeleteSelectedMemberButton
            // 
            this.DeleteSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DeleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DeleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DeleteSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteSelectedMemberButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.DeleteSelectedMemberButton.Location = new System.Drawing.Point(490, 447);
            this.DeleteSelectedMemberButton.Name = "DeleteSelectedMemberButton";
            this.DeleteSelectedMemberButton.Size = new System.Drawing.Size(166, 31);
            this.DeleteSelectedMemberButton.TabIndex = 24;
            this.DeleteSelectedMemberButton.Text = "Delete Selected";
            this.DeleteSelectedMemberButton.UseVisualStyleBackColor = true;
            this.DeleteSelectedMemberButton.Click += new System.EventHandler(this.DeleteSelectedPrizeButton_Click);
            // 
            // CreateTeamButton
            // 
            this.CreateTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateTeamButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CreateTeamButton.Location = new System.Drawing.Point(289, 518);
            this.CreateTeamButton.Name = "CreateTeamButton";
            this.CreateTeamButton.Size = new System.Drawing.Size(192, 31);
            this.CreateTeamButton.TabIndex = 25;
            this.CreateTeamButton.Text = "Create Team";
            this.CreateTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 571);
            this.Controls.Add(this.CreateTeamButton);
            this.Controls.Add(this.DeleteSelectedMemberButton);
            this.Controls.Add(this.TeamMemberListBox);
            this.Controls.Add(this.AddNewMemberGroupBox);
            this.Controls.Add(this.AddMemberButton);
            this.Controls.Add(this.SelectTeamMemberDropDown);
            this.Controls.Add(this.SelectTeamMemberLabel);
            this.Controls.Add(this.TeamNameValue);
            this.Controls.Add(this.TeamNameLabel);
            this.Controls.Add(this.CreateTeamLabel);
            this.Name = "CreateTeamForm";
            this.Text = "CreateTeamForm";
            this.AddNewMemberGroupBox.ResumeLayout(false);
            this.AddNewMemberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TeamNameValue;
        private Label TeamNameLabel;
        private Label CreateTeamLabel;
        private Button AddMemberButton;
        private ComboBox SelectTeamMemberDropDown;
        private Label SelectTeamMemberLabel;
        private GroupBox AddNewMemberGroupBox;
        private TextBox ContactNumberValue;
        private Label ContactNumberLabel;
        private TextBox EmailValue;
        private Label EmailLabel;
        private TextBox LastNameValue;
        private Label LastNameLabel;
        private TextBox FirstNameValue;
        private Label FirstNameLabel;
        private Button CreateMemberButton;
        private ListBox TeamMemberListBox;
        private Button DeleteSelectedMemberButton;
        private Button CreateTeamButton;
    }
}