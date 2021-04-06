import unittest

from thermometer_initial import thermometer


class ThermometerTest1(unittest.TestCase):
    def test_thermometer_calls_31_degrees_hot(self):
        for temp in range(30, 32):
            with self.subTest(
                    "Are you sure you report exactly 30 degrees Celsius as too hot? What about temperatures that are "
                    "over 30 degrees?"):
                self.assertEqual(thermometer(temp), "Too hot")


if __name__ == "__main__":
    unittest.main()
