
// Function executed after bars icon is clicked
function menuFunction() {

  var menuElement = document.getElementById("myMenuBar");

  if (menuElement.className === "menuBar") {
    menuElement.classList.add("responsive");

  } else {
    menuElement.classList.remove("responsive");
  }
}


document.addEventListener('DOMContentLoaded', function() {

  window.addEventListener('scroll', scrollFunction);

  var navbar = document.getElementById("myMenuBar");

  if (navbar.offsetTop == null) { return; }

  var sticky = navbar.offsetTop;

  function scrollFunction() {

    if (window.pageYOffset >= sticky) {
      navbar.classList.add("sticky")

    } else {
      navbar.classList.remove("sticky");

    }
  }
})

// Function called when page is loaded
window.onload = function HighlightActivePage() {

  // Uses the current page title to set the active menu button
  document.getElementById(document.title).classList.add("active");

}
