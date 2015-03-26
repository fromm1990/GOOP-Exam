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
    public partial class Form1 : Form
    {
        Tournament tournament;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tournament = new Tournament(16);

            //Setting up Data sources for combo boxes
            comboPlayerGender.DataSource = Enum.GetValues(typeof(Player.Genders));
            comboPlayerNationality.DataSource = Enum.GetValues(typeof(Player.Nationalities));
        }

        private void buttonAddPlayer_Click(object sender, EventArgs e)
        {
            Player newPlayer = new Player();
            try
            {         
                newPlayer.FristName = textPlayerFirstName.Text;
                newPlayer.MiddleName = textMiddleName.Text;
                newPlayer.LastName = textLastName.Text;
                newPlayer.DateOfBirth = datePlayerDOB.Value;
                newPlayer.Nationality = (int)comboPlayerNationality.SelectedValue;
                newPlayer.Gender = (int)comboPlayerGender.SelectedValue;

                tournament.AddPlayer(newPlayer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Can't add player", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            int n = dataGridViewPlayer.Rows.Add();

            dataGridViewPlayer.Rows[n].Cells[0].Value = newPlayer;
            dataGridViewPlayer.Rows[n].Cells[1].Value = newPlayer.FristName;
            dataGridViewPlayer.Rows[n].Cells[2].Value = newPlayer.MiddleName;
            dataGridViewPlayer.Rows[n].Cells[3].Value = newPlayer.LastName;
            dataGridViewPlayer.Rows[n].Cells[4].Value = newPlayer.DateOfBirth;
            dataGridViewPlayer.Rows[n].Cells[5].Value = newPlayer.CalcAge(newPlayer.DateOfBirth);
            dataGridViewPlayer.Rows[n].Cells[6].Value = newPlayer.Nationality;
            dataGridViewPlayer.Rows[n].Cells[7].Value = newPlayer.Gender;

            dataGridViewPlayer.Rows[n].Cells[0].ValueType = typeof(Player);
            dataGridViewPlayer.Rows[n].Cells[1].ValueType = typeof(string);
            dataGridViewPlayer.Rows[n].Cells[2].ValueType = typeof(string);
            dataGridViewPlayer.Rows[n].Cells[3].ValueType = typeof(string);
            dataGridViewPlayer.Rows[n].Cells[4].ValueType = typeof(DateTime);
            dataGridViewPlayer.Rows[n].Cells[5].ValueType = typeof(int);
            dataGridViewPlayer.Rows[n].Cells[6].ValueType = typeof(Player.Nationalities);
            dataGridViewPlayer.Rows[n].Cells[7].ValueType = typeof(Player.Genders);

            //Resets the text fields after submit
            textPlayerFirstName.Text = null;
            textMiddleName.Text = null;
            textLastName.Text = null;
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
    }
}
