using System;
namespace $ext_safeprojectname$.$safeprojectname$.Contracts.Handlers
{
    public interface IExceptionHandler
    {
        T FromUnsafeFunction<T>(Func<T> unsafeFunction);
    }
}
