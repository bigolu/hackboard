using HackBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HackBoard.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            //CreateUser();


            return View();
        }

        public int CreateUser(String name, String username, String password, String description,String github, String linkid)
        {
            int id = -1;
            using (var ctx = new Context())
            {

                User NewUser = new User()
                {
                    Email = username,
                    Name = name,
                    Password = password,
                    Description = description,
                    Github = github,
                    LinkId = linkid
                };
                id = NewUser.UserId;
                ctx.Users.Add(NewUser);
                ctx.SaveChanges();

            }
            

            return id ; //Json(c,JsonRequestBehavior.AllowGet);
            //new HackBoard.User { Email = "yodawg"}
        }
        public void CreateProject(String title, String hackathon_name, int ownerid, String description, int total_people_desired)
        {
            using (var ctx = new Context())
            {
                Project NewProject = new Project()
                {
                    Title = title,
                    Description = description,
                    MaxPeople = total_people_desired,

                   
                };
                ctx.Projects.Add(NewProject);
                ctx.SaveChanges();

            }

        }

        public void UpdateUser(String name, String username, String password, String description, String github, String linkid)
        {


        }
    }
}
