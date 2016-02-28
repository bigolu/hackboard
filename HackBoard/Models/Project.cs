using System;
using System.Collections.Generic;
using HackBoard.Models;
using System.Linq;
using System.Web;

namespace HackBoard.Models
{
    public class Project
    {

        public int ProjectId { get; set; }
        public Hackathon Hackathon { get; set; }
        public User Owner { get; set; }
        public int MaxPeople { get; set; }
        public int CurrentPeople { get; set; }  
        public  ICollection<User> Users { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public String Hackathon_Name { get; set; }


    }
}
