window.addEventListener("message", function (event) {
    if (event.origin === "https://centinelapistag.cardinalcommerce.com") {
        console.log(event.data);  // Log the event data to the console
        
        // Parse the event data as JSON
        var data_json = JSON.parse(event.data);

        // Check if the Status property is true
        if (data_json.Status === true) {
            // Pass the parsed data to Blazor
            window.dotNetHelper.invokeMethodAsync('OnMessageReceived', data_json);
        }
    }
}, false);