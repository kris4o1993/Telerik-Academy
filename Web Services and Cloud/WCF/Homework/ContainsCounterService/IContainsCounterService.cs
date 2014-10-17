namespace ContainsCounterService
{
    using System.ServiceModel;
    
    [ServiceContract]
    public interface IContainsCounterService
    {
        [OperationContract]
        int ContainsCounter(string first, string second);
    }
}
