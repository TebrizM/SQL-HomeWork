function playSound(e) {
    const audio = document.querySelector(`audio[data-key="${e.keyCode}"]`);
    const key = document.querySelector(`.key[data-key="${e.keyCode}"]`);

    if (!audio) {
        return;
        //stop the function
    }
    audio.currentTime = 0; //rewind sound
    audio.play();
    key.classList.add('playing');
};

function hide(e) {
    if (e.propertyName !== 'transform') {
        return;
    }
    this.classList.remove('playing')
}

const keys = document.querySelectorAll('.key');
keys.forEach(key => key.addEventListener('transitionend', hide))
window.addEventListener('keydown', playSound);