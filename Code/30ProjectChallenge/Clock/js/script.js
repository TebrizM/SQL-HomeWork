const secondbar = document.querySelector('.second-bar');
const minutebar = document.querySelector('.min-bar')
const hourbar = document.querySelector('.hour-bar')

function setDate() {
    const now = new Date();


    const seconds = now.getSeconds();
    const secondDegree = ((seconds / 60) * 360) + 90;
    secondbar.style.transform = `rotate(${secondDegree}deg)`;

    const minutes = now.getMinutes();
    const minuteDegree = ((minutes / 60) * 360) + 90;
    minutebar.style.transform = `rotate(${minuteDegree}deg)`;

    const hours = now.getHours();
    const hourDegree = ((hours / 12) * 360) + 90;
    hourbar.style.transform = `rotate(${hourDegree}deg)`;

    

}
setInterval(setDate, 1000)