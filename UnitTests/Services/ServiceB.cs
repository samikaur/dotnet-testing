using System;

namespace UnitTests.Services
{
    public class ServiceB : IServiceB
    {
        public int GetValue(int maxNumber)
        {
            var rnd = new Random();
            return rnd.Next(maxNumber);
        }
    }
}
