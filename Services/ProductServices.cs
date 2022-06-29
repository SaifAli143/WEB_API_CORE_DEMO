using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_API_CORE_DEMO.Model;
using WEB_API_CORE_DEMO.Repositories;

namespace WEB_API_CORE_DEMO.Services
{
    public class ProductServices: IProductServices
    {
        private readonly IProductRepositories _iProductRepo;
        // Injecition of Dependancy using constructor
        public ProductServices(IProductRepositories iProductRepo)
        {
            _iProductRepo = iProductRepo;
        }
        public int AddProduct(Product prod)
        {
            return _iProductRepo.AddProduct(prod);
        }
        public int DeleteProduct(int id)
        {
            return _iProductRepo.DeleteProduct(id);
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _iProductRepo.GetAllProducts();
        }
        public int ModifyProduct(Product prod)
        {
            return _iProductRepo.ModifyProduct(prod);
        }

    }
}
