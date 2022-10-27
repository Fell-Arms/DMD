function toggleMode() {
        $(".navbar").toggleClass("dark-nav-footer");
    $(".navbar").toggleClass("bg-white");
    $(".top-nav-link").toggleClass("text-dark");
    $(".top-nav-link").toggleClass("dark-nav-links");
    $(".navbar").toggleClass("navbar-light");
    $(".Footer").toggleClass("dark-nav-footer");

    $(".toggleMode").toggleClass("dark-mode");
    $(".card").toggleClass("dark-mode-form");
    $(".w3-container").toggleClass("dark-mode-form");
    $(".w3-card").toggleClass("dark-nav-footer");
    $(".form-control").toggleClass("dark-mode-form-control");
    $(".btn-pop-toggle").toggleClass("dark-mode-btn-toggle-pop");
    $(".icon-pop-toggle").toggleClass("dark-mode-icon-toggle-pop");
    }