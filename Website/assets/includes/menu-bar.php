

<div class = "menuBar" id = "myMenuBar">

    <!-- h2 elements should increase in size while mouse hovers and also change color
         No longer need to highlight background, and menu bar background can be transparent-->
    <a id = "About" href = "../about/"><h3>About</h3></a>
    <a id = "Donate" href = "../donate/"><h3>Donate</h3></a>
    <a id = "Download" href = "../download/"><h3>Download</h3></a>
    <a id = "Home" href = "../"><h3>Home</h3></a>

    <!--<a class = "icon" onclick = "menuFunction()"><i class = "fa fa-bars"></i></a>-->
</div>

<!-- Cannot call from file as home page index is in different directory to other pages
<script src = "./Assets/Scripts/menu-functions.js"></script>
<link rel = "stylesheet" href = "./Assets/Styles/menu-styles.css">
-->
<style>
/*--------------------------------------------------------------------*/
/* Hides all menu buttons except 'first-child' which is 'Home'*/
/*The nth-child needs to detect which page is active, and that variable needs to be passed in */
  @media screen and (max-width: 565px) {
    .menuBar a:not(:nth-child(<?php echo $activePage ?>)) {
      display: none;
    }
  /* Simultaneously displays the bars icon */
    .menuBar a.icon {
      float: right;
      display: block;
    }
  }
</style>
