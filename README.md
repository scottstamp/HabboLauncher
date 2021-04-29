# HabboLauncher
This project is a replacement for Sulake's atrocious HabboLauncher package.

Feel free to clone or modify this project for your own personal uses, I just ask that you link back to this page. :heart:

# Features
- Multi-login (allows loading multiple accounts / hotels at once)
- Auto-launch (will automatically launch the last client you selected after 5 seconds)
- G-Earth integration (set your G-Earth path in the Options dialog to connect automatically)
- Updater (checks with Habbo every time you run the launcher for any new client files)

# Motivation
After some heartfelt discussion with [@SulakeJohno](https://twitter.com/SulakeJohno/status/1382214370298564608) it's clear Sulake is more interested in "easy development" than providing quality software.

The latest Habbo Launcher application relies on Electron, while I normally wouldn't protest this, it's loading >300mb of data each time it opens to simply spawn another process.
It's also lacking a lot of useful features and has poor ergonomics (no auto-launch or close after launching).

Future goals include releasing a macOS compatible version once .NET 6 is stable (for M1 support).

# Dependencies
- [Fody](https://github.com/Fody/Home)
- [Costura](https://github.com/Fody/Costura)
- [Json.NET](https://www.newtonsoft.com/json)
- [Octokit](https://github.com/octokit/octokit.net)