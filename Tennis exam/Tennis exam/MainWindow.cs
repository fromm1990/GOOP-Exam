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
            groupBoxAdd.Enabled = false;
            //groupBoxGame.Enabled = false;

            //Setting up Data sources for combo boxes
            comboPlayerGender.DataSource = Enum.GetValues(typeof(Genders));
            comboPlayerNationality.DataSource = Enum.GetValues(typeof(Nationalities));
            comboRefereeGender.DataSource = Enum.GetValues(typeof(Genders));
            comboRefereeNationality.DataSource = Enum.GetValues(typeof(Nationalities));
            comboGMGender.DataSource = Enum.GetValues(typeof(Genders));
            comboGMNationality.DataSource = Enum.GetValues(typeof(Nationalities));
            comboTournamentType.DataSource = Enum.GetValues(typeof(TournamentTypes));
        }
        
        #region Create Tournament
        private void buttonTournamentCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textTournamentName.Text;
                DateTime startsAt = dateTimeTournamentStartsAt.Value;
                DateTime endsAt = dateTimeTournamentEndsAt.Value;
                int amountOfPlayers = Convert.ToInt32(comboTournamentAmountOfPlayers.SelectedItem);
                TournamentTypes type = (TournamentTypes)comboTournamentType.SelectedValue;

                switch (type)
                {
                    case TournamentTypes.DoubleFemale:
                    case TournamentTypes.DoubleMale:
                    case TournamentTypes.MixDouble:
                        amountOfPlayers = amountOfPlayers * 2;
                        break;
                }

                tournament = new Tournament(name, startsAt, endsAt, amountOfPlayers, type);
                
                groupBoxTournament.Enabled = false;
                groupBoxAdd.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Can't create tournament", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
        #endregion

        #region Add/Remover player
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
                newPlayer.Gender = (Genders)comboPlayerGender.SelectedValue;

                tournament.AddPlayer(newPlayer);

                DataGridAddElement(dataGridViewPlayer, newPlayer);

                //Resets the text fields after submit
                textPlayerFirstName.Text = null;
                textPlayerMiddleName.Text = null;
                textPlayerLastName.Text = null;
                datePlayerDOB.Value = DateTime.Today;
                comboPlayerGender.SelectedIndex = 0;
                comboPlayerNationality.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Can't add player", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        #endregion

        #region Add/Remove Referee
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
                newReferee.Gender = (Genders)comboRefereeGender.SelectedValue;
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

                DataGridAddElement(dataGridViewReferee, newReferee);

                //Resets the text fields after submit
                textRefereeFirstName.Text = null;
                textRefereeMiddleName.Text = null;
                textRefereeLastName.Text = null;
                dateRefereeDOB.Value = DateTime.Today;
                comboRefereeGender.SelectedIndex = 0;
                comboRefereeNationality.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Can't add player", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        #endregion

        #region Sort players/referes by first and last -name
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
        #endregion

        #region Set/Add/Remove game master
        private void buttonSetAsGameMaster_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dataGridViewReferee.SelectedRows.Count;
            try
            {
                if (selectedRowCount > 1)
                {
                    throw new Exception("You can only promote exactly one referee");
                }
                else if (selectedRowCount <= 0)
                {
                    throw new Exception("You will have to select exactly one referee.");
                }
                else if (dataGridViewReferee.SelectedRows[0].Cells[0].Value == null)
                {
                    throw new Exception("You can't promote an empty row");
                }
                else
                {
                    Referee referee = (Referee)dataGridViewReferee.SelectedRows[0].Cells[0].Value;
                    tournament.SetGameMaster(referee);
                    dataGridViewReferee.Rows.RemoveAt(dataGridViewReferee.SelectedRows[0].Index);
                    DataGridAddElement(dataGridViewGM, tournament.GameMasterProp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Can't remove referee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGMAdd_Click(object sender, EventArgs e)
        {
            GameMaster newGameMaster = new GameMaster();
            try
            {
                newGameMaster.FristName = textGMFirstName.Text;
                newGameMaster.MiddleName = textGMMiddleName.Text;
                newGameMaster.LastName = textGMLastName.Text;
                newGameMaster.DateOfBirth = dateGMDOB.Value;
                newGameMaster.Nationality = (int)comboGMNationality.SelectedValue;
                newGameMaster.Gender = (Genders)comboGMGender.SelectedValue;
                newGameMaster.LicenseAcquired = dateGMLicenseAcquired.Value;

                if (dateGMLicenseRenewed.Enabled == false)
                {
                    newGameMaster.LicenseLastRenewed = null;
                }
                else
                {
                    newGameMaster.LicenseLastRenewed = dateGMLicenseRenewed.Value;
                }


                tournament.AddGameMaster(newGameMaster);

                DataGridAddElement(dataGridViewGM, newGameMaster);

                //Resets the text fields after submit
                textGMFirstName.Text = null;
                textGMMiddleName.Text = null;
                textGMLastName.Text = null;
                dateGMDOB.Value = DateTime.Today;
                comboGMGender.SelectedIndex = 0;
                comboGMNationality.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Can't add game master", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkGMLicenseNeverRenewed_CheckedChanged(object sender, EventArgs e)
        {
            if (dateGMLicenseRenewed.Enabled == true)
            {
                dateGMLicenseRenewed.Enabled = false;
            }
            else
            {
                dateGMLicenseRenewed.Enabled = true;
            }
        }

        private void buttonGMRemove_Click(object sender, EventArgs e)
        {
            tournament.RemoveGamemaster();
            dataGridViewGM.Rows.Clear();
        }
        #endregion

        #region AutoFillData

        private void buttonPlayerAutoAdd_Click(object sender, EventArgs e)
        {
            AutoFillData autoAdd = new AutoFillData();

            switch (tournament.TournamentType)
            {
                case TournamentTypes.SingleFemale:
                case TournamentTypes.DoubleFemale:
                    for (int i = 0; i < tournament.TournamentSize; i++)
                    {
                        tournament.AddPlayer(autoAdd.AutoCreatePlayer("female"));
                    }
                    PopulateDataGridView(dataGridViewPlayer, tournament.Players);
                    break;
                case TournamentTypes.SingleMale:
                case TournamentTypes.DoubleMale:
                    for (int i = 0; i < tournament.TournamentSize; i++)
                    {
                        tournament.AddPlayer(autoAdd.AutoCreatePlayer("male"));
                    }
                    PopulateDataGridView(dataGridViewPlayer, tournament.Players);
                    break;
                case TournamentTypes.MixDouble:
                    for (int i = 0; i < tournament.TournamentSize / 2; i++)
                    {
                        tournament.AddPlayer(autoAdd.AutoCreatePlayer("female"));
                    }
                    for (int i = 0; i < tournament.TournamentSize / 2; i++)
                    {
                        tournament.AddPlayer(autoAdd.AutoCreatePlayer("male"));
                    }
                    PopulateDataGridView(dataGridViewPlayer, tournament.Players);
                    break;
            }

            
        }

        private void buttonRefereeAutoAdd_Click(object sender, EventArgs e)
        {
            AutoFillData autoAdd = new AutoFillData();

            for (int i = 0; i < tournament.TournamentSize / 4; i++)
            {
                tournament.AddReferee(autoAdd.AutoCreateReferee("female"));
            }
            for (int i = 0; i < tournament.TournamentSize / 4; i++)
            {
                tournament.AddReferee(autoAdd.AutoCreateReferee("male"));
            }
            PopulateDataGridView(dataGridViewReferee, tournament.Referees);
        }
        #endregion

        private void buttonTournamentPlay_Click(object sender, EventArgs e)
        {
            tournament.PlayTournament(tournament.TournamentType);
            PopulateDataGridView(dataGridViewGames, tournament.Games);
            try
            {
                if (tournament.IsSingle())
                {
                    labelTournamentWinner.Text = "Tournament winner: " + tournament.TournamentWinner()[0].FullName;
                }
                else
                {
                    labelTournamentWinner.Text = "Tournament winner: " + tournament.TournamentWinner()[0].FullName + 
                                                                 " and " + tournament.TournamentWinner()[1].FullName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Can't add player", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
