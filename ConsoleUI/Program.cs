using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete;
using System;

namespace ConsoleUI
{
    //SOLİD 
    //OPEN CLOSE PRINCIPLE: yeni bir özellik ekliyorsan kodlarında değişiklik yapmıyorsun
    class Program
    {
        static void Main(string[] args)
        {
            //Data Transformation Object DTO
            ProductTest();
            //IoC CONTAINER anlatılacak
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.Name);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));
            var result = productManager.GetProductDetails();
            if (result.Success)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }
    }
}
