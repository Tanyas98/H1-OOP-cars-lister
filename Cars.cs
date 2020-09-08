using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_cars_lister
{
    class Cars
    {
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private string model;

		public string Model
		{
			get { return model; }
			set { model = value; }
		}

		private string brand;

		public string Brand
		{
			get { return brand; }
			set { brand = value; }
		}

		private int year;

		public int Year
		{
			get { return year; }
			set { year = value; }
		}

		private int price;

		public int Price
		{
			get { return price; }
			set { price = value; }
		}

		private string color;

		public string Color
		{
			get { return color; }
			set { color = value; }
		}

		public Cars(int ID, string bilmodel, string mærke, int år, int pris, string farve)
		{
			Id = ID;
			Model = bilmodel;
			Brand = mærke;
			Year = år;
			Price = pris;
			Color = farve;
		}
	}
}
