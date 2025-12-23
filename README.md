# Reinstaller

A powerful software reinstallation management tool that tracks your application installation history and helps you manage reinstallations efficiently.

## 🚀 Features

- **Track Application History** - Monitor all your software installations and reinstallations
- **Store Installer Metadata** - Keep detailed information about versions, publishers, and file sizes
- **Monitor File Existence** - Track which installer files are still available on your system
- **Reinstall Statistics** - View reinstall counts and timestamps
- **JSON-based Data Management** - Clean, structured data storage
- **User-friendly Interface** - Intuitive Windows Forms application

## 📥 Download

### Latest Version
- **Download Original Reinstaller.exe** - [Direct Download](https://reinstaller.vercel.app/Reinstaller.exe) (68.42 MB)
- **Compressed Version** - [Download ZIP](https://reinstaller.vercel.app/Reinstaller_Original.zip) (63.08 MB)
- **Development Package** - [Full Package](https://reinstaller.vercel.app/Reinstaller_Package.zip) (with dependencies)

### Web Access
Visit the official website: [https://reinstaller.vercel.app](https://reinstaller.vercel.app)

## 🛠️ Installation

1. Download the executable from the links above
2. Run `Reinstaller.exe` (no installation required)
3. The application will create and manage its own configuration files automatically

## 📁 Project Structure

```
Reinstaller/
├── Reinstaller.exe              # Original executable
├── Reinstaller_Original.zip      # Compressed version
├── Reinstaller_Package.zip      # Development package
├── src/                         # Source code
│   ├── Program.cs               # Main application code
│   ├── Reinstaller.csproj       # .NET project file
│   └── assets/                  # Icons and resources
├── IconCache/                   # Cached application icons
├── index.html                   # Web interface
├── vercel.json                  # Vercel deployment config
└── README.md                    # This file
```

## 🏗️ Development

### Prerequisites
- .NET 6.0 SDK or later
- Windows operating system
- Visual Studio 2022 or VS Code (optional)

### Building from Source

```bash
# Clone the repository
git clone https://github.com/vvraju56/Reinstaller.git
cd Reinstaller

# Restore dependencies
dotnet restore src/Reinstaller.csproj

# Build the project
dotnet build src/Reinstaller.csproj --configuration Release

# Run the application
dotnet run --project src/Reinstaller.csproj

# Create standalone executable
dotnet publish src/Reinstaller.csproj --configuration Release --runtime win-x64 --self-contained true --output ./publish
```

### Project Dependencies
- .NET 6.0 Windows Forms
- System.Drawing.Common v6.0.0
- Windows Desktop Runtime 6.0+

## 🔧 Configuration

The application stores its data in a JSON file located in the application directory:
- `ReinstallHistory.json` - Contains all installation and reinstallation records

### Data Structure
```json
{
  "installHistory": [
    {
      "name": "Application Name",
      "version": "1.0.0",
      "publisher": "Publisher Name",
      "installDate": "2025-01-01",
      "installPath": "C:\\Program Files\\Application",
      "reinstallCount": 3,
      "lastReinstallDate": "2025-01-15",
      "installerFile": "path\\to\\installer.exe",
      "fileSize": "100 MB",
      "fileExists": true,
      "uninstallRegistry": "Registry path"
    }
  ]
}
```

## 🌐 Deployment

This project is deployed on Vercel with automatic GitHub integration:

- **Production URL:** https://reinstaller.vercel.app
- **Repository:** https://github.com/vvraju56/Reinstaller
- **CI/CD:** Automatic deployment on push to main branch

## 📊 Technical Specifications

- **Platform:** Windows x64
- **Framework:** .NET 6.0 Windows Forms
- **Language:** C# 10.0
- **File Size:** 68.42 MB (standalone)
- **Memory Usage:** ~32 MB (typical)
- **Storage:** JSON-based data files

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📝 License

This project is for personal use. Please contact the maintainer for licensing inquiries.

## 📞 Support

If you encounter any issues or have questions:

- 📧 Create an [Issue on GitHub](https://github.com/vvraju56/Reinstaller/issues)
- 🌐 Visit the [website](https://reinstaller.vercel.app)
- 💬 Check the [Discussions](https://github.com/vvraju56/Reinstaller/discussions)

## 🔄 Version History

- **v1.0.0** - Initial release with core reinstallation tracking
- **v1.0.1** - Added icon caching and improved UI
- **v1.0.2** - Web deployment and download optimization
- **v1.0.3** - Original executable integration and full functionality

## 🌟 Acknowledgments

- Thanks to all contributors and users who helped improve this tool
- Built with C# and .NET 6.0
- Deployed on Vercel platform
- Icons cached from installed applications

---

**Made with ❤️ by [Your Name](https://github.com/vvraju56)**

*Reinstaller - Simplify your software reinstallation workflow*