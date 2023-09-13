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
			public const string Name = "@Name";
			public const string Brand = "@Brand";
			public const string Model = "@Model";
			public const string ImageURL = "@ImageURL";
			public const string Category = "@Category";
			public const string Price = "@Price";
		}

        public class UserDetails
        {
            public const string UserId = "@UserId";
            public const string UserName = "@UserName";
            public const string Email = "@Email";
            public const string FirstName = "@FirstName";
            public const string LastName = "@LastName";
            public const string DOB = "@DOB";
            public const string ImageURL = "@ImageURL";
            public const string Address = "@Address";
        }
        public class CartDetails
        {
            public const string CartId = "@CartId";
            public const string UserId = "@UserId";
            public const string CreationDate = "@CreationDate";

        }
    }
}
