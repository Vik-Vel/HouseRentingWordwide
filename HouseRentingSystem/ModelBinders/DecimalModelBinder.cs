﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Globalization;

namespace HouseRentingSystem.ModelBinders
{
	public class DecimalModelBinder : IModelBinder
	{
		public Task BindModelAsync(ModelBindingContext bindingContext)
		{
			ValueProviderResult valueResult = bindingContext.ValueProvider
				.GetValue(bindingContext.ModelName);

			if (valueResult != ValueProviderResult.None && !string.IsNullOrEmpty(valueResult.FirstValue))
			{
				decimal result = 0m;
				bool success = false;

				try
				{
					string strValue = valueResult.FirstValue.Trim();
					strValue = strValue.Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator); //Replace all dots with the correct separator
					strValue = strValue.Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator); //Replace all commas with the correct separator

					result = Convert.ToDecimal(strValue, CultureInfo.CurrentCulture);//To make sure the same separator is used

					success = true;

				}
				catch (FormatException fe)
				{
					bindingContext.ModelState.AddModelError(bindingContext.ModelName, fe, bindingContext.ModelMetadata);
				}

				if (success)
				{
					bindingContext.Result = ModelBindingResult.Success(result);
				}
			}
			return Task.CompletedTask;
		}
	}
}
