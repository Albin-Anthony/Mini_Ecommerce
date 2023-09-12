using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Framework
{
    public class StroredProc
    {
        public class Payment
        {
			public const string InsertPayment = "[dbo].[InsertPayment]";
			public const string SelectPament = "[dbo].[SelectPament]";
			
		}

        public class Register
        {
			public const string SaveRegister = "[dbo].[SaveRegisterDetails]";

        }

        public class Login
        {
            public const string GetLogin = "[dbo].[CheckEmailAndPassword]";

        }

        public class Product
        {
			public const string SaveProductDetails = "[dbo].[SaveProductDetails]";
			public const string SelectProduct = "[Product].[SelectProduct]";
			public const string SelectById = "[Product].[SelectById]";
			public const string updateProduct = "[Product].[updateProduct]";
			public const string deleteProduct = "[Product].[deleteProduct]";


		}
	}
}
