﻿using LetsChat.Data;
using Microsoft.EntityFrameworkCore;

namespace LetsChatAppConstext.Extensions
{
	public static class WebApplicationBuilderExtensions
	{
		public static WebApplicationBuilder AddApplicationContext(this WebApplicationBuilder builder)
		{
			var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
			builder.Services.AddDbContext<ApplicationContext>(options =>
				options.UseNpgsql(connectionString));

			return builder;
		}
	}
}