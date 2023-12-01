using LetsChat.CrudServices;
using LetsChat.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LetsChat.Controllers
{
	[Route("/api/Rooms/")]
	[ApiController]
	public class ChatRoomController : ControllerBase
	{
		private readonly ChatRoomCrud _chatRoomCrud;

		public ChatRoomController(ChatRoomCrud chatRoomCrud)
		{
			_chatRoomCrud = chatRoomCrud;
		}

		[HttpGet]
		[Route("AllRooms")]
		public ChatRoom[] ChatRooms()
		{ 
			return _chatRoomCrud.GetAllChatRooms();
		}

		[HttpGet]
		[Route("RoomById/{id}")]
		public ChatRoom ChatRoom(int id) 
		{
			return _chatRoomCrud.GetChatRoom(id);
		}

		[HttpDelete]
		[Route("DeleteRoom")]
		public ChatRoom DeleteChatRoom(int chatRoomId)
		{
			return _chatRoomCrud.DeleteChatRoom(chatRoomId);
		}

		[HttpPut]
		[Route("NewRoom")]
		public ChatRoom NewChatRoom(ChatRoom newChatRoom)
		{
			return _chatRoomCrud.CreateNewChatRoom(newChatRoom);
		}
	}
}