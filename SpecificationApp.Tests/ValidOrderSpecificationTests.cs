namespace SpecificationApp.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    [TestClass]
    public class ValidOrderSpecificationTests
    {
        [TestMethod]
        public void IsSatisfiedBy_IfOrderIsValid_ReturnsTrue()
        {
            // Arrange
            bool result;
            var specification = new ValidOrderSpecification();
            ICollection<string> errors = new List<string>();
            OrderRequest orderRequest = new OrderRequest { SenderName = "Bryan", SenderEmail = "bryan@gmail.com", SenderContactNumber = "09997995864" };

            // Act
            result = specification.IsSatisfiedBy(orderRequest, ref errors);

            // Assert
            Assert.IsTrue(result);
        }
    }
}