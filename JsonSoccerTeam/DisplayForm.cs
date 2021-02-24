using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace JsonSoccerTeam
{
    public partial class DisplayForm : Form
    {
        public DisplayForm()
        {
            InitializeComponent();

        }

        public void CreatePlayers()
        {
            SoccerPlayer s1 = new SoccerPlayer("Rashford", 85, 80, 75, 90);
            SoccerPlayer s2 = new SoccerPlayer("Martial", 80, 85, 73, 82);
            SoccerPlayer s3 = new SoccerPlayer("Messi", 30, 30, 30, 30);
            SoccerPlayer s4 = new SoccerPlayer("Ronaldo", 99, 99, 99, 99);
            SoccerPlayer s5 = new SoccerPlayer("Pele", 100, 100, 100, 100);

            List<SoccerPlayer> players = new List<SoccerPlayer>();
            players.Add(s1);
            players.Add(s2);
            players.Add(s3);
            players.Add(s4);
            players.Add(s5);
            // string json = JsonConvert.SerializeObject(products, Formatting.Indented);

            using (StreamWriter writer = new StreamWriter("players.json", false))
            {
                JsonSerializer serializer = new JsonSerializer();

                serializer.Serialize(writer, players);
                //foreach (SoccerPlayer s in players)
                //{
                //    serializer.Serialize(writer, s);
                //}
            }
        }

        public void GetPlayersFromJson()
        {
            lbPlayers.Items.Clear();
            string jsonData = "";
            using (StreamReader reader = new StreamReader("players.json"))
            {
                jsonData = reader.ReadToEnd();
            }

            List<SoccerPlayer> players = JsonConvert.DeserializeObject<List<SoccerPlayer>>(jsonData);

            foreach (SoccerPlayer s in players)
            {
                lbPlayers.Items.Add(s);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string selectedPlayer = lbPlayers.SelectedItem.ToString();
            rtbSelectedPlayers.AppendText($"{selectedPlayer}\n");
        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {
            CreatePlayers();
            GetPlayersFromJson();
        }
    }
}
