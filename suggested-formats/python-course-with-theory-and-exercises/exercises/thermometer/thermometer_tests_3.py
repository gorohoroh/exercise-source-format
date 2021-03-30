import unittest

from thermometer_initial import thermometer


class ThermometerTest3(unittest.TestCase):
    def test_thermometer_calls_fairly_cold(self):
        for temp in [0, 5, 9]:
            with self.subTest(
                    "0 degrees should be reported as fairly cold, but 10 degrees should not."):
                self.assertEqual(thermometer(temp), "Fairly cold")


if __name__ == "__main__":
    unittest.main()
