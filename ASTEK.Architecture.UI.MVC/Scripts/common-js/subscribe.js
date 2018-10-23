function toogleSubscription(subscribed) {
    $.ajax({
        data: 'accountId='+subscribed,
        url: 'https://localhost:44300/Subscribe/ToogleSubscription',
        success: function (response) {
            applyResult(response);
        }
    });
}

function applyResult(response) {
    if (response.Success) {
        if (response.IsSubscribed) {
            $('#subscribeBtn').text('Se désabonner');
        }
        else {
            $('#subscribeBtn').text('S\'abonner');
        }
    }
}