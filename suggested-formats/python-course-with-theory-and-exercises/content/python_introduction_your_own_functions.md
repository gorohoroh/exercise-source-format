# Your own functions!

> For readers at home: this part is covered in the [Python Basics: Functions](https://www.youtube.com/watch?v=5owr-6suOl0) video.

Remember functions like `len()` that you can execute in Python? Well, good news – you will learn how to write your own functions now!

A function is a sequence of instructions that Python should execute. Each function in Python starts with the keyword `def`, is given a name, and can have some parameters. Let's give it a go. Replace the code in **python_intro.py** with the following:

{% filename %}python_intro.py{% endfilename %}
```python
def hi():
    print('Hi there!')
    print('How are you?')

hi()
```

Okay, our first function is ready!

You may wonder why we've written the name of the function at the bottom of the file. When we write `def hi():` and the indented lines following, this is us writing instructions for what the `hi()` function should do. Python will read and remember these instructions, but won't run the function yet. To tell Python we want to run the function, we have to call the function with `hi()`. Python reads the file and executes it from top to bottom, so we have to define the function in the file before we call it.

Let's run this now and see what happens:

```bash
$ python3 python_intro.py
Hi there!
How are you?
```

Note: if it didn't work, don't panic! The output will help you to figure why:
- If you get a `NameError`, that probably means you typed something wrong, so you should check that you used the same name when creating the function with `def hi():` and when calling it with `hi()`.
- If you get an `IndentationError`, check that both of the `print` lines have the same whitespace at the start of a line: python wants all the code inside the function to be neatly aligned.
- If there's no output at all, check that the last `hi()` *isn't* indented - if it is, that line will become part of the function too, and it will never get run.

Let's build our first function with parameters. We will change the previous example – a function that says 'hi' to the person running it – with a name:

{% filename %}python_intro.py{% endfilename %}
```python
def hi(name):
```

As you can see, we now gave our function a parameter that we called `name`:

{% filename %}python_intro.py{% endfilename %}
```python
def hi(name):
    if name == 'Ola':
        print('Hi Ola!')
    elif name == 'Sonja':
        print('Hi Sonja!')
    else:
        print('Hi anonymous!')

hi()
```

Remember: The `print` function is indented four spaces within the `if` statement. This is because the function runs when the condition is met. Let's see how it works now:

```bash
$ python3 python_intro.py
Traceback (most recent call last):
File "python_intro.py", line 10, in <module>
  hi()
TypeError: hi() missing 1 required positional argument: 'name'
```

Oops, an error. Luckily, Python gives us a pretty useful error message.
It tells us that the function `hi()` (the one we defined) has one required argument (called `name`) and that we forgot to pass it when calling the function.
Let's fix it at the bottom of the file:

{% filename %}python_intro.py{% endfilename %}
```python
hi("Ola")
```

And run it again:

```bash
$ python3 python_intro.py
Hi Ola!
```

And if we change the name?

{% filename %}python_intro.py{% endfilename %}
```python
hi("Sonja")
```

And run it:

```bash
$ python3 python_intro.py
Hi Sonja!
```

Now, what do you think will happen if you write another name in there? (Not Ola or Sonja.) Give it a try and see if you're right. It should print out this:

```bash
Hi anonymous!
```

This is awesome, right? This way you don't have to repeat yourself every time you want to change the name of the person the function is supposed to greet. And that's exactly why we need functions – you never want to repeat your code!

Let's do something smarter – there are more names than two, and writing a condition for each would be hard, right? Replace the content of your file with the following:

{% filename %}python_intro.py{% endfilename %}
```python
def hi(name):
    print('Hi ' + name + '!')

hi("Rachel")
```

Let's call the code now:

```bash
$ python3 python_intro.py
Hi Rachel!
```

Congratulations! You just learned how to write functions! :)

