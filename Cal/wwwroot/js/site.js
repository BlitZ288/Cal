const uri = 'api/Windows';

function GetWindow() {

    fetch(uri)
        .then(response => response.json())
        .then(data => _displayItems(data))
  

   
}
function _displayItems(data) {
    var addSquare = document.getElementById('add-Square');
    addSquare.value = data.resalt;


}

function AddWindow() {
    const addWidth = document.getElementById('add-Width');
    const addLength = document.getElementById('add-Lenght');

    const window = {
        Width: addWidth.value,
        Lenght: addLength.value
    };
  

    fetch(uri, {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            "Content-Type": "application/json"
        },
        body: JSON.stringify(window)
    })
        .then(response => response.json())
        .then(() => {
            GetWindow();
            addLength.value = ' ';
            addWidth.value = ' ';
        })
        

}