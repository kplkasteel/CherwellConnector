using CherwellConnector.Client;
using CherwellConnector.Model;

namespace CherwellConnector.Interface
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFormsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get mobile form by BusObId and Public ID
        /// </summary>
        /// <remarks>
        /// Operation that gets a mobile form for a specific Business Object by Business Object ID and Public ID.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="publicid">Specify the Business Object Public ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsFormsMobileFormResponse</returns>
        TrebuchetWebApiDataContractsFormsMobileFormResponse FormsGetMobileFormForBusObByIdAndPublicIdV1 (string busobid, string publicid, bool? foredit = null, string formid = null, string lang = null, string locale = null);

        /// <summary>
        /// Get mobile form by BusObId and Public ID
        /// </summary>
        /// <remarks>
        /// Operation that gets a mobile form for a specific Business Object by Business Object ID and Public ID.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="publicid">Specify the Business Object Public ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsFormsMobileFormResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsFormsMobileFormResponse> FormsGetMobileFormForBusObByIdAndPublicIdV1WithHttpInfo (string busobid, string publicid, bool? foredit = null, string formid = null, string lang = null, string locale = null);
        /// <summary>
        /// Get mobile form by Business Object ID and Business Object Record ID.
        /// </summary>
        /// <remarks>
        /// Operation that gets a mobile form for a specific Business Object by Business Object ID and record ID.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="busobrecid">Specify the Business Object Record ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsFormsMobileFormResponse</returns>
        TrebuchetWebApiDataContractsFormsMobileFormResponse FormsGetMobileFormForBusObByIdAndRecIdV1 (string busobid, string busobrecid, bool? foredit = null, string formid = null, string lang = null, string locale = null);

        /// <summary>
        /// Get mobile form by Business Object ID and Business Object Record ID.
        /// </summary>
        /// <remarks>
        /// Operation that gets a mobile form for a specific Business Object by Business Object ID and record ID.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="busobrecid">Specify the Business Object Record ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsFormsMobileFormResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsFormsMobileFormResponse> FormsGetMobileFormForBusObByIdAndRecIdV1WithHttpInfo (string busobid, string busobrecid, bool? foredit = null, string formid = null, string lang = null, string locale = null);
        /// <summary>
        /// Get mobile form by Business Object name and Public ID
        /// </summary>
        /// <remarks>
        /// Operation that gets a mobile form for a specific Business Object by Business Object name and public ID.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="publicid">Specify the Business Object public ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsFormsMobileFormResponse</returns>
        TrebuchetWebApiDataContractsFormsMobileFormResponse FormsGetMobileFormForBusObByNameAndPublicIdV1 (string busobname, string publicid, bool? foredit = null, string formid = null, string lang = null, string locale = null);

        /// <summary>
        /// Get mobile form by Business Object name and Public ID
        /// </summary>
        /// <remarks>
        /// Operation that gets a mobile form for a specific Business Object by Business Object name and public ID.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="publicid">Specify the Business Object public ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsFormsMobileFormResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsFormsMobileFormResponse> FormsGetMobileFormForBusObByNameAndPublicIdV1WithHttpInfo (string busobname, string publicid, bool? foredit = null, string formid = null, string lang = null, string locale = null);
        /// <summary>
        /// Get mobile form by Business Object name and record ID.
        /// </summary>
        /// <remarks>
        /// Operation that gets a mobile form for a specific Business Object by Business Object name and record ID.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="busobrecid">Specify the Business Object record ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsFormsMobileFormResponse</returns>
        TrebuchetWebApiDataContractsFormsMobileFormResponse FormsGetMobileFormForBusObByNameAndRecIdV1 (string busobname, string busobrecid, bool? foredit = null, string formid = null, string lang = null, string locale = null);

        /// <summary>
        /// Get mobile form by Business Object name and record ID.
        /// </summary>
        /// <remarks>
        /// Operation that gets a mobile form for a specific Business Object by Business Object name and record ID.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="busobrecid">Specify the Business Object record ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsFormsMobileFormResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsFormsMobileFormResponse> FormsGetMobileFormForBusObByNameAndRecIdV1WithHttpInfo (string busobname, string busobrecid, bool? foredit = null, string formid = null, string lang = null, string locale = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get mobile form by BusObId and Public ID
        /// </summary>
        /// <remarks>
        /// Operation that gets a mobile form for a specific Business Object by Business Object ID and Public ID.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="publicid">Specify the Business Object Public ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsFormsMobileFormResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsFormsMobileFormResponse> FormsGetMobileFormForBusObByIdAndPublicIdV1Async (string busobid, string publicid, bool? foredit = null, string formid = null, string lang = null, string locale = null);

        /// <summary>
        /// Get mobile form by BusObId and Public ID
        /// </summary>
        /// <remarks>
        /// Operation that gets a mobile form for a specific Business Object by Business Object ID and Public ID.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="publicid">Specify the Business Object Public ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsFormsMobileFormResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsFormsMobileFormResponse>> FormsGetMobileFormForBusObByIdAndPublicIdV1AsyncWithHttpInfo (string busobid, string publicid, bool? foredit = null, string formid = null, string lang = null, string locale = null);
        /// <summary>
        /// Get mobile form by Business Object ID and Business Object Record ID.
        /// </summary>
        /// <remarks>
        /// Operation that gets a mobile form for a specific Business Object by Business Object ID and record ID.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="busobrecid">Specify the Business Object Record ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsFormsMobileFormResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsFormsMobileFormResponse> FormsGetMobileFormForBusObByIdAndRecIdV1Async (string busobid, string busobrecid, bool? foredit = null, string formid = null, string lang = null, string locale = null);

        /// <summary>
        /// Get mobile form by Business Object ID and Business Object Record ID.
        /// </summary>
        /// <remarks>
        /// Operation that gets a mobile form for a specific Business Object by Business Object ID and record ID.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="busobrecid">Specify the Business Object Record ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsFormsMobileFormResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsFormsMobileFormResponse>> FormsGetMobileFormForBusObByIdAndRecIdV1AsyncWithHttpInfo (string busobid, string busobrecid, bool? foredit = null, string formid = null, string lang = null, string locale = null);
        /// <summary>
        /// Get mobile form by Business Object name and Public ID
        /// </summary>
        /// <remarks>
        /// Operation that gets a mobile form for a specific Business Object by Business Object name and public ID.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="publicid">Specify the Business Object public ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsFormsMobileFormResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsFormsMobileFormResponse> FormsGetMobileFormForBusObByNameAndPublicIdV1Async (string busobname, string publicid, bool? foredit = null, string formid = null, string lang = null, string locale = null);

        /// <summary>
        /// Get mobile form by Business Object name and Public ID
        /// </summary>
        /// <remarks>
        /// Operation that gets a mobile form for a specific Business Object by Business Object name and public ID.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="publicid">Specify the Business Object public ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsFormsMobileFormResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsFormsMobileFormResponse>> FormsGetMobileFormForBusObByNameAndPublicIdV1AsyncWithHttpInfo (string busobname, string publicid, bool? foredit = null, string formid = null, string lang = null, string locale = null);
        /// <summary>
        /// Get mobile form by Business Object name and record ID.
        /// </summary>
        /// <remarks>
        /// Operation that gets a mobile form for a specific Business Object by Business Object name and record ID.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="busobrecid">Specify the Business Object record ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsFormsMobileFormResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsFormsMobileFormResponse> FormsGetMobileFormForBusObByNameAndRecIdV1Async (string busobname, string busobrecid, bool? foredit = null, string formid = null, string lang = null, string locale = null);

        /// <summary>
        /// Get mobile form by Business Object name and record ID.
        /// </summary>
        /// <remarks>
        /// Operation that gets a mobile form for a specific Business Object by Business Object name and record ID.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="busobrecid">Specify the Business Object record ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsFormsMobileFormResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsFormsMobileFormResponse>> FormsGetMobileFormForBusObByNameAndRecIdV1AsyncWithHttpInfo (string busobname, string busobrecid, bool? foredit = null, string formid = null, string lang = null, string locale = null);
        #endregion Asynchronous Operations
    }
}