using DesafioEntrevistaTecnica.API.MenuOptions;
using DesafioEntrevistaTecnica.API.Models;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace DesafioEntrevistaTecnica.UnitTests.MenuOptions
{
    // Install - Package NUnit
    // Install-Package NUnit3TestAdapter

    [TestFixture]
    public class FindByEnergyCompanyEndpointSerialNumberTests
    {
        [Test]
        public void FindEndpointBySerialNumber_ExistingEndpoint_ShouldDisplayEndpointDetails()
        {
            // Arrange
            string endpointSerialNumber = "ABC123";
            List<EnergyCompany> endpoints = new List<EnergyCompany>
            {
                new EnergyCompany(endpointSerialNumber, "NSX1P2W", 12345, "1.0", "Connected")
            };

            // Mock user input/output
            Console.SetIn(new StringReader(endpointSerialNumber));
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            FindByEnergyCompanyEndpointSerialNumber.FindEndpointBySerialNumber(endpoints);

            // Assert
            StringAssert.Contains($"Endpoint Serial Number: {endpointSerialNumber}", consoleOutput.ToString());
        }

        [Test]
        public void FindEndpointBySerialNumber_NonExistingEndpoint_ShouldThrowException()
        {
            // Arrange
            string endpointSerialNumber = "XYZ456";
            List<EnergyCompany> endpoints = new List<EnergyCompany>
            {
                new EnergyCompany("ABC123", "NSX1P2W", 12345, "1.0", "Connected")
            };

            // Mock user input/output
            Console.SetIn(new StringReader(endpointSerialNumber));

            // Act & Assert
            Assert.Throws<Exception>(() => FindByEnergyCompanyEndpointSerialNumber.FindEndpointBySerialNumber(endpoints));
        }
    }
}
