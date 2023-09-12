using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Models.Input
{
	public class PamentDetailDTO
	{
		public int PaymentId { get; set; }
		public int CardNumber { get; set; }
		public string NameOnCard { get; set; }
		public DateTime ExpiryDate { get; set; }
		public int CVVCode { get; set; }

	}

	public class ProductDetailDTO
	{
		public int ProductId { get; set; }
		public string ProductName { get; set; }
		public string ProductDescription { get; set; }
		public string ImageURL { get; set; }
		public string Category { get; set; }
		public int Price { get; set; }
		public int Quantity { get; set; }
	}
}
