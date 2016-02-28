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

        public JsonResult createUser(String name, String username, String password, String description,String github, String linkid)
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
                
                ctx.Users.Add(NewUser);
                ctx.SaveChanges();
                id = NewUser.UserId;


            }
            

            return Json(id,JsonRequestBehavior.AllowGet);
            //new HackBoard.User { Email = "yodawg"}
        }
        public JsonResult createProject(String title, String hackathon_name, int ownerid, String description, int total_people_desired)
        {
            int id = -1;
            using (var ctx = new Context())
            {
                var user = ctx.Users.Find(ownerid);
                

                Project NewProject = new Project()
                {
                    Title = title,
                    Description = description,
                    MaxPeople = total_people_desired,
                    Owner = user,
                    CurrentPeople = 1,
                    Hackathon_Name = hackathon_name
                    
                   
                };
                user.OwnedProjects.Add(NewProject);
                user.JoinedProjects.Add(NewProject);
                ctx.Projects.Add(NewProject);
                ctx.SaveChanges();
                id = user.UserId;

            }
            return Json(id, JsonRequestBehavior.AllowGet);

        }

        public JsonResult getProjects()
        {
            List<Project> AllProjects;
            using (var ctx = new Context())
            {
                AllProjects = ctx.Projects.ToList();
                
            }
            return Json(AllProjects, JsonRequestBehavior.AllowGet);

        }
        public void approvalProject(int userid, int projectid)
        {
            using (var ctx = new Context())
            {
                var user = ctx.Users.Find(userid);
                var project = ctx.Projects.Find(projectid);

                user.ProspectiveProjects.Add(project);
                
            }

        }
    }
}
