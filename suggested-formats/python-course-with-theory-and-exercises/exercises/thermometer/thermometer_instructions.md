# Thermometer

Let's practice what you've learnt earlier when we discussed `if`, `else` and `elif` (collectively called _conditional statements_), as well as writing your own functions.

Let's write a function that, given the current temperature (in degrees Celsius) will write how we feel about this temperature.

The initial code in the code editor contains the following:

1. The definition of the `thermometer` function that only contains a line that says `pass`. `pass` is a way to tell Python that although the function exists, it doesn't do anything useful right now.
2. A call of the `thermometer` function where we pass `25` (meaning "25 degrees Celsius") as an argument.

Here's what you'll need to do:

## Instructions

### 1
Let's make our `thermometer` function do something. Instead of `pass`, add an `if` condition that prints "Too hot" if temperature is 30 degrees or higher.

:::tests
thermometer_tests_1.py
:::

:::hint

This is what your code is expected to look like after following this instruction:

```python
def thermometer(temp):
    if temp >= 30:
        print("Too hot")


thermometer(25)
```
:::


### 2
Great! Your function can now scream if it feels it's too hot out there.

Now, let's make it say something different about temperatures that feel OK. If temperature is less than 30 degrees but equal or more than 10 degrees, make the function print "It's comfortable out there".

Make sure that the condition we've introduced in the previous step stays intact. Remember the `elif` keyword? It will help you out here.

:::tests
thermometer_tests_2.py
:::

:::hint
This is what your code is expected to look like after following this instruction:

```python
def thermometer(temp):
    if temp >= 30:
        print("Too hot")
    elif 10 <= temp < 30:
        print("It's comfortable out there")


thermometer(25)
```
:::

### 3
Blabla:

```python
```

:::tests
thermometer_tests_3.py
:::

:::hint
TODO
:::

### 4
Blabla:

```python
```

:::tests
thermometer_tests_4.py
:::

:::hint
TODO
:::

