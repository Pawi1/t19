import nwd
import unittest


class Test(unittest.TestCase):
    def test_nwd(self):
        self.assertEqual(nwd.nwd(10, -15), 5)
        self.assertEqual(nwd.nwd(10, 10), 10)
        self.assertEqual(nwd.nwd(0, 5), 5)
        self.assertNotEqual(nwd.nwd(10, 5), 10)
