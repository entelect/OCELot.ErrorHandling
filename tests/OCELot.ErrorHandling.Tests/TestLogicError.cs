namespace OCELot.ErrorHandling.Tests
{
    public class TestLogicError : LogicError
    {
        public TestLogicError()
            :base(string.Empty)
        {
        }

        public TestLogicError(string message) 
            : base(message)
        {
        }
    }
}