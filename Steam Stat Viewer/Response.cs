using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam_Stat_Viewer
{
    public class Response
    {
        internal class Valve
        {
            /// <summary>
            /// A collection of the statistics which also contains the user's steamID and the name of the game.
            /// </summary>
            public Game playerStats { get; set; }
        }

        internal class Game
        {
            /// <summary>
            /// The steamID of the user we're getting statistics for.
            /// </summary>
            public string steamID { get; set; }
            /// <summary>
            /// The name of the game we're getting statistics for.
            /// </summary>
            public string gameName { get; set; }
            /// <summary>
            /// The actual statistics.
            /// </summary>
            public List<GameStat> stats { get; set; }
        }

        internal class GameStat
        {
            /// <summary>
            /// Name of the statistic.
            /// </summary>
            public string name { get; set; }
            /// <summary>
            /// The value of the statistic.
            /// </summary>
            public string value { get; set; }
        }
    }
}
