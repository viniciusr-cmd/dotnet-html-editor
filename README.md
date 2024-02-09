## Simple Terminal HTML Editor

This repository contains the source code for a simple command-line HTML editor written in C#. It allows you to create and edit HTML files directly from the terminal, making it a lightweight and efficient tool for quick HTML development.

**Features:**

* Create and open HTML files.
* Edit file content using basic navigation and editing commands.
* Save changes to existing files.
* View formatted HTML output in the terminal.
* Syntax highlighting for easier code identification.
* Undo/redo functionality for editing actions.

**Requirements:**

* .NET 6 or later ([https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download): [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download))
* Terminal emulator (e.g., Command Prompt, PowerShell)

**Getting Started:**

1. **Clone the repository:**

   ```bash
   git clone https://github.com/viniciusr-cmd/dotnet-html-editor.git
   ```

2. **Build the project:**

   - Navigate to the project directory in your terminal.
   - Run the following command:

     ```bash
     dotnet build
     ```

3. **Run the editor:**

   - In the same directory, run:

     ```bash
     dotnet run "path/to/your/file.html"
     ```

     Replace `"path/to/your/file.html"` with the actual path to your HTML file (optional). If no file is provided, a new file will be created.

**Basic Usage:**

* Use arrow keys and `HOME`/`END` to navigate the document.
* Insert text, delete characters, and backspace as usual.
* Use `ctrl+z` and `ctrl+y` for undo/redo.
* Type `:esc` to save the file and `:exit` to quit the editor.

**For more information:**

* Refer to the `Help` command within the editor for a list of available commands and their usage.
* Explore the source code to understand the editor's functionalities.

**Contributions:**

Feel free to fork this repository and contribute to its improvement. Any suggestions or pull requests are welcome!
