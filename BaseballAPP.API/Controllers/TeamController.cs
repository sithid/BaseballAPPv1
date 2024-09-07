using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BaseballAPP.Service.Model;

namespace BaseballAPP.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private List<string> Players = ["Alex", "John", "Joe"];
        private Team playerTeam = new Team();

        [HttpGet("GetPlayerName")]
        public string GetNameOfPlayer()
        {
            return "Alex";
        }

        [HttpGet("GetListPlayers")]
        public List<string> GetListOfPlayers()
        {
            return Players;
        }

        [HttpPost("CreateNewPlayer")]
        public bool CreateNewPlayer(string Name)
        {
            if( string.IsNullOrWhiteSpace( Name ) )
                return false;

            Players.Add(Name);

            return true;
        }
    }
}
