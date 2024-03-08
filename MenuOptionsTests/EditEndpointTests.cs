using DesafioEntrevistaTecnica.API.Models;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace DesafioEntrevistaTecnica.API.MenuOptions
{
    // Install - Package NUnit
    // Install-Package NUnit3TestAdapter

    [TestFixture]
    public class EditEnergyCompanyEndpointTests
    {
        [Test]
        public void EditEndpoint_ExistingEndpoint_ShouldEditSwitchState()
        {
            // Arrange
            string endpointSerialNumber = "ABC123";
            List<EnergyCompany> endpoints = new List<EnergyCompany>
            {
                new EnergyCompany(endpointSerialNumber, "NSX1P2W", 12345, "1.0", "Connected")
            };

            // Mock user input/output

            // Provide Endpoint Serial Number 
            Console.SetIn(new StringReader(endpointSerialNumber));
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            // Provide new value for State
            Console.SetIn(new StringReader("Disconnected"));
            var consoleNewValueOutput = new StringWriter();
            Console.SetOut(consoleNewValueOutput);

            // Act
            EditEnergyCompanyEndpoint.EditEndpoint(endpoints);

            // Assert
            StringAssert.Contains($"Endpoint Serial Number: {endpointSerialNumber}", consoleOutput.ToString());

        }

        [Test]
        public void EditEndpoint_NonExistingEndpoint_ShouldThrowException()
        {
            // Arrange
            string endpointSerialNumber = "XYZ456";
            List<EnergyCompany> endpoints = new List<EnergyCompany>
            {
                new EnergyCompany("ABC123", "NSX1P2W", 12345, "1.0", "Connected")
            };

            // Mock user input/output
            Console.SetIn(new StringReader(endpointSerialNumber));
            Console.SetIn(new StringReader("Disconnected"));

            // Act & Assert
            Assert.Throws<Exception>(() => EditEnergyCompanyEndpoint.EditEndpoint(endpoints));
        }

        [Test]
        public void EditEndpoint_ExistingEndpoint_StateValueException()
        {
            // Arrange
            string endpointSerialNumber = "ABC123";
            List<EnergyCompany> endpoints = new List<EnergyCompany>
            {
                new EnergyCompany("ABC123", "NSX1P2W", 12345, "1.0", "Connected")
            };

            // Mock user input/output
            Console.SetIn(new StringReader(endpointSerialNumber));
            Console.SetIn(new StringReader("Other value"));

            // Act & Assert
            Assert.Throws<Exception>(() => EditEnergyCompanyEndpoint.EditEndpoint(endpoints));
        }
    }
}
