using System;
using System.Collections.Generic;

namespace LinqueProductReview
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //UC1 Adding Default Values

            List<ProductReview> list = new List<ProductReview>()
            {
                new ProductReview(){ productId=1 ,userId=1,review="good",rating=15,isLike=true },
                new ProductReview(){ productId=2 ,userId=2,review="good",rating=18,isLike=true },
                new ProductReview(){ productId=3 ,userId=3,review="not good",rating=07,isLike=false },
                new ProductReview(){ productId=1 ,userId=2,review="good",rating=15,isLike=true },
                new ProductReview(){ productId=2 ,userId=1,review="not good",rating=10,isLike=false },
                new ProductReview(){ productId=4 ,userId=1,review="good",rating=19,isLike=true },
                new ProductReview(){ productId=3 ,userId=4,review="good",rating=13,isLike=true },
            };
           
        }
        /// <summary>
        /// Displays the all produc list Review
        /// </summary>
        /// <param name="list">The list.</param>
        public static void DisplayProduct(List<ProductReview> list)
        {
            foreach (ProductReview e in list)
            {
                Console.WriteLine("ProductId: " + e.productId + " userId: " + e.userId + " review: " + e.review + " rating: " + e.rating + " isLike: " + e.isLike);
            }
        }

        /// <summary>
        /// Retrives the top 3 records from list order by rating.
        /// </summary>
        /// <param name="list">The list.</param>
        public static void  RetriveTopRecords(List<ProductReview> list)
        {
            var res = from product in list orderby product.rating descending select product;
            var top = res.Take(3);
            DisplayProduct(list);
        }
    }
}
