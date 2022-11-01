//make a function that rolls one die | 1d6
function d(y) {
    //generate a random number between 1 and y
    return Math.floor(Math.random() * y) + 1;
}
//make a function that rolls multiple dice | 2d6
function XdY(x, y) {
    let results = [];
    //call d(y) x times and put in results
    do {
        results.push(d(y));
    }
    while (results.length < x)
    //return results
    return results;
}
const poolTest = { 6: 2, 8: 2, 10: 7, 20: 1 };
// make a function that rolls a pool of dice | 2d6 + 5d10
function dicePool(obj) {
    // make the results object
    let results = {};
    // call XdY for each entry in the obj
    for (let [y, x] of Object.entries(obj)) {
        results[y] = XdY(x, y);
    };
    // return results
    return results;
}