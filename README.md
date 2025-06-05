# CSharp-Text-Truncator

## Overview

Welcome to the **CSharp Text Truncator** project! This is a straightforward **C# console application** designed to truncate long text strings gracefully, ensuring they do not exceed a specified maximum length.

The goal of this project is to demonstrate a simple way to shorten text by cutting it off at word boundaries and appending an ellipsis (`...`) when truncated. It's perfect for beginners learning string manipulation in C# or anyone needing a quick utility to truncate text snippets.

---

## Project Structure

- **CSharp-Text-Truncator**: A standalone console app that:
  - Accepts a long text string.
  - Truncates the text without breaking words when exceeding a max length.
  - Outputs both the original and truncated text to the console.
  - Uses a customizable maximum length setting.

---

## Features

- Truncates text based on a configurable maximum character limit (default: 20).
- Ensures words are not cut in the middle—truncation happens cleanly at word boundaries.
- Adds an ellipsis (`...`) to indicate that the text has been shortened.
- Minimal, easy-to-understand C# implementation.
- Easily adaptable for different text sources or truncation rules.

---

## How It Works

The app splits the input text into words and iteratively adds them until the total length (including spaces) would exceed the maximum allowed. It then stops and appends `...` to indicate truncation.

---

## Output Example

Original: This is going to be a really really really really really long text!
Truncated: This is going to be a ...


Each run produces the truncated text based on the defined max length.

---

## How to Run

1. Open the solution in **Visual Studio** or your preferred C# IDE.
2. Set the project as the startup project.
3. Press `F5` or run the project.
4. The console will display both the original and truncated text.

---

## Screenshots

### Console Output

![Console Output](https://github.com/ElliotOne/CSharp-Text-Truncator/blob/master/screenshots/first.png)

---

## Technologies Used

- [.NET 6](https://dotnet.microsoft.com/)
- [C#](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [Visual Studio](https://visualstudio.microsoft.com/)

---

## License

This project is licensed under the MIT License. Feel free to use, modify, and distribute it.

---

## Contributions

Contributions are very welcome! You can fork the repo, submit issues, or open pull requests to add features such as:

- Custom ellipsis symbols or suffixes.
- Support for truncating by word count instead of characters.
- Command-line parameters for input text and max length.
- GUI or web interface.
