using System.ComponentModel;
using PCB.Manufacturing.Framework;

namespace PCB.Manufacturing.Model;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum ITAR
{
    Yes,
    No
}