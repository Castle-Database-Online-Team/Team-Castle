namespace GsmFactory.CommonResources
{
    using System.IO;
    using System.Linq;

    public static class Helper
    {
        public static void CreateDirectoryIfUnexistant(string directory)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }

        public static string AddExtention(string directory,string extention)
        {
            var segments = directory.Split(new char[] {'\\'});
            if (segments[segments.Count()-1]!=extention)
            {
                directory += "\\"+extention;
            }
            return directory;
        }
    }
}