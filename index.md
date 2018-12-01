Version: Public 4.0.0.2

[![Github Releases](https://img.shields.io/github/downloads/persiafighter/UnturnedServerManager/latest/total.svg?style=plastic)](https://github.com/persiafighter/UnturnedServerManager/releases/latest)

<h1>Requirements:</h1>

.Net 4.7 or Later

Windows

<h1>Download:</h1>

[Releases](https://github.com/persiafighter/UnturnedServerManager/releases/latest)

<h1>Known Bugs:</h1>

None as of 4.0.0.2

<h1>Changelog:</h1>

**V4.0.0.2** - 
* Removed vanilla server option due to high disk usage.
* Fixed updating menu crashing the application.
* Code Cleanup (Jetbrains Rider)

**V4.0.0.1** -
* Fixed raised exception when leaving the map field empty in the server configuration, saving and loading it again. (Credit to Luke_ArOres#0769 for finding it)
* Fixed forgotten addition of auto-detection of workshop maps. (Credit to Luke_ArOres#0769 for reminding of this issue)
* Fixed minor issue when loading maps for a vanilla server.
* Updated Fody and Costura.Fody to latest versions.

**V4.0.0.0** -

* Added more local control over server instances.
* Added filesystem control.
* Added constants file.
* Added steam login.
* Added Costura.Fody so that no referenced libraries are required next to the executable
* Improved plugin installer.
* Improved workshop installer.
* Improved design for the manager.
* Improved installation checking.
* Improved the entry for clean loading.
* Improved back-end downloading + Updating.
* Improved form controls for the server settings.
* Improved saved configuration files to json formatted files.
* Changed version retreival from github file to custom build numbers.
* Changed background colour to "Control" from FF0000.
* Removed project signing (due to Costura.Fody issues).
* Removed self-version checking.
* Removed logging.
* Fixed updating issues.
* Cleaned up & organised code.

**V3.0.1.4** - 

* Fixed A Problem With The Updater Tool GUI Displaying + Storing The Wrong Version Values.

**V3.0.1.3** - 

* Fixed The Ability To Launch More Than 1 Instance Of USM.
* Fixed TickTimer Form Showing When Doing Alt+Tab.

**V3.0.1.2** - 

* Fixed A Problem With Plugin Integrity Update.

**V3.0.1.1** - 

* Fixed The Ability To Resize The Updater Tool.
* Fixed The Startup Position Of The Server Settings Tool And Updater Tool.
* Re-Added USMVer.dat File To Notify Old Versions Of New Update.

**V3.0.1.0** - 

* Fixed The Inability To Change The Server Path From GUI.
* Fixed Inability To Start Program Again After Force Shutdown/Crash.
* Fixed Plugin Lists And Download.
* Fixed Unturned Version Not Updating On GUI With "Update All".
* Fixed Unknown DLL Files When Installing Some Plugins.
* Fixed Way To Download Data Files.
* Fixed The Bug With Using A Link In The Install By ID.
* Changed Unturned Updater Redirector.
* Added Versions.zip And Plugins.zip To Data Folder.
* Added .GitIgnore To Upload The Code Easier Without The Loss Of Local Data.
* Removed USM.exe, PIVer.dat, Plugins.dat, PluginsDl.dat, PluginsPage.dat, RocVer.dat, UntVer.dat And USMVer.dat From Data Folder.

**V3.0.0.5** - 

* Fixed Multiple Bugs With The Workshop Install Tool.
* Fixed Logger.
* Fixed Unturned Install.
* Fixed "Update All" Workshop Items Bug.
* Fixed Install By Id Workshop Items Bug.
* Changed Unturned Install Method.

**V3.0.0.4** - 

* Fixed Unable To Start Program In Offline Mode
* Fixed Bug When Puting A Non-Directory Link In Workshop Installer.
* Fixed Multiple Bugs With The Unturned Updater.
* Removed Comment About Unturned Updating Being Disabled.
* Enabled/Added Unturned Update Option.
* Added Option To Install Workshop Items By Item ID.
* Added "Update All" Button To Workshop Installer.
* Added Logger & System Logging To Log.txt.
* Changed Background Color To All Forms.

**V3.0.0.3** - 

* Fixed Updater.
* Fixed Few Errors With Plugin Installer.
* Fixed Few Errors With Downloader.cs.
* Fixed Per-Server Saving Issue.
* Fixed Issue With Plugin Management Button Being Active After Server Launch.
* Fixed Issue With Not Setting Difficulty.
* Changed Server ID Managing.
* Removed Github File Rocket_Latest.zip - Changed To Rocket Direct Download Link.

**V3.0.0.2** - 

* Fixed An Error With The Versions.dat File.

**V3.0.0.1** - 

* Fixed An Error When Launching The Updater Tool.
* Fixed A Bug Returning An Exception When Loading The Plugin Installer Without The PI Files.
* Added A Loop To Check If Rocket Is Installed, If It Isn't Plugin Install Is Disabled.

**V3.0.0.0** - 

* Fixed Issue With Gold Mode.
* Fixed Rocket Installation Freezing.
* Fixed Rocket Updating.
* Fixed/Added Ease of install for plugins.
* Fixed Bug With Workshop Item IDs Not Displaying.
* Fixed Per-Server SRS.
* Added Full Updater.
* Added Plugin Integrity files to include downloads and web pages to working plugins and their names.
* Added System Tray Icon.
* Added Local Server Configuration Files.
* Added Button To Open Selected Workshop Items In Browser.
* Disabled Unturned Updating For A Future, Much Better Update.
* Removed Rocket Updating Animation.
* Removed Global SRS.
* Removed Rocket Libraries.
* Changed User Interface.
* Changed Max servers from 4 to 100.
* Changed USM.lock file position.
* Changed Per-Server SRS Limiters.
* Changed Self-Version Checking Feature To The Full Updater + Notification.
* Changed USM Configuration File.

**V2.0.1.0** - 

* Changed How Rocket Install Works Due To Rocket Changing Their Builds And How They Function (Fully explained here: https://rocketmod.net/viewtopic.php?f=44&t=2961).
* Added Small Self-Version Checking Feature. Will Be Improved In Expected 3.0.0.0 Release.

**V2.0.0.0** - 

* Added Link To Reddit Post.
* Fixed SRS (Shutdown, Restart and Start) Buttons To Apply To The Servers That The Program Started Only.
* Added Rocket Install, Workshop Install And Plugin Install (Plugin install is buggy!).
* Added Per-Server SRS Features.

**V1.0.0.1** -

* Added link to github page.
