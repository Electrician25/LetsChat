using Microsoft.AspNetCore.SignalR;

namespace LetsChat.ChatHub
{
	public class ChatHub : Hub
	{
		public async Task AddToGroup(string groupName)
		{
			await Groups.AddToGroupAsync(Context.ConnectionId, groupName);

			await Clients.Group(groupName).SendAsync("Send",$"{Context.ConnectionId} has joined the group {groupName}.");
		}

		public async Task RemoveUserFromGroup(string groupName)
		{
			await Groups.RemoveFromGroupAsync(Context.ConnectionId, groupName);

			await Clients.Group(groupName).SendAsync("Send", $"{Context.ConnectionId} has left the group {groupName}.");
		}

		public async Task SendMessageToGroup(string username, string message)
		{
			await Clients.All.SendAsync("SendMessageToGroup", username, message);
		}
	}
}