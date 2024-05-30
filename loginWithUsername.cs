using System;
using System.Security.Cryptography.X509Certificates;

public static class AuthenticateUsers
{
    public const String UName = "Aravindan";
    public const String PWD = "Kaiv";
    public const String UID = "akaiv";
    public static bool AuthenticateUser(String username, String password)
    {
        if (username != UName && password != PWD)
        {
            return false;
        }
        else 
        { 
            return true; 
        }
    }
}
