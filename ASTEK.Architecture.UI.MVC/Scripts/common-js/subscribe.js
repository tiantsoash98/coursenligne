function toogleSubscription(subscribed) {
    $.ajax({
        data: 'accountId='+subscribed,
        url: 'https://localhost:44300/Subscribe/ToogleSubscription',
        success: function (response) {
            applyResult(response);
        }
    });
}

function toogleSubscriptionLink(subscribed) {
    $.ajax({
        data: 'accountId=' + subscribed,
        url: 'https://localhost:44300/Subscribe/ToogleSubscription',
        success: function (response) {
            applyResultLink(response, btnId);
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

function applyResultLink(response) {
    if (response.Success) {
        if (response.IsSubscribed) {
            $('#sub-' + response.SubscribedId).text('Se désabonner');
        }
        else {
            $('#sub-' + response.SubscribedId).text('S\'abonner');
        }
    }
}