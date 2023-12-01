const connection = new signalR.HubConnectionBuilder()
    .withUrl("/chatHub")
    .build();
    console.log(connection);//11111111111
connection.on("Send", function (message) {
    var li = document.createElement("li");
    li.textContent = message;
    console.log(message);//11111111111
    document.getElementById("messagesList").appendChild(li);
});

document.getElementById("groupmsg").addEventListener("click", async (event) => {
    var groupName = document.getElementById("group-name").value;
    var groupMsg = document.getElementById("group-message-text").value;
    console.log(groupName);//11111111111
    console.log(groupMsg);//11111111111
    try {
        await connection.invoke("SendMessageToGroup", groupName, groupMsg);
    }
    catch (e) {
        console.error(e.toString());
    }
    event.preventDefault();
});

document.getElementById("join-group").addEventListener("click", async (event) => {
    var groupName = document.getElementById("group-name").value;
    try {
        await connection.invoke("AddToGroup", groupName);
    }
    catch (e) {
        console.error(e.toString());
    }
    event.preventDefault();
});

document.getElementById("leave-group").addEventListener("click", async (event) => {
    var groupName = document.getElementById("group-name").value;
    try {
        await connection.invoke("RemoveUserFromGroup", groupName);
    }
    catch (e) {
        console.error(e.toString());
    }
    event.preventDefault();
});

(async () => {
    try {
        await connection.start();
    }
    catch (e) {
        console.error(e.toString());
    }
})();