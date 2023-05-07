using System;
using System.Linq;

namespace FactoryPattern
{
	public static class VehicleFactory
	{

        public static IVehicle GetVehicle(string tireNumber)
		{
			switch (tireNumber)
			{
				case "2":
				    return new Motorcycle();
				case "3":
					return new Motorcycle();
				case "6":
					return new SemiTruck();
				case "8":
					return new SemiTruck();
				default:
					return new Car();
			}

		}
	}
}

