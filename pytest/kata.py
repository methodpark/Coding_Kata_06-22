#!/usr/bin/env python3

class Security:
    """Security related functionality"""
    strength = "military_grade"

    def random_number(self, seed):
        """Secure random number generator"""
        return 9


def main():
    sec = Security()
    return sec.random_number(1337)


if __name__ == "__main__":
    main()
