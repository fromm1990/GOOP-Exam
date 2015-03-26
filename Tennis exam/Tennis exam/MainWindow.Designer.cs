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
            this.labelGender = new System.Windows.Forms.Label();
            this.comboPlayerGender = new System.Windows.Forms.ComboBox();
            this.labelNationality = new System.Windows.Forms.Label();
            this.comboPlayerNationality = new System.Windows.Forms.ComboBox();
            this.buttonPlayerAdd = new System.Windows.Forms.Button();
            this.datePlayerDOB = new System.Windows.Forms.DateTimePicker();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelPlayerFirstName = new System.Windows.Forms.Label();
            this.textMiddleName = new System.Windows.Forms.TextBox();
            this.textPlayerFirstName = new System.Windows.Forms.TextBox();
            this.labelMiddelName = new System.Windows.Forms.Label();
            this.TabReferee = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.TabPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayer)).BeginInit();
            this.TabReferee.SuspendLayout();
            this.groupBoxAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPlayers);
            this.tabControl1.Controls.Add(this.TabReferee);
            this.tabControl1.Location = new System.Drawing.Point(6, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1070, 187);
            this.tabControl1.TabIndex = 0;
            // 
            // TabPlayers
            // 
            this.TabPlayers.Controls.Add(this.buttonPlayerRemove);
            this.TabPlayers.Controls.Add(this.buttonPlayerAdd);
            this.TabPlayers.Controls.Add(this.buttonPlayerAutoAdd);
            this.TabPlayers.Controls.Add(this.dataGridViewPlayer);
            this.TabPlayers.Controls.Add(this.labelGender);
            this.TabPlayers.Controls.Add(this.comboPlayerGender);
            this.TabPlayers.Controls.Add(this.labelNationality);
            this.TabPlayers.Controls.Add(this.comboPlayerNationality);
            this.TabPlayers.Controls.Add(this.datePlayerDOB);
            this.TabPlayers.Controls.Add(this.labelDateOfBirth);
            this.TabPlayers.Controls.Add(this.textLastName);
            this.TabPlayers.Controls.Add(this.labelLastName);
            this.TabPlayers.Controls.Add(this.labelPlayerFirstName);
            this.TabPlayers.Controls.Add(this.textMiddleName);
            this.TabPlayers.Controls.Add(this.textPlayerFirstName);
            this.TabPlayers.Controls.Add(this.labelMiddelName);
            this.TabPlayers.Location = new System.Drawing.Point(4, 22);
            this.TabPlayers.Name = "TabPlayers";
            this.TabPlayers.Padding = new System.Windows.Forms.Padding(3);
            this.TabPlayers.Size = new System.Drawing.Size(1062, 161);
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
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(172, 80);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(42, 13);
            this.labelGender.TabIndex = 10;
            this.labelGender.Text = "Gender";
            // 
            // comboPlayerGender
            // 
            this.comboPlayerGender.FormattingEnabled = true;
            this.comboPlayerGender.Location = new System.Drawing.Point(175, 96);
            this.comboPlayerGender.Name = "comboPlayerGender";
            this.comboPlayerGender.Size = new System.Drawing.Size(143, 21);
            this.comboPlayerGender.TabIndex = 11;
            // 
            // labelNationality
            // 
            this.labelNationality.AutoSize = true;
            this.labelNationality.Location = new System.Drawing.Point(172, 42);
            this.labelNationality.Name = "labelNationality";
            this.labelNationality.Size = new System.Drawing.Size(56, 13);
            this.labelNationality.TabIndex = 8;
            this.labelNationality.Text = "Nationality";
            // 
            // comboPlayerNationality
            // 
            this.comboPlayerNationality.FormattingEnabled = true;
            this.comboPlayerNationality.Location = new System.Drawing.Point(175, 57);
            this.comboPlayerNationality.Name = "comboPlayerNationality";
            this.comboPlayerNationality.Size = new System.Drawing.Size(143, 21);
            this.comboPlayerNationality.TabIndex = 9;
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
            // datePlayerDOB
            // 
            this.datePlayerDOB.Location = new System.Drawing.Point(175, 19);
            this.datePlayerDOB.Name = "datePlayerDOB";
            this.datePlayerDOB.Size = new System.Drawing.Size(143, 20);
            this.datePlayerDOB.TabIndex = 7;
            this.datePlayerDOB.Value = new System.DateTime(2015, 3, 25, 0, 0, 0, 0);
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Location = new System.Drawing.Point(172, 3);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(71, 13);
            this.labelDateOfBirth.TabIndex = 6;
            this.labelDateOfBirth.Text = "Date Of Birth:";
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(6, 97);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(143, 20);
            this.textLastName.TabIndex = 5;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(3, 81);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(61, 13);
            this.labelLastName.TabIndex = 4;
            this.labelLastName.Text = "Last Name:";
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
            // textMiddleName
            // 
            this.textMiddleName.Location = new System.Drawing.Point(6, 58);
            this.textMiddleName.Name = "textMiddleName";
            this.textMiddleName.Size = new System.Drawing.Size(143, 20);
            this.textMiddleName.TabIndex = 3;
            // 
            // textPlayerFirstName
            // 
            this.textPlayerFirstName.Location = new System.Drawing.Point(6, 19);
            this.textPlayerFirstName.Name = "textPlayerFirstName";
            this.textPlayerFirstName.Size = new System.Drawing.Size(143, 20);
            this.textPlayerFirstName.TabIndex = 1;
            // 
            // labelMiddelName
            // 
            this.labelMiddelName.AutoSize = true;
            this.labelMiddelName.Location = new System.Drawing.Point(3, 42);
            this.labelMiddelName.Name = "labelMiddelName";
            this.labelMiddelName.Size = new System.Drawing.Size(72, 13);
            this.labelMiddelName.TabIndex = 2;
            this.labelMiddelName.Text = "Middle Name:";
            // 
            // TabReferee
            // 
            this.TabReferee.Controls.Add(this.label1);
            this.TabReferee.Controls.Add(this.textBox1);
            this.TabReferee.Location = new System.Drawing.Point(4, 22);
            this.TabReferee.Name = "TabReferee";
            this.TabReferee.Padding = new System.Windows.Forms.Padding(3);
            this.TabReferee.Size = new System.Drawing.Size(1062, 161);
            this.TabReferee.TabIndex = 0;
            this.TabReferee.Text = "Referee";
            this.TabReferee.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tournament Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 20);
            this.textBox1.TabIndex = 0;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 588);
            this.Controls.Add(this.groupBoxAdd);
            this.Name = "Form1";
            this.Text = "Tennis Sim";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabPlayers.ResumeLayout(false);
            this.TabPlayers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayer)).EndInit();
            this.TabReferee.ResumeLayout(false);
            this.TabReferee.PerformLayout();
            this.groupBoxAdd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabReferee;
        private System.Windows.Forms.TabPage TabPlayers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelPlayerFirstName;
        private System.Windows.Forms.TextBox textPlayerFirstName;
        private System.Windows.Forms.Label labelMiddelName;
        private System.Windows.Forms.TextBox textMiddleName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.DateTimePicker datePlayerDOB;
        private System.Windows.Forms.Button buttonPlayerAdd;
        private System.Windows.Forms.DataGridView dataGridViewPlayer;
        private System.Windows.Forms.Label labelNationality;
        private System.Windows.Forms.ComboBox comboPlayerNationality;
        private System.Windows.Forms.Label labelGender;
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
    }
}

