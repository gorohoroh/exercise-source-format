# Errors

Let's try something new. Can we get the length of a number the same way we could find out the length of our name? Type in `len(304023)` and hit `enter`:

```bash
>>> len(304023)
Traceback (most recent call last):
  File "<stdin>", line 1, in <module>
TypeError: object of type 'int' has no len()
```

We got our first error! The warning icon is our way of giving you a heads up that the code you are about to run won't work as expected. Making mistakes (even intentional ones) are an important part of learning!

 It says that objects of type "int" (integers, whole numbers) have no length. So what can we do now? Maybe we can write our number as a string? Strings have a length, right?

```bash
>>> len(str(304023))
6
```

It worked! We used the `str` function inside of the `len` function. `str()` converts everything to strings.

- The `str` function converts things into __strings__
- The `int` function converts things into __integers__

> Important: we can convert numbers into text, but we can't necessarily convert text into numbers – what would `int('hello')` be anyway?

