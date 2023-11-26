Add();

async function Add() {
    let sendRequest = await sendGetRequest("https://localhost:7211/api/rooms");
    console.log(sendRequest);
    let allChatRooms = sendRequest.chatRooms;
    console.log(allChatRooms);

    for(let i = 0; i < allChatRooms.length; i++)
    {
        let room = allChatRooms[i];
        createChatRoom(room);
    }
}

function createChatRoom(chatRoom)
{
    let roomElement = document.createElement("a");
    let roomName = "Lobby: " + chatRoom.roomName;
    roomElement.className = "room";
    roomElement.id = "roomId";
    roomElement.append(roomName);
    document.getElementById("roomsHolder").append(roomElement);
    return roomElement;
} 

function sendGetRequest(uri) {
    console.log("213");
    const myHeaders = new Headers()
    myHeaders.append('Content-Type', 'application/json')
    const request = new Request(uri, {
        method: 'GET',
        headers: myHeaders
    });

    console.log(request);
    let search_result = fetch(request)
        .then((response) => {
            return response.json();
        })
 
    return search_result;
}