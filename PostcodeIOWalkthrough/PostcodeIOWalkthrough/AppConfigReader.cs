using System;
using System.Configuration;
using System.Web.Configuration;

namespace PostcodeIOWalkthrough
{
    public static class AppConfigReader
    {
        public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];

    }
}
