using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PlatformService.Model;

namespace PlatformService.Data
{
    public interface IPlatformRepo
    {   bool SaveChanges();
        IEnumerable<Platform> GetAllPlatforms();
        Platform GetPlatformById( int id);
        void CreatePlatform (Platform platform);
    }
}