using LetsChat.Data;
using LetsChat.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LetsChat.CrudServices
{
	public class ChatRoomCrud : ControllerBase
	{
		private readonly ApplicationContext _applicationContext;

		public ChatRoomCrud(ApplicationContext applicationContext) 
		{
			_applicationContext = applicationContext;	
		}

		public ChatRoom[] GetAllChatRooms()
		{
			var rooms = _applicationContext.Rooms.ToArray();
			
			return rooms;
		}

		public ChatRoom GetChatRoom(int chatRoomId) 
		{
			var room = _applicationContext.Rooms.FirstOrDefault(r => r.ChatRoomId == chatRoomId);

			return room;
		}

		public ChatRoom DeleteChatRoom(int chatRoomId) 
		{
			var room = _applicationContext.Rooms.Where(r => r.ChatRoomId == chatRoomId).Include(u => u.User).First();
			_applicationContext.Rooms.Remove(room);
			_applicationContext.SaveChanges();

			return room;
		}

		public ChatRoom CreateNewChatRoom(ChatRoom newChatRoom)
		{
			_applicationContext.Rooms.Add(newChatRoom);
			_applicationContext.SaveChanges();

			return newChatRoom;
		}
	}
}