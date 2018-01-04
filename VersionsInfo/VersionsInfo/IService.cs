using System.Collections.Generic;

namespace VersionsInfo
{
    public interface IService
    {
        List<Version> GetVersionsAndroid();
    }
}