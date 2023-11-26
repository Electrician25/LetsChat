using LetsChatTogether_Application.Entities;

namespace LetsChatTogetherApp.Extensions
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddCategoryCrudServices(this IServiceCollection services)
		{
			services.AddTransient<ChatRoom>()
					.AddTransient<User>();

			return services;
		}
	}
}