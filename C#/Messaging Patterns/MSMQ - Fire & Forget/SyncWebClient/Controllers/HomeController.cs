using Entity;
using System.Web.Mvc;
using Workflow;

namespace SyncWebClient.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Unsubscribe(UnsubscribeCommand command)
        {
            UnsubscriptionWorkflow.Run(command.EmailAddress);
            return View("Unsubscribe");
        }
    }
}