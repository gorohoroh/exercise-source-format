# Alemira Coding Labs exercise source format

## Sources for examples of known coding exercise formats

1. The Odin Project: [sumAll](https://github.com/TheOdinProject/javascript-exercises/tree/master/sumAll)
2. freeCodeCamp: [remove items from an array with pop() and shift()](https://github.com/freeCodeCamp/freeCodeCamp/blob/main/curriculum/challenges/english/02-javascript-algorithms-and-data-structures/basic-data-structures/remove-items-from-an-array-with-pop-and-shift.md)
3. Exercism: [language-agnostic problem specifications](https://github.com/exercism/problem-specifications/tree/main/exercises), [language-specific practice exercises (C#)](https://github.com/exercism/csharp/tree/54e7eee498965605051a4de73a49af70ab4a7ced/exercises/practice)

## What kind of lightweight markup we need for Coding Labs

Current CL source format requirements:
1. It should be as versatile as possible in order to support authoring exercises in any programming language.
2. It should be clear to instructors who author exercises. For programming instructors, we can assume that they're proficient enough in what they teach, and they are able to write code for exercises (probably aided by some sort of code generation). If necessary, we'll later be able to put a UI on top of this for less tech-savvy instructors.
3. It should be VCS compatible: if necessary, an instructor should be able to check out exercises to their local machine and proceed with editing in their favorite editor. In this respect, having a simple Git hosting is a big plus, and we'll probably add GitHub/GitLab integration later.
4. It should support both novice-friendly exercises that contain multiple instructions and more complex projects for more advanced students.
5. Going forward, it should support integration into larger courseware written in a lightweight markup language such as Markdown, RST, or LiaScript.

## Initial Markdown-based format proposal

The current proposed exercise format (considerably inspired by Exercism) uses Markdown and requires exactly one non-standard Markdown feature: **custom containers**.

Custom containers enable designated markup for hints (`:::hint`) and tests (`:::tests`) in exercise definitions. Custom containers are available in many Markdown parsers, including [Markdig](https://github.com/xoofx/markdig/blob/master/src/Markdig.Tests/Specs/CustomContainerSpecs.md), [markdown-it](https://github.com/markdown-it/markdown-it-container), and [markdown-it-py](https://markdown-it-py.readthedocs.io/en/latest/_modules/mdit_py_plugins/container/index.html#container_plugin). Based on this [this babelmark test](https://babelmark.github.io/?text=%23%23+Instructions%0A%0A%23%23%23+1%0ALet%27s+make+our+%60thermometer()%60+function+do+something.+Instead+of+%60pass%60%2C+add+an+%60if%60+condition+that+returns+%22Too+hot%22+if+temperature+is+30+degrees+or+higher.%0A%0A%3A%3A%3Atests%0Athermometer_tests_1.py%0A%3A%3A%3A%0A%0A%3A%3A%3Ahint%0A%0AThis+is+what+your+code+is+expected+to+look+like+after+following+this+instruction%3A%0A%0A%60%60%60python%0Adef+thermometer(temp)%3A%0A++++if+temp+%3E%3D+30%3A%0A++++++++return+%22Too+hot%22%0A%0A%0Athermometer(25)%0A%60%60%60%0A%3A%3A%3A%0A%0A), markdig in advanced mode correctly transforms custom containers out of the box. Other parsers (such as markdown-it) can potentially do this, too, but require additional configuration.

## Markdown features that we may possibly need to enable non-practical Markdown-based content

It's not exactly clear what we'll need for authoring non-exercise content, but based on GitBook-based and Sphinx-based content researched, the following Markdown features would be very nice to have in the future:

* `include`. Allows to include one file into another. Useful to include blocks of content that are reused in multiple places. Available in GitBook. Sphinx provides both `include` and `literalinclude` (which only differ in error handling): 
  ```
    .. literalinclude:: php_time_test.php
        :caption: php_time_test.php
        :linenos:
        :language: html
    ```

* `toctree`. Allows rendering a table of contents based on parts of a file tree. Used in Sphinx ([docs](https://www.sphinx-doc.org/en/master/usage/restructuredtext/directives.html#directive-toctree)). Example:
  ```
  .. toctree::
     :maxdepth: 1
  
     semester_1/index
     semester_2/index
     about
  ```
* `csv-table`. Allows to create tables based on external CSV content, which allows editing tabular data in spreadsheets. Used in Docutils/Sphinx ([docs](https://docutils.sourceforge.io/docs/ref/rst/directives.html#csv-table)). Example:
  ```
  .. csv-table::
     :file: class_schedule.csv
     :widths: 15, 55, 30
     :header-rows: 1
  ```
* `[#n]`. Enables footnotes ([docs](https://www.sphinx-doc.org/en/master/usage/restructuredtext/basics.html#footnotes)). Example:
  ```
  .. [#f1] Wikipedia contributors. (2021, January 21).
     "`Web application security <https://en.wikipedia.org/wiki/Web_application_security>`_".
     In Wikipedia, The Free Encyclopedia. Retrieved 17:32, January 31, 2021,
     from https://en.wikipedia.org/w/index.php?title=Web_application_security&oldid=1001721387
  ```

## Todo items

* [x] Split exercise into 2 instructions
* [x] Try the same approach with Python
* [x] Try the same approach with JavaScript
* [x] Address issues: naming conventions to define different kinds of files (examples, initial, tests) will be hard to maintain because of language-specific conventions (i.e. title case for files in C# and lowercase in Python and JavaScript; special meaning for dot in file names in Python, etc.)
* [x] Define requirements for Markdown-based format
* [ ] Try the updated approach with Kotlin
* [ ] Try the updated approach with Java
* [ ] Try the updated approach with multi-file exercises in C# (ASP.NET Core?)
* [ ] Try the updated approach with multi-file exercises in Java (take a template from Codeboard)
* Should each C# exercise be a separate project?
