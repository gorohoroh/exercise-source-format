import contextlib
import unittest
from io import StringIO

from thermometer_initial import thermometer


# After instruction 1:
# def thermometer(temp):
#     if temp >= 30:
#         print("Too hot")
#
#
# thermometer(25)


class ThermometerTest(unittest.TestCase):
    def test_thermometer_calls_31_degrees_hot(self):
        for temp in range(30, 32):
            with contextlib.redirect_stdout(StringIO()) as temp_stdout:
                thermometer(temp)
            output = temp_stdout.getvalue().strip()
            with self.subTest("Are you sure you report exactly 30 degrees Celsius as too hot? What about temperatures that are over 30 degrees?"):
                self.assertEqual(output, "Too hot")
# TODO why are we running 3 tests here if the range only includes 2 numbers?


if __name__ == "__main__":
    unittest.main()
