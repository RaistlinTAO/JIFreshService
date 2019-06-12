#region

using System;
using System.Text;
using Jayrock.Json;
using Jayrock.Json.Conversion;
using Jayrock.Json.Conversion.Converters;

#endregion

namespace VTigerApi
{
    internal sealed class BooleanImporterEx : BooleanImporter
    {
        protected override object ImportFromString(ImportContext context, JsonReader reader)
        {
            try
            {
                string val = reader.ReadString().ToLower();
                return (val == "1") || (val == "true") || (val == "t");
            }
            catch (FormatException e)
            {
                throw new JsonException("Error importing JSON String as System.Boolean.", e);
            }
        }
    }

    internal sealed class BooleanExporterEx : ExporterBase
    {
        public BooleanExporterEx() : base(typeof (Boolean))
        {
        }

        protected override void ExportValue(ExportContext context, object value, JsonWriter writer)
        {
            writer.WriteString((bool) value ? "1" : "0");
        }
    }

    internal sealed class Int32ImporterEx : NumberImporterBase
    {
        public Int32ImporterEx() : base(typeof (int))
        {
        }

        protected override object ConvertFromString(string s)
        {
            if (s == "")
                return 0;
            return Convert.ToInt32(s);
        }
    }

    internal sealed class DateTimeImporterEx : ImporterBase
    {
        public DateTimeImporterEx() : base(typeof (DateTime))
        {
        }

        protected override object ImportFromString(ImportContext context, JsonReader reader)
        {
            try
            {
                string val = reader.ReadString();
                return DateTime.Parse(val);
            }
            catch (FormatException e)
            {
                throw new JsonException("Error importing JSON String as System.DateTime.", e);
            }
        }
    }

    internal sealed class DateTimeExporterEx : ExporterBase
    {
        public DateTimeExporterEx() : base(typeof (DateTime))
        {
        }

        protected override void ExportValue(ExportContext context, object value, JsonWriter writer)
        {
            //writer.WriteString(((DateTime)value).ToString("yyyy-MM-dd hh:mm:ss"));
            writer.WriteString(((DateTime) value).ToString("s"));
        }
    }

    internal sealed class EnumValueImporter : ImporterBase
    {
        public string[] values;

        public EnumValueImporter(Type outputType, string[] valueList)
            : base(outputType)
        {
            values = valueList;
        }

        protected override object ImportFromString(ImportContext context, JsonReader reader)
        {
            try
            {
                string val = reader.ReadString();
                int i = 0;
                foreach (string item in values)
                {
                    if (item == val)
                        return i;
                    i++;
                }
                throw new JsonException("Error importing JSON String as " + OutputType.FullName + ".");
            }
            catch (FormatException e)
            {
                throw new JsonException("Error importing JSON String as " + OutputType.FullName + ".", e);
            }
        }
    }

    internal sealed class EnumValueExporter : ExporterBase
    {
        public string[] values;

        public EnumValueExporter(Type outputType, string[] valueList)
            : base(outputType)
        {
            values = valueList;
        }

        protected override void ExportValue(ExportContext context, object value, JsonWriter writer)
        {
            writer.WriteString(values[(int) value]);
        }
    }

    internal sealed class EmailAdressesImporter : ImporterBase
    {
        public EmailAdressesImporter() : base(typeof (EmailAdresses))
        {
        }

        protected override object ImportFromString(ImportContext context, JsonReader reader)
        {
            try
            {
                string val = reader.ReadString();
                var result = new EmailAdresses {Adresses = JsonConvert.Import<string[]>(val)};
                return result;
            }
            catch (FormatException e)
            {
                throw new JsonException("Error importing JSON String as " + OutputType.FullName + ".", e);
            }
        }
    }

    internal sealed class EmailAdressesExporter : ExporterBase
    {
        public EmailAdressesExporter() : base(typeof (EmailAdresses))
        {
        }

        protected override void ExportValue(ExportContext context, object value, JsonWriter writer)
        {
            if (((EmailAdresses) value).Adresses != null)
            {
                var sb = new StringBuilder();
                foreach (string item in ((EmailAdresses) value).Adresses)
                    sb.Append(item + ",");
                sb.Remove(sb.Length - 1, 1);
                writer.WriteString(sb.ToString());
            }
            else
                writer.WriteString("");
        }
    }
}