using Entity;
using System;
using System.Diagnostics;
using System.Messaging;
using System.Web.Mvc;

namespace AsyncWebClient.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Unsubscribe(UnsubscribeCommand command)
        {
            try
            {
                const string queueAddress = @"HomeOffice\private$\msmq-test";

                using (var msmq = new MessageQueue(queueAddress))
                {
                    for (int i = 0; i < 10; i++)
                    {
                        msmq.Send(command);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }

            return View("Unsubscribe");
        }
    }
}