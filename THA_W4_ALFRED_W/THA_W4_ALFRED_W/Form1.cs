using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W4_ALFRED_W
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Team> teams = new List<Team>();
        private void btn_addteam_Click(object sender, EventArgs e)
        {
            comboBox_country.Items.Clear();
            bool teamExists = false;
            if(textBox_tname.Text == "" || textBox_tcountry.Text == "" || textBox_tcity.Text == "")
            {
                MessageBox.Show("Please fill in all the fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Team newTeam = new Team(textBox_tname.Text, textBox_tcountry.Text, textBox_tcity.Text);
                foreach (Team team in teams)
                {
                    if (team.teamName == newTeam.teamName)
                    {
                        teamExists = true;
                    }
                }
                if (teamExists == false)
                {
                    teams.Add(newTeam);
                }
                else
                {
                    MessageBox.Show("Team already exists, please add another team.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                textBox_tname.Text = "";
                textBox_tcountry.Text = "";
                textBox_tcity.Text = "";
            }
            foreach (Team team in teams)
            {
                if (!comboBox_country.Items.Contains(team.teamCountry))
                {
                    comboBox_country.Items.Add(team.teamCountry);
                }
            }
        }

        private void comboBox_country_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string pickedCountry = comboBox_country.Text;
            comboBox_team.Items.Clear();
            foreach(Team team in teams)
            {
                if(team.teamCountry == pickedCountry)
                {
                    comboBox_team.Items.Add(team.teamName);
                }
            }
        }

        private void comboBox_team_SelectionChangeCommitted(object sender, EventArgs e)
        {
            list_players.Items.Clear();
            foreach(Team team in teams)
            {
                if(team.teamName == comboBox_team.Text)
                {
                    foreach(Player players in team.Players)
                    {
                        list_players.Items.Add("(" + players.playerNum + ") " + players.playerName + ", " + players.playerPos);
                        list_players.Sorted = true;
                    }
                    break;
                }
            }
        }

        private void btn_removeplayer_Click(object sender, EventArgs e)
        {
            if(list_players.Items.Count < 11)
            {
                MessageBox.Show("Players must be more or equal to 11.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (Team team in teams)
                {
                    if (team.teamName == comboBox_team.Text)
                    {
                        foreach (Player player in team.Players)
                        {
                            if (list_players.SelectedItem.ToString().Contains(player.playerName))
                            {
                                team.Players.Remove(player);
                                break;
                            }
                        }
                    }
                }
                list_players.Items.RemoveAt(list_players.SelectedIndex);
            }
        }

        private void btn_addplayer_Click(object sender, EventArgs e)
        {
            bool belumada = true;
            if (textBox_pname.Text == "" || textBox_pnum.Text == "" || comboBox_position.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all the fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (comboBox_team.Text == "")
                {
                    MessageBox.Show("Please select a team first.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Player newPlayer = new Player(textBox_pname.Text, textBox_pnum.Text, comboBox_position.Text);
                    foreach (Team team in teams)
                    {
                        if (team.teamName == comboBox_team.Text)
                        {

                            foreach (Player player in team.Players)
                            {
                                if (newPlayer.playerNum == player.playerNum)
                                {
                                    belumada = false;
                                    break;
                                }
                            }
                            if (belumada == true)
                            {
                                team.Players.Add(newPlayer);
                            }
                            else
                            {
                                MessageBox.Show("Player with same number is found.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        }
                    }
                }
                textBox_pname.Text = "";
                textBox_pnum.Text = "";
                comboBox_position.SelectedIndex = -1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Team sampleteam1 = new Team("Bayern Munich", "Germany", "Munich");
            teams.Add(sampleteam1);
            Team sampleteam2 = new Team("Manchester United", "England", "Manchester");
            teams.Add(sampleteam2);
            Team sampleteam3 = new Team("Arsenal", "England", "London");
            teams.Add(sampleteam3);
            foreach (Team team in teams)
            {
                if (!comboBox_country.Items.Contains(team.teamCountry)) {
                    comboBox_country.Items.Add(team.teamCountry);
                } 
            }
            Player player1 = new Player("Manuel Neuer", "01", "GK");
            sampleteam1.Players.Add(player1);
            Player player2 = new Player("Dayot Upamecano", "02", "DF");
            sampleteam1.Players.Add(player2);
            Player player3 = new Player("Matthjis de Ligt", "04", "DF");
            sampleteam1.Players.Add(player3);
            Player player4 = new Player("Benjamin Pavard", "05", "DF");
            sampleteam1.Players.Add(player4);
            Player player5 = new Player("Joshua Kimmich", "06", "MF");
            sampleteam1.Players.Add(player5);
            Player player6 = new Player("Serge Gnarby", "07", "FW");
            sampleteam1.Players.Add(player6);
            Player player7 = new Player("Leon Goretzka", "08", "MF");
            sampleteam1.Players.Add(player7);
            Player player8 = new Player("Leroy Sane", "10", "FW");
            sampleteam1.Players.Add(player8);
            Player player9 = new Player("Paul Wanner", "14", "MF");
            sampleteam1.Players.Add(player9);
            Player player10 = new Player("Lucas Hernandez", "21", "DF");
            sampleteam1.Players.Add(player10);
            Player player11 = new Player("Thomas Muller", "25", "FW");
            sampleteam1.Players.Add(player11);

            Player playerr1 = new Player("David De Gea", "01", "GK");
            sampleteam2.Players.Add(playerr1);
            Player playerr2 = new Player("Victor Lindelof", "02", "DF");
            sampleteam2.Players.Add(playerr2);
            Player playerr3 = new Player("Phil Jones", "04", "DF");
            sampleteam2.Players.Add(playerr3);
            Player playerr4 = new Player("Harry Maguire", "05", "DF");
            sampleteam2.Players.Add(playerr4);
            Player playerr5 = new Player("Lisandro Martinez", "06", "DF");
            sampleteam2.Players.Add(playerr5);
            Player playerr6 = new Player("Bruno Fernandez", "08", "MF");
            sampleteam2.Players.Add(playerr6);
            Player playerr7 = new Player("Anthony Martial", "09", "FW");
            sampleteam2.Players.Add(playerr7);
            Player playerr8 = new Player("Marcus Rashford", "10", "FW");
            sampleteam2.Players.Add(playerr8);
            Player playerr9 = new Player("Tyrell Malacia", "12", "DF");
            sampleteam2.Players.Add(playerr9);
            Player playerr10 = new Player("Christian Eriksen", "14", "MF");
            sampleteam2.Players.Add(playerr10);
            Player playerr11 = new Player("Casemiro", "18", "MF");
            sampleteam2.Players.Add(playerr11);

            Player playerrr1 = new Player("Aaron Ramsdale", "01", "GK");
            sampleteam3.Players.Add(playerrr1);
            Player playerrr2 = new Player("Kieran Tierney", "03", "DF");
            sampleteam3.Players.Add(playerrr2);
            Player playerrr3 = new Player("Ben White", "04", "DF");
            sampleteam3.Players.Add(playerrr3);
            Player playerrr4 = new Player("Thomas", "05", "MF");
            sampleteam3.Players.Add(playerrr4);
            Player playerrr5 = new Player("Buyayo Saka", "07", "MF");
            sampleteam3.Players.Add(playerrr5);
            Player playerrr6 = new Player("Martin Odegaard", "08", "MF");
            sampleteam3.Players.Add(playerrr6);
            Player playerrr7 = new Player("Gabriel Jesus", "09", "FW");
            sampleteam3.Players.Add(playerrr7);
            Player playerrr8 = new Player("Smith Rowe", "10", "MF");
            sampleteam3.Players.Add(playerrr8);
            Player playerrr9 = new Player("Gabriel Martinelli", "11", "FW");
            sampleteam3.Players.Add(playerrr9);
            Player playerrr10 = new Player("William Saliba", "12", "DF");
            sampleteam3.Players.Add(playerrr10);
            Player playerrr11 = new Player("Eddie Nketiah", "14", "FW");
            sampleteam3.Players.Add(playerrr11);
        }
    }
}
