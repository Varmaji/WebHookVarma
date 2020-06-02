using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BajajFinWebApi.Models.Dev_Model
{
    public class Project1
    {
        public string id { get; set; }
        public string name { get; set; }
        public string state { get; set; }
        public string visibility { get; set; }
        public DateTime lastUpdateTime { get; set; }
    }

    public class Avatar1
    {
        public string href { get; set; }
    }

    public class Links1
    {
        public Avatar avatar { get; set; }
    }

    public class UpdatedBy
    {
        public string displayName { get; set; }
        public string url { get; set; }
        public Links _links { get; set; }
        public string id { get; set; }
        public string uniqueName { get; set; }
        public string imageUrl { get; set; }
        public string descriptor { get; set; }
    }

    public class RootSuite1
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Self1
    {
        public string href { get; set; }
    }

    public class ClientUrl1
    {
        public string href { get; set; }
    }

    public class RootSuite21
    {
        public string href { get; set; }
    }

    public class Links21
    {
        public Self _self { get; set; }
        public ClientUrl clientUrl { get; set; }
        public RootSuite2 rootSuite { get; set; }
    }

    public class Avatar21
    {
        public string href { get; set; }
    }

    public class Links3
    {
        public Avatar2 avatar { get; set; }
    }

    public class Owner
    {
        public string displayName { get; set; }
        public string url { get; set; }
        public Links3 _links { get; set; }
        public string id { get; set; }
        public string uniqueName { get; set; }
        public string imageUrl { get; set; }
        public string descriptor { get; set; }
    }

    public class TestOutcomeSettings
    {
        public bool syncOutcomeAcrossSuites { get; set; }
    }

    public class TestPlanResponse
    {
        public int id { get; set; }
        public Project project { get; set; }
        public DateTime updatedDate { get; set; }
        public UpdatedBy updatedBy { get; set; }
        public RootSuite rootSuite { get; set; }
        public Links2 _links { get; set; }
        public int revision { get; set; }
        public string name { get; set; }
        public string areaPath { get; set; }
        public string description { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string iteration { get; set; }
        public Owner owner { get; set; }
        public string state { get; set; }
        public TestOutcomeSettings testOutcomeSettings { get; set; }
    }

}