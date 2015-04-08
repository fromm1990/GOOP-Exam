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
            this.tabPlayers = new System.Windows.Forms.TabPage();
            this.buttonPlayerSortByLastName = new System.Windows.Forms.Button();
            this.buttonPlayerSortByFirstName = new System.Windows.Forms.Button();
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
            this.tabReferee = new System.Windows.Forms.TabPage();
            this.buttonSetAsGameMaster = new System.Windows.Forms.Button();
            this.buttonRefereeSortByLastName = new System.Windows.Forms.Button();
            this.buttonRefereeSortByFirstName = new System.Windows.Forms.Button();
            this.checkRefereeNeverRenewed = new System.Windows.Forms.CheckBox();
            this.labelRefereeLicenseRenewed = new System.Windows.Forms.Label();
            this.labelRefereeLicenseAcquired = new System.Windows.Forms.Label();
            this.dateRefereeLicenseRenewed = new System.Windows.Forms.DateTimePicker();
            this.dateRefereeLicenseAcquired = new System.Windows.Forms.DateTimePicker();
            this.buttonRefereeAutoAdd = new System.Windows.Forms.Button();
            this.buttonRefereeRemove = new System.Windows.Forms.Button();
            this.buttonRefereeAdd = new System.Windows.Forms.Button();
            this.dataGridViewReferee = new System.Windows.Forms.DataGridView();
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
            this.labelRefereeGender = new System.Windows.Forms.Label();
            this.comboRefereeGender = new System.Windows.Forms.ComboBox();
            this.labelRefereeNationality = new System.Windows.Forms.Label();
            this.comboRefereeNationality = new System.Windows.Forms.ComboBox();
            this.dateRefereeDOB = new System.Windows.Forms.DateTimePicker();
            this.labelRefereeDOB = new System.Windows.Forms.Label();
            this.textRefereeLastName = new System.Windows.Forms.TextBox();
            this.labelRefereeLastName = new System.Windows.Forms.Label();
            this.textRefereeMiddleName = new System.Windows.Forms.TextBox();
            this.labelRefereeMiddleName = new System.Windows.Forms.Label();
            this.textRefereeFirstName = new System.Windows.Forms.TextBox();
            this.labelRefereeFirstName = new System.Windows.Forms.Label();
            this.tabGameMaster = new System.Windows.Forms.TabPage();
            this.dataGridViewGM = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkGMLicenseNeverRenewed = new System.Windows.Forms.CheckBox();
            this.labelGMLicenseRenewed = new System.Windows.Forms.Label();
            this.labelGMLicenseAcquired = new System.Windows.Forms.Label();
            this.dateGMLicenseRenewed = new System.Windows.Forms.DateTimePicker();
            this.dateGMLicenseAcquired = new System.Windows.Forms.DateTimePicker();
            this.buttonGMAutoAdd = new System.Windows.Forms.Button();
            this.buttonGMRemove = new System.Windows.Forms.Button();
            this.buttonGMAdd = new System.Windows.Forms.Button();
            this.labelGMGender = new System.Windows.Forms.Label();
            this.comboGMGender = new System.Windows.Forms.ComboBox();
            this.labelGMNationality = new System.Windows.Forms.Label();
            this.comboGMNationality = new System.Windows.Forms.ComboBox();
            this.dateGMDOB = new System.Windows.Forms.DateTimePicker();
            this.labelGMDOB = new System.Windows.Forms.Label();
            this.textGMLastName = new System.Windows.Forms.TextBox();
            this.labelGMLastName = new System.Windows.Forms.Label();
            this.textGMMiddleName = new System.Windows.Forms.TextBox();
            this.labelGMMiddleName = new System.Windows.Forms.Label();
            this.textGMFirstName = new System.Windows.Forms.TextBox();
            this.labelGMFirstName = new System.Windows.Forms.Label();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.textTournamentName = new System.Windows.Forms.TextBox();
            this.dateTimeTournamentStartsAt = new System.Windows.Forms.DateTimePicker();
            this.dateTimeTournamentEndsAt = new System.Windows.Forms.DateTimePicker();
            this.labelTournamentName = new System.Windows.Forms.Label();
            this.groupBoxTournament = new System.Windows.Forms.GroupBox();
            this.buttonTournamentCreate = new System.Windows.Forms.Button();
            this.labelTournamentType = new System.Windows.Forms.Label();
            this.comboTournamentType = new System.Windows.Forms.ComboBox();
            this.labelTournamentAmountOfPlayers = new System.Windows.Forms.Label();
            this.comboTournamentAmountOfPlayers = new System.Windows.Forms.ComboBox();
            this.labelTournamentEndsAt = new System.Windows.Forms.Label();
            this.labelTournamentStartsAt = new System.Windows.Forms.Label();
            this.groupBoxGame = new System.Windows.Forms.GroupBox();
            this.buttonTournamentPlay = new System.Windows.Forms.Button();
            this.dataGridViewGames = new System.Windows.Forms.DataGridView();
            this.Object = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Winner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Round = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTournamentWinner = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayer)).BeginInit();
            this.tabReferee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReferee)).BeginInit();
            this.tabGameMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGM)).BeginInit();
            this.groupBoxAdd.SuspendLayout();
            this.groupBoxTournament.SuspendLayout();
            this.groupBoxGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGames)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPlayers);
            this.tabControl1.Controls.Add(this.tabReferee);
            this.tabControl1.Controls.Add(this.tabGameMaster);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(3, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1076, 268);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPlayers
            // 
            this.tabPlayers.Controls.Add(this.buttonPlayerSortByLastName);
            this.tabPlayers.Controls.Add(this.buttonPlayerSortByFirstName);
            this.tabPlayers.Controls.Add(this.buttonPlayerRemove);
            this.tabPlayers.Controls.Add(this.buttonPlayerAdd);
            this.tabPlayers.Controls.Add(this.buttonPlayerAutoAdd);
            this.tabPlayers.Controls.Add(this.dataGridViewPlayer);
            this.tabPlayers.Controls.Add(this.labelPlayerGender);
            this.tabPlayers.Controls.Add(this.comboPlayerGender);
            this.tabPlayers.Controls.Add(this.labelPlayerNationality);
            this.tabPlayers.Controls.Add(this.comboPlayerNationality);
            this.tabPlayers.Controls.Add(this.datePlayerDOB);
            this.tabPlayers.Controls.Add(this.labelPlayerDateOfBirth);
            this.tabPlayers.Controls.Add(this.textPlayerLastName);
            this.tabPlayers.Controls.Add(this.labelPlayerLastName);
            this.tabPlayers.Controls.Add(this.labelPlayerFirstName);
            this.tabPlayers.Controls.Add(this.textPlayerMiddleName);
            this.tabPlayers.Controls.Add(this.textPlayerFirstName);
            this.tabPlayers.Controls.Add(this.labelPlayerMiddelName);
            this.tabPlayers.Location = new System.Drawing.Point(4, 22);
            this.tabPlayers.Name = "tabPlayers";
            this.tabPlayers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlayers.Size = new System.Drawing.Size(1068, 242);
            this.tabPlayers.TabIndex = 1;
            this.tabPlayers.Text = "Player";
            this.tabPlayers.UseVisualStyleBackColor = true;
            // 
            // buttonPlayerSortByLastName
            // 
            this.buttonPlayerSortByLastName.Location = new System.Drawing.Point(826, 213);
            this.buttonPlayerSortByLastName.Name = "buttonPlayerSortByLastName";
            this.buttonPlayerSortByLastName.Size = new System.Drawing.Size(112, 23);
            this.buttonPlayerSortByLastName.TabIndex = 16;
            this.buttonPlayerSortByLastName.Text = "Sort By Last Name";
            this.buttonPlayerSortByLastName.UseVisualStyleBackColor = true;
            this.buttonPlayerSortByLastName.Click += new System.EventHandler(this.buttonPlayerSortByLastName_Click);
            // 
            // buttonPlayerSortByFirstName
            // 
            this.buttonPlayerSortByFirstName.Location = new System.Drawing.Point(944, 213);
            this.buttonPlayerSortByFirstName.Name = "buttonPlayerSortByFirstName";
            this.buttonPlayerSortByFirstName.Size = new System.Drawing.Size(112, 23);
            this.buttonPlayerSortByFirstName.TabIndex = 15;
            this.buttonPlayerSortByFirstName.Text = "Sort By First Name";
            this.buttonPlayerSortByFirstName.UseVisualStyleBackColor = true;
            this.buttonPlayerSortByFirstName.Click += new System.EventHandler(this.buttonPlayerSortByFirstName_Click);
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
            this.buttonPlayerAutoAdd.Click += new System.EventHandler(this.buttonPlayerAutoAdd_Click);
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
            this.dataGridViewPlayer.Size = new System.Drawing.Size(732, 201);
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
            // tabReferee
            // 
            this.tabReferee.Controls.Add(this.buttonSetAsGameMaster);
            this.tabReferee.Controls.Add(this.buttonRefereeSortByLastName);
            this.tabReferee.Controls.Add(this.buttonRefereeSortByFirstName);
            this.tabReferee.Controls.Add(this.checkRefereeNeverRenewed);
            this.tabReferee.Controls.Add(this.labelRefereeLicenseRenewed);
            this.tabReferee.Controls.Add(this.labelRefereeLicenseAcquired);
            this.tabReferee.Controls.Add(this.dateRefereeLicenseRenewed);
            this.tabReferee.Controls.Add(this.dateRefereeLicenseAcquired);
            this.tabReferee.Controls.Add(this.buttonRefereeAutoAdd);
            this.tabReferee.Controls.Add(this.buttonRefereeRemove);
            this.tabReferee.Controls.Add(this.buttonRefereeAdd);
            this.tabReferee.Controls.Add(this.dataGridViewReferee);
            this.tabReferee.Controls.Add(this.labelRefereeGender);
            this.tabReferee.Controls.Add(this.comboRefereeGender);
            this.tabReferee.Controls.Add(this.labelRefereeNationality);
            this.tabReferee.Controls.Add(this.comboRefereeNationality);
            this.tabReferee.Controls.Add(this.dateRefereeDOB);
            this.tabReferee.Controls.Add(this.labelRefereeDOB);
            this.tabReferee.Controls.Add(this.textRefereeLastName);
            this.tabReferee.Controls.Add(this.labelRefereeLastName);
            this.tabReferee.Controls.Add(this.textRefereeMiddleName);
            this.tabReferee.Controls.Add(this.labelRefereeMiddleName);
            this.tabReferee.Controls.Add(this.textRefereeFirstName);
            this.tabReferee.Controls.Add(this.labelRefereeFirstName);
            this.tabReferee.Location = new System.Drawing.Point(4, 22);
            this.tabReferee.Name = "tabReferee";
            this.tabReferee.Padding = new System.Windows.Forms.Padding(3);
            this.tabReferee.Size = new System.Drawing.Size(1068, 242);
            this.tabReferee.TabIndex = 0;
            this.tabReferee.Text = "Referee";
            this.tabReferee.UseVisualStyleBackColor = true;
            // 
            // buttonSetAsGameMaster
            // 
            this.buttonSetAsGameMaster.Location = new System.Drawing.Point(493, 213);
            this.buttonSetAsGameMaster.Name = "buttonSetAsGameMaster";
            this.buttonSetAsGameMaster.Size = new System.Drawing.Size(114, 23);
            this.buttonSetAsGameMaster.TabIndex = 25;
            this.buttonSetAsGameMaster.Text = "Set As Game Master";
            this.buttonSetAsGameMaster.UseVisualStyleBackColor = true;
            this.buttonSetAsGameMaster.Click += new System.EventHandler(this.buttonSetAsGameMaster_Click);
            // 
            // buttonRefereeSortByLastName
            // 
            this.buttonRefereeSortByLastName.Location = new System.Drawing.Point(826, 213);
            this.buttonRefereeSortByLastName.Name = "buttonRefereeSortByLastName";
            this.buttonRefereeSortByLastName.Size = new System.Drawing.Size(112, 23);
            this.buttonRefereeSortByLastName.TabIndex = 24;
            this.buttonRefereeSortByLastName.Text = "Sort By Last Name";
            this.buttonRefereeSortByLastName.UseVisualStyleBackColor = true;
            this.buttonRefereeSortByLastName.Click += new System.EventHandler(this.buttonRefereeSortByLastName_Click);
            // 
            // buttonRefereeSortByFirstName
            // 
            this.buttonRefereeSortByFirstName.Location = new System.Drawing.Point(944, 213);
            this.buttonRefereeSortByFirstName.Name = "buttonRefereeSortByFirstName";
            this.buttonRefereeSortByFirstName.Size = new System.Drawing.Size(112, 23);
            this.buttonRefereeSortByFirstName.TabIndex = 23;
            this.buttonRefereeSortByFirstName.Text = "Sort By First Name";
            this.buttonRefereeSortByFirstName.UseVisualStyleBackColor = true;
            this.buttonRefereeSortByFirstName.Click += new System.EventHandler(this.buttonRefereeSortByFirstName_Click);
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
            // labelRefereeLicenseRenewed
            // 
            this.labelRefereeLicenseRenewed.AutoSize = true;
            this.labelRefereeLicenseRenewed.Location = new System.Drawing.Point(341, 42);
            this.labelRefereeLicenseRenewed.Name = "labelRefereeLicenseRenewed";
            this.labelRefereeLicenseRenewed.Size = new System.Drawing.Size(96, 13);
            this.labelRefereeLicenseRenewed.TabIndex = 21;
            this.labelRefereeLicenseRenewed.Text = "License Renewed:";
            // 
            // labelRefereeLicenseAcquired
            // 
            this.labelRefereeLicenseAcquired.AutoSize = true;
            this.labelRefereeLicenseAcquired.Location = new System.Drawing.Point(341, 3);
            this.labelRefereeLicenseAcquired.Name = "labelRefereeLicenseAcquired";
            this.labelRefereeLicenseAcquired.Size = new System.Drawing.Size(92, 13);
            this.labelRefereeLicenseAcquired.TabIndex = 20;
            this.labelRefereeLicenseAcquired.Text = "License Acquired:";
            // 
            // dateRefereeLicenseRenewed
            // 
            this.dateRefereeLicenseRenewed.Location = new System.Drawing.Point(344, 57);
            this.dateRefereeLicenseRenewed.Name = "dateRefereeLicenseRenewed";
            this.dateRefereeLicenseRenewed.Size = new System.Drawing.Size(143, 20);
            this.dateRefereeLicenseRenewed.TabIndex = 19;
            this.dateRefereeLicenseRenewed.Value = new System.DateTime(2015, 3, 25, 0, 0, 0, 0);
            // 
            // dateRefereeLicenseAcquired
            // 
            this.dateRefereeLicenseAcquired.Location = new System.Drawing.Point(344, 19);
            this.dateRefereeLicenseAcquired.Name = "dateRefereeLicenseAcquired";
            this.dateRefereeLicenseAcquired.Size = new System.Drawing.Size(143, 20);
            this.dateRefereeLicenseAcquired.TabIndex = 18;
            this.dateRefereeLicenseAcquired.Value = new System.DateTime(2015, 3, 25, 0, 0, 0, 0);
            // 
            // buttonRefereeAutoAdd
            // 
            this.buttonRefereeAutoAdd.Location = new System.Drawing.Point(6, 132);
            this.buttonRefereeAutoAdd.Name = "buttonRefereeAutoAdd";
            this.buttonRefereeAutoAdd.Size = new System.Drawing.Size(69, 23);
            this.buttonRefereeAutoAdd.TabIndex = 17;
            this.buttonRefereeAutoAdd.Text = "Auto Add";
            this.buttonRefereeAutoAdd.UseVisualStyleBackColor = true;
            this.buttonRefereeAutoAdd.Click += new System.EventHandler(this.buttonRefereeAutoAdd_Click);
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
            this.dataGridViewReferee.Size = new System.Drawing.Size(563, 201);
            this.dataGridViewReferee.TabIndex = 14;
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
            // labelRefereeGender
            // 
            this.labelRefereeGender.AutoSize = true;
            this.labelRefereeGender.Location = new System.Drawing.Point(172, 80);
            this.labelRefereeGender.Name = "labelRefereeGender";
            this.labelRefereeGender.Size = new System.Drawing.Size(42, 13);
            this.labelRefereeGender.TabIndex = 13;
            this.labelRefereeGender.Text = "Gender";
            // 
            // comboRefereeGender
            // 
            this.comboRefereeGender.FormattingEnabled = true;
            this.comboRefereeGender.Location = new System.Drawing.Point(175, 96);
            this.comboRefereeGender.Name = "comboRefereeGender";
            this.comboRefereeGender.Size = new System.Drawing.Size(143, 21);
            this.comboRefereeGender.TabIndex = 12;
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
            // comboRefereeNationality
            // 
            this.comboRefereeNationality.FormattingEnabled = true;
            this.comboRefereeNationality.Location = new System.Drawing.Point(175, 57);
            this.comboRefereeNationality.Name = "comboRefereeNationality";
            this.comboRefereeNationality.Size = new System.Drawing.Size(143, 21);
            this.comboRefereeNationality.TabIndex = 10;
            // 
            // dateRefereeDOB
            // 
            this.dateRefereeDOB.Location = new System.Drawing.Point(175, 19);
            this.dateRefereeDOB.Name = "dateRefereeDOB";
            this.dateRefereeDOB.Size = new System.Drawing.Size(143, 20);
            this.dateRefereeDOB.TabIndex = 8;
            this.dateRefereeDOB.Value = new System.DateTime(2015, 3, 25, 0, 0, 0, 0);
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
            // textRefereeLastName
            // 
            this.textRefereeLastName.Location = new System.Drawing.Point(6, 97);
            this.textRefereeLastName.Name = "textRefereeLastName";
            this.textRefereeLastName.Size = new System.Drawing.Size(143, 20);
            this.textRefereeLastName.TabIndex = 6;
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
            // textRefereeMiddleName
            // 
            this.textRefereeMiddleName.Location = new System.Drawing.Point(6, 58);
            this.textRefereeMiddleName.Name = "textRefereeMiddleName";
            this.textRefereeMiddleName.Size = new System.Drawing.Size(143, 20);
            this.textRefereeMiddleName.TabIndex = 4;
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
            // textRefereeFirstName
            // 
            this.textRefereeFirstName.Location = new System.Drawing.Point(6, 19);
            this.textRefereeFirstName.Name = "textRefereeFirstName";
            this.textRefereeFirstName.Size = new System.Drawing.Size(143, 20);
            this.textRefereeFirstName.TabIndex = 2;
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
            // tabGameMaster
            // 
            this.tabGameMaster.Controls.Add(this.dataGridViewGM);
            this.tabGameMaster.Controls.Add(this.checkGMLicenseNeverRenewed);
            this.tabGameMaster.Controls.Add(this.labelGMLicenseRenewed);
            this.tabGameMaster.Controls.Add(this.labelGMLicenseAcquired);
            this.tabGameMaster.Controls.Add(this.dateGMLicenseRenewed);
            this.tabGameMaster.Controls.Add(this.dateGMLicenseAcquired);
            this.tabGameMaster.Controls.Add(this.buttonGMAutoAdd);
            this.tabGameMaster.Controls.Add(this.buttonGMRemove);
            this.tabGameMaster.Controls.Add(this.buttonGMAdd);
            this.tabGameMaster.Controls.Add(this.labelGMGender);
            this.tabGameMaster.Controls.Add(this.comboGMGender);
            this.tabGameMaster.Controls.Add(this.labelGMNationality);
            this.tabGameMaster.Controls.Add(this.comboGMNationality);
            this.tabGameMaster.Controls.Add(this.dateGMDOB);
            this.tabGameMaster.Controls.Add(this.labelGMDOB);
            this.tabGameMaster.Controls.Add(this.textGMLastName);
            this.tabGameMaster.Controls.Add(this.labelGMLastName);
            this.tabGameMaster.Controls.Add(this.textGMMiddleName);
            this.tabGameMaster.Controls.Add(this.labelGMMiddleName);
            this.tabGameMaster.Controls.Add(this.textGMFirstName);
            this.tabGameMaster.Controls.Add(this.labelGMFirstName);
            this.tabGameMaster.Location = new System.Drawing.Point(4, 22);
            this.tabGameMaster.Name = "tabGameMaster";
            this.tabGameMaster.Size = new System.Drawing.Size(1068, 242);
            this.tabGameMaster.TabIndex = 2;
            this.tabGameMaster.Text = "Game Master";
            this.tabGameMaster.UseVisualStyleBackColor = true;
            // 
            // dataGridViewGM
            // 
            this.dataGridViewGM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.dataGridViewGM.Location = new System.Drawing.Point(493, 6);
            this.dataGridViewGM.Name = "dataGridViewGM";
            this.dataGridViewGM.Size = new System.Drawing.Size(563, 72);
            this.dataGridViewGM.TabIndex = 43;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Object";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            this.dataGridViewTextBoxColumn9.Width = 35;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Frist Name";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Middle Name";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Date Of Birth";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Age";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 50;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "Nationality";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "License Acquired";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.HeaderText = "License Renewed";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // checkGMLicenseNeverRenewed
            // 
            this.checkGMLicenseNeverRenewed.AutoSize = true;
            this.checkGMLicenseNeverRenewed.Location = new System.Drawing.Point(344, 100);
            this.checkGMLicenseNeverRenewed.Name = "checkGMLicenseNeverRenewed";
            this.checkGMLicenseNeverRenewed.Size = new System.Drawing.Size(144, 17);
            this.checkGMLicenseNeverRenewed.TabIndex = 42;
            this.checkGMLicenseNeverRenewed.Text = "License Never Renewed";
            this.checkGMLicenseNeverRenewed.UseVisualStyleBackColor = true;
            this.checkGMLicenseNeverRenewed.CheckedChanged += new System.EventHandler(this.checkGMLicenseNeverRenewed_CheckedChanged);
            // 
            // labelGMLicenseRenewed
            // 
            this.labelGMLicenseRenewed.AutoSize = true;
            this.labelGMLicenseRenewed.Location = new System.Drawing.Point(341, 42);
            this.labelGMLicenseRenewed.Name = "labelGMLicenseRenewed";
            this.labelGMLicenseRenewed.Size = new System.Drawing.Size(96, 13);
            this.labelGMLicenseRenewed.TabIndex = 41;
            this.labelGMLicenseRenewed.Text = "License Renewed:";
            // 
            // labelGMLicenseAcquired
            // 
            this.labelGMLicenseAcquired.AutoSize = true;
            this.labelGMLicenseAcquired.Location = new System.Drawing.Point(341, 3);
            this.labelGMLicenseAcquired.Name = "labelGMLicenseAcquired";
            this.labelGMLicenseAcquired.Size = new System.Drawing.Size(92, 13);
            this.labelGMLicenseAcquired.TabIndex = 40;
            this.labelGMLicenseAcquired.Text = "License Acquired:";
            // 
            // dateGMLicenseRenewed
            // 
            this.dateGMLicenseRenewed.Location = new System.Drawing.Point(344, 57);
            this.dateGMLicenseRenewed.Name = "dateGMLicenseRenewed";
            this.dateGMLicenseRenewed.Size = new System.Drawing.Size(143, 20);
            this.dateGMLicenseRenewed.TabIndex = 39;
            this.dateGMLicenseRenewed.Value = new System.DateTime(2015, 3, 25, 0, 0, 0, 0);
            // 
            // dateGMLicenseAcquired
            // 
            this.dateGMLicenseAcquired.Location = new System.Drawing.Point(344, 19);
            this.dateGMLicenseAcquired.Name = "dateGMLicenseAcquired";
            this.dateGMLicenseAcquired.Size = new System.Drawing.Size(143, 20);
            this.dateGMLicenseAcquired.TabIndex = 38;
            this.dateGMLicenseAcquired.Value = new System.DateTime(2015, 3, 25, 0, 0, 0, 0);
            // 
            // buttonGMAutoAdd
            // 
            this.buttonGMAutoAdd.Location = new System.Drawing.Point(6, 132);
            this.buttonGMAutoAdd.Name = "buttonGMAutoAdd";
            this.buttonGMAutoAdd.Size = new System.Drawing.Size(69, 23);
            this.buttonGMAutoAdd.TabIndex = 37;
            this.buttonGMAutoAdd.Text = "Auto Add";
            this.buttonGMAutoAdd.UseVisualStyleBackColor = true;
            // 
            // buttonGMRemove
            // 
            this.buttonGMRemove.Location = new System.Drawing.Point(249, 132);
            this.buttonGMRemove.Name = "buttonGMRemove";
            this.buttonGMRemove.Size = new System.Drawing.Size(69, 23);
            this.buttonGMRemove.TabIndex = 36;
            this.buttonGMRemove.Text = "Remove";
            this.buttonGMRemove.UseVisualStyleBackColor = true;
            this.buttonGMRemove.Click += new System.EventHandler(this.buttonGMRemove_Click);
            // 
            // buttonGMAdd
            // 
            this.buttonGMAdd.Location = new System.Drawing.Point(175, 132);
            this.buttonGMAdd.Name = "buttonGMAdd";
            this.buttonGMAdd.Size = new System.Drawing.Size(69, 23);
            this.buttonGMAdd.TabIndex = 35;
            this.buttonGMAdd.Text = "Add";
            this.buttonGMAdd.UseVisualStyleBackColor = true;
            this.buttonGMAdd.Click += new System.EventHandler(this.buttonGMAdd_Click);
            // 
            // labelGMGender
            // 
            this.labelGMGender.AutoSize = true;
            this.labelGMGender.Location = new System.Drawing.Point(172, 80);
            this.labelGMGender.Name = "labelGMGender";
            this.labelGMGender.Size = new System.Drawing.Size(42, 13);
            this.labelGMGender.TabIndex = 34;
            this.labelGMGender.Text = "Gender";
            // 
            // comboGMGender
            // 
            this.comboGMGender.FormattingEnabled = true;
            this.comboGMGender.Location = new System.Drawing.Point(175, 96);
            this.comboGMGender.Name = "comboGMGender";
            this.comboGMGender.Size = new System.Drawing.Size(143, 21);
            this.comboGMGender.TabIndex = 33;
            // 
            // labelGMNationality
            // 
            this.labelGMNationality.AutoSize = true;
            this.labelGMNationality.Location = new System.Drawing.Point(172, 42);
            this.labelGMNationality.Name = "labelGMNationality";
            this.labelGMNationality.Size = new System.Drawing.Size(56, 13);
            this.labelGMNationality.TabIndex = 32;
            this.labelGMNationality.Text = "Nationality";
            // 
            // comboGMNationality
            // 
            this.comboGMNationality.FormattingEnabled = true;
            this.comboGMNationality.Location = new System.Drawing.Point(175, 57);
            this.comboGMNationality.Name = "comboGMNationality";
            this.comboGMNationality.Size = new System.Drawing.Size(143, 21);
            this.comboGMNationality.TabIndex = 31;
            // 
            // dateGMDOB
            // 
            this.dateGMDOB.Location = new System.Drawing.Point(175, 19);
            this.dateGMDOB.Name = "dateGMDOB";
            this.dateGMDOB.Size = new System.Drawing.Size(143, 20);
            this.dateGMDOB.TabIndex = 30;
            this.dateGMDOB.Value = new System.DateTime(2015, 3, 25, 0, 0, 0, 0);
            // 
            // labelGMDOB
            // 
            this.labelGMDOB.AutoSize = true;
            this.labelGMDOB.Location = new System.Drawing.Point(172, 3);
            this.labelGMDOB.Name = "labelGMDOB";
            this.labelGMDOB.Size = new System.Drawing.Size(71, 13);
            this.labelGMDOB.TabIndex = 29;
            this.labelGMDOB.Text = "Date Of Birth:";
            // 
            // textGMLastName
            // 
            this.textGMLastName.Location = new System.Drawing.Point(6, 97);
            this.textGMLastName.Name = "textGMLastName";
            this.textGMLastName.Size = new System.Drawing.Size(143, 20);
            this.textGMLastName.TabIndex = 28;
            // 
            // labelGMLastName
            // 
            this.labelGMLastName.AutoSize = true;
            this.labelGMLastName.Location = new System.Drawing.Point(3, 81);
            this.labelGMLastName.Name = "labelGMLastName";
            this.labelGMLastName.Size = new System.Drawing.Size(61, 13);
            this.labelGMLastName.TabIndex = 27;
            this.labelGMLastName.Text = "Last Name:";
            // 
            // textGMMiddleName
            // 
            this.textGMMiddleName.Location = new System.Drawing.Point(6, 58);
            this.textGMMiddleName.Name = "textGMMiddleName";
            this.textGMMiddleName.Size = new System.Drawing.Size(143, 20);
            this.textGMMiddleName.TabIndex = 26;
            // 
            // labelGMMiddleName
            // 
            this.labelGMMiddleName.AutoSize = true;
            this.labelGMMiddleName.Location = new System.Drawing.Point(3, 42);
            this.labelGMMiddleName.Name = "labelGMMiddleName";
            this.labelGMMiddleName.Size = new System.Drawing.Size(72, 13);
            this.labelGMMiddleName.TabIndex = 25;
            this.labelGMMiddleName.Text = "Middle Name:";
            // 
            // textGMFirstName
            // 
            this.textGMFirstName.Location = new System.Drawing.Point(6, 19);
            this.textGMFirstName.Name = "textGMFirstName";
            this.textGMFirstName.Size = new System.Drawing.Size(143, 20);
            this.textGMFirstName.TabIndex = 24;
            // 
            // labelGMFirstName
            // 
            this.labelGMFirstName.AutoSize = true;
            this.labelGMFirstName.Location = new System.Drawing.Point(3, 3);
            this.labelGMFirstName.Name = "labelGMFirstName";
            this.labelGMFirstName.Size = new System.Drawing.Size(60, 13);
            this.labelGMFirstName.TabIndex = 23;
            this.labelGMFirstName.Text = "First Name:";
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.tabControl1);
            this.groupBoxAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxAdd.Location = new System.Drawing.Point(0, 298);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(1082, 290);
            this.groupBoxAdd.TabIndex = 1;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Add";
            // 
            // textTournamentName
            // 
            this.textTournamentName.Location = new System.Drawing.Point(12, 32);
            this.textTournamentName.Name = "textTournamentName";
            this.textTournamentName.Size = new System.Drawing.Size(152, 20);
            this.textTournamentName.TabIndex = 2;
            // 
            // dateTimeTournamentStartsAt
            // 
            this.dateTimeTournamentStartsAt.Location = new System.Drawing.Point(13, 72);
            this.dateTimeTournamentStartsAt.Name = "dateTimeTournamentStartsAt";
            this.dateTimeTournamentStartsAt.Size = new System.Drawing.Size(151, 20);
            this.dateTimeTournamentStartsAt.TabIndex = 6;
            this.dateTimeTournamentStartsAt.Value = new System.DateTime(2015, 4, 5, 0, 0, 0, 0);
            // 
            // dateTimeTournamentEndsAt
            // 
            this.dateTimeTournamentEndsAt.Location = new System.Drawing.Point(13, 111);
            this.dateTimeTournamentEndsAt.Name = "dateTimeTournamentEndsAt";
            this.dateTimeTournamentEndsAt.Size = new System.Drawing.Size(151, 20);
            this.dateTimeTournamentEndsAt.TabIndex = 8;
            this.dateTimeTournamentEndsAt.Value = new System.DateTime(2015, 4, 5, 0, 0, 0, 0);
            // 
            // labelTournamentName
            // 
            this.labelTournamentName.AutoSize = true;
            this.labelTournamentName.Location = new System.Drawing.Point(10, 16);
            this.labelTournamentName.Name = "labelTournamentName";
            this.labelTournamentName.Size = new System.Drawing.Size(38, 13);
            this.labelTournamentName.TabIndex = 1;
            this.labelTournamentName.Text = "Name:";
            // 
            // groupBoxTournament
            // 
            this.groupBoxTournament.Controls.Add(this.buttonTournamentCreate);
            this.groupBoxTournament.Controls.Add(this.labelTournamentType);
            this.groupBoxTournament.Controls.Add(this.comboTournamentType);
            this.groupBoxTournament.Controls.Add(this.labelTournamentAmountOfPlayers);
            this.groupBoxTournament.Controls.Add(this.comboTournamentAmountOfPlayers);
            this.groupBoxTournament.Controls.Add(this.labelTournamentEndsAt);
            this.groupBoxTournament.Controls.Add(this.labelTournamentStartsAt);
            this.groupBoxTournament.Controls.Add(this.labelTournamentName);
            this.groupBoxTournament.Controls.Add(this.textTournamentName);
            this.groupBoxTournament.Controls.Add(this.dateTimeTournamentEndsAt);
            this.groupBoxTournament.Controls.Add(this.dateTimeTournamentStartsAt);
            this.groupBoxTournament.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxTournament.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTournament.Name = "groupBoxTournament";
            this.groupBoxTournament.Size = new System.Drawing.Size(184, 298);
            this.groupBoxTournament.TabIndex = 7;
            this.groupBoxTournament.TabStop = false;
            this.groupBoxTournament.Text = "Tournament";
            // 
            // buttonTournamentCreate
            // 
            this.buttonTournamentCreate.Location = new System.Drawing.Point(89, 217);
            this.buttonTournamentCreate.Name = "buttonTournamentCreate";
            this.buttonTournamentCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonTournamentCreate.TabIndex = 15;
            this.buttonTournamentCreate.Text = "Create";
            this.buttonTournamentCreate.UseVisualStyleBackColor = true;
            this.buttonTournamentCreate.Click += new System.EventHandler(this.buttonTournamentCreate_Click);
            // 
            // labelTournamentType
            // 
            this.labelTournamentType.AutoSize = true;
            this.labelTournamentType.Location = new System.Drawing.Point(10, 174);
            this.labelTournamentType.Name = "labelTournamentType";
            this.labelTournamentType.Size = new System.Drawing.Size(94, 13);
            this.labelTournamentType.TabIndex = 11;
            this.labelTournamentType.Text = "Tournament Type:";
            // 
            // comboTournamentType
            // 
            this.comboTournamentType.FormattingEnabled = true;
            this.comboTournamentType.Location = new System.Drawing.Point(13, 190);
            this.comboTournamentType.Name = "comboTournamentType";
            this.comboTournamentType.Size = new System.Drawing.Size(152, 21);
            this.comboTournamentType.TabIndex = 12;
            this.comboTournamentType.Text = "Select type";
            // 
            // labelTournamentAmountOfPlayers
            // 
            this.labelTournamentAmountOfPlayers.AutoSize = true;
            this.labelTournamentAmountOfPlayers.Location = new System.Drawing.Point(10, 134);
            this.labelTournamentAmountOfPlayers.Name = "labelTournamentAmountOfPlayers";
            this.labelTournamentAmountOfPlayers.Size = new System.Drawing.Size(81, 13);
            this.labelTournamentAmountOfPlayers.TabIndex = 9;
            this.labelTournamentAmountOfPlayers.Text = "Players/Teams:";
            // 
            // comboTournamentAmountOfPlayers
            // 
            this.comboTournamentAmountOfPlayers.FormattingEnabled = true;
            this.comboTournamentAmountOfPlayers.Items.AddRange(new object[] {
            "8",
            "16",
            "32",
            "64"});
            this.comboTournamentAmountOfPlayers.Location = new System.Drawing.Point(13, 150);
            this.comboTournamentAmountOfPlayers.Name = "comboTournamentAmountOfPlayers";
            this.comboTournamentAmountOfPlayers.Size = new System.Drawing.Size(151, 21);
            this.comboTournamentAmountOfPlayers.TabIndex = 10;
            this.comboTournamentAmountOfPlayers.Text = "Select amount";
            // 
            // labelTournamentEndsAt
            // 
            this.labelTournamentEndsAt.AutoSize = true;
            this.labelTournamentEndsAt.Location = new System.Drawing.Point(10, 95);
            this.labelTournamentEndsAt.Name = "labelTournamentEndsAt";
            this.labelTournamentEndsAt.Size = new System.Drawing.Size(47, 13);
            this.labelTournamentEndsAt.TabIndex = 7;
            this.labelTournamentEndsAt.Text = "Ends At:";
            // 
            // labelTournamentStartsAt
            // 
            this.labelTournamentStartsAt.AutoSize = true;
            this.labelTournamentStartsAt.Location = new System.Drawing.Point(10, 56);
            this.labelTournamentStartsAt.Name = "labelTournamentStartsAt";
            this.labelTournamentStartsAt.Size = new System.Drawing.Size(50, 13);
            this.labelTournamentStartsAt.TabIndex = 5;
            this.labelTournamentStartsAt.Text = "Starts At:";
            // 
            // groupBoxGame
            // 
            this.groupBoxGame.Controls.Add(this.labelTournamentWinner);
            this.groupBoxGame.Controls.Add(this.buttonTournamentPlay);
            this.groupBoxGame.Controls.Add(this.dataGridViewGames);
            this.groupBoxGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxGame.Location = new System.Drawing.Point(184, 0);
            this.groupBoxGame.Name = "groupBoxGame";
            this.groupBoxGame.Size = new System.Drawing.Size(898, 298);
            this.groupBoxGame.TabIndex = 8;
            this.groupBoxGame.TabStop = false;
            this.groupBoxGame.Text = "Game";
            // 
            // buttonTournamentPlay
            // 
            this.buttonTournamentPlay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonTournamentPlay.Location = new System.Drawing.Point(3, 255);
            this.buttonTournamentPlay.Name = "buttonTournamentPlay";
            this.buttonTournamentPlay.Size = new System.Drawing.Size(892, 40);
            this.buttonTournamentPlay.TabIndex = 9;
            this.buttonTournamentPlay.Text = "Play";
            this.buttonTournamentPlay.UseVisualStyleBackColor = true;
            this.buttonTournamentPlay.Click += new System.EventHandler(this.buttonTournamentPlay_Click);
            // 
            // dataGridViewGames
            // 
            this.dataGridViewGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Object,
            this.Winner,
            this.Loser,
            this.Result,
            this.Round});
            this.dataGridViewGames.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewGames.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewGames.Name = "dataGridViewGames";
            this.dataGridViewGames.Size = new System.Drawing.Size(892, 205);
            this.dataGridViewGames.TabIndex = 0;
            // 
            // Object
            // 
            this.Object.HeaderText = "Object";
            this.Object.Name = "Object";
            this.Object.Visible = false;
            // 
            // Winner
            // 
            this.Winner.HeaderText = "Winner";
            this.Winner.Name = "Winner";
            this.Winner.Width = 150;
            // 
            // Loser
            // 
            this.Loser.HeaderText = "Loser";
            this.Loser.Name = "Loser";
            this.Loser.Width = 150;
            // 
            // Result
            // 
            this.Result.HeaderText = "Result";
            this.Result.Name = "Result";
            // 
            // Round
            // 
            this.Round.HeaderText = "Round";
            this.Round.Name = "Round";
            this.Round.Width = 50;
            // 
            // labelTournamentWinner
            // 
            this.labelTournamentWinner.AutoSize = true;
            this.labelTournamentWinner.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTournamentWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTournamentWinner.Location = new System.Drawing.Point(3, 221);
            this.labelTournamentWinner.Name = "labelTournamentWinner";
            this.labelTournamentWinner.Size = new System.Drawing.Size(208, 25);
            this.labelTournamentWinner.TabIndex = 10;
            this.labelTournamentWinner.Text = "Tournament winner: ";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 588);
            this.Controls.Add(this.groupBoxGame);
            this.Controls.Add(this.groupBoxTournament);
            this.Controls.Add(this.groupBoxAdd);
            this.Name = "MainWindow";
            this.Text = "Tennis Sim";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPlayers.ResumeLayout(false);
            this.tabPlayers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayer)).EndInit();
            this.tabReferee.ResumeLayout(false);
            this.tabReferee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReferee)).EndInit();
            this.tabGameMaster.ResumeLayout(false);
            this.tabGameMaster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGM)).EndInit();
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxTournament.ResumeLayout(false);
            this.groupBoxTournament.PerformLayout();
            this.groupBoxGame.ResumeLayout(false);
            this.groupBoxGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGames)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabReferee;
        private System.Windows.Forms.TabPage tabPlayers;
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
        private System.Windows.Forms.Button buttonPlayerSortByLastName;
        private System.Windows.Forms.Button buttonPlayerSortByFirstName;
        private System.Windows.Forms.Button buttonRefereeSortByLastName;
        private System.Windows.Forms.Button buttonRefereeSortByFirstName;
        private System.Windows.Forms.TabPage tabGameMaster;
        private System.Windows.Forms.Button buttonSetAsGameMaster;
        private System.Windows.Forms.CheckBox checkGMLicenseNeverRenewed;
        private System.Windows.Forms.Label labelGMLicenseRenewed;
        private System.Windows.Forms.Label labelGMLicenseAcquired;
        private System.Windows.Forms.DateTimePicker dateGMLicenseRenewed;
        private System.Windows.Forms.DateTimePicker dateGMLicenseAcquired;
        private System.Windows.Forms.Button buttonGMAutoAdd;
        private System.Windows.Forms.Button buttonGMRemove;
        private System.Windows.Forms.Button buttonGMAdd;
        private System.Windows.Forms.Label labelGMGender;
        private System.Windows.Forms.ComboBox comboGMGender;
        private System.Windows.Forms.Label labelGMNationality;
        private System.Windows.Forms.ComboBox comboGMNationality;
        private System.Windows.Forms.DateTimePicker dateGMDOB;
        private System.Windows.Forms.Label labelGMDOB;
        private System.Windows.Forms.TextBox textGMLastName;
        private System.Windows.Forms.Label labelGMLastName;
        private System.Windows.Forms.TextBox textGMMiddleName;
        private System.Windows.Forms.Label labelGMMiddleName;
        private System.Windows.Forms.TextBox textGMFirstName;
        private System.Windows.Forms.Label labelGMFirstName;
        private System.Windows.Forms.DataGridView dataGridViewGM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.TextBox textTournamentName;
        private System.Windows.Forms.DateTimePicker dateTimeTournamentStartsAt;
        private System.Windows.Forms.DateTimePicker dateTimeTournamentEndsAt;
        private System.Windows.Forms.Label labelTournamentName;
        private System.Windows.Forms.GroupBox groupBoxTournament;
        private System.Windows.Forms.Label labelTournamentEndsAt;
        private System.Windows.Forms.Label labelTournamentStartsAt;
        private System.Windows.Forms.ComboBox comboTournamentAmountOfPlayers;
        private System.Windows.Forms.GroupBox groupBoxGame;
        private System.Windows.Forms.Label labelTournamentAmountOfPlayers;
        private System.Windows.Forms.Label labelTournamentType;
        private System.Windows.Forms.ComboBox comboTournamentType;
        private System.Windows.Forms.Button buttonTournamentCreate;
        private System.Windows.Forms.DataGridView dataGridViewGames;
        private System.Windows.Forms.Button buttonTournamentPlay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Object;
        private System.Windows.Forms.DataGridViewTextBoxColumn Winner;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Round;
        private System.Windows.Forms.Label labelTournamentWinner;
    }
}

