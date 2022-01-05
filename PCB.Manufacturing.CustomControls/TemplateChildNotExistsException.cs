using System;

namespace PCB.Manufacturing.CustomControls;

public class TemplateChildNotExistsException: ApplicationException
{
    public TemplateChildNotExistsException(string childName) : base($"Can not find template child with name {childName}")
    {
    }
}