using Nop.Core;
using Nop.Core.Data;
using Nop.Core.Domain.Catalog;
using Nop.Data;
using Nop.Services.Catalog;
using Nop.Services.Plugins;
using System.Collections.Generic;

namespace Nop.Plugin.VoiceIn.CRUD
{
    public class InvoiceCrudPlugin : BasePlugin, IPlugin
    {
        private readonly IRepository<Product> _productRepository;
        private readonly IProductService _productService;

        public InvoiceCrudPlugin(IRepository<Product> productRepository, IProductService productService)
        {
            _productRepository = productRepository;
            _productService = productService;
        }

        public void Install()
        {
            // Perform any installation tasks here
            base.InstallAsync();
        }

        public void Uninstall()
        {
            // Perform any uninstallation tasks here
            base.UninstallAsync();
        }

        // Create an item
        public void CreateItem(Item item)
        {
            // Implement your logic to create an item
            // You can use the provided item details to generate the item
        }

        // Read an item
        public Item ReadItem(int itemId)
        {
            // Implement your logic to read an item by its ID
            // You can fetch the item details from the database using the provided itemId
            return _productService.GetProductById(itemId);
        }

        // Update an item
        public void UpdateItem(Item item)
        {
            // Implement your logic to update an item
            // You can use the provided item object to update the corresponding item in the database
            _productRepository.UpdateAsync(item);
            
        }

        // Delete an item
        public void DeleteItem(int itemId)
        {
            // Implement your logic to delete an item by its ID
            // You can delete the item from the database using the provided itemId
            var item = _productService.GetProductPictureByIdAsync(itemId);
            if (item != null)
            {
                _productRepository.DeleteAsync(item);
                
            }
        }
    }
}
