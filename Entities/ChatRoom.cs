namespace LetsChat.Entities
{
	public class ChatRoom
	{
		public int ChatRoomId { get; set; }
		public string? RoomName { get; set; }
		public string? RoomPassword { get; set; }

		public ICollection<User>? User { get; set; }
	}
}