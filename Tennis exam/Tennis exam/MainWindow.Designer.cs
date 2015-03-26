namespace Tennis_exam
{
    partial class MainWindow
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPlayers = new System.Windows.Forms.TabPage();
            this.buttonPlayerRemove = new System.Windows.Forms.Button();
            this.buttonPlayerAdd = new System.Windows.Forms.Button();
            this.buttonPlayerAutoAdd = new System.Windows.Forms.Button();
            this.dataGridViewPlayer = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelPlayerGender = new System.Windows.Forms.Label();
            this.comboPlayerGender = new System.Windows.Forms.ComboBox();
            this.labelPlayerNationality = new System.Windows.Forms.Label();
            this.comboPlayerNationality = new System.Windows.Forms.ComboBox();
            this.datePlayerDOB = new System.Windows.Forms.DateTimePicker();
            this.labelPlayerDateOfBirth = new System.Windows.Forms.Label();
            this.textPlayerLastName = new System.Windows.Forms.TextBox();
            this.labelPlayerLastName = new System.Windows.Forms.Label();
            this.labelPlayerFirstName = new System.Windows.Forms.Label();
            this.textPlayerMiddleName = new System.Windows.Forms.TextBox();
            this.textPlayerFirstName = new System.Windows.Forms.TextBox();
            this.labelPlayerMiddelName = new System.Windows.Forms.Label();
            this.TabReferee = new System.Windows.Forms.TabPage();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.labelRefereeFirstName = new System.Windows.Forms.Label();
            this.textRefereeFirstName = new System.Windows.Forms.TextBox();
            this.labelRefereeMiddleName = new System.Windows.Forms.Label();
            this.textRefereeMiddleName = new System.Windows.Forms.TextBox();
            this.labelRefereeLastName = new System.Windows.Forms.Label();
            this.textRefereeLastName = new System.Windows.Forms.TextBox();
            this.labelRefereeDOB = new System.Windows.Forms.Label();
            this.dateRefereeDOB = new System.Windows.Forms.DateTimePicker();
            this.comboRefereeNationality = new System.Windows.Forms.ComboBox();
            this.labelRefereeNationality = new System.Windows.Forms.Label();
            this.comboRefereeGender = new System.Windows.Forms.ComboBox();
            this.labelRefereeGender = new System.Windows.Forms.Label();
            this.dataGridViewReferee = new System.Windows.Forms.DataGridView();
            this.buttonRefereeAdd = new System.Windows.Forms.Button();
            this.buttonRefereeRemove = new System.Windows.Forms.Button();
            this.buttonRefereeAutoAdd = new System.Windows.Forms.Button();
            this.dateRefereeLicenseAcquired = new System.Windows.Forms.DateTimePicker();
            this.dateRefereeLicenseRenewed = new System.Windows.Forms.DateTimePicker();
            this.labelRefereeLicenseAcquired = new System.Windows.Forms.Label();
            this.labelRefereeLicenseRenewed = new System.Windows.Forms.Label();
            this.checkRefereeNeverRenewed = new System.Windows.Forms.CheckBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicenseAcquired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicenseRenewed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.TabPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayer)).BeginInit();
            this.TabReferee.SuspendLayout();
            this.groupBoxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReferee)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPlayers);
            this.tabControl1.Controls.Add(this.TabReferee);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(3, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1076, 187);
            this.tabControl1.TabIndex = 0;
            // 
            // TabPlayers
            // 
            this.TabPlayers.Controls.Add(this.buttonPlayerRemove);
            this.TabPlayers.Controls.Add(this.buttonPlayerAdd);
            this.TabPlayers.Controls.Add(this.buttonPlayerAutoAdd);
            this.TabPlayers.Controls.Add(this.dataGridViewPlayer);
            this.TabPlayers.Controls.Add(this.labelPlayerGender);
            this.TabPlayers.Controls.Add(this.comboPlayerGender);
            this.TabPlayers.Controls.Add(this.labelPlayerNationality);
            this.TabPlayers.Controls.Add(this.comboPlayerNationality);
            this.TabPlayers.Controls.Add(this.datePlayerDOB);
            this.TabPlayers.Controls.Add(this.labelPlayerDateOfBirth);
            this.TabPlayers.Controls.Add(this.textPlayerLastName);
            this.TabPlayers.Controls.Add(this.labelPlayerLastName);
            this.TabPlayers.Controls.Add(this.labelPlayerFirstName);
            this.TabPlayers.Controls.Add(this.textPlayerMiddleName);
            this.TabPlayers.Controls.Add(this.textPlayerFirstName);
            this.TabPlayers.Controls.Add(this.labelPlayerMiddelName);
            this.TabPlayers.Location = new System.Drawing.Point(4, 22);
            this.TabPlayers.Name = "TabPlayers";
            this.TabPlayers.Padding = new System.Windows.Forms.Padding(3);
            this.TabPlayers.Size = new System.Drawing.Size(1068, 161);
            this.TabPlayers.TabIndex = 1;
            this.TabPlayers.Text = "Player";
            this.TabPlayers.UseVisualStyleBackColor = true;
            // 
            // buttonPlayerRemove
            // 
            this.buttonPlayerRemove.Location = new System.Drawing.Point(249, 132);
            this.buttonPlayerRemove.Name = "buttonPlayerRemove";
            this.buttonPlayerRemove.Size = new System.Drawing.Size(69, 23);
            this.buttonPlayerRemove.TabIndex = 14;
            this.buttonPlayerRemove.Text = "Remove";
            this.buttonPlayerRemove.UseVisualStyleBackColor = true;
            this.buttonPlayerRemove.Click += new System.EventHandler(this.buttonPlayerRemove_Click);
            // 
            // buttonPlayerAdd
            // 
            this.buttonPlayerAdd.Location = new System.Drawing.Point(175, 132);
            this.buttonPlayerAdd.Name = "buttonPlayerAdd";
            this.buttonPlayerAdd.Size = new System.Drawing.Size(69, 23);
            this.buttonPlayerAdd.TabIndex = 13;
            this.buttonPlayerAdd.Text = "Add";
            this.buttonPlayerAdd.UseVisualStyleBackColor = true;
            this.buttonPlayerAdd.Click += new System.EventHandler(this.buttonAddPlayer_Click);
            // 
            // buttonPlayerAutoAdd
            // 
            this.buttonPlayerAutoAdd.Location = new System.Drawing.Point(6, 132);
            this.buttonPlayerAutoAdd.Name = "buttonPlayerAutoAdd";
            this.buttonPlayerAutoAdd.Size = new System.Drawing.Size(69, 23);
            this.buttonPlayerAutoAdd.TabIndex = 12;
            this.buttonPlayerAutoAdd.Text = "Auto Add";
            this.buttonPlayerAutoAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPlayer
            // 
            this.dataGridViewPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.FirstName,
            this.MiddleName,
            this.LastName,
            this.DateOfBirth,
            this.Age,
            this.Nationality,
            this.Gender});
            this.dataGridViewPlayer.Location = new System.Drawing.Point(324, 6);
            this.dataGridViewPlayer.Name = "dataGridViewPlayer";
            this.dataGridViewPlayer.Size = new System.Drawing.Size(732, 149);
            this.dataGridViewPlayer.TabIndex = 1;
            // 
            // No
            // 
            this.No.HeaderText = "Object";
            this.No.Name = "No";
            this.No.Visible = false;
            this.No.Width = 35;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Frist Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // MiddleName
            // 
            this.MiddleName.HeaderText = "Middle Name";
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.HeaderText = "Date Of Birth";
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            this.Age.Width = 50;
            // 
            // Nationality
            // 
            this.Nationality.HeaderText = "Nationality";
            this.Nationality.Name = "Nationality";
            this.Nationality.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // labelPlayerGender
            // 
            this.labelPlayerGender.AutoSize = true;
            this.labelPlayerGender.Location = new System.Drawing.Point(172, 80);
            this.labelPlayerGender.Name = "labelPlayerGender";
            this.labelPlayerGender.Size = new System.Drawing.Size(42, 13);
            this.labelPlayerGender.TabIndex = 10;
            this.labelPlayerGender.Text = "Gender";
            // 
            // comboPlayerGender
            // 
            this.comboPlayerGender.FormattingEnabled = true;
            this.comboPlayerGender.Location = new System.Drawing.Point(175, 96);
            this.comboPlayerGender.Name = "comboPlayerGender";
            this.comboPlayerGender.Size = new System.Drawing.Size(143, 21);
            this.comboPlayerGender.TabIndex = 11;
            // 
            // labelPlayerNationality
            // 
            this.labelPlayerNationality.AutoSize = true;
            this.labelPlayerNationality.Location = new System.Drawing.Point(172, 42);
            this.labelPlayerNationality.Name = "labelPlayerNationality";
            this.labelPlayerNationality.Size = new System.Drawing.Size(56, 13);
            this.labelPlayerNationality.TabIndex = 8;
            this.labelPlayerNationality.Text = "Nationality";
            // 
            // comboPlayerNationality
            // 
            this.comboPlayerNationality.FormattingEnabled = true;
            this.comboPlayerNationality.Location = new System.Drawing.Point(175, 57);
            this.comboPlayerNationality.Name = "comboPlayerNationality";
            this.comboPlayerNationality.Size = new System.Drawing.Size(143, 21);
            this.comboPlayerNationality.TabIndex = 9;
            // 
            // datePlayerDOB
            // 
            this.datePlayerDOB.Location = new System.Drawing.Point(175, 19);
            this.datePlayerDOB.Name = "datePlayerDOB";
            this.datePlayerDOB.Size = new System.Drawing.Size(143, 20);
            this.datePlayerDOB.TabIndex = 7;
            this.datePlayerDOB.Value = new System.DateTime(2015, 3, 25, 0, 0, 0, 0);
            // 
            // labelPlayerDateOfBirth
            // 
            this.labelPlayerDateOfBirth.AutoSize = true;
            this.labelPlayerDateOfBirth.Location = new System.Drawing.Point(172, 3);
            this.labelPlayerDateOfBirth.Name = "labelPlayerDateOfBirth";
            this.labelPlayerDateOfBirth.Size = new System.Drawing.Size(71, 13);
            this.labelPlayerDateOfBirth.TabIndex = 6;
            this.labelPlayerDateOfBirth.Text = "Date Of Birth:";
            // 
            // textPlayerLastName
            // 
            this.textPlayerLastName.Location = new System.Drawing.Point(6, 97);
            this.textPlayerLastName.Name = "textPlayerLastName";
            this.textPlayerLastName.Size = new System.Drawing.Size(143, 20);
            this.textPlayerLastName.TabIndex = 5;
            // 
            // labelPlayerLastName
            // 
            this.labelPlayerLastName.AutoSize = true;
            this.labelPlayerLastName.Location = new System.Drawing.Point(3, 81);
            this.labelPlayerLastName.Name = "labelPlayerLastName";
            this.labelPlayerLastName.Size = new System.Drawing.Size(61, 13);
            this.labelPlayerLastName.TabIndex = 4;
            this.labelPlayerLastName.Text = "Last Name:";
            // 
            // labelPlayerFirstName
            // 
            this.labelPlayerFirstName.AutoSize = true;
            this.labelPlayerFirstName.Location = new System.Drawing.Point(3, 3);
            this.labelPlayerFirstName.Name = "labelPlayerFirstName";
            this.labelPlayerFirstName.Size = new System.Drawing.Size(60, 13);
            this.labelPlayerFirstName.TabIndex = 0;
            this.labelPlayerFirstName.Text = "First Name:";
            // 
            // textPlayerMiddleName
            // 
            this.textPlayerMiddleName.Location = new System.Drawing.Point(6, 58);
            this.textPlayerMiddleName.Name = "textPlayerMiddleName";
            this.textPlayerMiddleName.Size = new System.Drawing.Size(143, 20);
            this.textPlayerMiddleName.TabIndex = 3;
            // 
            // textPlayerFirstName
            // 
            this.textPlayerFirstName.Location = new System.Drawing.Point(6, 19);
            this.textPlayerFirstName.Name = "textPlayerFirstName";
            this.textPlayerFirstName.Size = new System.Drawing.Size(143, 20);
            this.textPlayerFirstName.TabIndex = 1;
            // 
            // labelPlayerMiddelName
            // 
            this.labelPlayerMiddelName.AutoSize = true;
            this.labelPlayerMiddelName.Location = new System.Drawing.Point(3, 42);
            this.labelPlayerMiddelName.Name = "labelPlayerMiddelName";
            this.labelPlayerMiddelName.Size = new System.Drawing.Size(72, 13);
            this.labelPlayerMiddelName.TabIndex = 2;
            this.labelPlayerMiddelName.Text = "Middle Name:";
            // 
            // TabReferee
            // 
            this.TabReferee.Controls.Add(this.checkRefereeNeverRenewed);
            this.TabReferee.Controls.Add(this.labelRefereeLicenseRenewed);
            this.TabReferee.Controls.Add(this.labelRefereeLicenseAcquired);
            this.TabReferee.Controls.Add(this.dateRefereeLicenseRenewed);
            this.TabReferee.Controls.Add(this.dateRefereeLicenseAcquired);
            this.TabReferee.Controls.Add(this.buttonRefereeAutoAdd);
            this.TabReferee.Controls.Add(this.buttonRefereeRemove);
            this.TabReferee.Controls.Add(this.buttonRefereeAdd);
            this.TabReferee.Controls.Add(this.dataGridViewReferee);
            this.TabReferee.Controls.Add(this.labelRefereeGender);
            this.TabReferee.Controls.Add(this.comboRefereeGender);
            this.TabReferee.Controls.Add(this.labelRefereeNationality);
            this.TabReferee.Controls.Add(this.comboRefereeNationality);
            this.TabReferee.Controls.Add(this.dateRefereeDOB);
            this.TabReferee.Controls.Add(this.labelRefereeDOB);
            this.TabReferee.Controls.Add(this.textRefereeLastName);
            this.TabReferee.Controls.Add(this.labelRefereeLastName);
            this.TabReferee.Controls.Add(this.textRefereeMiddleName);
            this.TabReferee.Controls.Add(this.labelRefereeMiddleName);
            this.TabReferee.Controls.Add(this.textRefereeFirstName);
            this.TabReferee.Controls.Add(this.labelRefereeFirstName);
            this.TabReferee.Location = new System.Drawing.Point(4, 22);
            this.TabReferee.Name = "TabReferee";
            this.TabReferee.Padding = new System.Windows.Forms.Padding(3);
            this.TabReferee.Size = new System.Drawing.Size(1068, 161);
            this.TabReferee.TabIndex = 0;
            this.TabReferee.Text = "Referee";
            this.TabReferee.UseVisualStyleBackColor = true;
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.tabControl1);
            this.groupBoxAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxAdd.Location = new System.Drawing.Point(0, 376);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(1082, 212);
            this.groupBoxAdd.TabIndex = 1;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Add";
            // 
            // labelRefereeFirstName
            // 
            this.labelRefereeFirstName.AutoSize = true;
            this.labelRefereeFirstName.Location = new System.Drawing.Point(3, 3);
            this.labelRefereeFirstName.Name = "labelRefereeFirstName";
            this.labelRefereeFirstName.Size = new System.Drawing.Size(60, 13);
            this.labelRefereeFirstName.TabIndex = 1;
            this.labelRefereeFirstName.Text = "First Name:";
            // 
            // textRefereeFirstName
            // 
            this.textRefereeFirstName.Location = new System.Drawing.Point(6, 19);
            this.textRefereeFirstName.Name = "textRefereeFirstName";
            this.textRefereeFirstName.Size = new System.Drawing.Size(143, 20);
            this.textRefereeFirstName.TabIndex = 2;
            // 
            // labelRefereeMiddleName
            // 
            this.labelRefereeMiddleName.AutoSize = true;
            this.labelRefereeMiddleName.Location = new System.Drawing.Point(3, 42);
            this.labelRefereeMiddleName.Name = "labelRefereeMiddleName";
            this.labelRefereeMiddleName.Size = new System.Drawing.Size(72, 13);
            this.labelRefereeMiddleName.TabIndex = 3;
            this.labelRefereeMiddleName.Text = "Middle Name:";
            // 
            // textRefereeMiddleName
            // 
            this.textRefereeMiddleName.Location = new System.Drawing.Point(6, 58);
            this.textRefereeMiddleName.Name = "textRefereeMiddleName";
            this.textRefereeMiddleName.Size = new System.Drawing.Size(143, 20);
            this.textRefereeMiddleName.TabIndex = 4;
            // 
            // labelRefereeLastName
            // 
            this.labelRefereeLastName.AutoSize = true;
            this.labelRefereeLastName.Location = new System.Drawing.Point(3, 81);
            this.labelRefereeLastName.Name = "labelRefereeLastName";
            this.labelRefereeLastName.Size = new System.Drawing.Size(61, 13);
            this.labelRefereeLastName.TabIndex = 5;
            this.labelRefereeLastName.Text = "Last Name:";
            // 
            // textRefereeLastName
            // 
            this.textRefereeLastName.Location = new System.Drawing.Point(6, 97);
            this.textRefereeLastName.Name = "textRefereeLastName";
            this.textRefereeLastName.Size = new System.Drawing.Size(143, 20);
            this.textRefereeLastName.TabIndex = 6;
            // 
            // labelRefereeDOB
            // 
            this.labelRefereeDOB.AutoSize = true;
            this.labelRefereeDOB.Location = new System.Drawing.Point(172, 3);
            this.labelRefereeDOB.Name = "labelRefereeDOB";
            this.labelRefereeDOB.Size = new System.Drawing.Size(71, 13);
            this.labelRefereeDOB.TabIndex = 7;
            this.labelRefereeDOB.Text = "Date Of Birth:";
            // 
            // dateRefereeDOB
            // 
            this.dateRefereeDOB.Location = new System.Drawing.Point(175, 19);
            this.dateRefereeDOB.Name = "dateRefereeDOB";
            this.dateRefereeDOB.Size = new System.Drawing.Size(143, 20);
            this.dateRefereeDOB.TabIndex = 8;
            this.dateRefereeDOB.Value = new System.DateTime(2015, 3, 25, 0, 0, 0, 0);
            // 
            // comboRefereeNationality
            // 
            this.comboRefereeNationality.FormattingEnabled = true;
            this.comboRefereeNationality.Location = new System.Drawing.Point(175, 57);
            this.comboRefereeNationality.Name = "comboRefereeNationality";
            this.comboRefereeNationality.Size = new System.Drawing.Size(143, 21);
            this.comboRefereeNationality.TabIndex = 10;
            // 
            // labelRefereeNationality
            // 
            this.labelRefereeNationality.AutoSize = true;
            this.labelRefereeNationality.Location = new System.Drawing.Point(172, 42);
            this.labelRefereeNationality.Name = "labelRefereeNationality";
            this.labelRefereeNationality.Size = new System.Drawing.Size(56, 13);
            this.labelRefereeNationality.TabIndex = 11;
            this.labelRefereeNationality.Text = "Nationality";
            // 
            // comboRefereeGender
            // 
            this.comboRefereeGender.FormattingEnabled = true;
            this.comboRefereeGender.Location = new System.Drawing.Point(175, 96);
            this.comboRefereeGender.Name = "comboRefereeGender";
            this.comboRefereeGender.Size = new System.Drawing.Size(143, 21);
            this.comboRefereeGender.TabIndex = 12;
            // 
            // labelRefereeGender
            // 
            this.labelRefereeGender.AutoSize = true;
            this.labelRefereeGender.Location = new System.Drawing.Point(172, 80);
            this.labelRefereeGender.Name = "labelRefereeGender";
            this.labelRefereeGender.Size = new System.Drawing.Size(42, 13);
            this.labelRefereeGender.TabIndex = 13;
            this.labelRefereeGender.Text = "Gender";
            // 
            // dataGridViewReferee
            // 
            this.dataGridViewReferee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReferee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.LicenseAcquired,
            this.LicenseRenewed});
            this.dataGridViewReferee.Location = new System.Drawing.Point(493, 6);
            this.dataGridViewReferee.Name = "dataGridViewReferee";
            this.dataGridViewReferee.Size = new System.Drawing.Size(563, 149);
            this.dataGridViewReferee.TabIndex = 14;
            // 
            // buttonRefereeAdd
            // 
            this.buttonRefereeAdd.Location = new System.Drawing.Point(175, 132);
            this.buttonRefereeAdd.Name = "buttonRefereeAdd";
            this.buttonRefereeAdd.Size = new System.Drawing.Size(69, 23);
            this.buttonRefereeAdd.TabIndex = 15;
            this.buttonRefereeAdd.Text = "Add";
            this.buttonRefereeAdd.UseVisualStyleBackColor = true;
            this.buttonRefereeAdd.Click += new System.EventHandler(this.buttonRefereeAdd_Click);
            // 
            // buttonRefereeRemove
            // 
            this.buttonRefereeRemove.Location = new System.Drawing.Point(249, 132);
            this.buttonRefereeRemove.Name = "buttonRefereeRemove";
            this.buttonRefereeRemove.Size = new System.Drawing.Size(69, 23);
            this.buttonRefereeRemove.TabIndex = 16;
            this.buttonRefereeRemove.Text = "Remove";
            this.buttonRefereeRemove.UseVisualStyleBackColor = true;
            this.buttonRefereeRemove.Click += new System.EventHandler(this.buttonRefereeRemove_Click);
            // 
            // buttonRefereeAutoAdd
            // 
            this.buttonRefereeAutoAdd.Location = new System.Drawing.Point(6, 132);
            this.buttonRefereeAutoAdd.Name = "buttonRefereeAutoAdd";
            this.buttonRefereeAutoAdd.Size = new System.Drawing.Size(69, 23);
            this.buttonRefereeAutoAdd.TabIndex = 17;
            this.buttonRefereeAutoAdd.Text = "Auto Add";
            this.buttonRefereeAutoAdd.UseVisualStyleBackColor = true;
            // 
            // dateRefereeLicenseAcquired
            // 
            this.dateRefereeLicenseAcquired.Location = new System.Drawing.Point(344, 19);
            this.dateRefereeLicenseAcquired.Name = "dateRefereeLicenseAcquired";
            this.dateRefereeLicenseAcquired.Size = new System.Drawing.Size(143, 20);
            this.dateRefereeLicenseAcquired.TabIndex = 18;
            this.dateRefereeLicenseAcquired.Value = new System.DateTime(2015, 3, 25, 0, 0, 0, 0);
            // 
            // dateRefereeLicenseRenewed
            // 
            this.dateRefereeLicenseRenewed.Location = new System.Drawing.Point(344, 57);
            this.dateRefereeLicenseRenewed.Name = "dateRefereeLicenseRenewed";
            this.dateRefereeLicenseRenewed.Size = new System.Drawing.Size(143, 20);
            this.dateRefereeLicenseRenewed.TabIndex = 19;
            this.dateRefereeLicenseRenewed.Value = new System.DateTime(2015, 3, 25, 0, 0, 0, 0);
            // 
            // labelRefereeLicenseAcquired
            // 
            this.labelRefereeLicenseAcquired.AutoSize = true;
            this.labelRefereeLicenseAcquired.Location = new System.Drawing.Point(341, 3);
            this.labelRefereeLicenseAcquired.Name = "labelRefereeLicenseAcquired";
            this.labelRefereeLicenseAcquired.Size = new System.Drawing.Size(93, 13);
            this.labelRefereeLicenseAcquired.TabIndex = 20;
            this.labelRefereeLicenseAcquired.Text = "Licence Acquired:";
            // 
            // labelRefereeLicenseRenewed
            // 
            this.labelRefereeLicenseRenewed.AutoSize = true;
            this.labelRefereeLicenseRenewed.Location = new System.Drawing.Point(341, 42);
            this.labelRefereeLicenseRenewed.Name = "labelRefereeLicenseRenewed";
            this.labelRefereeLicenseRenewed.Size = new System.Drawing.Size(97, 13);
            this.labelRefereeLicenseRenewed.TabIndex = 21;
            this.labelRefereeLicenseRenewed.Text = "Licence Renewed:";
            // 
            // checkRefereeNeverRenewed
            // 
            this.checkRefereeNeverRenewed.AutoSize = true;
            this.checkRefereeNeverRenewed.Location = new System.Drawing.Point(344, 100);
            this.checkRefereeNeverRenewed.Name = "checkRefereeNeverRenewed";
            this.checkRefereeNeverRenewed.Size = new System.Drawing.Size(144, 17);
            this.checkRefereeNeverRenewed.TabIndex = 22;
            this.checkRefereeNeverRenewed.Text = "License Never Renewed";
            this.checkRefereeNeverRenewed.UseVisualStyleBackColor = true;
            this.checkRefereeNeverRenewed.CheckedChanged += new System.EventHandler(this.checkRefereeNeverRenewed_CheckedChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Object";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 35;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Frist Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Middle Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Date Of Birth";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Age";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Nationality";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // LicenseAcquired
            // 
            this.LicenseAcquired.HeaderText = "License Acquired";
            this.LicenseAcquired.Name = "LicenseAcquired";
            // 
            // LicenseRenewed
            // 
            this.LicenseRenewed.HeaderText = "License Renewed";
            this.LicenseRenewed.Name = "LicenseRenewed";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 588);
            this.Controls.Add(this.groupBoxAdd);
            this.Name = "MainWindow";
            this.Text = "Tennis Sim";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabPlayers.ResumeLayout(false);
            this.TabPlayers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayer)).EndInit();
            this.TabReferee.ResumeLayout(false);
            this.TabReferee.PerformLayout();
            this.groupBoxAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReferee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabReferee;
        private System.Windows.Forms.TabPage TabPlayers;
        private System.Windows.Forms.Label labelPlayerFirstName;
        private System.Windows.Forms.TextBox textPlayerFirstName;
        private System.Windows.Forms.Label labelPlayerMiddelName;
        private System.Windows.Forms.TextBox textPlayerMiddleName;
        private System.Windows.Forms.Label labelPlayerLastName;
        private System.Windows.Forms.TextBox textPlayerLastName;
        private System.Windows.Forms.Label labelPlayerDateOfBirth;
        private System.Windows.Forms.DateTimePicker datePlayerDOB;
        private System.Windows.Forms.Button buttonPlayerAdd;
        private System.Windows.Forms.DataGridView dataGridViewPlayer;
        private System.Windows.Forms.Label labelPlayerNationality;
        private System.Windows.Forms.ComboBox comboPlayerNationality;
        private System.Windows.Forms.Label labelPlayerGender;
        private System.Windows.Forms.ComboBox comboPlayerGender;
        private System.Windows.Forms.Button buttonPlayerAutoAdd;
        private System.Windows.Forms.Button buttonPlayerRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.Label labelRefereeDOB;
        private System.Windows.Forms.TextBox textRefereeLastName;
        private System.Windows.Forms.Label labelRefereeLastName;
        private System.Windows.Forms.TextBox textRefereeMiddleName;
        private System.Windows.Forms.Label labelRefereeMiddleName;
        private System.Windows.Forms.TextBox textRefereeFirstName;
        private System.Windows.Forms.Label labelRefereeFirstName;
        private System.Windows.Forms.DateTimePicker dateRefereeDOB;
        private System.Windows.Forms.Button buttonRefereeAutoAdd;
        private System.Windows.Forms.Button buttonRefereeRemove;
        private System.Windows.Forms.Button buttonRefereeAdd;
        private System.Windows.Forms.DataGridView dataGridViewReferee;
        private System.Windows.Forms.Label labelRefereeGender;
        private System.Windows.Forms.ComboBox comboRefereeGender;
        private System.Windows.Forms.Label labelRefereeNationality;
        private System.Windows.Forms.ComboBox comboRefereeNationality;
        private System.Windows.Forms.Label labelRefereeLicenseAcquired;
        private System.Windows.Forms.DateTimePicker dateRefereeLicenseRenewed;
        private System.Windows.Forms.DateTimePicker dateRefereeLicenseAcquired;
        private System.Windows.Forms.Label labelRefereeLicenseRenewed;
        private System.Windows.Forms.CheckBox checkRefereeNeverRenewed;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicenseAcquired;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicenseRenewed;
    }
}

