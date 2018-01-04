namespace VersionsInfo
{
    public class Version
    {
        public string CodeName { get; set; }
        public string VersionNumber { get; set; }
        public string Description { get; set; }

        public Version(string codeName, string versionNumber, string description)
        {
            CodeName = codeName;
            VersionNumber = versionNumber;
            Description = description;
        }
    }
}
