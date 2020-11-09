using System;
using System.Collections.Generic;

namespace LinqToDataTableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Table demo");
            Console.WriteLine("==========================");
            //LinqToDataTable linqToDataTableObj = new LinqToDataTable();
            //linqToDataTableObj.AddDataTableDemo();

            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ProductID=1,UserID=1,Rating=2,Review="Good",IsLike=true},
                new ProductReview(){ProductID=2,UserID=1,Rating=4,Review="Good",IsLike=true},
                new ProductReview(){ProductID=3,UserID=1,Rating=5,Review="Good",IsLike=true},
                new ProductReview(){ProductID=4,UserID=1,Rating=6,Review="Good",IsLike=false},
                new ProductReview(){ProductID=5,UserID=1,Rating=2,Review="nice",IsLike=true},
                new ProductReview(){ProductID=6,UserID=1,Rating=1,Review="bas",IsLike=true},
                new ProductReview(){ProductID=8,UserID=1,Rating=1,Review="Good",IsLike=false},
                new ProductReview(){ProductID=8,UserID=1,Rating=9,Review="nice",IsLike=true},
                new ProductReview(){ProductID=2,UserID=1,Rating=10,Review="nice",IsLike=true},
                new ProductReview(){ProductID=10,UserID=1,Rating=8,Review="nice",IsLike=true},
                new ProductReview(){ProductID=11,UserID=1,Rating=3,Review="nice",IsLike=true}
            };

            foreach(var list in productReviewList)
            {
                Console.WriteLine($"{list.ProductID},{list.UserID},{list.Rating},{list.Review},{list.IsLike}");
            }

            Management management = new Management();
            management.TopRecords(productReviewList);

            management.SelectedRecords(productReviewList);
            management.RetrieveCountOfRecords(productReviewList);
        }
    }
}
