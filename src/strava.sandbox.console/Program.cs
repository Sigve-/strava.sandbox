

using System.Runtime.InteropServices;
using Strava.Authentication;
using Strava.Clients;

namespace strava.sandbox.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var staticAuthentication = new StaticAuthentication("f112cb279e1ab839bae4918febb5b7a96f199e40");
            var web = new WebAuthentication{AccessToken = "f112cb279e1ab839bae4918febb5b7a96f199e40", AuthCode = ""};
            var client = new StravaClient(staticAuthentication);
            var segment = client.Segments.GetSegment("10393462");
            var segmentLeaderboard = client.Segments.GetFullSegmentLeaderboard("10393462");
            var athlete = client.Athletes.GetAthlete();
            
        }
    }
}
