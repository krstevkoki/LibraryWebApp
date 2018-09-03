using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryWebApp.Models
{
    public static class Roles
    {
        public const string Admin = "Admin";
        public const string Staff = "Staff";
        public const string Member = "Member";
        public const string User = "User";

        public static int Count => ExportToList().Count;

        public static List<string> ExportToList()
        {
            return new List<string> {Roles.Admin, Roles.Staff, Roles.Member, Roles.User};
        }

        public static string[] ExportToArray()
        {
            return ExportToList().ToArray();
        }
    }
}