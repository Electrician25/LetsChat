using LetsChat.CrudServices;

namespace LetsChat.ServiceCollectionExtensions
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddCategoryCrudServices(this IServiceCollection services)
		{
			services.AddTransient<ChatRoomCrud>();

			return services;
		}
	}
}