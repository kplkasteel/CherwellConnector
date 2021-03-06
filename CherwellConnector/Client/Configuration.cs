using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using CherwellConnector.Interface;

namespace CherwellConnector.Client
{
    /// <summary>
    ///     Represents a set of configuration settings
    /// </summary>
    public class Configuration : IReadableConfiguration
    {
        #region Constants

        /// <summary>
        ///     Version of the package.
        /// </summary>
        /// <value>Version of the package.</value>
        public const string Version = "1.0.0";

        /// <summary>
        ///     Identifier for ISO 8601 DateTime Format
        /// </summary>
        /// <remarks>See https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8 for more information.</remarks>
        // ReSharper disable once InconsistentNaming
        private const string ISO8601_DATETIME_FORMAT = "o";

        #endregion Constants

        #region Static Members

        private static readonly object GlobalConfigSync = new { };
        private static Configuration _globalConfiguration;

        /// <summary>
        ///     Default creation of exceptions for a given method name and response object
        /// </summary>
        public static readonly ExceptionFactory DefaultExceptionFactory = (methodName, response) =>
        {
            var status = (int) response.StatusCode;
            return status switch
            {
                >= 400 => new ApiException(status,
                    $"Error calling {methodName}: {response.Content}", response.Content),
                0 => new ApiException(status,
                    $"Error calling {methodName}: {response.ErrorMessage}", response.ErrorMessage),
                _ => null
            };
        };

        /// <summary>
        ///     Gets or sets the default Configuration.
        /// </summary>
        /// <value>Configuration.</value>
        public static Configuration Default
        {
            get => _globalConfiguration;
            set
            {
                lock (GlobalConfigSync)
                {
                    _globalConfiguration = value;
                }
            }
        }

        #endregion Static Members

        #region Private Members

        /// <summary>
        ///     Gets or sets the API key based on the authentication name.
        /// </summary>
        /// <value>The API key.</value>
        private readonly IDictionary<string, string> _apiKey;

        /// <summary>
        ///     Gets or sets the prefix (e.g. Token) of the API key based on the authentication name.
        /// </summary>
        /// <value>The prefix of the API key.</value>
        private readonly IDictionary<string, string> _apiKeyPrefix;

        private string _dateTimeFormat = ISO8601_DATETIME_FORMAT;
        private string _tempFolderPath = Path.GetTempPath();

        #endregion Private Members

        #region Constructors

        static Configuration()
        {
            _globalConfiguration = new GlobalConfiguration();
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Configuration" /> class
        /// </summary>
        public Configuration()
        {
            UserAgent = "Swagger-Codegen/1.0.0/csharp";
            BasePath = "https://localhost/CherwellAPI";
            DefaultHeader = new ConcurrentDictionary<string, string>();
            ApiKey = new ConcurrentDictionary<string, string>();
            ApiKeyPrefix = new ConcurrentDictionary<string, string>();

            // Setting Timeout has side effects (forces ApiClient creation).
            Timeout = 100000;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Configuration" /> class
        /// </summary>
        public Configuration(
            IDictionary<string, string> defaultHeader,
            IDictionary<string, string> apiKey,
            IDictionary<string, string> apiKeyPrefix,
            string basePath) : this()
        {
            if (string.IsNullOrWhiteSpace(basePath))
                throw new ArgumentException("The provided basePath is invalid.", nameof(basePath));
            if (defaultHeader == null)
                throw new ArgumentNullException(nameof(defaultHeader));
            if (apiKey == null)
                throw new ArgumentNullException(nameof(apiKey));
            if (apiKeyPrefix == null)
                throw new ArgumentNullException(nameof(apiKeyPrefix));

            BasePath = basePath;

            foreach (var keyValuePair in defaultHeader) DefaultHeader.Add(keyValuePair);

            foreach (var keyValuePair in apiKey) ApiKey.Add(keyValuePair);

            foreach (var keyValuePair in apiKeyPrefix) ApiKeyPrefix.Add(keyValuePair);
        }

        #endregion Constructors

        #region Properties

        private ApiClient _apiClient;

        /// <summary>
        ///     Gets an instance of an ApiClient for this configuration
        /// </summary>
        public ApiClient ApiClient => _apiClient ??= CreateApiClient();

        private readonly string _basePath;

        /// <summary>
        ///     Gets or sets the base path for API access.
        /// </summary>
        public string BasePath
        {
            get => _basePath;
            init
            {
                _basePath = value;
                // pass-through to ApiClient if it's set.
                if (_apiClient != null) _apiClient.RestClient.BaseUrl = new Uri(_basePath);
            }
        }

        /// <summary>
        ///     Gets or sets the default header.
        /// </summary>
        public IDictionary<string, string> DefaultHeader { get; }

        /// <summary>
        ///     Gets or sets the HTTP timeout (milliseconds) of ApiClient. Default to 100000 milliseconds.
        /// </summary>
        public int Timeout
        {
            get => ApiClient.RestClient.Timeout;
            private init => ApiClient.RestClient.Timeout = value;
        }

        /// <summary>
        ///     Gets or sets the HTTP user agent.
        /// </summary>
        /// <value>Http user agent.</value>
        public string UserAgent { get; }

        /// <summary>
        ///     Gets or sets the username (HTTP basic authentication).
        /// </summary>
        /// <value>The username.</value>
        public string Username => null;

        /// <summary>
        ///     Gets or sets the password (HTTP basic authentication).
        /// </summary>
        /// <value>The password.</value>
        public string Password => null;

        /// <summary>
        ///     Gets the API key with prefix.
        /// </summary>
        /// <param name="apiKeyIdentifier">API key identifier (authentication scheme).</param>
        /// <returns>API key with prefix.</returns>
        public string GetApiKeyWithPrefix(string apiKeyIdentifier)
        {
            ApiKey.TryGetValue(apiKeyIdentifier, out var apiKeyValue);
            if (ApiKeyPrefix.TryGetValue(apiKeyIdentifier, out var apiKeyPrefix))
                return apiKeyPrefix + " " + apiKeyValue;
            return apiKeyValue;
        }

        /// <summary>
        ///     Gets or sets the access token for OAuth2 authentication.
        /// </summary>
        /// <value>The access token.</value>
        public string AccessToken => null;

        /// <summary>
        ///     Gets or sets the temporary folder path to store the files downloaded from the server.
        /// </summary>
        /// <value>Folder path.</value>
        public string TempFolderPath
        {
            get => _tempFolderPath;

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    // Possible breaking change since swagger-codegen 2.2.1, enforce a valid temporary path on set.
                    _tempFolderPath = Path.GetTempPath();
                    return;
                }

                // create the directory if it does not exist
                if (!Directory.Exists(value)) Directory.CreateDirectory(value);

                // check if the path contains directory separator at the end
                if (value[^1] == Path.DirectorySeparatorChar)
                    _tempFolderPath = value;
                else
                    _tempFolderPath = value + Path.DirectorySeparatorChar;
            }
        }

        /// <summary>
        ///     Gets or sets the date time format used when serializing in the ApiClient
        ///     By default, it's set to ISO 8601 - "o", for others see:
        ///     https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx
        ///     and https://msdn.microsoft.com/en-us/library/8kb3ddd4(v=vs.110).aspx
        ///     No validation is done to ensure that the string you're providing is valid
        /// </summary>
        /// <value>The DateTimeFormat string</value>
        public string DateTimeFormat
        {
            get => _dateTimeFormat;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    // Never allow a blank or null string, go back to the default
                    _dateTimeFormat = ISO8601_DATETIME_FORMAT;
                    return;
                }

                // Caution, no validation when you choose date time format other than ISO 8601
                // Take a look at the above links
                _dateTimeFormat = value;
            }
        }

        /// <summary>
        ///     Gets or sets the prefix (e.g. Token) of the API key based on the authentication name.
        /// </summary>
        /// <value>The prefix of the API key.</value>
        public IDictionary<string, string> ApiKeyPrefix
        {
            get => _apiKeyPrefix;
            private init => _apiKeyPrefix =
                value ?? throw new InvalidOperationException("ApiKeyPrefix collection may not be null.");
        }

        /// <summary>
        ///     Gets or sets the API key based on the authentication name.
        /// </summary>
        /// <value>The API key.</value>
        public IDictionary<string, string> ApiKey
        {
            get => _apiKey;
            private init =>
                _apiKey = value ?? throw new InvalidOperationException("ApiKey collection may not be null.");
        }

        #endregion Properties

        #region Methods

        /// <summary>
        ///     Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        public void AddDefaultHeader(string key, string value)
        {
            DefaultHeader[key] = value;
        }

        /// <summary>
        ///     Creates a new <see cref="ApiClient" /> based on this <see cref="Configuration" /> instance.
        /// </summary>
        /// <returns></returns>
        private ApiClient CreateApiClient()
        {
            return new(BasePath) {Configuration = this};
        }


        /// <summary>
        ///     Returns a string with essential information for debugging.
        /// </summary>
        public static string ToDebugReport()
        {
            var report = "C# SDK (IO.Swagger) Debug Report:\n";
            report += "    OS: " + Environment.OSVersion + "\n";
            report += "    .NET Framework Version: " + Environment.Version + "\n";
            report += "    Version of the API: \n";
            report += "    SDK Package Version: 1.0.0\n";

            return report;
        }

        /// <summary>
        ///     Add Api Key Header.
        /// </summary>
        /// <param name="key">Api Key name.</param>
        /// <param name="value">Api Key value.</param>
        /// <returns></returns>
        public void AddApiKey(string key, string value)
        {
            ApiKey[key] = value;
        }

        /// <summary>
        ///     Sets the API key prefix.
        /// </summary>
        /// <param name="key">Api Key name.</param>
        /// <param name="value">Api Key value.</param>
        public void AddApiKeyPrefix(string key, string value)
        {
            ApiKeyPrefix[key] = value;
        }

        #endregion Methods
    }
}