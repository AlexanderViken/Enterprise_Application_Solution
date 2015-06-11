using System;

namespace $safeprojectname$.Contracts.Repositories
{
    public interface ILogger
    {
        void LogException(Exception ex);
    }
}
