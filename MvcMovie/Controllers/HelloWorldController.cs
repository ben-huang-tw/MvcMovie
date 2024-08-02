using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 

        public string Index() {
            return "This is my <b>default</b> action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 
        //public string Welcome() {
        //    return "This is the Welcome action method...";
        //}

        // 
        // GET: /HelloWorld/Welcome?name=Scott&numtimes=4
        //public string Welcome(string name, int numTimes = 1) {
        //    return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
        //}

        // GET: /HelloWorld/Welcome/1?name=Scott
        // GET: /HelloWorld/Welcome/Scott/3
        public string Welcome(string name, int ID = 1) {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }
    }
}