"use strict";
// Creating a connection to SignalR Hub
var connection = new signalR.HubConnectionBuilder().withUrl("/order").build();
var connId;
// Starting the connection with server
connection.start().then(function () {

    connection.invoke('GetConnectionId').then(function (connectionId) {
        connId = connectionId
    });

}).catch(function (err) {
    return console.error(err.toString());
});

connection.on("ReceiveMessage", function (order) {
    var displayMsg = order.meal.name + " : " + order.meal.price;
    var imgUrl = order.meal.imgPath;
    var div = document.createElement("div");
    var h4 = document.createElement("h4");
    var img = document.createElement("img");
    var p = document.createElement("p");
    var p2 = document.createElement("p")

    p.innerHTML = order.meal.discription;
    p2.innerHTML = "R"+ order.meal.price;
    img.src = order.meal.imgPath;
    img.style.width = "100%";
    img.style.width = "100%";
    h4.innerHTML = order.meal.name;
    div.appendChild(h4);
    div.appendChild(img);
    div.appendChild(p2);
    div.appendChild(p);
    
    
    document.getElementById("listMessage").appendChild(div);
});