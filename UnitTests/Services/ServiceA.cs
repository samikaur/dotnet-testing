namespace UnitTests.Services
{
    public class ServiceA : IServiceA
    {
        private readonly IServiceB _serviceB;

        public ServiceA(IServiceB serviceB)
        {
            _serviceB = serviceB;
        }

        public int SumServiceBAndParamterValue(int maxNumber, int anotherNumber)
        {
            return _serviceB.GetValue(maxNumber) + anotherNumber;
        }
    }
}
