using System;
using System.IO;
using ListView.Data;
using ListView.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileHelperTwoIOS))]
namespace ListView.iOS
{
    public class FileHelperTwoIOS : IFileHelperTwo
    {
        public string getPath()
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");
            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }
            return Path.Combine(libFolder, "PersonSQlite.db3");
        }
    }
}
