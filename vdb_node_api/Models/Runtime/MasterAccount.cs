﻿namespace vdb_node_api.Models.Runtime;

public class MasterAccount
{
    public string KeyHashBase64 { get; init; }

    public MasterAccount(string keyHashBase64)
    {
        KeyHashBase64 = keyHashBase64;
    }
}
