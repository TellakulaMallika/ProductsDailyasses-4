using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppProducts;

namespace ConsoleAppProducts
{
    public class ProductDetails
    {
        static SortedList<int,Product> listProducts = new SortedList<int,Product>()
        {
          {1, new Product(){PId=1,PName="Shampoo",PBrand="Brand1",PPrice=100,MfDate=new DateTime(day:10,month:6,year:2022),ExpDate=new DateTime(day:16,month:12,year:2023) } },
          {2,new Product(){ PId = 2,PName="Soap",PBrand="Brand2",PPrice = 50,MfDate = new DateTime(day: 11, month: 8, year: 2022),ExpDate = new DateTime(day: 18, month: 12, year: 2023) } },
          {3,new Product(){PId=3,PName="Detergent",PBrand="Brand3",PPrice=60,MfDate=new DateTime(day:19,month:10,year:2022),ExpDate=new DateTime(day:20,month:11,year:2023) } },
          {4,new Product(){PId=4,PName="Lotion",PBrand="Brand4",PPrice=80,MfDate=new DateTime(day:22,month:12,year:2022),ExpDate=new DateTime(day:28,month:10,year:2023) } },
          {5,new Product(){PId=5,PName="Sunscreen",PBrand="Brand5",PPrice=100,MfDate=new DateTime(day:24,month:10,year:2022),ExpDate=new DateTime(day:30,month:12,year:2023) } },

        };
        public SortedList<int,Product> ALLProducts()
        {
            return listProducts;
        }
        public Product SearchProduct(int id)
        {
            if (listProducts.ContainsKey(id))
                return listProducts[id];
            else
                return null;
        }
    }
}



    
    