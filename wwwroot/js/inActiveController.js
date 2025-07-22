var InactivityController = function () {

    //var _inactivityControllerNotifyModal = app.inactiveModal;

    var lastActivityTimeStorageKey;
    var timeOutSecond;

    function bindActions() {
        window.onmousemove = setUserActivity; // catches mouse movements
        window.onmousedown = setUserActivity; // catches mouse movements
        window.onclick = setUserActivity;     // catches mouse clicks
        window.onscroll = setUserActivity;    // catches scrolling
        window.onkeypress = setUserActivity;  //catches keyboard actions
    }

    var isUserActive = true;
    function setUserActivity() {
        isUserActive = true;
    }

    function control() {
        writeToStorage();
        controlStorage();
    }

    function writeToStorage() {
        if (isUserActive) {
            if (localStorage) {
                localStorage.setItem(lastActivityTimeStorageKey, Date.now());
            } else {
               app.setCookieValue(lastActivityTimeStorageKey, Date.now());
            }
        }

        isUserActive = false;
    }

    var notifierIsOpened = false;
    function controlStorage() {
        var lastActivityTime = 0;
        if (localStorage) {
            lastActivityTime = localStorage.getItem(lastActivityTimeStorageKey);
        } else {
            lastActivityTime =app.getCookieValue(lastActivityTimeStorageKey);
        }

        if (Date.now() - lastActivityTime <= timeOutSecond * 1000) {
            if (notifierIsOpened) {
                inactiveModalstop();
                inactiveModalclose();
                notifierIsOpened = false;
            }

            return;
        }

        if (!notifierIsOpened) {
            if ($('#SessionIdTimeOut').length > 0) {
                inactiveModalinit();
                inactiveModalopen();
                notifierIsOpened = true;
            }
        }
    }

    return {
        init: function (options) {
            lastActivityTimeStorageKey = options.lastActivityTimeStorageKey ? options.lastActivityTimeStorageKey : "UserLastActivity";
            timeOutSecond = options.InActivityControlSecond;
            bindActions();
            writeToStorage();
            setInterval(control, 1000);
        }
    };
}();

$(document).ready(function () {
    setTimeout(function () {
        if ($('#userTimeWarning').length > 0) {
            InactivityController.init({
                lastActivityTimeStorageKey: "UserLastActivity",
                InActivityControlSecond: parseInt($('#userTimeWarning').val())  // show inactivity modal when the TimeOutSecond passed
            });
        }
        else {
            InactivityController.init({
                lastActivityTimeStorageKey: "UserLastActivity",
                InActivityControlSecond: parseInt(600)  // show inactivity modal when the TimeOutSecond passed
            });
        }
    },1000);
    
});