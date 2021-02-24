using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSoccerTeam
{
    class SoccerPlayer
    {
        private string name;
        private int pace;
        private int dribbling;
        private int strength;
        private int shooting;

        public SoccerPlayer(string name, int pace, int dribbling, int strength, int shooting)
        {
            this.Name = name;
            this.Pace = pace;
            this.Dribbling = dribbling;
            this.Strength = strength;
            this.Shooting = shooting;
        }

        public string Name { get => name; set => name = value; }
        public int Pace { get => pace; set => pace = value; }
        public int Dribbling { get => dribbling; set => dribbling = value; }
        public int Strength { get => strength; set => strength = value; }
        public int Shooting { get => shooting; set => shooting = value; }

        public override string ToString()
        {
            string display = name;
            return display;
        }
    }
}
