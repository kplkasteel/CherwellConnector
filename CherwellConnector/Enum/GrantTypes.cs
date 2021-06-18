using System.Diagnostics.CodeAnalysis;

namespace CherwellConnector.Enum
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum GrantTypes
    {
        password = 0,
        refresh_token = 1
    }
}