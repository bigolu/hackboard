using System;
using System.Collections.Generic;
using HackBoard.Models;
using System.Linq;
using System.Web;

namespace HackBoard.Models
{
    public class Project
    {
        public Project()
        {
        }
        Hackathon Hackathon { get; set; }
        List<Project> OwnedProjects { get; set; }
        List<Project> InterestProjects { get; set; }
        List<Project> JoinedProjects { get; set; }
        User Owner;
        int MaxPeople;
        int CurrentPeople;
        List<User> Users { get; set; }
        
                    
    }
}