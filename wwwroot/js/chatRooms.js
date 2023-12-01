Add();

async function Add() {
    let sendRequest = await sendGetRequest("https://localhost:7211/api/Rooms/AllRooms");
    console.log(sendRequest);

    for(let i = 0; i < sendRequest.length; i++)
    {
        let room = sendRequest[i];
        createChatRoom(room);
    }
}

function createChatRoom(chatRoom)
{
    let roomElement = document.createElement("a");
    roomElement.href = "";
    let trueOrFalsePassword = chekChatRoomsPassword(chatRoom.roomPassword);
    let roomName = "Name Room: " + chatRoom.roomName;
    let pass = "Room Password: " + trueOrFalsePassword;
    roomElement.className = "room";
    roomElement.id = "join-group";
    roomElement.append(roomName);
    roomElement.append(pass);
    document.getElementById("roomsHolder").append(roomElement);
    return roomElement;
} 

function chekChatRoomsPassword(password)
{
    if(password != null)
    {
        return "YES"
    }

    return "NO";
}