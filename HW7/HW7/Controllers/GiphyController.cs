using HW7.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace HW7.Controllers
{
    public class GiphyController : Controller
    {
        LogContext db = new LogContext();

        // GET: Giphy
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult Search()
        {
            List<SearchResult> list = new List<SearchResult>();

            string giphyString = "http://api.giphy.com/v1/gifs/search?api_key=" 
                + System.Web.Configuration.WebConfigurationManager.AppSettings["apikey"]
                + "&q=" + Request.QueryString["search"];

            WebRequest request = WebRequest.Create(giphyString);
            Stream stream = request.GetResponse().GetResponseStream();

            RootObject gifs = new System.Web.Script.Serialization.JavaScriptSerializer()
                                  .Deserialize<RootObject>(new StreamReader(stream)
                                  .ReadToEnd());

            stream.Close();

            for (int i =0; i < 25; i++)
            {
                SearchResult searchResult = new SearchResult();
                searchResult.image = gifs.data[i].images.downsized_small.mp4;
                list.Add(searchResult);
            }
            // log user data
            var log = db.logs.Create();
            log.IPAddress = Request.UserHostAddress;
            log.SearchTerm = Request.QueryString["search"];
            log.AgentString = Request.UserAgent;
            db.logs.Add(log);
            db.SaveChanges();

            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}