
//$(document).ready(function () {
//    console.log('Init InActive');
//    Init();
//});
var that = $('#timeoutModal');
var $countDownHolder;
var $countDownInformation;
var $progressBar;

var timeOutSecond = 60; //show inactivity modal when TimeOutSecond passed
var currentSecond = timeOutSecond;
var changeNotifyContentInterval;
function done() {
    inactiveModalstop();
    window.location.replace("auth/login");
}
function changeNotifyContent() {
    currentSecond--;
    if (currentSecond <= 0) {
        $countDownHolder.text("0s");
        $progressBar.css("width", "0%");
        done();
    } else {
        $countDownHolder.text(currentSecond + "s");
        $countDownInformation.text("Your session will expire because you have been inactive for a long time. Provide any mouse/keyboard input on the web page to stop session termination. Redirect for " + currentSecond + " seconds.");
        $progressBar.css("width", parseInt(currentSecond / timeOutSecond * 100) + "%");
    }
}
inactiveModalinit = function () {
    $countDownHolder = $('#timeoutModal').find('#countdown-holder');
    $countDownInformation = $('#timeoutModal').find('#countdown-information');
    $progressBar = $('#timeoutModal').find('.progress-bar');

    $countDownHolder.text(timeOutSecond + "s");
    $progressBar.css("width", "100%");

    changeNotifyContentInterval = setInterval(changeNotifyContent, 1000);
}
inactiveModalstop = function Stop() {
    clearInterval(changeNotifyContentInterval);
    currentSecond = timeOutSecond;
    
}
inactiveModalopen = function () {
    $('#timeoutModal').modal('show');
}
inactiveModalclose = function () {
    var input = { UserID: $('#SessionIdTimeOut').val(), UserName: $('#userNamehidden').val()};
    $.post("https://apitest.honglanservices.co/api/ResetTimeOut", input)
        .done(function (data) {
            if (data.Status == 200) {
                $('#SessionIdTimeOut').val(data.Content.UserID);
            }
        });
    $('#timeoutModal').modal('hide');
}



