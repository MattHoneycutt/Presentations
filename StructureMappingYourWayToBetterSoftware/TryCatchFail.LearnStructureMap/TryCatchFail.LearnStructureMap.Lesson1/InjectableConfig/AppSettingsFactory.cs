using System;
using System.Configuration;
using System.Linq;
using System.Reflection;

namespace TryCatchFail.LearnStructureMap.Lesson1.InjectableConfig
{
	public class AppSettingsFactory
	{
		private static object ConvertArray(string rawValue, PropertyInfo prop)
		{
			var elementType = prop.PropertyType.GetElementType();
			var convertedValues =
				rawValue.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
					.Select(v => ConvertPrimitiveType(elementType, v))
					.ToArray();

			var targetArray = Array.CreateInstance(elementType, convertedValues.Length);

			for (var i = 0; i < convertedValues.Length; i++)
			{
				targetArray.SetValue(convertedValues[i], i);
			}

			return targetArray;
		}

		private static object ConvertPrimitiveType(Type targetType, string rawValue)
		{
			return Convert.ChangeType(rawValue, targetType);
		}
		
		public object GetSettingsFor(Type settingsType)
		{
			var settings = Activator.CreateInstance(settingsType);

			foreach (var prop in settingsType.GetProperties(BindingFlags.Instance | BindingFlags.Public)
				.Where(p => p.CanRead && p.CanWrite))
			{
				var settingName = settingsType.Name + "." + prop.Name;

				var rawValue = ConfigurationManager.AppSettings[settingName];

				if (rawValue == null)
				{
					throw new ApplicationException("Setting not found in app.config file: " + settingName);
				}

				object targetValue;

				//NOTE: This only works for primitive, non-nullable types and arrays.
  				if (prop.PropertyType.IsArray)
  				{
  					targetValue = ConvertArray(rawValue, prop);
  				}
  				else
  				{
					targetValue = ConvertPrimitiveType(prop.PropertyType, rawValue);	
  				}
				

				prop.SetValue(settings, targetValue, null);
			}


			return settings;
		}
	}
}