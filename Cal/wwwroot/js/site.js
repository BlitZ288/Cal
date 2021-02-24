const uri = 'api/Windows';

function GetWindow() {

    fetch(uri)
        .then(response => response.json())
        .then(data => _displayItems(data))
  

   
}
function _displayItems(data) {
    var addResalt = document.getElementById('add-Resalt');
    var addResalt_Install = document.getElementById('add-Resalt_Install');
    addResalt.value = data.resalt;
    addResalt_Install.value = data.resalt_Install;

}

function AddWindow() {
    const addWidth = document.getElementById('add-Width');
    const addLength = document.getElementById('add-Lenght');
    var addTempered_Glass = document.getElementById('add_Tempered_Glass');
    var addTempered_Clarified = document.getElementById('add_Tempered_Clarified');
    var addPicture = document.getElementById('add_Picture');
    var addSockets = document.getElementById('add_Sockets');
    var addRailing = document.getElementById('add_Railing');
    var addFasteners = document.getElementById('add_Fasteners');


    const window = {
        Width: addWidth.value,
        Lenght: addLength.value,
        Tempered_Glass: addTempered_Glass.checked,
        Tempered_Clarified: addTempered_Clarified.checked,
        Picture: addPicture.value,
        Sockets: addSockets.value,
        Railing: addRailing.value,
        Fasteners: addFasteners.value
    };
    
  

    fetch(uri, {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            "Content-Type": "application/json"
        },
        body: JSON.stringify(window),
    })
        .then(response => response.json())
        .then(data => _displayItems(data))
        .then(() => {
           
            addLength.value = ' ';
            addWidth.value = ' ';
        })
        

}