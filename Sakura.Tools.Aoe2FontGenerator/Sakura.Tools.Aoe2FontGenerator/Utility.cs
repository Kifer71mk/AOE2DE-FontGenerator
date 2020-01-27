﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using JetBrains.Annotations;

namespace Sakura.Tools.Aoe2FontGenerator
{
	/// <summary>
	/// Provide helper methods. This class is static.
	/// </summary>
	public static class Utility
	{
		/// <summary>
		/// Convert the <see cref="CultureInfo"/> instance to its corresponding <see cref="XmlLanguage"/>.
		/// </summary>
		/// <param name="cultureInfo">The <see cref="CultureInfo"/> to be converted.</param>
		/// <returns>The <see cref="XmlLanguage"/> related with the <paramref name="cultureInfo"/>.</returns>
		/// <exception cref="ArgumentNullException"><paramref name="cultureInfo"/> is null.</exception>
		public static XmlLanguage ToXmlLanguage([NotNull]this CultureInfo cultureInfo)
		{
			if (cultureInfo is null)
			{
				throw new ArgumentNullException(nameof(cultureInfo));
			}

			return XmlLanguage.GetLanguage(cultureInfo.IetfLanguageTag);
		}
	}
}