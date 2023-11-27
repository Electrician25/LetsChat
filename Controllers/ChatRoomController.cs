using LetsChat.CrudServices;
using LetsChat.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LetsChat.Controller
{
	[Route("/api/{controller}")]
	[ApiController]
	public class ChatRoomController : ControllerBase
	{
		private readonly ChatRoomCrud _chatRoomCrud;

		public ChatRoomController(ChatRoomCrud chatRoomCrud)
		{
			_chatRoomCrud = chatRoomCrud;
		}

		[HttpGet]
		[Route("allchats")]
		public ChatRoom[] AllChatRooms()
		{ 
			return _chatRoomCrud.GetAllChatRooms();
		}
	}
}