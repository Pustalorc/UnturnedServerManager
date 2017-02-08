----------- Unturned Server Manager -----------

Version: Public 3.0.0.5

[![Github Releases](https://img.shields.io/github/downloads/persiafighter/UnturnedServerManager/latest/total.svg?style=plastic)](https://github.com/persiafighter/UnturnedServerManager/releases/tag/v3.0.0.5) [![GitHub issues](https://img.shields.io/github/issues/persiafighter/UnturnedServerManager.svg?style=plastic)](https://github.com/persiafighter/UnturnedServerManager/issues) [![GitHub closed issues](https://img.shields.io/github/issues-closed/persiafighter/UnturnedServerManager.svg?style=plastic)]()

Last Update: January 1, 2017

--

#Note:

I'll be falling back to debugging and fixing the current state of the program. Please report the bugs. Once the program seems stable, i'll be working on new features.

--

#Requirements:

.Net 4.5 or Later

Windows (Will be working on mac version at some point in time)

Unturned Installed Somewhere In Your Computer


#Upcoming Features:

* Control on each of the server's console (ban and such).
* Update All Plugins (bulk update).
* Auto-Restart Option.
* Ease of config for rocket settings and permissions.
* Delete Mod/Plugin Selected.
* USM Settings.

#Known Bugs:

* Unable to change the server path.
* Plugin lists are incorrect but still allow download of a few items.
* When program crashes, it is unable to start without finding and removing USM.lock file.
* Multiple Log Sectors missing.
* Unable to tell difference of what happened where in the logs.
* Install by ID in workshop installer has a bug when adding a link there.
* Messageboxes are incomplete.
* Unknown DLL Files when installing a few ids.
* Unable to see already downloaded items with install by ID.
* Errors when using an incorrect format for a folder.
* Shutdown/Restart makes player data loss.

#Download:

https://github.com/persiafighter/UnturnedServerManager/raw/master/Data/USM.exe

Or compile it yourself with the source code!

#Reddit Post:

https://www.reddit.com/r/unturned/comments/546y67/unturned_server_manager/

#Changelog:

**V3.0.0.5** - 

* Fixed multiple bugs with the workshop install tool.
* Fixed Logger.
* Fixed Unturned Install.
* Fixed "Update All" Workshop Items Bug.
* Fixed install by id workshop items bug.
* Changed Unturned Install Method.

**V3.0.0.4** - 

* Fixed Unable To Start Program In Offline Mode
* Fixed Bug When Puting A Non-Directory Link In Workshop Installer.
* Fixed Multiple Bugs With The Unturned Updater.
* Removed Comment About Unturned Updating Being Disabled.
* Enabled/Added Unturned Update Option
* Added option to install workshop items by item ID.
* Added "Update All" Button To Workshop Installer.
* Added logger & system logging to Log.txt
* Changed background color to all forms	

**V3.0.0.3** - 

* Fixed Updater
* Fixed Few Errors With Plugin Installer
* Fixed Few Errors With Downloader.cs
* Fixed Per-Server Saving Issue
* Fixed Issue With Plugin Management Button Being Active After Server Launch
* Fixed Issue With Not Setting Difficulty
* Changed Server ID Managing
* Removed Github File Rocket_Latest.zip - Changed To Rocket Direct Download Link

**V3.0.0.2** - 

* Fixed An Error With The Versions.dat File

**V3.0.0.1** - 

* Fixed An Error When Launching The Updater Tool
* Fixed A Bug Returning An Exception When Loading The Plugin Installer Without The PI Files.
* Added A Loop To Check If Rocket Is Installed, If It Isn't Plugin Install Is Disabled.

**V3.0.0.0** - 

* Fixed Issue With Gold Mode
* Fixed Rocket Installation Freezing
* Fixed Rocket Updating
* Fixed/Added Ease of install for plugins
* Fixed Bug With Workshop Item IDs Not Displaying
* Fixed Per-Server SRS
* Added Full Updater
* Added Plugin Integrity files to include downloads and web pages to working plugins and their names
* Added System Tray Icon
* Added Local Server Configuration Files
* Added Button To Open Selected Workshop Items In Browser.
* Disabled Unturned Updating For A Future, Much Better Update.
* Removed Rocket Updating Animation
* Removed Global SRS
* Removed Rocket Libraries
* Changed User Interface
* Changed Max servers from 4 to 100
* Changed USM.lock file position
* Changed Per-Server SRS Limiters
* Changed Self-Version Checking Feature To The Full Updater + Notification
* Changed USM Configuration File

**V2.0.1.0** - 

* Changed how Rocket Install works due to rocket changing their builds and how they function. (Fully explained here: https://rocketmod.net/viewtopic.php?f=44&t=2961)
* Added small self-version checking feature. Will be improved in expected 3.0.0.0 release.

**V2.0.0.0** - 

* Added link to reddit post
* Fixed SRS (Shutdown, restart and start) buttons to apply to the servers that the program started only.
* Added Rocket Install, Workshop Install and Plugin Install (Plugin install is buggy!)
* Added Per-Server SRS Features

**V1.0.0.1** - Added link to github page.

----------- Unturned Server Manager -----------
