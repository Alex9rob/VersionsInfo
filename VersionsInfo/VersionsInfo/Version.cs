using Xamarin.Forms;

namespace VersionsInfo
{
    public class Version
    {
        public string CodeName { get; set; }
        public string VersionNumber { get; set; }
        public string Description { get; set; }
        public ImageSource ImageUrl { get; set; }

        public Version(string versionNumber, string codeName, string description)
        {
            VersionNumber = versionNumber;
            CodeName = codeName;
            Description = description;
        }
    }
}
