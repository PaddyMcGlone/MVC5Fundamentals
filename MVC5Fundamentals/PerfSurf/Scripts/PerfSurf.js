(function() {

    var perfHub = $.connection.PerfHub;
    $.connection.logging = true;
    $.connection.hub.start();

    // Method which will get invoked when client says - NewMessage
    perfHub.client.newMessage = function(message) {
        model.addMessage(message);
    };


    // KO model which will be bound to the UI
    var model = function() {
        var self = this; // preserving the self object - good js coding

        self.message = ko.observable(""), //Message user sends to server
        self.messages = ko.observableArray() //Messages arriving from the server
    };

    // behaviour
    model.prototype = {
        sendMessage : function() {
            var self = this;

            perfHub.server.send(self.message());
            self.message("");
        },

        addMessage : function() {
            var self = this;

            self.messages.push(message);
        }
    };

    var model = new Model();

    //When the dom is ready
    $(function() {
        ko.applyBindings(model);
    });

}());