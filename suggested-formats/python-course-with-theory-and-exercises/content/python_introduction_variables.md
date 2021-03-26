# Variables

An important concept in programming is variables. A variable is nothing more than a name for something so you can use it later. Programmers use these variables to store data, make their code more readable and so they don't have to keep remembering what things are.

Let's say we want to create a new variable called `name`:

```bash
>>> name = "Ola"
```

We type name equals Ola.

As you've noticed, your program didn't return anything like it did before. So how do we know that the variable actually exists? Enter `name` and hit `enter`:

```bash
>>> name
'Ola'
```

Yippee! Your first variable! :) You can always change what it refers to:

```bash
>>> name = "Sonja"
>>> name
'Sonja'
```

You can use it in functions too:

```bash
>>> len(name)
5
```

Awesome, right? Now, variables can be anything – numbers too! Try this:

```bash
>>> a = 4
>>> b = 6
>>> a * b
24
```

But what if we used the wrong name? Can you guess what would happen? Let's try!

```bash
>>> city = "Tokyo"
>>> ctiy
Traceback (most recent call last):
  File "<stdin>", line 1, in <module>
NameError: name 'ctiy' is not defined
```

An error! As you can see, Python has different types of errors and this one is called a **NameError**. Python will give you this error if you try to use a variable that hasn't been defined yet. If you encounter this error later, check your code to see if you've mistyped any names.

Play with this for a while and see what you can do!


