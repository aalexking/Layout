
// Function is called when home page loaded
window.onload = function() {

    // ----------------------------------------------------------

    // set height to height of foreground box plus padding height

    document.getElementById('bg-image').style.height = "1400px";
    //document.getElementById('bg-image').style.height = (document.getElementById('main-section').style.height * 1.4) + "px";

    // ----------------------------------------------------------


    //console.log(document.getElementsByClassName('bg-image')[0].style.height);
}

window.onscroll = function() {
    
    // Sets the top distance of the footer to the current transform height of the background image
    document.getElementById('footer').style.top = document.getElementById('bg-image').style.transform.split(', ')[1];

    //console.log(document.getElementsByClassName('bg-image')[0].style.height);
}

