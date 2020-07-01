namespace GenericsConcept
{
    internal class OperationResult<T>
    {
        public OperationResult(T result, string message)
        {
            Result = result;
            Message = message;
        }

        public T Result { get; set; }
        public string Message { get; set; }
    }
}