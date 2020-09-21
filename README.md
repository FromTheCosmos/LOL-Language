<!-- PROJECT LOGO -->
<p align="center">
  <a href="https://github.com/FromTheCosmos/LOL-Language">
    <img src="/LOL-Language/Resources/LOL_LANGUAGE_small.png" alt="Logo" width="80" height="80">
  </a>
</p>

# LOL-Language
LOL-Language is a Windows Form application written in C# to allow users to select client language on startup. This also includes region-specific champion voiceovers specific to the selected language. This project is open source and will remain open source. It is recommended to run the project by cloning it in VSCode, Atom or Visual Studio. I have included a LOL-Language.exe direct download in the repository, however this is likely to be flagged by antivirus due to it not being a widely distributed and recognized application. Direct download can be found [here](https://github.com/FromTheCosmos/LOL-Language/raw/master/LOL-Language/LOL-Language.exe).

Updates are unlikely to occur unless Riot completely overhauls their client structure, which at that point they will likely have language selection natively as with the VALORANT client.

<p align="center">
  <img src="https://i.imgur.com/SgQWfwB.png"
     alt="Example Screenshot"
     style="float: left; margin-right: 10px;" />
</p>

# How does it work?

No outside connections are made and no client files are modified. The League of Legends client is simply started by the application with specific locale(Region/Language) target arguments as shown in the code snippet below.

```csharp
        // Sets what the arguments are for the process assigned to variable
        string locale = "--locale=" + languageComboBox.SelectedValue.ToString();

        // Starts the LeagueClient.exe assuming the path was set successfully using locale as arguments
        Process.Start(clientPath, locale);
```

From there, the client automatically launches with the specified language and downloads the necessary assets to satisfy that language requirement (Voiceovers and other audio).



# Will I get banned using this?
Users should be fine running an application of this nature, though with any third-party software you should assume there is always a small chance. I have been in touch with some of the folks over at the Riot Games Developer relations in their [Discord server](https://discord.gg/riotgamesdevrel) and one of the translators advised it should be fine, the link to that message is [here](https://discordapp.com/channels/187652476080488449/345329525455978498/756761465049841684).

# How do I set my League of Legends installation?

You can either click the button that says "Select LeagueClient.exe" or click and drag your League shortcut or .exe file to the application and it should automatically detect it.

<p align="center">
  <img src="https://i.imgur.com/HEV1VAE.gif"
     alt="Example Screenshot"
     style="float: left; margin-right: 10px;" />
</p>

# Issues
If you downloaded the LOL-Language.exe instead of downloading the source code and running it in Visual Studio, you may run into a problem where the application does not launch and is unresponsive. This is likely due to not having the required prerequisites. The only real prerequisite for this application is a recent version of Microsoft's .NET Framework. You can install Microsoft .NET Framework 4.7.2 [here](https://dotnet.microsoft.com/download/dotnet-framework/net472).

<!-- LICENSE -->
# License
This project is released under the GPLv3 license, for more details, take a look at the [LICENSE](https://github.com/FromTheCosmos/LOL-Language/blob/master/LICENSE) file.
