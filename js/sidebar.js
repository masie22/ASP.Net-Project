jQuery(document).ready(function ($) {
    $('#toggler').click(function (event) {
        event.preventDefault();
        $('#wrap').toggleClass('toggled');
    });
})

