using NUnit.Framework;

namespace OCELot.ErrorHandling.Tests
{
    [TestFixture]
    public class ArgumentNullErrorTests
    {
        private const string ParameterName = "Potato";

        [Test]
        public void CanCreateArgumentNullError()
        {
            var argumentNullError = new ArgumentNullError(ParameterName);
            StringAssert.Contains(ParameterName, argumentNullError.Message);
        }
    }
}