<!DOCTYPE html>

<!-- For use of experimental menu bars -->

<html>
  <head>

    <meta name = "viewport" content = "width=device-width, initial-scale=1">
    <link rel = "stylesheet" href = "https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">

    <link rel = "stylesheet" href = "./temp.css">

    <style>



    </style>
  </head>
  <body>

      <!-- Needs to detect which file has called so it can change "active" class to that webpage -->

      <h2>Testing</h2>

      <div class = "menuBar" id = "myMenuBar">
        <a class = "<?php ?>" href = "http://localhost/">Home <i class = ""></i></a>

        <div class = "subMenu">
          <button class = "subMenuButton">Testing <i class = "fa fa-caret-down"></i></button>
          <div class = "subMenu-content" id = "test">
            <a href = "">Test1</a>
            <a href = "">Test2</a>
          </div>
        </div>

        <a class = "<?php ?>" href = "http://localhost/HTML-page/">HTML <i class = ""></i></a>
        <a class = "<?php ?>" href = "http://localhost/CSS-page/">CSS <i class = ""></i></a>
        <a class = "<?php ?>" href = "http://localhost/JS-page/">JavaScript <i class = ""></i></a>

        <div class = "subMenu">
          <button class = "subMenuButton">Helloo <i class = "fa fa-caret-down"></i></button>
          <div class = "subMenu-content" id = "test">
            <a href = "">Hello1</a>
            <a href = "">Hello2</a>
          </div>
        </div>

        <a href = "javascript:void(0);" class = "icon" onclick = "menuFunction()"><i class = "fa fa-bars"></i></a>
      </div>

    <script src = "menu-functions.js"></script>

    <img src = "../html-example.png">

    </body>
</html>
