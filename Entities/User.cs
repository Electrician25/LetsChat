namespace LetsChat.Entities
{
	public class User
	{
		public int? UserId { get; set; }
		public string? UserName { get; set; }
		public string? UserPassword { get; set; }
		public int ChatRoomId { get; set; }
		public ChatRoom? ChatRoom { get; set; }
	}
}