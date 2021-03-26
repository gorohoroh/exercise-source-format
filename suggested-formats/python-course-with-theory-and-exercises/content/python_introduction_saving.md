# Save it!

> For readers at home: this part is covered in the [Python Basics: Saving files and "If" statement](https://www.youtube.com/watch?v=dOAg6QVAxyk) video.


So far we've been writing all our python code in the interpreter, which limits us to entering one line of code at a time. Normal programs are saved in files and executed by our programming language __interpreter__ or __compiler__. So far we've been running our programs one line at a time in the Python __interpreter__. We're going to need more than one line of code for the next few tasks, so we'll quickly need to:

- Exit the Python interpreter
- Open up our code editor of choice
- Save some code into a new python file
- Run it!

To exit from the Python interpreter that we've been using, type the `exit()` function

```bash
>>> exit()
$
```

This will put you back into the command prompt.

Earlier, we picked out a code editor from the [code editor](../code_editor/README.md) section. We'll need to open the editor now and write some code into a new file (or if you're using a Chromebook, create a new file in the cloud IDE and open the file, which will be in the included code editor):

{% filename %}editor{% endfilename %}
```python
print('Hello, Django girls!')
```

Obviously, you're a pretty seasoned Python developer now, so feel free to write some code that you've learned today.

Now we need to save the file and give it a descriptive name. Let's call the file **python_intro.py** and save it to your desktop. We can name the file anything we want, but the important part here is to make sure the file ends in __.py__. The __.py__ extension tells our operating system that this is a **Python executable file** and Python can run it.

> **Note** You should notice one of the coolest thing about code editors: colors! In the Python console, everything was the same color; now you should see that the `print` function is a different color from the string. This is called "syntax highlighting", and it's a really useful feature when coding. The color of things will give you hints, such as unclosed strings or a typo in a keyword name (like the `def` in a function, which we'll see below). This is one of the reasons we use a code editor. :)


With the file saved, it's time to run it! Using the skills you've learned in the command line section, use the terminal to **change directories** to the desktop.

<!--sec data-title="Change directory: OS X" data-id="python_OSX"
data-collapse=true ces-->

On a Mac, the command will look something like this:

```bash
$ cd ~/Desktop
```
<!--endsec-->

<!--sec data-title="Change directory: Linux" data-id="python_linux"
data-collapse=true ces-->

On Linux, it will be like this:

```bash
$ cd ~/Desktop
```

(Remember that the word "Desktop" might be translated to your local language.)

<!--endsec-->

<!--sec data-title="Change directory: Windows Command Prompt" data-id="python_windows" data-collapse=true ces-->

On Windows Command Prompt, it will be like this:

```bash
> cd %HomePath%\Desktop
```
<!--endsec-->


<!--sec data-title="Change directory: Windows Powershell" data-id="python_windowsPSH" data-collapse=true ces-->

And on Windows Powershell, it will be like this:

```bash
> cd $Home\Desktop
```
<!--endsec-->


If you get stuck, ask for help. That's exactly what the coaches are here for!

Now use Python to execute the code in the file like this:

```bash
$ python3 python_intro.py
Hello, Django girls!
```

Note: on Windows 'python3' is not recognized as a command. Instead, use 'python' to execute the file:

```bash
> python python_intro.py
```

Alright! You just ran your first Python program that was saved to a file. Feel awesome?

You can now move on to an essential tool in programming:

