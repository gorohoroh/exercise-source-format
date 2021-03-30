import unittest

from thermometer_initial import thermometer


class ThermometerTest4(unittest.TestCase):
    def test_thermometer_calls_freezing_my_ass_off(self):
        for temp in [-1, -10, -100]:
            with self.subTest(
                    "Are you sure that all negative temperatures are reported as ass-freezing?"):
                self.assertEqual(thermometer(temp), "Freezing my ass off!")

    # We could additionally test if input code contains an else statement


if __name__ == "__main__":
    unittest.main()
