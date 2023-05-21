using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.VoiceIn.CRUD.Models;
using Nop.Plugin.VoiceIn.CRUD.Services;
using System.Linq;
using System.Threading.Tasks;

namespace Nop.Plugin.VoiceIn.CRUD.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        public IActionResult Index()
        {
            var items = _itemService.GetAllItems();

            var model = items.Select(item => new ItemModel
            {
                Id = item.Id,
                Name = item.Name,
                Description = item.Description,
                Price = item.Price,
                Quantity = item.Quantity
            }).ToList();

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ItemModel item)
        {
            if (ModelState.IsValid)
            {
                _itemService.CreateItem(item);

                return RedirectToAction("Index");
            }

            return View(item);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var item = _itemService.GetItemById(id);

            if (item == null)
                return RedirectToAction("Index");

            var model = new ItemModel
            {
                Id = item.Id,
                Name = item.Name,
                Description = item.Description,
                Price = item.Price,
                Quantity = item.Quantity
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(ItemModel model)
        {
            if (ModelState.IsValid)
            {
                var item = _itemService.GetItemById(model.Id);

                if (item == null)
                    return RedirectToAction("Index");

                // Update the item properties
                item.Name = model.Name;
                item.Description = model.Description;
                item.Price = model.Price;
                item.Quantity = model.Quantity;

                _itemService.UpdateItem(item);

                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var item = _itemService.GetItemById(id);

            if (item == null)
                return RedirectToAction("Index");

            var model = new ItemModel
            {
                Id = item.Id,
                Name = item.Name,
                Description = item.Description,
                Price = item.Price,
                Quantity = item.Quantity
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var item = _itemService.GetItemById(id);

            if (item == null)
                return RedirectToAction("Index");

            _itemService.DeleteItem(id);

            return RedirectToAction("Index");
        }
    }
}
