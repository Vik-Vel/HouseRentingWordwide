using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRentingSystem.Infrastructure.Constants
{
	public static class DataConstants
	{
		//Category 
		public const int CategoryNameMaxLenght = 50;
		//public const int CategoryNameMinLenght = 50;

		//House
		public const int HouseTitleMinLenght = 10;
		public const int HouseTitleMaxLenght = 50;

		public const int HouseAddressMinLenght = 30;
		public const int HouseAddressMaxLenght = 150;

		public const int HouseDescriptionMinLenght = 50;
		public const int HouseDescriptionMaxLenght = 500;

		public const string HousePricePerMonthMinRange = "0";
		public const string HousePricePerMonthMaxRange = "2000";

		//Agent
		public const int AgentPhoneNumberMinLenght = 7;
		public const int AgentPhoneNumberMaxLenght = 15;
	}
}
