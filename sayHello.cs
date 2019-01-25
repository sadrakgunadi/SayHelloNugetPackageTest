using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SayHello
{
    /// <summary>
    /// Say Hello Portable Library Test
    /// </summary>
    public static class sayHello
    {
        /// <summary>
        /// Method Test
        /// </summary>
        /// <param name="yourName">your name</param>
        /// <returns></returns>
        public static string Hi(string yourName)
        {
            return $"Hi, {yourName}";
        }
    }
}
