namespace OCELot.ErrorHandling.Tests
{
    public class TestLogicError : LogicError
    {
        public TestLogicError()
        {
        }

        public TestLogicError(string message) 
            : base(message)
        {
        }
    }
}