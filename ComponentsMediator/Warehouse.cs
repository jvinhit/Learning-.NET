﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentsMediator
{
	public class Warehouse
	{
		public Warehouse()
		{
			Mediator.Instance.ProductChanged += (s, e) => { SaveChangesInRepository(e.Product); };
		}

		private void SaveChangesInRepository(Product product)
		{
			Console.WriteLine("About to save the changes for product {0}", product.Name);
		}
	}
}
