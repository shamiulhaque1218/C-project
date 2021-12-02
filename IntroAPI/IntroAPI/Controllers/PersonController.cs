using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IntroAPI.Controllers
{
    public class PersonController : ApiController
    {
        public List<string> GetNames()
        {
            List<string> names = new List<string>();
            names.Add("Shamiul");
            names.Add("Alvi");
            return names ;
        }
        public string Get(int id)
        {
            return "Names" + id;
        }
        public string Post()
        {
            return "Posted";
        }
        public string Put(int id, string name)
        {
            return "Put" + name + " " +id;
        }
        public string Delete(int id, string name)
        {
            return "Delete" + name + " " + id;
        }
    }
}
