function toogleSubscription(subscribed) {
    $.ajax({
        data: 'accountId='+subscribed,
        url: 'Subscribe/ToogleSubscription',
        success: function (response) {
            applyResult(response);
        }
    });
}

function applyResult(response) {
    var result = JSON.parse(response);

    if (result.Success == 'true') {
        if (result.IsSubscribed == 'true') {
            $('#subscribeBtn').text('Se désabonner');
        }
        else {
            $('#subscribeBtn').text('S\'abonner');
        }
    }
}