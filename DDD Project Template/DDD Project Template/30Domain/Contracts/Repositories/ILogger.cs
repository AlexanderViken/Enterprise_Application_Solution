using System;

namespace $ext_safeprojectname$.$safeprojectname$.Contracts.Repositories
{
    public interface ILogger
    {
        void LogException(Exception ex);
    }
}
