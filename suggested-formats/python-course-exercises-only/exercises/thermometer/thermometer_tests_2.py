import unittest

from thermometer_initial import thermometer


class ThermometerTest2(unittest.TestCase):
    def test_thermometer_calls_comfortable(self):
        for temp in [10, 15, 29]:
            with self.subTest(
                    "Make sure that exactly 10 degrees is treated as comfortable, but exactly 30 degrees is too hot"):
                self.assertEqual(thermometer(temp), "It's comfortable out there")


if __name__ == "__main__":
    unittest.main()
