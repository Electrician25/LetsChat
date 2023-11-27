using LetsChat.Data;
using LetsChat.Entities;
using Microsoft.AspNetCore.Mvc;

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
	}
}