# 🔐 AES Encryption Tool

This is a simple desktop app built in C# that lets you **encrypt** and **decrypt** text with the **AES** encryption algorithm. It uses the MaterialSkin library for a modern and sleek user interface.

## 🌟 Features

- ✨ **Encrypt Text**: Encrypt any text using a secret key.
- 🔓 **Decrypt Text**: Decrypt the encrypted text back to its original form.
- 📋 **Clipboard Integration**: Automatically copies the encrypted/decrypted text to your clipboard.
- 🔑 **Key Generation**: The encryption key is generated using an MD5 hash of your input key.

## ⚙️ Requirements

- .NET Framework (4.5 or higher recommended)
- [MaterialSkin Library](https://github.com/IgnaceMaes/MaterialSkin)

## 🛠️ Installation

1. Clone or download the repository.
2. Open the project in **Visual Studio**.
3. Build the solution (Ctrl+Shift+B).
4. Run the application from Visual Studio or navigate to the compiled executable.

## 📝 How to Use

1. 💬 **Enter text** in the "Encrypt" field to encrypt it.
![text1](https://i.imgur.com/Dy7xDDN.png)
3. 🔑 **Provide your key** in the "Key" field.
![key1](https://i.imgur.com/0BQphnq.png)
5. ➡️ Click **Encrypt Text!** to see the result.
![result](https://i.imgur.com/4zuBU1l.png)
7. 🔁 To decrypt, **paste the encrypted text** into the "Decrypt" field and click **Decrypt Text!**.
![decrypt](https://i.imgur.com/SUsUazi.png)


## 📜 License

This project is licensed under the **MIT License** - see the [LICENSE](LICENSE) file for details.

## 🤝 Credits

- [MaterialSkin](https://github.com/IgnaceMaes/MaterialSkin) for the Material Design UI.
- C# and .NET for building the application.
- [AES](https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.aes?view=netframework-4.8) for encryption and decryption.

## 📬 Contact

For questions, suggestions, or issues, feel free to open an issue or reach out via [Discord](https://discord.com/invite/FgXwbeBp7t).
