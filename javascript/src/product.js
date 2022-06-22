function add(numbers) {
    return numbers.reduce((prev, cur) => prev + cur, 0);
}

module.exports.add = add;
