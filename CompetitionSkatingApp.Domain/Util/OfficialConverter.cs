using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using CompetitionSkatingApp.Domain.Interfaces;

namespace CompetitionSkatingApp.Domain.Util
{
    public class OfficialConverter : JsonConverter<IOfficial>
    {
        public override IOfficial Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using (JsonDocument doc = JsonDocument.ParseValue(ref reader))
            {
                JsonElement root = doc.RootElement;

                if (root.TryGetProperty("type", out JsonElement typeElement))
                {
                    string type = typeElement.GetString();
                    switch (type)
                    {
                        case "Adjudicator":
                            return JsonSerializer.Deserialize<Adjudicator>(root.GetRawText(), options);
                            //TODO FIX THE CHAIRMANS/ CHAIRPERSONS PROBLEM
                        case "Chairperson":
                            return JsonSerializer.Deserialize<Chairman>(root.GetRawText(), options);
                        default:
                            throw new JsonException($"Unknown IOfficial type: {type}");
                    }
                }
                else
                {
                    throw new JsonException("Missing type discriminator property.");
                }
            }
        }

        public override void Write(Utf8JsonWriter writer, IOfficial value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, options);
        }
    }
}
