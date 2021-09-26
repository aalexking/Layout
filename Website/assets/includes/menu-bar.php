
<header onload="UpdateNavbar()">
    <nav id="nv_1" class="navbar-container">
        <ul id="nv_10" class="navbar">
            <li id="nv_11" class="menubar">
                <div id="" class="selection-bar-container">
                    <ul id="nv_110" class="selection-bar">
                        <li id="nv_111" class="selection-section first">
                            <div id="" class="selection-bar-home">
                                <a id="" class="selection-bar-home-link" href = "/">
                                    <ul id="nv_1110" class="selection-bar-logo">
                                        <li id="1111" class="">
                                            <img id="icon_1" class="selection-bar-icon" src="/assets/images/logo.png">
                                        </li>
                                        <li id="1112" class=""`>
                                            <h2 id="" class="selection-bar-text">Layout</h2>
                                        </li>
                                    </ul>
                                </a>
                            </div>
                        </li>
                        <li id="nv_112" class="selection-section">
                            <div id="" class="">
                                <ul id="nv_1120" class="selection-bar-buttons">
                                    <li id="nv_1121" class="selection-bar-button">
                                        <a id="nv_1121-download" class="selection-bar-button-link" href = "/download/">
                                            <h3 id="" class="selection-bar-button-text">Download</h3>
                                        </a>
                                    </li>
                                    <li id="nv_1122" class="selection-bar-button">
                                        <a id="nv_1122-donate" class="selection-bar-button-link" href = "/donate/">
                                            <h3 id="" class="selection-bar-button-text">Donate</h3>
                                        </a>
                                        <div id="" class="selection-bar-button-side-border"></div>
                                    </li>
                                    <li id="nv_1123" class="selection-bar-button">
                                        <a id="nv_1123-about" class="selection-bar-button-link" href = "/about/">
                                            <h3 id="" class="selection-bar-button-text">About</h3>
                                        </a>
                                    </li>
                                </ul>
                            </div>
                        </li>
                        <li id="nv_113" class="selection-section last">
                            <div id="" class="selection-section-bars-container">
                                <!--<a id="" class="selection-section-bars" onclick="" href="javascript:void(0);"><i id="testing" class="fa fa-bars"></i></a>-->
                                <a id="" class="selection-section-bars" onlick="" href="javascript:void(0);">
                                    <img id="" class="selection-section-bars-image" src="/assets/images/home.png">
                                </a>
                            </div>
                        </li>
                    </ul>
                </div>    
            </li>
            <li id="nv_12" class="menubar">
                <div id="" class="">
                    <ul id="nv_120" class="page-display-bar">
                        <li id="nv_121" class="page-display-button">
                            <a id="nv_121-parentname" class="page-display-link" href = "">
                                Parent Name
                            </a>
                        </li>
                        <li id="nv_122" class="page-display-button">
                            >
                            <a id="nv_122-layout" class="page-display-link" href = "/">
                                Layout
                            </a>
                        </li>
                        <li id="nv_123" class="page-display-button">
                            >
                            <a id="nv_123-page" class="page-display-link" href = "/">
                                Home
                            </a>
                        </li>
                    </ul>
                </div>
            </li>
        </ul>
    </nav>
</header>

<!-- modify so that it can add new li element to list (example " Layout > Downloads > Thank You") based in current directory -->
<script>
    // window.location.pathname
    
    (function UpdateNavbar() {

        console.log(window.location.pathname);

        var path = window.location.pathname.split("/");

        console.log(path);

        path.splice(0, 1);

        

        for (let i = 0; i < path.legnth; i++) {

            path[i][0] = path[i][0].toUpperCase();
            console.log(path[i][0]);

        }

        console.log(path);

        var pageID = "";
        var pageLocation = ";"

        document.getElementById("nv_123-page").innerHTML = document.title;

        switch(document.title) {

            case "Home":
                document.getElementById("nv_123-page").href = "/";
                return;

            case "Download":
                pageLocation = "/download/";
                pageID = "nv_1121";
                break;

            case "Donate":
                pageLocation = "/donate/";
                pageID = "nv_1122";
                break;

            case "About":
                pageLocation = "/about/";
                pageID = "nv_1123";
                break;

            default:
                return;
        }

        // Uses the current page title to set the active menu button
        document.getElementById(pageID).classList.add("active");
        document.getElementById("nv_123-page").href = pageLocation;

    })();
    
</script>
