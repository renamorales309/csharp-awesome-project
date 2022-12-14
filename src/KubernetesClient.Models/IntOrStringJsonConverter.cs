namespace k8s.Models
{
    internal sealed class IntOrStringJsonConverter : JsonConverter<IntstrIntOrString>
    {
        public override IntstrIntOrString Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.String:
                    return reader.GetString();
                case JsonTokenType.Number:
                    return reader.GetInt64();
                default:
                    break;
            }

            throw new NotSupportedException();
        }

        public override void Write(Utf8JsonWriter writer, IntstrIntOrString value, JsonSerializerOptions options)
        {
            if (writer == null)
            {
                throw new ArgumentNullException(nameof(writer));
            }

            var s = value?.Value;

            if (long.TryParse(s, out var intv))
            {
                writer.WriteNumberValue(intv);
                return;
            }

            writer.WriteStringValue(s);
        }
    }
}
