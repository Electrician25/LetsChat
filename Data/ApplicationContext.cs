using LetsChat.Entities;
using Microsoft.EntityFrameworkCore;

namespace LetsChat.Data
{
	public class ApplicationContext : DbContext
	{
		public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) 
		{
			Database.EnsureCreated();
		}

		public virtual DbSet<ChatRoom> Rooms => Set<ChatRoom>();

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>()
				.HasOne(c => c.ChatRoom)
				.WithMany(u => u.User)
				.OnDelete(DeleteBehavior.Cascade);

			modelBuilder.Entity<ChatRoom>().HasData(
				new ChatRoom[]
				{
					new()
					{
						ChatRoomId = 1,
						RoomName = "YesPass",
						RoomPassword = "1"
					},
					new()
					{
						ChatRoomId = 2,
						RoomName = "NoPass",
						RoomPassword = null
					}
				});

			modelBuilder.Entity<User>().HasData(
				new User[]
				{
					new()
					{
						UserId = 1,
						ChatRoomId = 1,
						UserName = "Alex1",
						UserPassword = "1"
					},
					new()
					{
						UserId = 2,
						ChatRoomId = 1,
						UserName = "Alex2",
						UserPassword = "2"
					},
					new()
					{
						UserId = 3,
						ChatRoomId = 1,
						UserName = "Alex3",
						UserPassword = "3"
					},
					new()
					{
						UserId = 4,
						ChatRoomId = 1,
						UserName = "Alex4",
						UserPassword = "4"
					}
				});
		}
	}
}