# Dictionaries

> For readers at home: this part is covered in the [Python Basics: Dictionaries](https://www.youtube.com/watch?v=ZX1CVvZLE6c) video.

A dictionary is similar to a list, but you access values by looking up a key instead of a numeric index. A key can be any string or number. The syntax to define an empty dictionary is:

```bash
>>> {}
{}
```

This shows that you just created an empty dictionary. Hurray!

Now, try writing the following command (try substituting your own information, too):

```bash
>>> participant = {'name': 'Ola', 'country': 'Poland', 'favorite_numbers': [7, 42, 92]}
```

With this command, you just created a variable named `participant` with three key–value pairs:

- The key `name` points to the value `'Ola'` (a `string` object),
- `country` points to `'Poland'` (another `string`),
- and `favorite_numbers` points to `[7, 42, 92]` (a `list` with three numbers in it).

You can check the content of individual keys with this syntax:

```bash
>>> print(participant['name'])
Ola
```

See, it's similar to a list. But you don't need to remember the index – just the name.

What happens if we ask Python the value of a key that doesn't exist? Can you guess? Let's try it and see!

```bash
>>> participant['age']
Traceback (most recent call last):
  File "<stdin>", line 1, in <module>
KeyError: 'age'
```

Look, another error! This one is a **KeyError**. Python is helpful and tells you that the key `'age'` doesn't exist in this dictionary.

When should you use a dictionary or a list? Well, that's a good point to ponder. Think about the answer before looking at it in the next line.

- Do you just need an ordered sequence of items? Go for a list.
- Do you need to associate values with keys, so you can look them up efficiently (by key) later on? Use a dictionary.

Dictionaries, like lists, are *mutable*, meaning that they can be changed after they are created. You can add new key–value pairs to a dictionary after it is created, like this:

```bash
>>> participant['favorite_language'] = 'Python'
```

Like lists, using the `len()` function on the dictionaries returns the number of key–value pairs in the dictionary. Go ahead and type in this command:

```bash
>>> len(participant)
4
```

I hope it makes sense up to now. :) Ready for some more fun with dictionaries? Read on for some amazing things.

You can use the `pop()` method to delete an item in the dictionary. Say, if you want to delete the entry corresponding to the key `'favorite_numbers'`, type in the following command:

```bash
>>> participant.pop('favorite_numbers')
[7, 42, 92]
>>> participant
{'country': 'Poland', 'favorite_language': 'Python', 'name': 'Ola'}
```

As you can see from the output, the key–value pair corresponding to the 'favorite_numbers' key has been deleted.

As well as this, you can also change a value associated with an already-created key in the dictionary. Type this:

```bash
>>> participant['country'] = 'Germany'
>>> participant
{'country': 'Germany', 'favorite_language': 'Python', 'name': 'Ola'}
```

As you can see, the value of the key `'country'` has been altered from `'Poland'` to `'Germany'`. :) Exciting? Hurrah! You just learned another amazing thing.
