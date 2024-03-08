namespace DesafioEntrevistaTecnica.API.Models
{
    internal class EnergyCompany : IEnergyCompany
    {

        // EnergyCompanyConstructor
        public EnergyCompany(string serialNumber, string meterModel, int meterNumber, string meterFirmwareVersion, string state)
        {
            EndpointSerialNumber = serialNumber;
            MeterModelId = SetMeterModelId(meterModel);
            MeterNumber = meterNumber;
            MeterFirmwareVersion = meterFirmwareVersion;
            SwitchState = SetSwitchState(state);
        }

        // EnergyCompany Attributes
        public string EndpointSerialNumber { get; set; }
        public int MeterModelId { get; }
        public int MeterNumber { get; set; }
        public string MeterFirmwareVersion { get; set; }
        public int SwitchState { get; set; }

        // Default values for MeterModelId based on meterModel
        public static int SetMeterModelId(string meterModel)
        {
            switch (meterModel)
            {
                case "NSX1P2W": return 16;
                case "NSX1P3W": return 17;
                case "NSX2P3W": return 18;
                case "NSX3P4W": return 19;
                default: throw new Exception("Invalid Meter Model: " + meterModel);
            }
        }

        // Default values for SwitchState based on state
        public static int SetSwitchState(string state)
        {
            switch (state)
            {
                case "Disconnected": return 0;
                case "Connected": return 1;
                case "Armed": return 2;
                default: throw new Exception("Invalid Switch State: " + state);
            }
        }
    }
}
