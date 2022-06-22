pub fn fizzbuzz(i: i32) -> String {
    match (i % 3, i % 5) {
        (0, 0) => "FizzBuzz".to_string(),
        (0, _) => "Fizz".to_string(),
        (_, 0) => "Buzz".to_string(),
        (_, _) => i.to_string(),
    }
}

#[cfg(test)]
mod test {
    use super::fizzbuzz;

    #[test]
    fn fizzbuzz_for_multiple_of_15() {
        assert_eq!("FizzBuzz", fizzbuzz(15));
    }

    #[test]
    fn fizzbuzz_for_multiple_of_5() {
        assert_eq!("Buzz", fizzbuzz(5));
    }

    #[test]
    fn fizzbuzz_for_multiple_of_3() {
        assert_eq!("Fizz", fizzbuzz(3));
    }

    #[test]
    fn number_otherwise() {
        assert_eq!("2", fizzbuzz(2));
    }
}
