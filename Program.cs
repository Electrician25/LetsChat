using LetsChat.ActionResult;
using LetsChat.ChatHub;
using LetsChat.ServiceCollectionExtensions;
using LetsChatAppConstext.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR();
builder.Services.AddCategoryCrudServices();
builder.Services.AddAuthorization();
builder.Services.AddControllers();
builder.AddApplicationContext();
builder.Services.AddRouting();
builder.Services.AddTransient(provider =>
{
	return new Func<string, HtmlResult>(
		path => ActivatorUtilities.CreateInstance<HtmlResult>(provider, path));
});

var app = builder.Build();

app.MapHub<ChatHub>("/chatHub");

app.UseHttpsRedirection();

app.UseStatusCodePages();

app.UseAuthorization();

app.UseDefaultFiles();

app.MapControllers();

app.UseStaticFiles();

app.UseRouting();

app.Run();