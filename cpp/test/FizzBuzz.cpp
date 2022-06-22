#include "gtest/gtest.h"

#include "FizzBuzz.hpp"

#include <string>
#include <tuple>


class FizzBuzzFixture: public ::testing::TestWithParam<std::tuple<int, std::string>> {};

TEST_P(FizzBuzzFixture, CheckIfFizzBuzzBuzzes) {
    int input = std::get<0>(GetParam());
    std::string expectedOutput = std::get<1>(GetParam());
    auto retVal = fizzBuzz(input);
    ASSERT_EQ(expectedOutput, retVal);
}

INSTANTIATE_TEST_SUITE_P(FizzBuzz,
                         FizzBuzzFixture,
                         ::testing::Values(
                             std::make_tuple(0, "Fizz"),
                             std::make_tuple(3, "3")));


TEST(FizzBuzz, test123) {
    std::string retVal = fizzBuzz(0);

    ASSERT_EQ("Fizz", retVal);
}
