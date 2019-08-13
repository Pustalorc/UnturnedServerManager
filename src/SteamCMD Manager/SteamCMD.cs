﻿using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using Pustalorc.Applications.USM.Configuration;
using Pustalorc.Applications.USM.File_Control;

namespace Pustalorc.Applications.USM.SteamCMD_Manager
{
    internal static class SteamCmd
    {
        /// <summary>
        ///     Link to official steam download for SteamCMD.
        /// </summary>
        private static string DownloadLink => "https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip";

        /// <summary>
        ///     Runs a command directly into SteamCMD.
        /// </summary>
        /// <param name="command">
        ///     The command to be run by SteamCMD. Must be a string such as if you were running SteamCMD.exe from
        ///     console yourself excluding username + password.
        /// </param>
        public static void RunCommand(string command)
        {
            VerifySteam();

            var inst = Installation.Load();
            var steamCmdExe = Path.Combine(inst.InstallationPath, "steamcmd.exe");

            var proc = new Process();

            var startInfo = new ProcessStartInfo {FileName = steamCmdExe, Arguments = $" +login anonymous {command}"};

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                startInfo = new ProcessStartInfo
                    {FileName = "/bin/bash", Arguments = $"steamcmd +login anonymous {command}"};

            proc.StartInfo = startInfo;
            proc.Start();
            proc.WaitForExit();
        }

        /// <summary>
        ///     Moves a downloaded workshop folder.
        /// </summary>
        /// <param name="id">The ID of the workshop folder.</param>
        /// <param name="directoryDestination">The destination for the workshop folder.</param>
        public static void MoveWorkshopFolder(string id, string directoryDestination)
        {
            var inst = Installation.Load();
            var workshopDir = Path.Combine(inst.InstallationPath, "steamapps", "workshop", "content", "304930", id);
            var mapMeta = Path.Combine(workshopDir, "Map.meta");
            var mapsDir = Path.Combine(directoryDestination, "Maps", id);
            var contentDir = Path.Combine(directoryDestination, "Content", id);

            FileActions.CopyDirectory(workshopDir, FileActions.VerifyFile(mapMeta) ? mapsDir : contentDir);
        }

        /// <summary>
        ///     Verifies that SteamCMD is present in the installation. Should be called before running SteamCMD.exe or doing
        ///     anything with SteamCMD.
        /// </summary>
        private static void VerifySteam()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) return;

            var inst = Installation.Load();
            var steamCmdExe = Path.Combine(inst.InstallationPath, "steamcmd.exe");

            try
            {
                if (FileActions.VerifyFile(steamCmdExe)) return;

                var zipTarget = Path.Combine(Path.GetTempPath(), Path.GetTempFileName());
                FileActions.Download(DownloadLink, zipTarget);
                FileActions.ExtractZip(zipTarget, inst.InstallationPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}