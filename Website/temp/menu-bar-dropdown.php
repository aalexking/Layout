<!DOCTYPE html>
<html>
	<title> HTML Homepage</title>

	<head>

		<meta name = "viewport" content = "width = device-width, initial-scale = 1">
		<link rel = "stylesheet" href = "https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">

		<style>

			body {margin: 0; font-family: Arial}

			.topnav {
				overflow: hidden;
				background-color: #333; /* Dark grey */
			}

			.topnav a {
				float: left;
				display: block;
				color: #f2f2f2; /* Light grey */
				text-align: center;
				padding: 14px 16px;
				text-decoration: none;
				font-size: 17px;
				cursor: pointer;
			}

			.active {
				background-color: #4CAF50; /* green */
				color: white;
			}

			.topnav .icon {
				display: none;
			}

			.dropdown {
				float: left;
				overflow: hidden;
			}

			.dropdown .dropbtn {
				font-size: 17px;
				border: none;
				outline: none;
				color: white;
				padding: 14px 16px;
				background-color: inherit;
				font-family: inherit;
				margin: 0;
				cursor: pointer;
			}

			.dropdown-content {
				display: none;
				position: absolute;
				background-color: #f9f9f9; /* white */
				min-width: 160px;
				box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);
				z-index: 1;
			}

			.dropdown-content a {
				float: none;
				color: black;
				padding: 12px 16px;
				text-decoration: none;
				display: block;
				text-align: left;
			}

			.topnav a:hover, .dropdown:hover .dropbtn {
				background-color: #555; /* Dark grey */
				color: white;
			}

			.dropdown-content a:hover {
				background-color: #ddd; /* Light grey */
				color: black;
			}

			.dropdown:hover .dropdown-content {
				display: block;
			}

			@media screen and (max-width: 600px) {
				.topnav a:not(:first-child), .dropdown .dropbtn {
					display: none;
				}

 				.topnav a.icon {
					float: right;
					display: block;
				}

			}

			@media screen and (max-width: 600px) {
				.topnav.responsive {position: relative;}
				.topnav.responsive .icon {
					position: absolute;
					right: 0;
					top: 0;
				}
				.topnav.responsive a {
					float: none;
					display: none;
					text-align: left;
				}
				.topnav.responsive .dropdown {float: none;}
				.topnav.responsive .dropdown-content {position: relative;}
				.topnav.responsive .dropdown .dropbtn {
					display: block;
					width: 100%;
					text-align: left;
				}
			}
`			`
	 }

		</style>

	</head>

	<body>

		<div class = "topnav" id = "myTopnav">

			<div class = "dropdown">
				<button class = "dropbtn">Home <i class = "fa fa-caret-down"></i></button>
				<div class = "dropdown-content">
					<a href = "">Home1</a>
					<a href = "">Home2</a>
					<a href = "">Home3</a>
				</div>
			</div>

			<div class = "dropdown">
				<button class = "dropbtn">Dropdown <i class = "fa fa-caret-down"></i></button>
				<div class = "dropdown-content">
					<a href = "http://localhost/">Link1</a>
					<a href = "">Link2</a>
					<a href = "">Link3</a>
				</div>
			</div>
			<a href = "">About</a>
			<a href = "javascript:void(0);" style = "font-size: 15px" class = "icon" onclick = "myFunction()"><i class = "fa fa-bars"></i></a>
		</div>

		<div style = "padding-left: 16px">
			<h2>Random Info</h2>
		</div>

		<script>
		function myFunction() {
			var x = document.getElementById("myTopnav");
			if (x.classname === "topnav") {
				x.classname += " responsive";
			} else {
				x.className = "topnav";
			}
		}
		</script>

	</body>
</html>
