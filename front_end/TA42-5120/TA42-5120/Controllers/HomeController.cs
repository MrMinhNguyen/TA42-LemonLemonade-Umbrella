using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;
using TA42_5120.Models;

namespace TA42_5120.Controllers
{
    public class HomeController : Controller
    {
        uvr hhh = new uvr();

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View();
        }

        public ActionResult Data()
        {
            ViewBag.Title = "UV Data";

            string urlAddress = "https://lemonumbrella.azurewebsites.net/uvr_by_year";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlAddress);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;
                if (response.CharacterSet == null)
                    readStream = new StreamReader(receiveStream);
                else
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                string data = readStream.ReadToEnd();
                response.Close();
                readStream.Close();
                /*remove [ & ]*/
                data = data.TrimStart(new char[] { '[' }).TrimEnd(new char[] { ']' });
                string[] split = data.Split(',');
                List<string> hello = new List<string>();
                for (int i = 0; i < split.Length; i++)
                {
                    //remove{ and }
                    if (i % 2 == 0)
                        split[i] = split[i].TrimStart(new char[] { '{' });
                    else
                        split[i] = split[i].TrimEnd(new char[] { '}' });
                    string a = split[i].Split(':')[0];
                    string b = split[i].Split(':')[1];
                    hello.Add(a);
                    hello.Add(b);
                }
                hhh.year = hello[7];
                hhh.avg_uvr = hello[11];
                ViewBag.uvr = hhh.year;
                ViewBag.uvrmax = hhh.avg_uvr;
                return View();
            }
            return null;
        }




            public ActionResult Educate()
        {
            ViewBag.Title = "Education";
            return View();
        }

        public ActionResult Recommend()
        {
            ViewBag.Title = "Recommendation";
            return View();
        }
    }
}