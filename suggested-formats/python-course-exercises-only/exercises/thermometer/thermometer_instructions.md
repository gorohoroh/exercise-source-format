# Thermometer

Let's practice what you've learnt earlier when we discussed `if`, `else` and `elif` (collectively called _conditional statements_), as well as writing your own functions.

Let's write a function that, given the current temperature (in degrees Celsius), will say how it feels about this temperature.

The initial code in the code editor contains the following:

1. The definition of the `thermometer()` function that only contains a line that says `pass`. `pass` is a way to tell Python that although the function exists, it doesn't do anything useful right now.
2. A `print()` statement that outputs the result of executing the `thermometer()` function with a value of `25` (meaning "25 degrees Celsius") as an argument.

Here's what you'll need to do:

## Instructions

### 1
Let's make our `thermometer()` function do something. Instead of `pass`, add an `if` condition that returns "Too hot" if temperature is 30 degrees or higher.

:::tests
thermometer_tests_1.py
:::

:::hint

This is what your code is expected to look like after following this instruction:

```python
def thermometer(temp):
    if temp >= 30:
        return "Too hot"


thermometer(25)
```
:::


### 2
Great! Your function can now let us know if it's too hot out there.

Now, let's make it say something different about temperatures that feel OK. If temperature is less than 30 degrees but equal or more than 10 degrees, make the function return "It's comfortable out there".

Make sure that the condition we've introduced in the previous step stays intact. Remember the `elif` keyword? It will help you out here.

:::tests
thermometer_tests_2.py
:::

:::hint
This is what your code is expected to look like after following this instruction:

```python
def thermometer(temp):
    if temp >= 30:
        return "Too hot"
    elif 10 <= temp < 30:
        return "It's comfortable out there"


thermometer(25)
```
:::

### 3
You're doing just fine, and your function can now report comfortable conditions!

When temperature falls to single digits, it starts to get chilly, doesn't it? If temperature is less than 10 degrees but equal or more than 0, make the function return "Fairly cold".

:::tests
thermometer_tests_3.py
:::

:::hint
You need to write another `elif` statement that's very similar to the one you've created in the previous step.
:::

### 4
Finally, let's address temperatures below zero. If it's below zero, make our function scream "Freezing my ass off!".

:::tests
thermometer_tests_4.py
:::

:::hint
You could use another `elif` statement here, but using `else` would be shorter: if written correctly, the conditions above cover all possible positive temperatures and zero, which means `else` would cover all negative temperatures. 
:::

