using BajajFinWebApi.Models.Dev_Model;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.OAuth;
using Microsoft.VisualStudio.Services.WebApi;
using Microsoft.VisualStudio.Services.WebApi.Patch;
using Microsoft.VisualStudio.Services.WebApi.Patch.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WorkItemWebhook.Models;

namespace WorkItemWebhook.Controllers
{
    public class CreateWorkitemController : Controller
    {

        public static WorkItemTrackingHttpClient WitClient;
        // GET: CreateWorkitem

        public ActionResult Index()
        {
            
            return View();
        }

        public static void ConnectWithPAT(string ServiceURL, string PAT)
        {
            try
            {
                
                VssConnection connection = new VssConnection(new Uri(ServiceURL), new VssBasicCredential("RY",PAT));
                InitClients(connection);
            }
            catch (Exception E)
            {
                throw E;
            }
        }
        static void InitClients(VssConnection Connection)
        {
            try
            {
                WitClient = Connection.GetClient<WorkItemTrackingHttpClient>();
            }
            catch (Exception E)
            {
                throw (E);
            }
        }

        public void CreateWork(WebHookRequestModel webhook)
        {
            try
            {
                string PAT = "mwcoyft3jyr2hilu4jsibj2lz32hxe5cxawpa2tlwqtibag76wmq";
                string BaseURL = webhook.resourceContainers.project.baseUrl;
                string Project = webhook.resourceContainers.project.id;
                //string RequestBody = Request.;

                int daysToAdd = 7;
                DateTime date =Convert.ToDateTime("2020-05-19T09:04:02.72Z");
                while (daysToAdd > 0)
                {
                    date = date.AddDays(1);

                    if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday)
                    {
                        daysToAdd -= 1;
                    }
                }

                JsonPatchDocument patchDocument = new JsonPatchDocument();

                JsonPatchOperation Jsonpatch = new JsonPatchOperation()
                {
                    Operation = Operation.Add,
                    Path = "/fields/" + "Custom.EndDate",
                    Value = date.ToString("yyyy-MM-dd'T'HH:mm:ss.fffffff'Z'")
                };
                if (!patchDocument.Contains(Jsonpatch))
                    patchDocument.Add(Jsonpatch);
                    ConnectWithPAT(BaseURL, PAT);
                WitClient.UpdateWorkItemAsync(patchDocument, webhook.resource.id);

            }
            catch(Exception e)
            {
                throw e;
            }
            
        }


    }
}