// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;
using System.Text.Json.Serialization.Metadata;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// TestDescendants
    /// </summary>
    public partial class TestDescendants : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestDescendants" /> class.
        /// </summary>
        /// <param name="alternativeName">alternativeName</param>
        [JsonConstructor]
        public TestDescendants(string alternativeName)
        {
            AlternativeName = alternativeName;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines ObjectType
        /// </summary>
        public enum ObjectTypeEnum
        {
            /// <summary>
            /// Enum Descendant1 for value: Descendant1
            /// </summary>
            Descendant1 = 1,

            /// <summary>
            /// Enum Descendant2 for value: Descendant2
            /// </summary>
            Descendant2 = 2
        }

        /// <summary>
        /// Returns a <see cref="ObjectTypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static ObjectTypeEnum ObjectTypeEnumFromString(string value)
        {
            if (value.Equals("Descendant1"))
                return ObjectTypeEnum.Descendant1;

            if (value.Equals("Descendant2"))
                return ObjectTypeEnum.Descendant2;

            throw new NotImplementedException($"Could not convert value to type ObjectTypeEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="ObjectTypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ObjectTypeEnum? ObjectTypeEnumFromStringOrDefault(string value)
        {
            if (value.Equals("Descendant1"))
                return ObjectTypeEnum.Descendant1;

            if (value.Equals("Descendant2"))
                return ObjectTypeEnum.Descendant2;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="ObjectTypeEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string ObjectTypeEnumToJsonValue(ObjectTypeEnum value)
        {
            if (value == ObjectTypeEnum.Descendant1)
                return "Descendant1";

            if (value == ObjectTypeEnum.Descendant2)
                return "Descendant2";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Gets or Sets AlternativeName
        /// </summary>
        [JsonPropertyName("alternativeName")]
        public string AlternativeName { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestDescendants {\n");
            sb.Append("  AlternativeName: ").Append(AlternativeName).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="TestDescendants" />
    /// </summary>
    public class TestDescendantsJsonConverter : JsonConverter<TestDescendants>
    {
        /// <summary>
        /// Deserializes json to <see cref="TestDescendants" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TestDescendants Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> alternativeName = default;
            Option<TestDescendants.ObjectTypeEnum?> objectType = default;

            string? discriminator = ClientUtils.GetDiscriminator(utf8JsonReader, "objectType");

            if (discriminator != null && discriminator.Equals("Descendant1"))
                return JsonSerializer.Deserialize<Descendant1>(ref utf8JsonReader, jsonSerializerOptions) ?? throw new JsonException("The result was an unexpected value.");

            if (discriminator != null && discriminator.Equals("Descendant2"))
                return JsonSerializer.Deserialize<Descendant2>(ref utf8JsonReader, jsonSerializerOptions) ?? throw new JsonException("The result was an unexpected value.");

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "alternativeName":
                            alternativeName = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "objectType":
                            string? objectTypeRawValue = utf8JsonReader.GetString();
                            if (objectTypeRawValue != null)
                                objectType = new Option<TestDescendants.ObjectTypeEnum?>(TestDescendants.ObjectTypeEnumFromStringOrDefault(objectTypeRawValue));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!alternativeName.IsSet)
                throw new ArgumentException("Property is required for class TestDescendants.", nameof(alternativeName));

            if (!objectType.IsSet)
                throw new ArgumentException("Property is required for class TestDescendants.", nameof(objectType));

            if (alternativeName.IsSet && alternativeName.Value == null)
                throw new ArgumentNullException(nameof(alternativeName), "Property is not nullable for class TestDescendants.");

            if (objectType.IsSet && objectType.Value == null)
                throw new ArgumentNullException(nameof(objectType), "Property is not nullable for class TestDescendants.");

            return new TestDescendants(alternativeName.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="TestDescendants" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="testDescendants"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TestDescendants testDescendants, JsonSerializerOptions jsonSerializerOptions)
        {
            if (testDescendants is Descendant1 descendant1){
                JsonSerializer.Serialize<Descendant1>(writer, descendant1, jsonSerializerOptions);
                return;
            }

            if (testDescendants is Descendant2 descendant2){
                JsonSerializer.Serialize<Descendant2>(writer, descendant2, jsonSerializerOptions);
                return;
            }

            writer.WriteStartObject();

            WriteProperties(writer, testDescendants, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TestDescendants" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="testDescendants"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, TestDescendants testDescendants, JsonSerializerOptions jsonSerializerOptions)
        {
            if (testDescendants.AlternativeName == null)
                throw new ArgumentNullException(nameof(testDescendants.AlternativeName), "Property is required for class TestDescendants.");

            writer.WriteString("alternativeName", testDescendants.AlternativeName);

            writer.WriteString("objectType", TestDescendants.ObjectTypeEnumToJsonValue(testDescendants.ObjectType));
        }
    }

    /// <summary>
    /// The TestDescendantsSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(TestDescendants))]
    public partial class TestDescendantsSerializationContext : JsonSerializerContext { }
}
