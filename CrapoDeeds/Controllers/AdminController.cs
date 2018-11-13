using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrapoDeeds.Models;

namespace CrapoDeeds.Controllers
{
    public class AdminController : Controller
    {
        public static int taskCount = 1;
        public static int clientCounter = 1;
        public static int caseCount = 1;
        public ActionResult Index()
        {
            return View ();
        }
        public ActionResult Tasks()
        {
            return View();
        }
        public ActionResult ViewTasks()
        {
            List<Task> tasks = new List<Task>();

            for (int iCount = 0; iCount < 20; iCount++)
            {
                Task tempTask = new Task();
                tempTask.taskID = taskCount;
                taskCount++;
                tempTask.Case = "Walmart Case";
                tempTask.createdDate = new DateTime();
                tempTask.dueDate = new DateTime();
                tempTask.taskOwner = "David Crapo";
                tempTask.taskDescription = "This is the really tough walmart case....";
                tasks.Add(tempTask);
            }

            return View(tasks.AsEnumerable());
        }
        public ActionResult AddClient()
        {
            return View();
        }
        public ActionResult Clients()
        {
            List<Client> clients = new List<Client>();

            for (int iCount = 0; iCount < 20; iCount++)
            {
                Client tempClient = new Client();
                tempClient.clientID = clientCounter;
                clientCounter++;
                tempClient.clientName = "WalMart";
                tempClient.companyAddress = "1st Ave Temple Square Salt Lake City 84780";
                clients.Add(tempClient);
            }
            return View(clients.AsEnumerable());
        }
        public ActionResult AddCase()
        {
            return View();
        }
        public ActionResult Cases()
        {
            List<Case> cases = new List<Case>();

            for (int iCount = 0; iCount < 20; iCount++)
            {
                Case tempCase = new Case();
                tempCase.caseID = caseCount;
                caseCount++;
                tempCase.caseDescription = "Trying to protect WalMart form Target who is suing for copying";
                tempCase.client = new Client();
                tempCase.client.clientName = "WalMart";
                cases.Add(tempCase);
            }
            return View(cases.AsEnumerable());
        }
    }
}
