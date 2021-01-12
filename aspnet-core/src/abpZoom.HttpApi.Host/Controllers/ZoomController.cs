using abpZoom.zoom;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace abpZoom.Controllers
{
    public class ZoomController : Controller
    {
               [HttpPost]
        public JsonResult CreateMeeting(ZoomObj zoomObj)
        {
            
            var client = new RestClient($"https://api.zoom.us/v2/users/{zoomObj.User_id}/meetings");
            var request = new RestRequest(Method.POST);
           
            request.AddHeader("authorization", $"Bearer {zoomObj.Token}");
            request.AddHeader("content-type", "application/json;charset=UTF-8");
            request.AddParameter("application/json","{}", ParameterType.RequestBody);
            IRestResponse response =  client.Execute(request);
            return Json(new { response.Content });
        }
            // GET: ZoomController
            public ActionResult Index()
        {
            return Json("d");
        }

        // GET: ZoomController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ZoomController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ZoomController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ZoomController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ZoomController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ZoomController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ZoomController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
