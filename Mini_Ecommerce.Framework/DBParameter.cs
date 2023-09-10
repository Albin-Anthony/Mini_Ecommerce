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
	}
}
