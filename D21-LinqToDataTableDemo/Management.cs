using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LinqToDataTableDemo
{
    class Management
    {
        public readonly DataTable dataTable = new DataTable();
        public void TopRecords(List<ProductReview> listProductReview)
        {
            var recordedData = (from ProductReviews in listProductReview
                               orderby ProductReviews.Rating descending
                               select ProductReviews).Take(3);
            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProductID);
            }
        }
        public void SelectedRecords(List<ProductReview> listProductReview)
        {
            var recordData = from productReviews in listProductReview
                             where (productReviews.ProductID == 1 || productReviews.ProductID == 4 || productReviews.ProductID == 9)
                             && productReviews.Rating > 3
                             select productReviews;
            foreach(var list in recordData)
            {
                Console.WriteLine(list.ProductID);
            }
        }
        public void RetrieveCountOfRecords(List<ProductReview> listProductReview)
        {
            var recordData = listProductReview.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });
            foreach(var list in recordData)
            {
                Console.WriteLine(list.ProductID + "-----------"+ list.Count);
            }
        }
    }
}
