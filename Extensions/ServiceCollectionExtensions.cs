using LetsChat.CrudServices;
using LetsChat.Entities;

namespace LetsChat.ServiceCollectionExtensions
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddCategoryCrudServices(this IServiceCollection services)
		{
			services.AddTransient<ChatRoomCrud>()
				.AddTransient<User>();

			return services;
		}
	}
}