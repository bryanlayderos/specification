namespace SpecificationApp.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    [TestClass]
    public class ValidEmailSpecificationTests
    {
        [TestMethod]
        public void IsSatisfiedBy_IfEmailIsValid_ReturnsTrue()
        {
            // Arrange
            bool result;
            var specification = new ValidEmailSpecification();
            ICollection<string> errors = new List<string>();
            OrderRequest orderRequest = new OrderRequest { SenderEmail = "test@gmail.com" };

            // Act
            result = specification.IsSatisfiedBy(orderRequest, ref errors);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
