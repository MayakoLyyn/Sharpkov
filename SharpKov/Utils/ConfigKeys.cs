﻿using System;
using System.Collections.Generic;
using System.Text;
// ReSharper disable InconsistentNaming

namespace SharpKov.Utils
{
    public static class ConfigKeys
    {
        // Auth
        public static readonly string Auth_ConsumerKey          = "Auth:ConsumerKey";
        public static readonly string Auth_ConsumerSecret       = "Auth:ConsumerSecret";
        public static readonly string Auth_AccessToken          = "Auth:AccessToken";
        public static readonly string Auth_AccessSecret         = "Auth:AccessSecret";

        // Preferences
        public static readonly string Preferences_Local         = "Preferences:Local";
        public static readonly string Preferences_ForceLastWord = "Preferences:ForceLastWord";
        public static readonly string Preferences_Logging       = "Preferences:Logging";
        public static readonly string Preferences_TestMode      = "Preferences:TestMode";
    }
}
