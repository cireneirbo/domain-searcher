using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace domain_searcher
{
    public class DomainSearch
    {
        public string api_key { get; set; }
        public string date { get; set; }
        public string page { get; set; }
        public int limit { get; set; }
        public string domain { get; set; }
        public string zone { get; set; }
        public string country { get; set; }
        public bool isDead { get; set; }
        public string A { get; set; }
        public string NS { get; set; }
        public string CNAME { get; set; }
        public string MX { get; set; }
        public string TXT { get; set; }
    }
}


