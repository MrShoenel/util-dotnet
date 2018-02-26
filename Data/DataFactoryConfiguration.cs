/// ---------------------------------------------------------------------------------
///
/// Copyright (c) 2018 Sebastian Hönel [sebastian.honel@lnu.se]
///
/// https://github.com/MrShoenel/Util-dotnet
///
/// This file is part of the project Data. All files in this project,
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
using Extensions;
using Logging.Loggers;
using System;

namespace Data
{
	public class DataFactoryConfiguration
	{
		public String DatabaseConnectionString { protected internal get; set; }

		public DatabaseType DatabaseType { protected internal set; get; }

		public BaseLogger<DataFactory> Logger { protected internal set; get; }

		/// <summary>
		/// Usually used if the selected storage is file-based. Has no effect for
		/// e.g. server-based storage solutions such as MySQL.
		/// </summary>
		public String TempDirectory { protected internal set; get; }

		/// <summary>
		/// Constructs a new configuration for a <see cref="DataFactory"/>.
		/// </summary>
		/// <param name="databaseConnectionString"></param>
		/// <param name="databaseType"></param>
		/// <param name="logger">If null, a <see cref="DevNullLogger{T}"/> will be used.</param>
		/// <param name="tempDiretory"></param>
		public DataFactoryConfiguration(String databaseConnectionString, DatabaseType databaseType, BaseLogger<DataFactory> logger = null, String tempDiretory = null)
		{
			if (XString.IsNullOrEmptyOrWhiteSpace(databaseConnectionString))
			{
				throw new ArgumentException(nameof(databaseConnectionString));
			}

			this.DatabaseConnectionString = databaseConnectionString;
			this.DatabaseType = databaseType;
			this.Logger = logger ?? new DevNullLogger<DataFactory>();
			this.TempDirectory = tempDiretory;
		}
	}
}
