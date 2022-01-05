using System.ComponentModel;
using PCB.Manufacturing.Framework;

namespace PCB.Manufacturing.Model;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum IPC
{
    [Description("Class 1")]
    Class1, 
    [Description("Class 2")]
    Class2
}