using System;
using SecurePass.Droid.Services;
using SecurePass.Shared;
using Xamarin.Forms;

[assembly: Dependency(typeof(AccessService))]
namespace SecurePass.Droid.Services
{
    public class AccessService : IAccessService
    {

        public static string Code { get; set; } = String.Empty;

        public void setCode(string code)
        {
            Code = code;
        }
    }
}