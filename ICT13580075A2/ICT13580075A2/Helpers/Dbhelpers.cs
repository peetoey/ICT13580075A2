using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using ICT13580075A2.Models;

namespace ICT13580075A2.Helpers
{
    public class Dbhelpers
    {
        SQLiteConnection db;
        public Dbhelpers(string dbPath)
        {
            db = new SQLiteConnection(dbPath);
            db.CreateTable<Product>();
        }

        public int AddProduct(Product product)
        {
            db.Insert(product);
            return product.Id;
        }
        public List<Product> GetProducts()
        {
            return db.Table<Product>().ToList();
        }
        public int UpdateProduct(Product product)
        {
            return db.Update(product);
        }
        public int DeleteProduct(Product product)
        {
            return db.Delete(product);
        }
    }
}
