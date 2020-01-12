using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Steam_Stat_Viewer
{
    public class Parser
    {
        /// <summary>
        /// Parse a JSON response from Valve's web API.
        /// </summary>
        /// <param name="JSON">The JSON response to parse.</param>
        /// <returns></returns>
        public static string Parse(string JSON)
        {
            string parsed = "";

            Response.Valve valve = JsonConvert.DeserializeObject<Response.Valve>(JSON);

            foreach (Response.GameStat stat in valve.playerStats.stats)
                parsed += $"{stat.name} : {stat.value}" + Environment.NewLine;

            return parsed;
        }
    }
}
