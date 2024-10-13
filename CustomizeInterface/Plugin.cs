using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Reflection;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace Customizer
{
    // Do not forget to update version number and author (company attribute) in AssemblyInfo.cs class
    // To generate Base64 string for Images below, you can use https://www.base64-image.de/
    [Export(typeof(IXrmToolBoxPlugin)),
        ExportMetadata("Name", "Theme Customizer"),
        ExportMetadata("Description", "Tool to help to create or update custom theme on the new interface of Dynamics 365"),
        // Please specify the base64 content of a 32x32 pixels image
        ExportMetadata("SmallImageBase64", "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAACXBIWXMAAAsTAAALEwEAmpwYAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAHISURBVHgB7VXtUcJAEH35KAA7iB1ABcYOoAKxAuS/SjI2gBUAFYgVSAemA+jA/HaE891dMB9cBpIw+CdvJjO5y+7bt5fdPaBFixb/DGv/IgJ42MI/1REOVlaAjekTuTr4Jp+Drt6gnYuI9rFRgHhEn8ZvqIodxtYLprnAO4zI+sBlx+Ax57cwK9xOshmhDuzUj8G7zPSTAYKS4BJD2qzFMyYphUaMeoiT4B6JP/jqneRFkeJJnVIigMeCOiK0H5LgpqwjPisjt61PwVU8ASJm0UM2A4EZ8hnFDDjIksuiYiZDHGa+pO19tujIH5BzUhCXdkERYoJ1gXhjhbg22Mns/ZywUCVzyKl/VR868lwKdNEcfm61xbjMMKn+aXbPRgOotivC1Ud7KhoJOAcaCUiKLF/hW1WUlxGgIPBeYBypYjOZcgDJolVPoMd08yK0OV4F7jI7aiixPUNO2KXa+WEwR7Wgn6pR3XPV+AT4G1Ykey1sexQ24/6XepyDVpWItf5zwFbzv0r1y6F2q13LsTmy/oMqRkkosMBxRLTt7W/E8kmYv2Ck06Ds/i/4+bySh7S/QTpJ44RjQY45qsA4bCr4NvFv0aLFRfALBZeSAkrDu0kAAAAASUVORK5CYII="),
        // Please specify the base64 content of a 80x80 pixels image
        ExportMetadata("BigImageBase64", "iVBORw0KGgoAAAANSUhEUgAAAFAAAABQCAYAAACOEfKtAAAACXBIWXMAAAsTAAALEwEAmpwYAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAQ5SURBVHgB7ZrRWdswEMf/cug7I7gTFCaoOwHZoOkEpe9QHDoAMEHDBNAJcCdoOkHdCZrHPhTUu4sS7ITEVhxime9+3+cvTiLb0t/S6XQ6QFEURVEURVEURVEURVEURVGUDmCe+tGeIEEPZ3R6QMc+dseEjoxq9cmkyNEAmyLGPfqI8AaP7YgLRXJ3jKncd+xhvMkzlwS0QxLuASnaJsLAnOHa5xISbZ/q/pFaldDXBP5kdP21+YJR3QtKAtpTDKjiXxEGE6rdYZ1eURDuGNsZMTndb1hHyGjh23uEA4tyXFVIzI3FDxIvxfbMTcwdyZ7hTkzBGqKF7wlCwoj9WomYmx7ugPWNbAC/nDt6Sf1VBSJ0FOodFzuy1TG9pBv7WSbVJTopoIiH6uG9VchE0Byx9MxFAScIHBm2uxZvRoQLsbmln8qMERKm7MaILWrbxeLhXJhYygKSA4twyMF+mUMq3ZOh2zYl76AkIPlcYxLxA9onp3q8K/mAVoZuDH+mqxtQ53igttF95dNiiMIL8sLg6PH0CeRts8oVbgSmDYpRHzYR6+wsO88/6fOSxJuU6mPxC37wva4W77WIa2tKZX184LEZ4pBPDBpAU/vI68GvEJsT/IYnNOvy6mjgcclyD656Rkr3t2Iiqp1xGqV07xGfdsWNSTzKeovHiCA8vFFxncXVTDxmD4HjVgFxzeKTTcSbwXMA9UQWkVcgbOf25/e1NHIi3NLQzYrXBC8gzbxHHqWHTcNg7vqROyrpwhA+qFkup95xiR3zkgTM0AJBC1gVSipx7xd83Rah98D68b29dtbxL0nAP2iB0AUMPjr0cgT8i9dogaAF9PLpona2I7rgxuS1Shkvh3trhC+gpU3vehwsRot3QfhLOSuZCvUiPj3aikxlL7nR5CMvwpADbwpegKWR0EO2aFa6sBa+rR1mgsQNb+jzHTbAxR05dJYs/cmBPyshvNScSzBWCH4Iu96UeVySUPzwxmsVg7l4vMecrC3Iu3MFU9GNeOA0suxDXzbET6uDsJwWInu+nN1QN2zWe9wjDn8IQ3phRr0qg19gdZaewY29pbXyN2ptPv/3H9m4Ht6ScIOSrat7b0cnBBSMbARxL9mkscck1jHbsDk9NCGfnXQmM8HNfkOEQGHnslOpHRIwte2ErebYctS7e7kxkWxqt5NBweKdlzMjOieguDXT3bPdiviEeEwns7PmIu5qOK8Qj2kmoPHqBZNNNtVXPppEpEYNAMnnea644XSP+Xx1QlNTAUeoW/ln6i0ysRgcbvn+3MOHLkc7W1ewUWoHQ44qG/WqrKncVeZZI8wb5rkUqZVPU6SxgAxVvO8W/DEaVmhL9WFnOyEx+y5BatXWKNcpl5AZZx2k/lujWxFwhqv4rLI52O6lYexruODCvjty/q1pFoOiKIqiKIqiKIqiKIqiKIqiKJ3hPwgfQjxc0DpaAAAAAElFTkSuQmCC"),
        ExportMetadata("BackgroundColor", "#2f8de8"),
        ExportMetadata("PrimaryFontColor", "#000000"),
        ExportMetadata("SecondaryFontColor", "#252525")]
    public class Plugin : PluginBase
    {
        public override IXrmToolBoxPluginControl GetControl()
        {
            return new ThemeCustomizer();
        }

        /// <summary>
        /// Constructor 
        /// </summary>
        public Plugin()
        {
            // If you have external assemblies that you need to load, uncomment the following to 
            // hook into the event that will fire when an Assembly fails to resolve
            // AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(AssemblyResolveEventHandler);
        }

        /// <summary>
        /// Event fired by CLR when an assembly reference fails to load
        /// Assumes that related assemblies will be loaded from a subfolder named the same as the Plugin
        /// For example, a folder named Sample.XrmToolBox.MyPlugin 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        private Assembly AssemblyResolveEventHandler(object sender, ResolveEventArgs args)
        {
            Assembly loadAssembly = null;
            Assembly currAssembly = Assembly.GetExecutingAssembly();

            // base name of the assembly that failed to resolve
            var argName = args.Name.Substring(0, args.Name.IndexOf(","));

            // check to see if the failing assembly is one that we reference.
            List<AssemblyName> refAssemblies = currAssembly.GetReferencedAssemblies().ToList();
            var refAssembly = refAssemblies.Where(a => a.Name == argName).FirstOrDefault();

            // if the current unresolved assembly is referenced by our plugin, attempt to load
            if (refAssembly != null)
            {
                // load from the path to this plugin assembly, not host executable
                string dir = Path.GetDirectoryName(currAssembly.Location).ToLower();
                string folder = Path.GetFileNameWithoutExtension(currAssembly.Location);
                dir = Path.Combine(dir, folder);

                var assmbPath = Path.Combine(dir, $"{argName}.dll");

                if (File.Exists(assmbPath))
                {
                    loadAssembly = Assembly.LoadFrom(assmbPath);
                }
                else
                {
                    throw new FileNotFoundException($"Unable to locate dependency: {assmbPath}");
                }
            }

            return loadAssembly;
        }
    }
}