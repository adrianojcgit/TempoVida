namespace TempoVida.Services
{
    public class Operation : IOperationTransient, IOperationScoped, IOperationSingleton
    {
        public string OperationId { get; set; }
        public Operation()
        {
                OperationId = Guid.NewGuid().ToString();
        }
    }
}
