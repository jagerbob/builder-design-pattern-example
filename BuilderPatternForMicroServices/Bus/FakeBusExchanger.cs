using Common.Model;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Common.Bus;

public class FakeBusExchanger
{
    private readonly string _fakeBusPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "BuilderPatternFakeBus");

    public FakeBusExchanger()
    {
        Directory.CreateDirectory(_fakeBusPath);
    }

    public void Send<DataFormat>(DataFormat data)
    {
        switch (data)
        {
            case XMLEventMessage xmlData: XMLSend(xmlData); break;
            case JsonEventMessage jsonData: JSONSend(jsonData); break;
            default: throw new ArgumentException($"Format \"{data?.GetType()?.Name}\" is currently not handled by the bus");
        }
    }

    private void XMLSend(XMLEventMessage message)
    {
        using var fs = File.Create(Path.Combine(_fakeBusPath, $"{DateTime.Now:yyyy-dd-M-HH-mm-ss}-{Guid.NewGuid()}.xml"));
        new System.Xml.Serialization.XmlSerializer(typeof(XMLEventMessage)).Serialize(fs, message);
    }

    private void JSONSend(JsonEventMessage message)
    {
        using var fs = File.Create(Path.Combine(_fakeBusPath, $"{DateTime.Now:yyyy-dd-M-HH-mm-ss}-{Guid.NewGuid()}.json"));
        JsonSerializer.Serialize(fs, message, new JsonSerializerOptions { WriteIndented = true });
    }
}
