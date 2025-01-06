using FootBall_Tournament_Management.DAO;
using FootBall_Tournament_Management.NewFolder1;
using FootBall_Tournament_Management.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FootBall_Tournament_Management.Forms.Chart
{
    public partial class StatisticChart : Form
    {
        private int tournamentID;
        public StatisticChart(int tournamentID)
        {
            InitializeComponent();
            this.tournamentID = tournamentID;
            LoadPieChart(GetScores());
        }

        private List<int> ConvertScore(string score)
        {
            string[] _score = score.Split('-');

            List<int> result = new List<int>();
            result.Add(int.Parse(_score[0]));
            result.Add(int.Parse(_score[1]));

            return result;
        }


        private List<Tuple<string, int>> GetScores()
        {
            List<Tuple<string, int>> tuples = new List<Tuple<string, int>>();

            TeamsInTournament teams = new TeamsInTournamentDAO().GetAllTeamsInTournament(tournamentID);
            DataTable matches = new MatchDAO().GetAllMatchesInTournament(tournamentID);

            foreach (Team team in teams.Teams)
            {
                int sum = 0;
                foreach (DataRow row in matches.Rows)
                {
                    if (team.TeamID == int.Parse(row[2].ToString()) || team.TeamID == int.Parse(row[3].ToString()))
                    {
                        List<int> scores = ConvertScore(row[7].ToString());

                        if (team.TeamID == int.Parse(row[2].ToString()))
                        {
                            sum += scores[0];
                        }
                        else
                        {
                            sum += scores[1];
                        }
                    }
                }

                tuples.Add(new Tuple<string, int>(team.TeamName, sum));

            }

            return tuples;
        }

        private void LoadPieChart(List<Tuple<string, int>> tuples)
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();

            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Team's Goal");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            foreach (Tuple<string, int> tuple in tuples)
            {
                series.Points.AddXY(tuple.Item1, tuple.Item2);
            }

            series.Label = "#PERCENT";
            series.LegendText = "#VALX";

            chart1.Series.Add(series);
            chart1.Titles.Add("Team Goal Statistics");
            chart1.Titles[0].Font = new Font("Arial", 16, FontStyle.Bold);

            chart1.Legends[0].Enabled = true;
        }

        private void LoadColumnChart(List<Tuple<string, int>> tuples)
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();

            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Team's Goal");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;

            foreach (Tuple<string, int> tuple in tuples)
            {
                series.Points.AddXY(tuple.Item1, tuple.Item2);
            }

            chart1.Series.Add(series);
            chart1.Titles.Add("Team Goal Statistics");
            chart1.Titles[0].Font = new Font("Arial", 16, FontStyle.Bold);
            series.IsValueShownAsLabel = true;

            chart1.Legends[0].Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                LoadPieChart(GetScores());
            }
            else
            {
                LoadColumnChart(GetScores());
            }
        }
    }
}
