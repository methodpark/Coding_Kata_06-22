import kata
import pytest


@pytest.fixture
def security():
    return kata.Security()


def test_encryption_strength(security):
    assert security.strength == "military_grade"


@pytest.mark.parametrize("seed", [1, 2, 4711, 1337])
def test_random_number_generator(security, seed):
    assert security.random_number(seed) == 9
