/// ---------------------------------------------------------------------------------
///
/// Copyright (c) 2018 Sebastian Hönel [sebastian.honel@lnu.se]
///
/// https://github.com/MrShoenel/Util-dotnet
///
/// This file is part of the project Extensions. All files in this project,
/// if not noted otherwise, are licensed under the MIT-license.
///
/// ---------------------------------------------------------------------------------
///
/// Permission is hereby granted, free of charge, to any person obtaining a
/// copy of this software and associated documentation files (the "Software"),
/// to deal in the Software without restriction, including without limitation
/// the rights to use, copy, modify, merge, publish, distribute, sublicense,
/// and/or sell copies of the Software, and to permit persons to whom the
/// Software is furnished to do so, subject to the following conditions:
///
/// The above copyright notice and this permission notice shall be included in all
/// copies or substantial portions of the Software.
///
/// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
/// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
/// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
/// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
/// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
/// CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
///
/// ---------------------------------------------------------------------------------
///
using System;
using System.Linq;

namespace Extensions
{
	/// <summary>
	/// A class containing extensions for <see cref="System.String"/>.
	/// </summary>
	public static class XString
	{
		/// <summary>
		/// Simple method that prefixes any uppercase letter with an underscore (except
		/// for the first letter).
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		public static string ToSimpleUnderscoreCase(this string str)
		{
			return string.Concat(str.Select((x, i) => i > 0 && Char.IsUpper(x) ? $"_{x}" : $"{x}"));
		}

		/// <summary>
		/// Returns true if this <see cref="String"/> is empty or only consists of whitespace.
		/// </summary>
		/// <param name="string"></param>
		/// <returns></returns>
		public static Boolean IsEmptyOrWhiteSpace(this string @string)
		{
			return @string.Length == 0 || @string.Trim().Length == 0;
		}

		/// <summary>
		/// Returns true if this <see cref="String"/> is either null or matches the criteria of
		/// the method <see cref="IsEmptyOrWhiteSpace(string)"/>.
		/// </summary>
		/// <param name="string"></param>
		/// <returns></returns>
		public static Boolean IsNullOrEmptyOrWhiteSpace(this string @string)
		{
			return @string == null || @string.IsEmptyOrWhiteSpace();
		}
	}
}
