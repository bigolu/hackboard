using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HackBoard.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new Context())
            {
                User user1 = new User() { Email = "ishan@poop.com" };
                ctx.Users.Add(user1);
                ctx.SaveChanges();
            }
        }
    }
}