using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tennis_exam.Classes;

namespace Tennis_exam
{
    public partial class MainWindow : Form
    {
        Tournament tournament;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tournament = new Tournament(16);

            //Setting up Data sources for combo boxes
            comboPlayerGender.DataSource = Enum.GetValues(typeof(Player.Genders));
            comboPlayerNationality.DataSource = Enum.GetValues(typeof(Player.Nationalities));
            comboRefereeGender.DataSource = Enum.GetValues(typeof(Referee.Genders));
            comboRefereeNationality.DataSource = Enum.GetValues(typeof(Referee.Nationalities));
        }
        

        private void buttonAddPlayer_Click(object sender, EventArgs e)
        {
            Player newPlayer = new Player();
            try
            {         
                newPlayer.FristName = textPlayerFirstName.Text;
                newPlayer.MiddleName = textPlayerMiddleName.Text;
                newPlayer.LastName = textPlayerLastName.Text;
                newPlayer.DateOfBirth = datePlayerDOB.Value;
                newPlayer.Nationality = (int)comboPlayerNationality.SelectedValue;
                newPlayer.Gender = (int)comboPlayerGender.SelectedValue;

                tournament.AddPlayer(newPlayer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Can't add player", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            DataGridAddElement(dataGridViewPlayer, newPlayer);

            //Resets the text fields after submit
            textPlayerFirstName.Text = null;
            textPlayerMiddleName.Text = null;
            textPlayerLastName.Text = null;
            datePlayerDOB.Value = DateTime.Today;
            comboPlayerGender.SelectedIndex = 0;
            comboPlayerNationality.SelectedIndex = 0;


        }

        private void buttonPlayerRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewPlayer.SelectedRows)
            {   
                try
                {
                    tournament.RemovePlayer((Player)row.Cells[0].Value);
                    dataGridViewPlayer.Rows.RemoveAt(row.Index);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Can't remove player", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonRefereeAdd_Click(object sender, EventArgs e)
        {
            Referee newReferee = new Referee();
            try
            {
                newReferee.FristName = textRefereeFirstName.Text;
                newReferee.MiddleName = textRefereeMiddleName.Text;
                newReferee.LastName = textRefereeLastName.Text;
                newReferee.DateOfBirth = dateRefereeDOB.Value;
                newReferee.Nationality = (int)comboRefereeNationality.SelectedValue;
                newReferee.Gender = (int)comboRefereeGender.SelectedValue;
                newReferee.LicenseAcquired = dateRefereeLicenseAcquired.Value;

                if (dateRefereeLicenseRenewed.Enabled == false)
                {
                    newReferee.LicenseLastRenewed = null;
                }
                else
                {
                    newReferee.LicenseLastRenewed = dateRefereeLicenseRenewed.Value;
                }
                

                tournament.AddReferee(newReferee);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Can't add player", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DataGridAddElement(dataGridViewReferee, newReferee);

            //Resets the text fields after submit
            textRefereeFirstName.Text = null;
            textRefereeMiddleName.Text = null;
            textRefereeLastName.Text = null;
            dateRefereeDOB.Value = DateTime.Today;
            comboRefereeGender.SelectedIndex = 0;
            comboRefereeNationality.SelectedIndex = 0;
        }

        private void checkRefereeNeverRenewed_CheckedChanged(object sender, EventArgs e)
        {
            if (dateRefereeLicenseRenewed.Enabled == true)
            {
                dateRefereeLicenseRenewed.Enabled = false;
            }
            else
            {
                dateRefereeLicenseRenewed.Enabled = true;
            }          
        }

        private void buttonRefereeRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewReferee.SelectedRows)
            {
                try
                {
                    tournament.RemoveReferee((Referee)row.Cells[0].Value);
                    dataGridViewReferee.Rows.RemoveAt(row.Index);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Can't remove referee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonPlayerSortByFirstName_Click(object sender, EventArgs e)
        {
            tournament.SortByFirstName(tournament.Players);
            dataGridViewPlayer.Rows.Clear();
            PopulateDataGridView(dataGridViewPlayer, tournament.Players);

        }

        private void buttonPlayerSortByLastName_Click(object sender, EventArgs e)
        {
            tournament.SortByLastName(tournament.Players);
            dataGridViewPlayer.Rows.Clear();
            PopulateDataGridView(dataGridViewPlayer, tournament.Players);
        }

        private void buttonRefereeSortByFirstName_Click(object sender, EventArgs e)
        {
            tournament.SortByFirstName(tournament.Referees);
            dataGridViewReferee.Rows.Clear();
            PopulateDataGridView(dataGridViewReferee, tournament.Referees);
        }

        private void buttonRefereeSortByLastName_Click(object sender, EventArgs e)
        {
            tournament.SortByLastName(tournament.Referees);
            dataGridViewReferee.Rows.Clear();
            PopulateDataGridView(dataGridViewReferee, tournament.Referees);
        }

    }
}
