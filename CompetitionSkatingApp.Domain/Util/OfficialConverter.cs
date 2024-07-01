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

                // Access eventTeam element directly
                JsonElement eventTeamElement = root;

                // Check for "chairmans" array (handle missing property)
                JsonElement chairmansArray;
                if (eventTeamElement.TryGetProperty("chairmans", out chairmansArray))
                {
                    if (chairmansArray.EnumerateArray().Any())
                    {
                        // Assuming the first element is the chief judge (modify if needed)
                        JsonElement firstChairmanElement = chairmansArray.EnumerateArray().FirstOrDefault();
                        return JsonSerializer.Deserialize<Chairman>(firstChairmanElement.GetRawText(), options);
                    }
                }

                // Check for "adjudicators" property (handle missing property)
                JsonElement adjudicatorElement;
                if (eventTeamElement.TryGetProperty("adjudicators", out adjudicatorElement))
                {
                    return JsonSerializer.Deserialize<Adjudicator>(adjudicatorElement.GetRawText(), options);
                }

                // No valid official found (handle error or return default)
                Console.WriteLine("No valid official found in 'eventTeam'.");
                return null;  // Or modify this based on your application's requirements
            }
        }

        public override void Write(Utf8JsonWriter writer, IOfficial value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, options);
        }
    }

}

