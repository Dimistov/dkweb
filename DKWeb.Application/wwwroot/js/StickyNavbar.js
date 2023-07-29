// STICKY NAVBAR

// Onscroll event
window.onscroll = function () { toggleStickinessFunction() };

// Function to execute
function toggleStickinessFunction() {
    // Variables
    var navbar = document.getElementById("appNavBar");

    // Getting the highest point of the navbar
    var navOffset = navbar.offsetTop;

    // Instructing to add the sticky class to the navbar if the window offsetTop is higher than the navbar offset
    if (window.pageYOffset > navOffset) {
        navbar.classList.add("nav-sticky");
        document.body.style.paddingTop = 100 + 'px';
    } else {
        navbar.classList.remove("nav-sticky");
        document.body.style.paddingTop = 0 + 'px';
    }
}
