﻿/*
 * Description: secretSafe namespace js file and viewmodels declaration
 */

// Namespace
var secretSafe = {};

// Models

secretSafe.chatMessage = function (sender, content, dateSent) {
    var self = this;
    self.username = sender;
    self.content = content;
    if (dateSent != null) {
        self.timestamp = dateSent;
    }
}

secretSafe.user = function (username, userId, roomname, color) {
    var self = this;
    self.username = username;
    self.id = userId;
    self.roomname = roomname;
    self.color = color;

    console.log(username + " for js");
    console.log(userId + " for js");
    console.log(color + " for js");
    console.log(roomname + " for js");

}

// ViewModels

secretSafe.chatViewModel = function () {
    var self = this;
    self.messages = ko.observableArray();
}

secretSafe.connectedUsersViewModel = function () {
    var self = this;
    self.contacts = ko.observableArray();
    self.customRemove = function (userToRemove) {
        var userIdToRemove = userToRemove.id;
        self.contacts.remove(function (item) {
            return item.id === userIdToRemove;
        });
    }
}

