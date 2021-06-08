using CherwellConnector.Client;
using CherwellConnector.Model;

namespace CherwellConnector.Interface
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILifecycleApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get current lifecycle stage for record
        /// </summary>
        /// <remarks>
        /// Gets the current lifecycle stage of a business object record
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsLifecycleGetRecordStatusResponse</returns>
        TrebuchetWebApiDataContractsLifecycleGetRecordStatusResponse LifecycleGetRecordStage (string businessObjectDefinitionId, string recordId, string lang = null, string locale = null);

        /// <summary>
        /// Get current lifecycle stage for record
        /// </summary>
        /// <remarks>
        /// Gets the current lifecycle stage of a business object record
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsLifecycleGetRecordStatusResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsLifecycleGetRecordStatusResponse> LifecycleGetRecordStageWithHttpInfo (string businessObjectDefinitionId, string recordId, string lang = null, string locale = null);
        /// <summary>
        /// Get current lifecycle status for record
        /// </summary>
        /// <remarks>
        /// Gets the current lifecycle status of a business object record
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsLifecycleGetRecordStatusResponse</returns>
        TrebuchetWebApiDataContractsLifecycleGetRecordStatusResponse LifecycleGetRecordStatus (string businessObjectDefinitionId, string recordId, string lang = null, string locale = null);

        /// <summary>
        /// Get current lifecycle status for record
        /// </summary>
        /// <remarks>
        /// Gets the current lifecycle status of a business object record
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsLifecycleGetRecordStatusResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsLifecycleGetRecordStatusResponse> LifecycleGetRecordStatusWithHttpInfo (string businessObjectDefinitionId, string recordId, string lang = null, string locale = null);
        /// <summary>
        /// Get lifecycle stages
        /// </summary>
        /// <remarks>
        /// Gets all of the stages on the lifecycle for a Business Object
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsLifecycleGetStagesResponse</returns>
        TrebuchetWebApiDataContractsLifecycleGetStagesResponse LifecycleGetStages (string businessObjectDefinitionId, string lang = null, string locale = null);

        /// <summary>
        /// Get lifecycle stages
        /// </summary>
        /// <remarks>
        /// Gets all of the stages on the lifecycle for a Business Object
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsLifecycleGetStagesResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsLifecycleGetStagesResponse> LifecycleGetStagesWithHttpInfo (string businessObjectDefinitionId, string lang = null, string locale = null);
        /// <summary>
        /// Get lifecycle statuses
        /// </summary>
        /// <remarks>
        /// Gets all of the statuses on the lifecycle for a Business Object
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsLifecycleGetStatusesResponse</returns>
        TrebuchetWebApiDataContractsLifecycleGetStatusesResponse LifecycleGetStatuses (string businessObjectDefinitionId, string lang = null, string locale = null);

        /// <summary>
        /// Get lifecycle statuses
        /// </summary>
        /// <remarks>
        /// Gets all of the statuses on the lifecycle for a Business Object
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsLifecycleGetStatusesResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsLifecycleGetStatusesResponse> LifecycleGetStatusesWithHttpInfo (string businessObjectDefinitionId, string lang = null, string locale = null);
        /// <summary>
        /// Get lifecycle transition options for record
        /// </summary>
        /// <remarks>
        /// Gets the lifecycle transition options currently available to a business object record
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsLifecycleGetTransitionOptionsResponse</returns>
        TrebuchetWebApiDataContractsLifecycleGetTransitionOptionsResponse LifecycleGetTransitionOptions (string businessObjectDefinitionId, string recordId, string lang = null, string locale = null);

        /// <summary>
        /// Get lifecycle transition options for record
        /// </summary>
        /// <remarks>
        /// Gets the lifecycle transition options currently available to a business object record
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsLifecycleGetTransitionOptionsResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsLifecycleGetTransitionOptionsResponse> LifecycleGetTransitionOptionsWithHttpInfo (string businessObjectDefinitionId, string recordId, string lang = null, string locale = null);
        /// <summary>
        /// Get lifecycle transitions
        /// </summary>
        /// <remarks>
        /// Gets all of the transitions on the lifecycle for a Business Object
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsLifecycleGetTransitionsResponse</returns>
        TrebuchetWebApiDataContractsLifecycleGetTransitionsResponse LifecycleGetTransitions (string businessObjectDefinitionId, string lang = null, string locale = null);

        /// <summary>
        /// Get lifecycle transitions
        /// </summary>
        /// <remarks>
        /// Gets all of the transitions on the lifecycle for a Business Object
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsLifecycleGetTransitionsResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsLifecycleGetTransitionsResponse> LifecycleGetTransitionsWithHttpInfo (string businessObjectDefinitionId, string lang = null, string locale = null);
        /// <summary>
        /// Transition a business object record
        /// </summary>
        /// <remarks>
        /// Transitions a business object record in to the specified lifecycle status
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="transitionRecordRequest"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsResponseBase</returns>
        TrebuchetWebApiDataContractsResponseBase LifecycleTransitionRecord (string businessObjectDefinitionId, string recordId, TrebuchetWebApiDataContractsLifecycleTransitionRecordRequest transitionRecordRequest, string lang = null, string locale = null);

        /// <summary>
        /// Transition a business object record
        /// </summary>
        /// <remarks>
        /// Transitions a business object record in to the specified lifecycle status
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="transitionRecordRequest"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsResponseBase</returns>
        ApiResponse<TrebuchetWebApiDataContractsResponseBase> LifecycleTransitionRecordWithHttpInfo (string businessObjectDefinitionId, string recordId, TrebuchetWebApiDataContractsLifecycleTransitionRecordRequest transitionRecordRequest, string lang = null, string locale = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get current lifecycle stage for record
        /// </summary>
        /// <remarks>
        /// Gets the current lifecycle stage of a business object record
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsLifecycleGetRecordStatusResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsLifecycleGetRecordStatusResponse> LifecycleGetRecordStageAsync (string businessObjectDefinitionId, string recordId, string lang = null, string locale = null);

        /// <summary>
        /// Get current lifecycle stage for record
        /// </summary>
        /// <remarks>
        /// Gets the current lifecycle stage of a business object record
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsLifecycleGetRecordStatusResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsLifecycleGetRecordStatusResponse>> LifecycleGetRecordStageAsyncWithHttpInfo (string businessObjectDefinitionId, string recordId, string lang = null, string locale = null);
        /// <summary>
        /// Get current lifecycle status for record
        /// </summary>
        /// <remarks>
        /// Gets the current lifecycle status of a business object record
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsLifecycleGetRecordStatusResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsLifecycleGetRecordStatusResponse> LifecycleGetRecordStatusAsync (string businessObjectDefinitionId, string recordId, string lang = null, string locale = null);

        /// <summary>
        /// Get current lifecycle status for record
        /// </summary>
        /// <remarks>
        /// Gets the current lifecycle status of a business object record
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsLifecycleGetRecordStatusResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsLifecycleGetRecordStatusResponse>> LifecycleGetRecordStatusAsyncWithHttpInfo (string businessObjectDefinitionId, string recordId, string lang = null, string locale = null);
        /// <summary>
        /// Get lifecycle stages
        /// </summary>
        /// <remarks>
        /// Gets all of the stages on the lifecycle for a Business Object
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsLifecycleGetStagesResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsLifecycleGetStagesResponse> LifecycleGetStagesAsync (string businessObjectDefinitionId, string lang = null, string locale = null);

        /// <summary>
        /// Get lifecycle stages
        /// </summary>
        /// <remarks>
        /// Gets all of the stages on the lifecycle for a Business Object
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsLifecycleGetStagesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsLifecycleGetStagesResponse>> LifecycleGetStagesAsyncWithHttpInfo (string businessObjectDefinitionId, string lang = null, string locale = null);
        /// <summary>
        /// Get lifecycle statuses
        /// </summary>
        /// <remarks>
        /// Gets all of the statuses on the lifecycle for a Business Object
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsLifecycleGetStatusesResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsLifecycleGetStatusesResponse> LifecycleGetStatusesAsync (string businessObjectDefinitionId, string lang = null, string locale = null);

        /// <summary>
        /// Get lifecycle statuses
        /// </summary>
        /// <remarks>
        /// Gets all of the statuses on the lifecycle for a Business Object
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsLifecycleGetStatusesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsLifecycleGetStatusesResponse>> LifecycleGetStatusesAsyncWithHttpInfo (string businessObjectDefinitionId, string lang = null, string locale = null);
        /// <summary>
        /// Get lifecycle transition options for record
        /// </summary>
        /// <remarks>
        /// Gets the lifecycle transition options currently available to a business object record
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsLifecycleGetTransitionOptionsResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsLifecycleGetTransitionOptionsResponse> LifecycleGetTransitionOptionsAsync (string businessObjectDefinitionId, string recordId, string lang = null, string locale = null);

        /// <summary>
        /// Get lifecycle transition options for record
        /// </summary>
        /// <remarks>
        /// Gets the lifecycle transition options currently available to a business object record
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsLifecycleGetTransitionOptionsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsLifecycleGetTransitionOptionsResponse>> LifecycleGetTransitionOptionsAsyncWithHttpInfo (string businessObjectDefinitionId, string recordId, string lang = null, string locale = null);
        /// <summary>
        /// Get lifecycle transitions
        /// </summary>
        /// <remarks>
        /// Gets all of the transitions on the lifecycle for a Business Object
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsLifecycleGetTransitionsResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsLifecycleGetTransitionsResponse> LifecycleGetTransitionsAsync (string businessObjectDefinitionId, string lang = null, string locale = null);

        /// <summary>
        /// Get lifecycle transitions
        /// </summary>
        /// <remarks>
        /// Gets all of the transitions on the lifecycle for a Business Object
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsLifecycleGetTransitionsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsLifecycleGetTransitionsResponse>> LifecycleGetTransitionsAsyncWithHttpInfo (string businessObjectDefinitionId, string lang = null, string locale = null);
        /// <summary>
        /// Transition a business object record
        /// </summary>
        /// <remarks>
        /// Transitions a business object record in to the specified lifecycle status
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="transitionRecordRequest"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsResponseBase</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsResponseBase> LifecycleTransitionRecordAsync (string businessObjectDefinitionId, string recordId, TrebuchetWebApiDataContractsLifecycleTransitionRecordRequest transitionRecordRequest, string lang = null, string locale = null);

        /// <summary>
        /// Transition a business object record
        /// </summary>
        /// <remarks>
        /// Transitions a business object record in to the specified lifecycle status
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="transitionRecordRequest"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsResponseBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsResponseBase>> LifecycleTransitionRecordAsyncWithHttpInfo (string businessObjectDefinitionId, string recordId, TrebuchetWebApiDataContractsLifecycleTransitionRecordRequest transitionRecordRequest, string lang = null, string locale = null);
        #endregion Asynchronous Operations
    }
}