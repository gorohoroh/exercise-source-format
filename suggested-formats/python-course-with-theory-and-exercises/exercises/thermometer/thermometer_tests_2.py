import contextlib
import unittest
from io import StringIO

from thermometer_initial import thermometer


# After instruction 1:
# def thermometer(temp):
#     if temp >= 30:
#         print("Too hot")
#     elif 10 <= temp < 30:
#         print("It's comfortable out there")
#
#
# thermometer(25)


class ThermometerTest2(unittest.TestCase):
    def test_thermometer_calls_comfortable(self):
        for temp in [10, 15, 29]:
            with contextlib.redirect_stdout(StringIO()) as temp_stdout:
                thermometer(temp)
            output = temp_stdout.getvalue().strip()
            with self.subTest("Make sure that exactly 10 degrees is treated as comfortable, but exactly 30 degrees is too hot"):
                self.assertEqual(output, "It's comfortable out there")


if __name__ == "__main__":
    unittest.main()
