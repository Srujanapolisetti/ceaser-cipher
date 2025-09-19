# Ceaser Cipher

A simple Windows Forms application in C# that implements the Caesar Cipher — a basic encryption/decryption technique shifting letters by a fixed number.

---

## Table of Contents

- [Features](#features)  
- [Getting Started](#getting-started)  
  - [Prerequisites](#prerequisites)  
  - [Installation](#installation)  
- [Usage](#usage)  
- [How It Works](#how-it-works)  
- [Project Structure](#project-structure)  
- [Contributing](#contributing)  
- [License](#license)  

---

## Features

- Encrypt plaintext by shifting each letter by a given key.  
- Decrypt ciphertext back using the same key.  
- Handles uppercase and lowercase letters separately.  
- Ignores non-alphabetical characters (punctuation, digits, spaces) or leaves them unchanged.  

---

## Getting Started

### Prerequisites

- Windows OS  
- [.NET Framework](https://dotnet.microsoft.com/) (version appropriate for the project)  
- Visual Studio (Windows Forms support)  

### Installation

1. Clone this repository:

   ```bash
   git clone https://github.com/Srujanapolisetti/ceaser-cipher.git
Open the solution file Ceaser cipher.sln in Visual Studio.

Restore any NuGet packages if necessary.

Build the solution.

Usage
Run the application.

Enter the text you want to encrypt or decrypt.

Provide the key (shift amount).

Choose whether to encrypt or decrypt.

See the output in the UI.

How It Works
The Caesar Cipher works by shifting each letter in the text by a fixed number of places. For example:

With a key of 3, A becomes D, B → E, … X → A, Y → B, Z → C.

The same process is reversed for decryption using the same key.

Project Structure
python
Copy code
ceaser-cipher/
├── Ceaser cipher.sln        # Visual Studio solution file  
├── WinFormsApp2/             # The Windows Forms application project  
│   ├── Form1.cs              # Main form with UI logic  
│   ├── Program.cs             # Application entry point  
│   ├── … (design files, etc.) # Designer, resource files  
│   └── other class files  
├── .gitignore                 # Files/folders to be ignored by Git  
└── .gitattributes             # Git attributes configuration  
Contributing
Contributions are welcome! If you want to help, you can:

Suggest enhancements or report bugs via GitHub Issues.

Fork the repository, make changes, and submit a pull request.

Follow code style (e.g. naming, formatting) consistent with existing code.

License
This project is open source.
Author

Srujanapolisetti
