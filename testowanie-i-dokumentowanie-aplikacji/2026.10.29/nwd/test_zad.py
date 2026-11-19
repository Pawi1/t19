import unittest
from math import gcd

import zad


class TestNwd(unittest.TestCase):
    def test_basic(self):
        self.assertEqual(zad.nwd(12, 18), 6)
        self.assertEqual(zad.nwd(7, 7), 7)
        self.assertEqual(zad.nwd(13, 8), 1)
        self.assertEqual(zad.nwd(3, 12), 3)
        self.assertEqual(zad.nwd(12, 3), 3)

    def test_matches_gcd(self):
        for a in range(1, 40):
            for b in range(1, 40):
                with self.subTest(a=a, b=b):
                    self.assertEqual(zad.nwd(a, b), gcd(a, b))
