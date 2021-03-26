# Strings

How about your name? Type your first name in quotes like this:

```bash
>>> "Ola"
'Ola'
```

You've now created your first string! It's a sequence of characters that can be processed by a computer. The string must always begin and end with the same character. This may be single (`'`) or double (`"`) quotes (there is no difference!) The quotes tell Python that what's inside of them is a string.

Strings can be strung together. Try this:

```bash
>>> "Hi there " + "Ola"
'Hi there Ola'
```

You can also multiply strings with a number:

```bash
>>> "Ola" * 3
'OlaOlaOla'
```

If you need to put an apostrophe inside your string, you have two ways to do it.

Using double quotes:

```bash
>>> "Runnin' down the hill"
"Runnin' down the hill"
```

or escaping the apostrophe with a backslash (`\`):

```bash
>>> 'Runnin\' down the hill'
"Runnin' down the hill"
```

Nice, huh? To see your name in uppercase letters, type:

```bash
>>> "Ola".upper()
'OLA'
```

You just used the `upper` __method__ on your string! A method (like `upper()`) is a sequence of instructions that Python has to perform on a given object (`"Ola"`) once you call it.

If you want to know the number of letters contained in your name, there is a __function__ for that too!

```bash
>>> len("Ola")
3
```

Wonder why sometimes you call functions with a `.` at the end of a string (like `"Ola".upper()`) and sometimes you first call a function and place the string in parentheses? Well, in some cases, functions belong to objects, like `upper()`, which can only be performed on strings. In this case, we call the function a __method__. Other times, functions don't belong to anything specific and can be used on different types of objects, just like `len()`. That's why we're giving `"Ola"` as a parameter to the `len` function.
