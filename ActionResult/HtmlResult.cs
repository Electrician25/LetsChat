using Microsoft.AspNetCore.Mvc;

namespace LetsChat.ActionResult
{
	public sealed class HtmlResult : ContentResult
	{
		public HtmlResult() { }
	
		public HtmlResult(string path)
		{
			Content = File.ReadAllText(path);
			ContentType = "text/html; charset=utf-8";
		}
	}
}