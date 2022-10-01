using Common.Builder;

namespace SolutionWithFluentBuilderAndRelatedFactoryPattern
{
    public static class FluentEventMessageBuilderFactory
    {
        public static IFluentEventMessageBuilder Create(string type)
            => type.ToUpper() switch
            {
                "JSON" => new FluentJSONEventMessageBuilder(),
                // "XML" => new FluentXMLEventMessageBuilder(),
                _ => throw new ArgumentException("Invalid type")
            };
    }
}
