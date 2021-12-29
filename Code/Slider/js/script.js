const carousel = document.querySelector('.slide');
const carouselimg = document.querySelectorAll('.slide img')
const prevbtn = document.querySelector('#prevbtn')
const nextbtn = document.querySelector('#nextbtn')

let counter = 1;
const size = carouselimg[0].clientWidth;
carousel.style.transform = 'translateX(' + (-size * counter) + 'px)';


nextbtn.addEventListener('click', () => {
    if (counter >= carouselimg.length - 1) {
        return;
    }

    carousel.style.transition = "transform 0.4s linear";
    counter++;

    carousel.style.transform = 'translateX(' + (-size * counter) + 'px)';


})
prevbtn.addEventListener('click', () => {
    if (counter <= 0) {
        return;
    }

    carousel.style.transition = "transform 0.4s linear";
    counter--;

    carousel.style.transform = 'translateX(' + (-size * counter) + 'px)';


})
carousel.addEventListener('transitionend', () => {
    if (carouselimg[counter].id === 'last-clone') {
        carousel.style.transition = "none";
        counter = carouselimg.length - 2;
        carousel.style.transform = 'translateX(' + (-size * counter) + 'px)';


    }
    if (carouselimg[counter].id === 'firstclone') {
        carousel.style.transition = "none";
        counter = carouselimg.length - counter;
        carousel.style.transform = 'translateX(' + (-size * counter) + 'px)';


    }
})