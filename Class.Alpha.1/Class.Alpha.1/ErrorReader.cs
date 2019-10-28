using System;

namespace Class.Alpha._1
{
    public static class ErrorReader
    {
        public static string Read(int error)
        {
            switch (error)
            {
                case 0:
                    return "Default";
                case -1:
                    return "No Valid Connection";
                case 1:
                    return "Your Input Number is Not in Valid Range";
                case 2:
                    return "There is no Matching Id or Password Exists";
                default:
                    return string.Empty;
            }
        }
    }

    public enum Errors
    {
        Default = 0,
        NoConnection = -1,
        TooLongOrTooShort = 1,
        NotMatch = 2,
    }
}