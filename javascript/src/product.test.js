const { add  } = require("./product");

describe("add()", () => {
    it("returns the sum for a list of numbers", () => {
        const numbers = [1, 2, 3, 4];

        const result = add(numbers);

        expect(result).toBe(10);
    });

    it("throws when called with something other than an array", () => {
        const notSupported = { some: 'weird object' };

        expect(() => add(notSupported)).toThrowError();
    });
});
