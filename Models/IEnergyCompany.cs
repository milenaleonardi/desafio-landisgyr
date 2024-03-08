namespace DesafioEntrevistaTecnica.API.Models
{
    internal interface IEnergyCompany
    {
        string EndpointSerialNumber { get; set; }
        int MeterModelId { get; }
        int MeterNumber { get; set; }
        string MeterFirmwareVersion { get; set; }
        int SwitchState { get; set; }
    }
}
