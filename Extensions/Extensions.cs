using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;

namespace AutosExchange.Extensions
{
    public static class IdentityExtensions
    {
        public static string GetName(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("Name");
            // Test for null to avoid issues during local testing
            return (claim != null) ? claim.Value : string.Empty;
        }

        public static string GetPhoneNumber(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("PhoneNumber");
            // Test for null to avoid issues during local testing
            return (claim != null) ? claim.Value : string.Empty;
        }

        public static string GetAddress(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("Address");
            // Test for null to avoid issues during local testing
            return (claim != null) ? claim.Value : string.Empty;
        }

        public static string GetCity(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("City");
            // Test for null to avoid issues during local testing
            return (claim != null) ? claim.Value : string.Empty;
        }

        public static string GetProvince(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("Province");
            // Test for null to avoid issues during local testing
            return (claim != null) ? claim.Value : string.Empty;
        }

        public static string GetWebsite(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("Website");
            // Test for null to avoid issues during local testing
            return (claim != null) ? claim.Value : string.Empty;
        }

    }
}