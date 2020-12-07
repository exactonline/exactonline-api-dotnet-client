using System;

public class SDKFieldType : Attribute
{
    public SDKFieldType(FieldType fieldType)
    {
        TypeOfField = fieldType;
    }

    public FieldType TypeOfField { get; set; }
}
