using System;

public class SupportedActionsSDK : Attribute
{
    public SupportedActionsSDK(bool canCreate, bool canRead, bool canUpdate, bool canDelete)
    {
        CanCreate = canCreate;
        CanRead = canRead;
        CanUpdate = canUpdate;
        CanDelete = canDelete;
    }

    public bool CanCreate { get; }

    public bool CanRead { get; }

    public bool CanUpdate { get; }

    public bool CanDelete { get; }
}
