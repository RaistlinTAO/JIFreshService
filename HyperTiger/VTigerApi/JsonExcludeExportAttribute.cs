#region

using System;
using System.ComponentModel;
using System.ComponentModel.Design;

#endregion

namespace Jayrock.Json.Conversion
{
    /// <summary>
    /// </summary>
    [Serializable]
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public sealed class JsonExcludeExportAttribute : Attribute, IPropertyDescriptorCustomization, IObjectMemberExporter
    {
        void IObjectMemberExporter.Export(ExportContext context, JsonWriter writer, object source)
        {
            //writer.WriteMember(_property.Name);
            //context.Export(_property.GetValue(source), writer);
        }

        /// <summary>
        /// </summary>
        /// <param name="property"></param>
        public void Apply(PropertyDescriptor property)
        {
            var services = (IServiceContainer) property;
            services.AddService(typeof (IObjectMemberExporter), this);
        }
    }
}