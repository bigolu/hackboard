using HackBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackBoard
{
    public class Hackathon
    {
        
        public int HackathonId { get; set; }
        String HackathonName { get; set; }
        String HackathonDescription { get; set; }
        int HackathonID { get; set; }
        public virtual ICollection<Project> Projects { get; set; }


    }
}
