namespace SpecificationApp.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    [TestClass]
    public class ValidNameSpecificationTests
    {
        [TestMethod]
        public void IsSatisfiedBy_IfNameIsValid_ReturnsTrue()
        {
            // Arrange
            bool result;
            var specification = new ValidNameSpecification();
            ICollection<string> errors = new List<string>();
            OrderRequest orderRequest = new OrderRequest{ SenderName = "Bryan" };

            // Act
            result = specification.IsSatisfiedBy(orderRequest, ref errors);

            // Assert
            Assert.IsTrue(result);
        }
    }
}