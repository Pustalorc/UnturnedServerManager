----------- Unturned Server Manager -----------

Version: Public 4.0.0.0

[![Github Releases](https://img.shields.io/github/downloads/persiafighter/UnturnedServerManager/latest/total.svg?style=plastic)](https://github.com/persiafighter/UnturnedServerManager/releases/tag/v3.0.0.5) [![GitHub issues](https://img.shields.io/github/issues/persiafighter/UnturnedServerManager.svg?style=plastic)](https://github.com/persiafighter/UnturnedServerManager/issues)

Last Update: April 30, 2017

--

# Requirements:

.Net 4.6 or Later

Windows

# Known Bugs:

None as of 4.0.0.0

# Download:

https://github.com/persiafighter/UnturnedServerManager/releases/latest

# Changelog:

**V4.0.0.0** -

* Added Server.cs for a more local control over server instances.
* Added rocket's configs editor.
* Added permissions editor.
* Added Config.json editor.
* Added filesystem control.
* Added constants file.
* Added steam login.
* Improved plugin installer.
* Improved workshop installer.
* Improved design for Manager.cs.
* Improved Entry.cs for clean loading.
* Improved back-end downloading + Updating.
* Improved form controls for Server Settings.cs.
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

**V1.0.0.1** - Added link to github page.

----------- Unturned Server Manager -----------