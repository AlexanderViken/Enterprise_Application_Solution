using System;
using $ext_safeprojectname$.Domain.Contracts.Repositories;
#if DEBUG
using System.Diagnostics;
#endif

namespace $safeprojectname$.Repositories
{
    public class NoLogger : ILogger
    {
        public void LogException(Exception ex)
        {
            #if DEBUG
            Debug.WriteLine(ex.Message);
            #endif
        }

    }
}
