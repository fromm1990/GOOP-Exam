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
        private void DataGridAddElement(DataGridView dataGrid, Player newPlayer)
        {
            int n = dataGridViewPlayer.Rows.Add();

            dataGrid.Rows[n].Cells[0].Value = newPlayer;
            dataGrid.Rows[n].Cells[1].Value = newPlayer.FristName;
            dataGrid.Rows[n].Cells[2].Value = newPlayer.MiddleName;
            dataGrid.Rows[n].Cells[3].Value = newPlayer.LastName;
            dataGrid.Rows[n].Cells[4].Value = newPlayer.DateOfBirth;
            dataGrid.Rows[n].Cells[5].Value = newPlayer.CalcAge(newPlayer.DateOfBirth);
            dataGrid.Rows[n].Cells[6].Value = newPlayer.Nationality;
            dataGrid.Rows[n].Cells[7].Value = newPlayer.Gender;

            dataGrid.Rows[n].Cells[0].ValueType = typeof(Player);
            dataGrid.Rows[n].Cells[1].ValueType = typeof(string);
            dataGrid.Rows[n].Cells[2].ValueType = typeof(string);
            dataGrid.Rows[n].Cells[3].ValueType = typeof(string);
            dataGrid.Rows[n].Cells[4].ValueType = typeof(DateTime);
            dataGrid.Rows[n].Cells[5].ValueType = typeof(int);
            dataGrid.Rows[n].Cells[6].ValueType = typeof(Player.Nationalities);
            dataGrid.Rows[n].Cells[7].ValueType = typeof(Player.Genders);
        }

        private void DataGridAddElement(DataGridView dataGrid, Referee newReferee)
        {
            int n = dataGridViewReferee.Rows.Add();

            dataGrid.Rows[n].Cells[0].Value = newReferee;
            dataGrid.Rows[n].Cells[1].Value = newReferee.FristName;
            dataGrid.Rows[n].Cells[2].Value = newReferee.MiddleName;
            dataGrid.Rows[n].Cells[3].Value = newReferee.LastName;
            dataGrid.Rows[n].Cells[4].Value = newReferee.DateOfBirth;
            dataGrid.Rows[n].Cells[5].Value = newReferee.CalcAge(newReferee.DateOfBirth);
            dataGrid.Rows[n].Cells[6].Value = newReferee.Nationality;
            dataGrid.Rows[n].Cells[7].Value = newReferee.Gender;
            dataGrid.Rows[n].Cells[8].Value = newReferee.LicenseAcquired;
            dataGrid.Rows[n].Cells[9].Value = newReferee.LicenseLastRenewed;

            dataGrid.Rows[n].Cells[0].ValueType = typeof(Referee);
            dataGrid.Rows[n].Cells[1].ValueType = typeof(string);
            dataGrid.Rows[n].Cells[2].ValueType = typeof(string);
            dataGrid.Rows[n].Cells[3].ValueType = typeof(string);
            dataGrid.Rows[n].Cells[4].ValueType = typeof(DateTime);
            dataGrid.Rows[n].Cells[5].ValueType = typeof(int);
            dataGrid.Rows[n].Cells[6].ValueType = typeof(Referee.Nationalities);
            dataGrid.Rows[n].Cells[7].ValueType = typeof(Referee.Genders);
            dataGrid.Rows[n].Cells[8].ValueType = typeof(DateTime);
            dataGrid.Rows[n].Cells[9].ValueType = typeof(DateTime?);
        }

        private void PopulateDataGridView(DataGridView dataGrid, Player[] players)
        {
            foreach (Player player in players)
            {
                if (player != null)
                {
                    DataGridAddElement(dataGrid, player);
                }
            }
        }

        private void PopulateDataGridView(DataGridView dataGrid, Referee[] referees)
        {
            foreach (Referee referee in referees)
            {
                if (referee != null)
                {
                    DataGridAddElement(dataGrid, referee);
                }
            }
        }

    }
}
