using System;
using SecurePass.iOS.Services;
using SecurePass.Shared;
using Xamarin.Forms;

[assembly: Dependency(typeof(AccessService))]
namespace SecurePass.iOS.Services
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