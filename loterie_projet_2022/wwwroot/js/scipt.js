player_number = []

function getNumberID(id) {
    var element = document.getElementById(id);
    element.classList.add("mystyle");
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

document.getElementById('formInput').addEventListener('submit', (e) => {

    e.preventDefault();



});
        