using System;
using System.Collections.Generic;
using System.Text;

namespace VersionsInfo
{
    public class MockService:IService
    {
        private readonly List<Version> _versionsAndroid;

        public MockService()
        {
            _versionsAndroid = new List<Version>
            {
                new Version("Cupcake", "1.5", "April 27, 2009" ),
                new Version("Donut", "1.6", "September 15, 2009")
            };
        }
        public List<Version> GetVersionsAndroid()
        {
            return _versionsAndroid;
        }
    }
}
