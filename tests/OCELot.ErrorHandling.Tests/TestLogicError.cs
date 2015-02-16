namespace OCELot.ErrorHandling.Tests
{
    public class TestLogicError : LogicError
    {
        public TestLogicError()
            :base("this is just a test")
        {
        }

        public TestLogicError(string message) 
            : base(message)
        {
        }
    }
}