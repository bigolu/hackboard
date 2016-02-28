using System;
using System.Collections.Generic;
using System.Linq;
using HackBoard.Models;
using System.Threading.Tasks;

namespace HackBoard
{
    public class User
    {

        public User()
        {

        }
        // String UserName { get; set; }
        public String Email { get; set; }
        public int ID { get; set; }
        public List<Project> OwnedProjects { get; set; }
        public List<Project> ProspectiveProjects { get; set; }
        public List<Project> JoinedProjects { get; set; }
        public String Blurb { get; set; }
        public List<Hackathon> JoinedHackathons { get; set; }





    }
}
