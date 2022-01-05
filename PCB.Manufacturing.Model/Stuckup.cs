using System.ComponentModel;
using PCB.Manufacturing.Framework;

namespace PCB.Manufacturing.Model;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum Stuckup
{
    [Description("Standard")]
    Standard,

    [Description("See Notes")]
    SeeNotes
}