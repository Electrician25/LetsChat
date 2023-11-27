Add();

async function Add() {
    let sendRequest = await sendGetRequest("https://localhost:7211/api/chatRooms");
    console.log(sendRequest);
    let allChatRooms = sendRequest.chatRooms;

    for(let i = 0; i < allChatRooms.length; i++)
    {
        let room = allChatRooms[i];
        createChatRoom(room);
    }
}

function createChatRoom(chatRoom)
{
    console.log(chatRoom);
    let roomElement = document.createElement("a");
    let roomName = "Lobby: " + chatRoom.roomName;
    roomElement.className = "room";
    roomElement.id = "roomId";
    roomElement.append(roomName);
    document.getElementById("roomsHolder").append(roomElement);
    return roomElement;
} 

function sendGetRequest(uri) {
    const myHeaders = new Headers()
    myHeaders.append('Content-Type', 'application/json')
    const request = new Request(uri, {
        method: 'GET',
        headers: myHeaders
    });

    let search_result = fetch(request)
        .then((response) => {
            return response.json();
        })
 
    return search_result;
}