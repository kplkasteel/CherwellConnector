using CherwellConnector.Client;
using CherwellConnector.Model;

namespace CherwellConnector.Interface
{
    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILifecycleApi : IApiAccessor
    {
        /// <summary>
        ///     Get current lifecycle stage for record
        /// </summary>
        /// <remarks>
        ///     Gets the current lifecycle stage of a business object record
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>RecordStatusResponse</returns>
        RecordStatusResponse LifecycleGetRecordStage(string businessObjectDefinitionId, string recordId,
            string lang = null, string locale = null);

        /// <summary>
        ///     Get current lifecycle status for record
        /// </summary>
        /// <remarks>
        ///     Gets the current lifecycle status of a business object record
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>RecordStatusResponse</returns>
        RecordStatusResponse LifecycleGetRecordStatus(string businessObjectDefinitionId, string recordId,
            string lang = null, string locale = null);

        /// <summary>
        ///     Get lifecycle stages
        /// </summary>
        /// <remarks>
        ///     Gets all of the stages on the lifecycle for a Business Object
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>StagesResponse</returns>
        StagesResponse LifecycleGetStages(string businessObjectDefinitionId, string lang = null, string locale = null);

        /// <summary>
        ///     Get lifecycle statuses
        /// </summary>
        /// <remarks>
        ///     Gets all of the statuses on the lifecycle for a Business Object
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>StatusesResponse</returns>
        StatusesResponse LifecycleGetStatuses(string businessObjectDefinitionId, string lang = null,
            string locale = null);

        /// <summary>
        ///     Get lifecycle transition options for record
        /// </summary>
        /// <remarks>
        ///     Gets the lifecycle transition options currently available to a business object record
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>TransitionOptionsResponse</returns>
        TransitionOptionsResponse LifecycleGetTransitionOptions(string businessObjectDefinitionId, string recordId,
            string lang = null, string locale = null);

        /// <summary>
        ///     Get lifecycle transitions
        /// </summary>
        /// <remarks>
        ///     Gets all of the transitions on the lifecycle for a Business Object
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>TransitionsResponse</returns>
        TransitionsResponse LifecycleGetTransitions(string businessObjectDefinitionId, string lang = null,
            string locale = null);

        /// <summary>
        ///     Transition a business object record
        /// </summary>
        /// <remarks>
        ///     Transitions a business object record in to the specified lifecycle status
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="transitionRecordRequest"></param>
        /// <param name="lang">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <param name="locale">
        ///     Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;
        ///     locale\&quot; can be used to specify the culture. (optional)
        /// </param>
        /// <returns>ResponseBase</returns>
        ResponseBase LifecycleTransitionRecord(string businessObjectDefinitionId, string recordId,
            TransitionRecordRequest transitionRecordRequest, string lang = null, string locale = null);
    }
}