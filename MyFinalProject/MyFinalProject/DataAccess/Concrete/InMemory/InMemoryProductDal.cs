using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            // Veritabanından veri gelmesini simüle etmek için fake ürünler oluşturduk
            _products = new List<Product> 
            { 
                new Product{ProductId=1, CategoryId=1, ProductName = "Bardak", UnitPrice = 15, UnitsInStock =15 },
                new Product{ProductId=2, CategoryId=1, ProductName = "Kamera", UnitPrice = 500, UnitsInStock =3 },
                new Product{ProductId=3, CategoryId=2, ProductName = "Telefon", UnitPrice = 1500, UnitsInStock =2 },
                new Product{ProductId=4, CategoryId=2, ProductName = "Klavye", UnitPrice = 150, UnitsInStock =65 },
                new Product{ProductId=5, CategoryId=2, ProductName = "Fare", UnitPrice = 85, UnitsInStock =1 },
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            // LINQ - Language Integrated Query
            // Lambda

            // Aşağıdaki kodu LINQ özelliği kullanarak yazdık
            // LINQ bizi uzun uzun arama yapmaktan kurtarıyor aradığımız değeri bulmak için döngü ile tek tek tüm elemanları dönmektense
            // LINQ teknolojisi sayesinde SQL sorgusu gibi sorgular yapabiliriz ve tüm elemanları tek tek dönmemize gerek kalmaz
            // LINQ teknolojisinin SingleOrDefault özelliğini kullandık fakat arayışımıza göre farklı özellikleri de kullanabiliriz
            // parantez içinde yazdığımız ifade C# dilinin lambda özelliği
            // p yani döngülerde kullandığımız geçici değişken
            // => eşit ve küçükse operatörü
            // p.ProductId döngü dönerken o an ki p değişkeninin barındırdığı elemanın product id'si
            // == eşit mi öperatörü
            // product.ProductId karşılaştırmak istediğimiz product'ın product id'si
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            // Product sınıfından productToDelete adında bir nesne oluşturduk
            // bu nesne silinmesi istenen değeri LINQ yardımıyla bulduktan sonra üzerinde tutuyor

            // üstte LINQ sayesinde bulduğumuz ve productToDelete nesnesinde tuttuğumuz silmek istediğimiz değeri
            // _product listesinden remove özelliği sayesinde siliyoruz
            _products.Remove(productToDelete);

            // LINQ bizi uzun uzun kod yazmaktan kurtarıyor ve 5 6 satırda yazacağımız karmaşık kodu tek satırda yazmamıza olanak sağlıyor
            
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            // LINQ sayesinde gönderdiğim ürünün id'si ile listede içinde aynı ürün id'sine sahip olan ürünü bul anlamına gelen tek satırlık bir sorgu yazabildik
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

        }
    }
}
