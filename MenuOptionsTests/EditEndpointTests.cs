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
            List<EnergyCompany> endpoints = new List<EnergyCompany>
            {
                new EnergyCompany("ABC123", "NSX1P2W", 12345, "1.0", "Connected")
            };

            // Mock user input/output
            var consoleInput = new StringReader("ABC123\nDisconnected\n");
            Console.SetIn(consoleInput);

            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            EditEnergyCompanyEndpoint.EditEndpoint(endpoints);

            // Assert
            var editedEndpoint = endpoints.Find(endpoint => endpoint.EndpointSerialNumber == "ABC123");
            Assert.AreEqual(1, editedEndpoint.SwitchState);
            StringAssert.Contains($"\nEndpoint was edited to Disconnected with success.", consoleOutput.ToString());
        }


        [Test]
        public void EditEndpoint_NonExistingEndpoint_ShouldThrowException()
        {
            // Arrange
            List<EnergyCompany> endpoints = new List<EnergyCompany>
            {
                new EnergyCompany("ABC123", "NSX1P2W", 12345, "1.0", "Connected")
            };

            // Mock user input/output
            Console.SetIn(new StringReader("XYZ456\nDisconnected\n"));

            // Act & Assert
            Assert.Throws<Exception>(() => EditEnergyCompanyEndpoint.EditEndpoint(endpoints));
        }

    }
}
