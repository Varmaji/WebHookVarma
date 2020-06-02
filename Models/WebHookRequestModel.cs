using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkItemWebhook.Models
{
    public class WebHookRequestModel
    {
        public string subscriptionId { get; set; }
        public int notificationId { get; set; }
        public string id { get; set; }
        public string eventType { get; set; }
        public string publisherId { get; set; }
        public Message message { get; set; }
        public DetailedMessage detailedMessage { get; set; }
        public Resource resource { get; set; }
        public string resourceVersion { get; set; }
        public ResourceContainers resourceContainers { get; set; }
        public DateTime createdDate { get; set; }
    }
    public class Message
    {
        public string text { get; set; }
        public string html { get; set; }
        public string markdown { get; set; }

    }
    public class DetailedMessage
    {
        public string text { get; set; }
        public string html { get; set; }
        public string markdown { get; set; }

    }
    public class Fields
    {

        [JsonProperty(PropertyName = "System.AreaPath")]
        public string AreaPath { get; set; }
        //public string __invalid_name__System.TeamProject { get; set; }
        //public string __invalid_name__System.IterationPath { get; set; }
        [JsonProperty(PropertyName = "WorkItemType")]
        public string WorkItemType { get; set; }
        [JsonProperty(PropertyName = "System.State")]
        public string State { get; set; }
        // public string __invalid_name__System.Reason { get; set; }

        //[JsonProperty(PropertyName = "System.AssignedTo")]
        //public SystemAssignedTo AssignedTo { get; set; }
        //public DateTime __invalid_name__System.CreatedDate { get; set; }

        
        [JsonProperty(PropertyName = "System.Title")]
        public string Title { get; set; }
        //public DateTime __invalid_name__Microsoft.VSTS.Common.StateChangeDate { get; set; }
        //public DateTime __invalid_name__Microsoft.VSTS.Common.ActivatedDate { get; set; }
        //public MicrosoftVSTSCommonActivatedBy __invalid_name__Microsoft.VSTS.Common.ActivatedBy { get; set; }
        [JsonProperty(PropertyName = "Microsoft.VSTS.Common.Priority")]
        public int Priority { get; set; }
        //public string __invalid_name__Microsoft.VSTS.TCM.AutomationStatus { get; set; }

        [JsonProperty(PropertyName = "System.CreatedDate")]
        public DateTime CreatedDate;

        [JsonProperty(PropertyName = "Custom.EndDate")]
        public DateTime EndDate;

    }
    public class Self
    {
        public string href { get; set; }

    }
    public class WorkItemUpdates
    {
        public string href { get; set; }

    }
    public class WorkItemRevisions
    {
        public string href { get; set; }

    }
    public class WorkItemComments
    {
        public string href { get; set; }

    }
    public class Html
    {
        public string href { get; set; }

    }
    public class WorkItemType
    {
        public string href { get; set; }

    }
    //public class Fields
    //{
    //    public string href { get; set; }

    //}
    public class _links
    {
        public Self self { get; set; }
        public WorkItemUpdates workItemUpdates { get; set; }
        public WorkItemRevisions workItemRevisions { get; set; }
        public WorkItemComments workItemComments { get; set; }
        public Html html { get; set; }
        public WorkItemType workItemType { get; set; }
        public Fields fields { get; set; }

    }
    public class Resource
    {
        public int id { get; set; }
        public int rev { get; set; }
        public Fields fields { get; set; }
        public _links _links { get; set; }
        public string url { get; set; }

    }
    public class Collection
    {
        public string id { get; set; }
        public string baseUrl { get; set; }

    }
    public class Account
    {
        public string id { get; set; }
        public string baseUrl { get; set; }

    }
    public class Project
    {
        public string id { get; set; }
        public string baseUrl { get; set; }

    }
    public class ResourceContainers
    {
        public Collection collection { get; set; }
        public Account account { get; set; }
        public Project project { get; set; }

    }
  
}