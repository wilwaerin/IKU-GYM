let slideIndex = 1;
showSlides(slideIndex);

function plusSlides(n) {
    showSlides(slideIndex += n);
}


function currentSlide(n) {
    showSlides(slideIndex = n);
}

function showSlides(n) {
    let i;
    let slides = document.getElementsByClassName("mySlides");
    let dots = document.getElementsByClassName("dot");
    if (n > slides.length) { slideIndex = 1 }
    if (n < 1) { slideIndex = slides.length }
    for (i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }
    for (i = 0; i < dots.length; i++) {
        dots[i].className = dots[i].className.replace(" active", "");
    }
    slides[slideIndex - 1].style.display = "block";
    dots[slideIndex - 1].className += " active";
}



function validate() {
    let fname = document.forms["contactform"]["fname"].value;
    let lname = document.forms["contactform"]["lname"].value;
    let email = document.forms["contactform"]["email"].value;
    let subject = document.forms["contactform"]["subject"].value;
    if (fname == "" || lname == "" || email == "" || subject == "") {
        alert("You must fill all fields");
        return false;
    }
}
