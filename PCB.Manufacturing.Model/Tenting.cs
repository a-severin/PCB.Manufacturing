using System.ComponentModel;
using PCB.Manufacturing.Framework;

namespace PCB.Manufacturing.Model;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum Tenting
{
    [Description("Both Sides")]
    BothSides,

    [Description("Top Side")]
    TopSide,

    [Description("Bottom Side")]
    BottomSide,

    [Description("None")]
    None
}