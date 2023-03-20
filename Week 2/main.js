function redundant(str) {
    return function() {
        return str;
    }
}

const f1 = redundant("apple");
console.log(typeof(f1));
console.log(f1());

const f2 = redundant("pear");
console.log(typeof(f2));
console.log(f2());

const f3 = redundant("");
console.log(typeof(f3));
console.log(f3());