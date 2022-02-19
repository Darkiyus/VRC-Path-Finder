# VRC-Path-Finder
A small DLL to include to find the VRChat location.

# Intended use
You can use this for example to install your mod automatically in the VRC folder without the annoying "select your VRC.exe".

# What exactly does that do?
It returns you as string the VRChat folder.

# How do I use it?
1. include the VRCPathFinder.dll in your project.

            right click on your project -> add -> project reference -> browse -> select VRCPathFinder.dll -> ok
            
2. specify VRCPathFinder as namespace
            
       using VRCPathFinder;
3. call the function

       VRCPath.Search();
      
# Example
In this example we download an image from the Internet and save it to the VRC Mod folder

    using VRCPathFinder; //my Pathfinder (IMPORTANT)
    using System.Net; //Download Files
    class Example
    {
        public static void Main()
        {

            string vrcPath = VRCPath.Search(); //Stores the VRC location in the string "vrcpath".
            string vrcModPath = vrcPath + "\\Mods"; //Add the modfolder to the string, so that we end up with the modfolder.

            WebClient webClient = new WebClient(); //Create a WebClient instance.
            webClient.DownloadFile("https://cdnb.artstation.com/p/assets/images/images/000/115/039/large/tom-edwards-the-grim-reaper-by-tomedwardsconcepts.jpg", vrcModPath + "\\Reaper.jpg" ); // Pulls a reaper image from the Internet and saves it to the VRC Mod Folder as "Reaper.jpg"

        }
    }
