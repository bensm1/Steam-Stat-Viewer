using System;
using System.Net;

namespace Steam_Stat_Viewer
{
    public class WebAPI
    {
        /// <summary>
        /// Request game statistics from Valve's web API.
        /// </summary>
        /// <param name="steamID">The steamID of the user you want statistics for.</param>
        /// <param name="appID">The appID of the game you want statistics for.</param>
        public static string RequestStatistics(string steamID, string appID)
        {
            string apiKey = "YourApiKeyHere";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"http://api.steampowered.com/ISteamUserStats/GetUserStatsForGame/v0002/?appid={appID}&key={apiKey}&steamid={steamID}");
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();
            var responseReader = new System.IO.StreamReader(webStream);
            var response = responseReader.ReadToEnd();

            responseReader.Close();

            if (response != null)
                return response;

            return "Invalid response received.";
        }
    }
}
