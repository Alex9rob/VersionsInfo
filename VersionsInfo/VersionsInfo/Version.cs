using Xamarin.Forms;

namespace VersionsInfo
{
    public class Version
    {
        public string VersionNumber { get; set; }
        public string CodeName { get; set; }
        public string Api { get; set; }
        public string Date { get; set; }
        public ImageSource ImagePath { get; set; }
        public string Description { get; set; }

        public Version(string versionNumber, string codeName, string api, string date, ImageSource imagePath, string description)
        {
            VersionNumber = versionNumber;
            CodeName = codeName;
            Api = api;
            Date = date;
            ImagePath = imagePath;
            Description = description;
        }
    }
}
