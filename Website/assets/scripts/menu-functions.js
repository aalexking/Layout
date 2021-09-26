
// IMPORTANT: onload function don't see mto work as they are called before include function is processed

// Function executed after bars icon is clicked
/*
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
*/
// Function called when page is loaded
/*
window.onload = function HighlightActivePage() {

  console.log("test");
  var pageID = "";

  switch(document.title) {
    case "Download":
      pageID = "nv_1121";
      break;

    case "Donate":
      pageID = "nv_1122";
      break;

    case "About":
      pageID = "nv_1123";
      break;

    default:
      break;
  }

  // Uses the current page title to set the active menu button
  document.getElementById(pageID).classList.add("active");

}
*/

