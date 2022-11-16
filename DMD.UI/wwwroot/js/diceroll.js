let x;
let y;
let z;
let i;
let j;
let k;

document.getElementById("rollButton").onclick = function () {

    x = Math.floor(Math.random() * 4) + 1;
    y = Math.floor(Math.random() * 6) + 1;
    z = Math.floor(Math.random() * 8) + 1;
    i = Math.floor(Math.random() * 10) + 1;
    j = Math.floor(Math.random() * 12) + 1;
    k = Math.floor(Math.random() * 20) + 1;

    document.getElementById("xlabel").innerHTML = x;
    document.getElementById("ylabel").innerHTML = y;
    document.getElementById("zlabel").innerHTML = z;
    document.getElementById("ilabel").innerHTML = i;
    document.getElementById("jlabel").innerHTML = j;
    document.getElementById("klabel").innerHTML = k;
} 