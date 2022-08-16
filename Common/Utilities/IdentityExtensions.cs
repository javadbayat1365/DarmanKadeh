using Common.Utilities;
using System;
using System.Globalization;
using System.Security.Claims;
using System.Security.Principal;

namespace Common
{
    public static class IdentityExtensions
    {
        public static string FindFirstValue(this ClaimsIdentity identity, string claimType)
        {
            return identity?.FindFirst(claimType)?.Value;
        }
    }
}
