let age = new Date(1997, 04, 07);

function birthday(){
    setInterval(() =>{
        let nowDate = new Date();
        let myMillieSecond= nowDate.getTime() - age.getTime();
        let second = myMillieSecond / 1000;
        let minute = second / 60;
        let hour = minute / 60;
        let day = hour/ 24;
        let year = day /365;

        let secondbar = document.querySelector('#second-input');
        secondbar.innerHTML = Math.floor(second%60);
        let minutebar = document.querySelector('#minute-input');
        minutebar.innerHTML = Math.floor(minute%60);
        let clockbar = document.querySelector('#hour-input');
        clockbar.innerHTML = Math.floor(hour%24);
        let daybars = document.querySelector('#day-input');
        daybars.innerHTML = Math.floor(day%365);
        let yearbar = document.querySelector('#year-input');
        yearbar.innerHTML = Math.floor(year);
    }, 1000);
}
