using System.ComponentModel;
using PCB.Manufacturing.Framework;

namespace PCB.Manufacturing.Model;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum Flux
{
    [Description("Clean")]
    Clean,

    [Description("No Clean")]
    NoClean
}