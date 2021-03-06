﻿using System;

namespace lab5.Candies
{
	public class Candy
	{
		public string Name { get; }
		public double SugarWeight { get; }
		public double Weight { get; }         
		public Candy(string name, double sugarWeight, double weight)
		{

			if (sugarWeight > weight)
			{
				throw new InvalidOperationException();
			}             
			Name = name;
			SugarWeight = sugarWeight;
			Weight = weight;
		}
	}
}