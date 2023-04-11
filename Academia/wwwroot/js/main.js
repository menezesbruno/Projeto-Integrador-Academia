(function ($) {
    "use strict";

    // Marcar o menu ativo
    document.addEventListener('DOMContentLoaded', () => {
        document.querySelectorAll('.nav-link').forEach(link => {
            if (link.getAttribute('href').toLowerCase() === location.pathname.toLowerCase()) {
                link.classList.add('active');
            } else {
                link.classList.remove('active');
            }
        });
    });

    // Dropdown ao passar o mouse
    $(document).ready(function () {
        function toggleNavbarMethod() {
            if ($(window).width() > 992) {
                $('.navbar .dropdown').on('mouseover', function () {
                    $('.dropdown-toggle', this).trigger('click');
                }).on('mouseout', function () {
                    $('.dropdown-toggle', this).trigger('click').blur();
                });
            } else {
                $('.navbar .dropdown').off('mouseover').off('mouseout');
            }
        }
        toggleNavbarMethod();
        $(window).resize(toggleNavbarMethod);
    });

    // Voltar ao topo
    $(window).scroll(function () {
        if ($(this).scrollTop() > 100) {
            $('.back-to-top').fadeIn('slow');
        } else {
            $('.back-to-top').fadeOut('slow');
        }
    });
    $('.back-to-top').click(function () {
        $('html, body').animate({ scrollTop: 0 }, 1500, 'easeInOutExpo');
        return false;
    });
})(jQuery);
