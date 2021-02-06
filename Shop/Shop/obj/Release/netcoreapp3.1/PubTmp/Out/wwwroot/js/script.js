document.getElementById('widget-button').onclick = function () {
    document.getElementById('widget-frame').style = 'display: block';
    document.getElementById('close-button').style = 'display: block';
    document.getElementById('widget-button').style = 'display: none';
}

document.getElementById('close-button').onclick = function () {
    document.getElementById('widget-frame').style = 'display: none';
    document.getElementById('close-button').style = 'display: none';
    document.getElementById('widget-button').style = 'display: block';
}