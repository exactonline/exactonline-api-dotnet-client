using System;

public class SDKFieldType : Attribute
{
    public FieldType TypeOfField { get; set; }

    public SDKFieldType(FieldType fieldType)
    {
        TypeOfField = fieldType;
    }
}

