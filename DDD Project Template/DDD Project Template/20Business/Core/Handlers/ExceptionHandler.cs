using $ext_safeprojectname$.Domain.Contracts.Handlers;
using $ext_safeprojectname$.Domain.Contracts.Repositories;
using System;

namespace $ext_safeprojectname$.$safeprojectname$.Handlers
{
    public class ExceptionHandler : IExceptionHandler
    {
        private readonly ILogger _logger;

        public ExceptionHandler(ILogger logger)
        {
            _logger = logger;
        }

        public T FromUnsafeFunction<T>(Func<T> unsafeFunction)
        {
            try
            {
                return unsafeFunction.Invoke();
            }
            catch(Exception ex)
            {
                _logger.LogException(ex);
            }
            return default(T);
        }
    }
}
