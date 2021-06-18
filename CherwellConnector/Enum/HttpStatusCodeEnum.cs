using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CherwellConnector.Enum
{
    /// <summary>
    ///     Defines HttpStatusCode
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum HttpStatusCodeEnum
    {
        /// <summary>
        ///     Enum Continue for value: Continue
        /// </summary>
        [EnumMember(Value = "Continue")] Continue = 1,

        /// <summary>
        ///     Enum SwitchingProtocols for value: SwitchingProtocols
        /// </summary>
        [EnumMember(Value = "SwitchingProtocols")]
        SwitchingProtocols = 2,

        /// <summary>
        ///     Enum OK for value: OK
        /// </summary>
        [EnumMember(Value = "OK")] OK = 3,

        /// <summary>
        ///     Enum Created for value: Created
        /// </summary>
        [EnumMember(Value = "Created")] Created = 4,

        /// <summary>
        ///     Enum Accepted for value: Accepted
        /// </summary>
        [EnumMember(Value = "Accepted")] Accepted = 5,

        /// <summary>
        ///     Enum NonAuthoritativeInformation for value: NonAuthoritativeInformation
        /// </summary>
        [EnumMember(Value = "NonAuthoritativeInformation")]
        NonAuthoritativeInformation = 6,

        /// <summary>
        ///     Enum NoContent for value: NoContent
        /// </summary>
        [EnumMember(Value = "NoContent")] NoContent = 7,

        /// <summary>
        ///     Enum ResetContent for value: ResetContent
        /// </summary>
        [EnumMember(Value = "ResetContent")] ResetContent = 8,

        /// <summary>
        ///     Enum PartialContent for value: PartialContent
        /// </summary>
        [EnumMember(Value = "PartialContent")] PartialContent = 9,

        /// <summary>
        ///     Enum MultipleChoices for value: MultipleChoices
        /// </summary>
        [EnumMember(Value = "MultipleChoices")]
        MultipleChoices = 10,

        /// <summary>
        ///     Enum Ambiguous for value: Ambiguous
        /// </summary>
        [EnumMember(Value = "Ambiguous")] Ambiguous = 11,

        /// <summary>
        ///     Enum MovedPermanently for value: MovedPermanently
        /// </summary>
        [EnumMember(Value = "MovedPermanently")]
        MovedPermanently = 12,

        /// <summary>
        ///     Enum Moved for value: Moved
        /// </summary>
        [EnumMember(Value = "Moved")] Moved = 13,

        /// <summary>
        ///     Enum Found for value: Found
        /// </summary>
        [EnumMember(Value = "Found")] Found = 14,

        /// <summary>
        ///     Enum Redirect for value: Redirect
        /// </summary>
        [EnumMember(Value = "Redirect")] Redirect = 15,

        /// <summary>
        ///     Enum SeeOther for value: SeeOther
        /// </summary>
        [EnumMember(Value = "SeeOther")] SeeOther = 16,

        /// <summary>
        ///     Enum RedirectMethod for value: RedirectMethod
        /// </summary>
        [EnumMember(Value = "RedirectMethod")] RedirectMethod = 17,

        /// <summary>
        ///     Enum NotModified for value: NotModified
        /// </summary>
        [EnumMember(Value = "NotModified")] NotModified = 18,

        /// <summary>
        ///     Enum UseProxy for value: UseProxy
        /// </summary>
        [EnumMember(Value = "UseProxy")] UseProxy = 19,

        /// <summary>
        ///     Enum Unused for value: Unused
        /// </summary>
        [EnumMember(Value = "Unused")] Unused = 20,

        /// <summary>
        ///     Enum TemporaryRedirect for value: TemporaryRedirect
        /// </summary>
        [EnumMember(Value = "TemporaryRedirect")]
        TemporaryRedirect = 21,

        /// <summary>
        ///     Enum RedirectKeepVerb for value: RedirectKeepVerb
        /// </summary>
        [EnumMember(Value = "RedirectKeepVerb")]
        RedirectKeepVerb = 22,

        /// <summary>
        ///     Enum BadRequest for value: BadRequest
        /// </summary>
        [EnumMember(Value = "BadRequest")] BadRequest = 23,

        /// <summary>
        ///     Enum Unauthorized for value: Unauthorized
        /// </summary>
        [EnumMember(Value = "Unauthorized")] Unauthorized = 24,

        /// <summary>
        ///     Enum PaymentRequired for value: PaymentRequired
        /// </summary>
        [EnumMember(Value = "PaymentRequired")]
        PaymentRequired = 25,

        /// <summary>
        ///     Enum Forbidden for value: Forbidden
        /// </summary>
        [EnumMember(Value = "Forbidden")] Forbidden = 26,

        /// <summary>
        ///     Enum NotFound for value: NotFound
        /// </summary>
        [EnumMember(Value = "NotFound")] NotFound = 27,

        /// <summary>
        ///     Enum MethodNotAllowed for value: MethodNotAllowed
        /// </summary>
        [EnumMember(Value = "MethodNotAllowed")]
        MethodNotAllowed = 28,

        /// <summary>
        ///     Enum NotAcceptable for value: NotAcceptable
        /// </summary>
        [EnumMember(Value = "NotAcceptable")] NotAcceptable = 29,

        /// <summary>
        ///     Enum ProxyAuthenticationRequired for value: ProxyAuthenticationRequired
        /// </summary>
        [EnumMember(Value = "ProxyAuthenticationRequired")]
        ProxyAuthenticationRequired = 30,

        /// <summary>
        ///     Enum RequestTimeout for value: RequestTimeout
        /// </summary>
        [EnumMember(Value = "RequestTimeout")] RequestTimeout = 31,

        /// <summary>
        ///     Enum Conflict for value: Conflict
        /// </summary>
        [EnumMember(Value = "Conflict")] Conflict = 32,

        /// <summary>
        ///     Enum Gone for value: Gone
        /// </summary>
        [EnumMember(Value = "Gone")] Gone = 33,

        /// <summary>
        ///     Enum LengthRequired for value: LengthRequired
        /// </summary>
        [EnumMember(Value = "LengthRequired")] LengthRequired = 34,

        /// <summary>
        ///     Enum PreconditionFailed for value: PreconditionFailed
        /// </summary>
        [EnumMember(Value = "PreconditionFailed")]
        PreconditionFailed = 35,

        /// <summary>
        ///     Enum RequestEntityTooLarge for value: RequestEntityTooLarge
        /// </summary>
        [EnumMember(Value = "RequestEntityTooLarge")]
        RequestEntityTooLarge = 36,

        /// <summary>
        ///     Enum RequestUriTooLong for value: RequestUriTooLong
        /// </summary>
        [EnumMember(Value = "RequestUriTooLong")]
        RequestUriTooLong = 37,

        /// <summary>
        ///     Enum UnsupportedMediaType for value: UnsupportedMediaType
        /// </summary>
        [EnumMember(Value = "UnsupportedMediaType")]
        UnsupportedMediaType = 38,

        /// <summary>
        ///     Enum RequestedRangeNotSatisfiable for value: RequestedRangeNotSatisfiable
        /// </summary>
        [EnumMember(Value = "RequestedRangeNotSatisfiable")]
        RequestedRangeNotSatisfiable = 39,

        /// <summary>
        ///     Enum ExpectationFailed for value: ExpectationFailed
        /// </summary>
        [EnumMember(Value = "ExpectationFailed")]
        ExpectationFailed = 40,

        /// <summary>
        ///     Enum UpgradeRequired for value: UpgradeRequired
        /// </summary>
        [EnumMember(Value = "UpgradeRequired")]
        UpgradeRequired = 41,

        /// <summary>
        ///     Enum InternalServerError for value: InternalServerError
        /// </summary>
        [EnumMember(Value = "InternalServerError")]
        InternalServerError = 42,

        /// <summary>
        ///     Enum NotImplemented for value: NotImplemented
        /// </summary>
        [EnumMember(Value = "NotImplemented")] NotImplemented = 43,

        /// <summary>
        ///     Enum BadGateway for value: BadGateway
        /// </summary>
        [EnumMember(Value = "BadGateway")] BadGateway = 44,

        /// <summary>
        ///     Enum ServiceUnavailable for value: ServiceUnavailable
        /// </summary>
        [EnumMember(Value = "ServiceUnavailable")]
        ServiceUnavailable = 45,

        /// <summary>
        ///     Enum GatewayTimeout for value: GatewayTimeout
        /// </summary>
        [EnumMember(Value = "GatewayTimeout")] GatewayTimeout = 46,

        /// <summary>
        ///     Enum HttpVersionNotSupported for value: HttpVersionNotSupported
        /// </summary>
        [EnumMember(Value = "HttpVersionNotSupported")]
        HttpVersionNotSupported = 47
    }
}