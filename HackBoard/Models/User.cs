using System;
using System.Collections.Generic;
using System.Linq;
using HackBoard.Models;
using System.Threading.Tasks;

namespace HackBoard
{
    public class User
    {

        public int UserId { get; set; }
        // String UserName { get; set; }
        public String Email { get; set; }
        //public int ID { get; set; }
        public virtual ICollection<Project> OwnedProjects { get; set; }
        public virtual ICollection<Project> ProspectiveProjects { get; set; }
        public virtual ICollection<Project> JoinedProjects { get; set; }
        public String Description { get; set; }
        public virtual ICollection<Hackathon> JoinedHackathons { get; set; }
        public String Github { get; set; }
        public String LinkId { get; set; }
        public String Password { get; set; }
        public String Name { get; set; }





    }
}
