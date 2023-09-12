using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Framework
{
	public class DBParameter
	{
		public class payment
		{
			public const string PaymentId = "@PaymentId";
			public const string CardNumber = "@CardNumber";
			public const string NameOnCard = "@NameOnCard";
			public const string ExpiryDate = "@ExpiryDate";
			public const string CVVCode = "@CVVCode";
		}

		public class product
		{
			public const string ProductId = "@ProductId";
			public const string ProductName = "@ProductName";
			public const string ProductDescription = "@ProductDescription";
			public const string ImageURL = "@ImageURL";
			public const string Category = "@Category";
			public const string Price = "@Price";
			public const string Quantity = "@Quantity";
		}
	}
}
