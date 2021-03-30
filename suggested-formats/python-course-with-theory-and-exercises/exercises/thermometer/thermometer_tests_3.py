import contextlib
import unittest
from io import StringIO

from thermometer_initial import thermometer


# After instruction 3:
# def thermometer(temp):
#     if temp >= 30:
#         print("Too hot")
#     elif 10 <= temp < 30:
#         print("It's comfortable out there")
#     elif 0 <= temp < 10:
#         print("Fairly cold")
#
#
# thermometer(25)


class ThermometerTest3(unittest.TestCase):
    def test_thermometer_calls_31_degrees_hot(self):
        for temp in [0, 5, 9]:
            with contextlib.redirect_stdout(StringIO()) as temp_stdout:
                thermometer(temp)
            output = temp_stdout.getvalue().strip()
            with self.subTest(
                    "0 degrees should be reported as fairly cold, but 10 degrees should not."):
                self.assertEqual(output, "Fairly cold")


if __name__ == "__main__":
    unittest.main()
