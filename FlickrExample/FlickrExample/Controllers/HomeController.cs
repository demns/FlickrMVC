using System.Web.Mvc;
using FlickrNet;

namespace FlickrExample.Controllers {
    public class HomeController : Controller {
        // GET: Home
        public ActionResult Index() {
            var flickr = new Flickr("c2b9248adf2b3a90214a1c20fe1fdef6", "c1c66b0a7f1ca84d");
            flickr.PhotosGetRecent(127156566, 10);

            var options = new PhotoSearchOptions {
                UserId = "127156566@N02",
                PerPage = 200,
                Page = 1
            };

            PhotoCollection firstSet = flickr.PhotosSearch(options);
            //options.Page = 2;
            //PhotoCollection secondSet = flickr.PhotosSearch(options);
            //options.Page = 3;
            //PhotoCollection thirdSet = flickr.PhotosSearch(options);

            return View(firstSet);
        }
    }
}