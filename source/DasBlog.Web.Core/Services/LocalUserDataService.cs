﻿using System.Collections.Generic;
using System.IO;
using DasBlog.Core.Security;
//using Microsoft.AspNetCore.Server.Kestrel.Transport.Libuv.Internal.Networking;
using Microsoft.Extensions.Options;
//using SQLitePCL;

// rather annoyingly this takes a dependency on the Asp.Net Sdk

namespace DasBlog.Core.Services
{
	public class LocalUserDataService : Interfaces.ILocalUserDataService
	{
		private LocalUserDataOptions options;
		public LocalUserDataService(IOptions<LocalUserDataOptions> optionsAccessor)
		{
			options = optionsAccessor.Value;
		}
		public IEnumerable<User> LoadUsers()
		{
			return new List<User>
			{
				new User
				{
					Name = "mike",
					Role = Role.Admin,
					Ask = true,
					EmailAddress = "mike@com.com",
					Active = true,
					DisplayName = "Mike May The Adminsitrator",
					NotifyOnAllComment = true,
					NotifyOnNewPost = true,
					NotifyOnOwnComment = true,
					OpenIDUrl = "mike.com",
					Password = "19-A2-85-41-44-B6-3A-8F-76-17-A6-F2-25-01-9B-12",
					XmlPassword = ""
				}
				,new User
				{
					Name = "bob",
					Role = Role.Contributor,
					Ask = true,
					EmailAddress = "bob@com.com",
					Active = true,
					DisplayName = "Bob The Contributor",
					NotifyOnAllComment = true,
					NotifyOnNewPost = true,
					NotifyOnOwnComment = true,
					OpenIDUrl = "mike.com",
					Password = "19-A2-85-41-44-B6-3A-8F-76-17-A6-F2-25-01-9B-12",
					XmlPassword = ""
				}
			};
		}
	}

	public class LocalUserDataOptions
	{
		public string Path{ get; set; }
	}
}
