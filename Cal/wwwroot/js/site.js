const uri = 'api/Windows';
var fields = [];
var cout = 1;
function GetWindow() {

    fetch(uri)
        .then(response => response.json())
        .then(data => _displayItems(data))
  
}
function disp() {
    
    event.currentTarget.parentElement
        .querySelectorAll('input:not([type="submit"]),select').forEach(function (e) {
            fields.push({ value: e.value, id: e.id, checked: e.checked });
        })
}
function Past() {
    cout++;
    var CloneWindow = document.getElementById('FORMA').cloneNode(true);
    document.querySelector("form").appendChild(CloneWindow);
    
}
function _displayItems(data) {
    var addResalt = document.getElementById('add-Resalt');
    var addResalt_Install = document.getElementById('add-Resalt_Install');
    addResalt.value = data.resalt;
    addResalt_Install.value = data.resalt_Install;

}

function AddWindow() {
    disp();
    let Windows = [];
    let j = 0;
    for (let i = 0; i < cout; i++) {

        for (; j < fields.length; ) {
      
            switch (fields[j].id) {

                case 'add-Width':
                    var addWidth = fields[j].value;
                    break;
                case 'add-Lenght':
                    var addLength = fields[j].value;
                    break;
                case 'add_Tempered_Glass':
                    var addTempered_Glass = fields[j].checked;
                    break;
                case 'add_Tempered_Clarified':
                    var addTempered_Clarified = fields[j].checked;
                    break;
                case 'add_Picture':
                    var addPicture = fields[j].value;
                    break;
                case 'add_Sockets':
                    var addSockets = fields[j].value;
                    break;
                case 'add_Railing':
                    var addRailing = fields[j].value;
                    break;
                case 'add_Fasteners':
                    var addFasteners = fields[j].value;
                    break;
                case 'add_Booking':
                    var addBooking = fields[j].value;
                    break;
            }
          
            if (j == 8) {
                var window = {
                    Width: addWidth,
                    Lenght: addLength,
                    Tempered_Glass: addTempered_Glass,
                    Tempered_Clarified: addTempered_Clarified,
                    Picture: addPicture,
                    Sockets: addSockets,
                    Railing: addRailing,
                    Fasteners: addFasteners,
                    Booking: addBooking
                };
       
                Windows.push(window)

            }
            j++;

        }
     
       
       
        //var addWidth = document.getElementById('add-Width');
        //var addLength = document.getElementById('add-Lenght');
        //var addTempered_Glass = document.getElementById('add_Tempered_Glass');
        //var addTempered_Clarified = document.getElementById('add_Tempered_Clarified');
        //var addPicture = document.getElementById('add_Picture');
        //var addSockets = document.getElementById('add_Sockets');
        //var addRailing = document.getElementById('add_Railing');
        //var addFasteners = document.getElementById('add_Fasteners');
        //var addBooking = document.getElementById('add_Booking');

        //const window = {
        //    Width: addWidth.value,
        //    Lenght: addLength.value,
        //    Tempered_Glass: addTempered_Glass.checked,
        //    Tempered_Clarified: addTempered_Clarified.checked,
        //    Picture: addPicture.value,
        //    Sockets: addSockets.value,
        //    Railing: addRailing.value,
        //    Fasteners: addFasteners.value,
        //    Booking: addBooking.checked
        //};
        //Windows.push(window);
    }

    //const window = {
    //    Width: addWidth.value,
    //    Lenght: addLength.value,
    //    Tempered_Glass: addTempered_Glass.checked,
    //    Tempered_Clarified: addTempered_Clarified.checked,
    //    Picture: addPicture.value,
    //    Sockets: addSockets.value,
    //    Railing: addRailing.value,
    //    Fasteners: addFasteners.value,
    //    Booking: addBooking.checked
    //};
    //Windows.push(window);
  

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
           
            addLength.value = '';
            addWidth.value = '';
            addSockets.value = '';
            addRailing.value = '';
            addFasteners.value = '';
        })
        

}