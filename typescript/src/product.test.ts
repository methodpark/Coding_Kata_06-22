import { dummy } from "./product";

describe("product module", () => {
    describe("dummy()", () => {
        it("returns 42", () => {
            const result = dummy();

            expect(result).toEqual(42);
        });
    });
});
