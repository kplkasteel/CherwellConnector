using System.Diagnostics.CodeAnalysis;

namespace CherwellConnector.Enum
{
    /// <summary>
    ///     Authentication modes for Cherwell
    /// </summary>
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum AuthModes
    {
        Internal = 1,
        LDAP = 2,
        SAML = 3,
        Windows = 4,
        Auto = 5
    }
}