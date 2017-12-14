using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Tests
{
    public static class Pages
    {
        public static class HomePage
        {
            static string Url = "http://www.google.com";
            static string PageTitle = "SEIS - Special Education Information System";

            public static void Goto()
            {
                Browser.Goto(Url);
            }

            public static bool IsAt()
            {
                if (Browser.Title == PageTitle)
                {
                    return true;
                }

                else
                {
                    return false;
                } ;
            }
        }
    }
}