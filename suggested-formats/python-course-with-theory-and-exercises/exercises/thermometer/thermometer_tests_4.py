import contextlib
import unittest
from io import StringIO

from thermometer_initial import thermometer


class ThermometerTest4(unittest.TestCase):
    def test_thermometer_calls_freezing_my_ass_off(self):
        for temp in [-1, -10, -100]:
            with contextlib.redirect_stdout(StringIO()) as temp_stdout:
                thermometer(temp)
            output = temp_stdout.getvalue().strip()
            with self.subTest(
                    "Are you sure that all negative temperatures are reported as ass-freezing?"):
                self.assertEqual(output, "Freezing my ass off!")

    # We could additionally test if input code contains an else statement


if __name__ == "__main__":
    unittest.main()
