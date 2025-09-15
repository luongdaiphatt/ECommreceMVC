using ECommerceMVC.data;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace ECommerceMVC.ViewComponents
{
    public class MenuLoaiViewComponent : ViewComponent
    {
        private readonly MongoDbService _db;

        public MenuLoaiViewComponent(MongoDbService db)
        {
            _db = db;
        }

        public IViewComponentResult Invoke()
        {
            var data = _db.Loais.Find(_ => true).ToList();
            return View(data);
        }
    }
}
