    document.getElementById('fullScreenButton').onclick = function() {
        toggleFullScreen();
    };

    function toggleFullScreen() {
        var elem = document.documentElement; // Tüm belgeyi alır

    if (elem.requestFullscreen) {
            if (!document.fullscreenElement) {
        elem.requestFullscreen();
            } else {
        document.exitFullscreen();
            }
        } else if (elem.mozRequestFullScreen) { /* Firefox */
            if (!document.mozFullScreen) {
        elem.mozRequestFullScreen();
            } else {
        document.mozCancelFullScreen();
            }
        } else if (elem.webkitRequestFullscreen) { /* Chrome, Safari ve Opera */
            if (!document.webkitIsFullScreen) {
        elem.webkitRequestFullscreen();
            } else {
        document.webkitExitFullscreen();
            }
        } else if (elem.msRequestFullscreen) { /* Internet Explorer */
            if (!document.msFullscreenElement) {
        elem.msRequestFullscreen();
            } else {
        document.msExitFullscreen();
            }
        }
    }