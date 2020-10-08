﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOMWalkthrough
{
    public static class AppConfigReader
    {
        public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];
        public static readonly string SignInPageUrl = ConfigurationManager.AppSettings["signin_url"];
    }
}
