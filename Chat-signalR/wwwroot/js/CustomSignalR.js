debugger
var connection = new signalR.HubConnectionBuilder()
    .withUrl("/Chat")
    .build();

// to get data when connection will stablished
connection.on("Welcome",
    function (id) {
        debugger
        userId = id;
    });


// to connect that branch which you send the data in method in it
// (recive) is the function which data will coming back from hub into it
connection.on("ReceiveMessage", receive);

debugger

async function Start() {
    try {
        await connection.start();

    } catch (e) {
        setTimeout(Start, 6000);
    }
}

connection.onclose(Start);
Start();



function InsertNewMessage( groupId) {
    debugger
    var text = ''
    $(".newText").each(function (entry, index, array) {
        text +=index.value;
});
    connection.invoke("CreateNewMessage", groupId, text);
}


//function CreateElement(text) {
//    debugger
//    var myLi = $("#messageElement");
//    var newElement = document.createElement("span");
//    newElement.textContent = text;
//    myLi.append(newElement);
//}


function receive(message) {
    debugger
    var myLi = $("#messageElement");
    var newElement = document.createElement("span");
    newElement.textContent = message.text;
    myLi.append(newElement);
}

