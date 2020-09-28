using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerExample
{
    class Player
    {
        private string m_playerName;
        private int m_score;
        private int m_timePlayed;

        public int TimePlayed
        {
            get { return m_timePlayed; }
            set { m_timePlayed = value; }
        }

        public string PlayerName
        {
            get { return m_playerName; }
            set { m_playerName = value; }
        }

        public int Score
        {
            get { return m_score; }
            set { m_score = value; }
        }

        public int ScoreByTimePlayed
        {
            get { return m_score / m_timePlayed; }
        }

        //Autoproperty
        public int  { get; set; }

    }
}
