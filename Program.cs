using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fast_Furious
{
    internal static class Program
    {
        public static List<Player> Players = new List<Player>();
        public static List<game> games = new List<game>();
        public static Player getPlayer(String name)
        {
            foreach(var p in Players)
            {
                if(p.Name==name)
                    return p;

            }
            return null;
        }
        public static int getHighestScore( )
        {

            int highScore = -1;
            foreach (var p in Players)
            {
                if (p.MaxScore >= highScore)
                    highScore = p.MaxScore;

            }
            return highScore;
        }
        public static int getlowestScore( )
        {

            int lowestScore = -1;
            foreach (var p in Players)
            {
                if (p.MinScore <= lowestScore)
                    lowestScore = p.MinScore;

            }
            return lowestScore;
        }
        public static int getHighestDuration( )
        {

            int highDuration = -1;
            foreach (var p in Players)
            {
                if (p.MaxScore >= highDuration)
                    highDuration = p.MaxScore;

            }
            return highDuration;
        }
        public static int getlowestDuration( )
        {

            int lowestDuration = -1;
            foreach (var p in Players)
            {
                if (p.MinDuration <= lowestDuration)
                    lowestDuration = p.MinScore;

            }
            return lowestDuration;
        }
        public static int getTotal()
        {

            int t = 0;
            foreach (var g in games)
            {
                t += g.totalDuration;

            }
            return t;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
       
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Player computer1 = new Player("Computer1","","","Red");
            Player computer2 = new Player("Computer2", "", "", "Blue");
            Players.Add(computer1);
            Players.Add(computer2);
            Application.Run(new Intro());
        }
    }
}
