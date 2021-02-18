const url = 'api/Windows';

function GetWindow() {
    fetch(url)

}

function AddWindow() {
    const addWidth = document.getElementById('add-Width');
    const addLength = document.getElementById('add-Length');

    const window = {
        Width: addWidth.value,
        Length: addLength.value
    };

    fetch(url, {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(window)

    })
        .then(response => response.json);

}