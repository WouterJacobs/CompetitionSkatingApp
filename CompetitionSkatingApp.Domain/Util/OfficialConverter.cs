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

                JsonElement eventTeamElement = root;

                JsonElement chairmansArray;
                if (eventTeamElement.TryGetProperty("chairmans", out chairmansArray))
                {
                    if (chairmansArray.EnumerateArray().Any())
                    {
                        JsonElement firstChairmanElement = chairmansArray.EnumerateArray().FirstOrDefault();
                        return JsonSerializer.Deserialize<Chairman>(firstChairmanElement.GetRawText(), options);
                    }
                }

                JsonElement adjudicatorElement;
                if (eventTeamElement.TryGetProperty("adjudicators", out adjudicatorElement))
                {
                    return JsonSerializer.Deserialize<Adjudicator>(adjudicatorElement.GetRawText(), options);
                }

                Console.WriteLine("No valid official found in 'eventTeam'.");
                return null; 
            }
        }

        public override void Write(Utf8JsonWriter writer, IOfficial value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, options);
        }
    }

}

