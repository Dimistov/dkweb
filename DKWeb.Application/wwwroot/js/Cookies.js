// Cookie functions

function setCookie(name, value) {
    document.cookie = `${name}` + "=" + `${value}` + "; expires=Sun, 6 January 2030 12:00:00 UTC;";
}