using System;
namespace $safeprojectname$.Contracts.Handlers
{
    public interface IExceptionHandler
    {
        T FromUnsafeFunction<T>(Func<T> unsafeFunction);
    }
}
