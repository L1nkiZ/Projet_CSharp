var player_number = []

function getNumberID(id) {
    var element = document.getElementById(id);

    if (this.player_number.length < 6 && this.player_number.includes(id) === false) {

        this.player_number.push(id)

        String_player_number = player_number.toString();
        
        element.classList.add("checked");

        console.log(this.player_number);
        console.log(String_player_number);
        return this.String_player_number;
    }

    else {
        console.log("c'est non")
    }
}

function reset() {
    const classes = document.querySelectorAll('.checked')

    classes.forEach(c => {
        c.classList.remove('checked');
    });
    this.player_number = []
}

document.getElementById('formInput').addEventListener('submit', (e) => {

    e.preventDefault();

    if (player_number.length == 6) {

        String_player_number = player_number.toString();
        
        document.getElementById("player_number").value = String_player_number;
        console.log(document.getElementById("player_number").value)
    }

        
    document.getElementById('formInput').submit();

});


function copieText() {
    // Get the text field
    var copyText = document.getElementById("inputCodeGUID");

    // Select the text field
    copyText.select();

    // Copy the text inside the text field
    navigator.clipboard.writeText(copyText.value);
}

function transformDate(dateString) {

    const dateObject = new Date(Date.parse(dateString));
    const date = dateObject.toLocaleDateString('fr-FR');

    return date;
}