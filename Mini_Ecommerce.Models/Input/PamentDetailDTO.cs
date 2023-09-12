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
		public string Name { get; set; }
		public string Brand { get; set; }
		public string Model { get; set; }
		public string ImageURL { get; set; }
		public string Category { get; set; }
		public string Price { get; set; }


	}
}
