function factorial(n) {
    if (n === 0 || n === 1) {
        return 1;
    }
    return n * factorial(n - 1); // function calling itself with new value
}

console.log(factorial(5));