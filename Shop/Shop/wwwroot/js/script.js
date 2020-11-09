document.getElementById('widget-button').onclick = function () {
    document.getElementById('widget-frame').style = 'display: block';
    document.getElementById('close-button').style = 'display: block';
    //var closeButton = document.createElement('a');
    //closeButton.id = 'close-button';
    //var closeButtonText = document.createElement('i');
    //closeButtonText.id = 'close-button-text';
    //closeButtonText.textContent = 'X';
    //closeButton.appendChild(closeButtonText);
    //document.body.appendChild(closeButton);

    document.getElementById('widget-button').style = 'display: none';
}

document.getElementById('close-button').onclick = function () {
    document.getElementById('widget-frame').style = 'display: none';
    document.getElementById('close-button').style = 'display: none';
    document.getElementById('widget-button').style = 'display: block';
}