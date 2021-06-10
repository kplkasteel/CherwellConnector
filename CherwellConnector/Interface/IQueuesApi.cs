using CherwellConnector.Client;
using CherwellConnector.Model;

namespace CherwellConnector.Interface
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IQueuesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Add a Business Object to a queue
        /// </summary>
        /// <remarks>
        /// Operation to add a Business Object to a queue
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object containing all properties necessary to add an item to a queue. All properties are required. The standin key defines the queue to which we want to add the Business Object.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsQueuesAddItemToQueueResponse</returns>
        TrebuchetWebApiDataContractsQueuesAddItemToQueueResponse QueuesAddItemToQueueV1 (TrebuchetWebApiDataContractsQueuesAddItemToQueueRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Add a Business Object to a queue
        /// </summary>
        /// <remarks>
        /// Operation to add a Business Object to a queue
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object containing all properties necessary to add an item to a queue. All properties are required. The standin key defines the queue to which we want to add the Business Object.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsQueuesAddItemToQueueResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsQueuesAddItemToQueueResponse> QueuesAddItemToQueueV1WithHttpInfo (TrebuchetWebApiDataContractsQueuesAddItemToQueueRequest request, string lang = null, string locale = null);
        /// <summary>
        /// Check a Business Object in to a queue
        /// </summary>
        /// <remarks>
        /// Operation to check in a queue item
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request object for checking in an item to a queue. All properties are required except for historyNotes</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsQueuesCheckInQueueItemResponse</returns>
        TrebuchetWebApiDataContractsQueuesCheckInQueueItemResponse QueuesCheckInQueueItemV1 (TrebuchetWebApiDataContractsQueuesCheckInQueueItemRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Check a Business Object in to a queue
        /// </summary>
        /// <remarks>
        /// Operation to check in a queue item
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request object for checking in an item to a queue. All properties are required except for historyNotes</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsQueuesCheckInQueueItemResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsQueuesCheckInQueueItemResponse> QueuesCheckInQueueItemV1WithHttpInfo (TrebuchetWebApiDataContractsQueuesCheckInQueueItemRequest request, string lang = null, string locale = null);
        /// <summary>
        /// Check a Business Object out of a queue
        /// </summary>
        /// <remarks>
        /// Operation to check out a queue item
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request object for checking out an item from a queue. All properties are required except for historyNotes</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsQueuesCheckOutQueueItemResponse</returns>
        TrebuchetWebApiDataContractsQueuesCheckOutQueueItemResponse QueuesCheckOutQueueItemV1 (TrebuchetWebApiDataContractsQueuesCheckOutQueueItemRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Check a Business Object out of a queue
        /// </summary>
        /// <remarks>
        /// Operation to check out a queue item
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request object for checking out an item from a queue. All properties are required except for historyNotes</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsQueuesCheckOutQueueItemResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsQueuesCheckOutQueueItemResponse> QueuesCheckOutQueueItemV1WithHttpInfo (TrebuchetWebApiDataContractsQueuesCheckOutQueueItemRequest request, string lang = null, string locale = null);
        /// <summary>
        /// Get available queues.
        /// </summary>
        /// <remarks>
        /// Get available queues for a specific Business Object type based on scope, scope owner, and folder.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to get available queues for.</param>
        /// <param name="scopeowner">The scope owner to get available queues for.</param>
        /// <param name="folder">The folder to get available queues for.  This has to be the folder ID which can be retrieved by doing a getqueues operation without the folder including links option then the links will have the folder IDs.</param>
        /// <param name="links">Whether or not to include links. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsCoreManagerData</returns>
        ManagerData QueuesGetQueuesFolderV1 (string scope, string scopeowner, string folder, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get available queues.
        /// </summary>
        /// <remarks>
        /// Get available queues for a specific Business Object type based on scope, scope owner, and folder.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to get available queues for.</param>
        /// <param name="scopeowner">The scope owner to get available queues for.</param>
        /// <param name="folder">The folder to get available queues for.  This has to be the folder ID which can be retrieved by doing a getqueues operation without the folder including links option then the links will have the folder IDs.</param>
        /// <param name="links">Whether or not to include links. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsCoreManagerData</returns>
        ApiResponse<ManagerData> QueuesGetQueuesFolderV1WithHttpInfo (string scope, string scopeowner, string folder, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get available queues.
        /// </summary>
        /// <remarks>
        /// Get available queues for a specific Business Object type based on scope, and scope owner.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to get available queues for.</param>
        /// <param name="scopeowner">The scope owner to get available queues for.</param>
        /// <param name="links">Whether or not to include links. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsCoreManagerData</returns>
        ManagerData QueuesGetQueuesScopeOwnerV1 (string scope, string scopeowner, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get available queues.
        /// </summary>
        /// <remarks>
        /// Get available queues for a specific Business Object type based on scope, and scope owner.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to get available queues for.</param>
        /// <param name="scopeowner">The scope owner to get available queues for.</param>
        /// <param name="links">Whether or not to include links. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsCoreManagerData</returns>
        ApiResponse<ManagerData> QueuesGetQueuesScopeOwnerV1WithHttpInfo (string scope, string scopeowner, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get available queues.
        /// </summary>
        /// <remarks>
        /// Get available queues for a specific Business Object type based on scope.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to get available queues for.</param>
        /// <param name="links">Whether or not to include links. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsCoreManagerData</returns>
        ManagerData QueuesGetQueuesScopeV1 (string scope, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get available queues.
        /// </summary>
        /// <remarks>
        /// Get available queues for a specific Business Object type based on scope.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to get available queues for.</param>
        /// <param name="links">Whether or not to include links. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsCoreManagerData</returns>
        ApiResponse<ManagerData> QueuesGetQueuesScopeV1WithHttpInfo (string scope, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get available queues.
        /// </summary>
        /// <remarks>
        /// Get available queues for a specific Business Object.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Whether or not to include links. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsCoreManagerData</returns>
        ManagerData QueuesGetQueuesV1 (bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get available queues.
        /// </summary>
        /// <remarks>
        /// Get available queues for a specific Business Object.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Whether or not to include links. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsCoreManagerData</returns>
        ApiResponse<ManagerData> QueuesGetQueuesV1WithHttpInfo (bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Remove an item from a queue
        /// </summary>
        /// <remarks>
        /// Operation to remove an item from a queue
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request object to remove an item from a queue. All properties are required except for historyNotes</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsQueuesRemoveItemFromQueueResponse</returns>
        TrebuchetWebApiDataContractsQueuesRemoveItemFromQueueResponse QueuesRemoveItemFromQueueV1 (TrebuchetWebApiDataContractsQueuesRemoveItemFromQueueRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Remove an item from a queue
        /// </summary>
        /// <remarks>
        /// Operation to remove an item from a queue
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request object to remove an item from a queue. All properties are required except for historyNotes</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsQueuesRemoveItemFromQueueResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsQueuesRemoveItemFromQueueResponse> QueuesRemoveItemFromQueueV1WithHttpInfo (TrebuchetWebApiDataContractsQueuesRemoveItemFromQueueRequest request, string lang = null, string locale = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Add a Business Object to a queue
        /// </summary>
        /// <remarks>
        /// Operation to add a Business Object to a queue
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object containing all properties necessary to add an item to a queue. All properties are required. The standin key defines the queue to which we want to add the Business Object.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsQueuesAddItemToQueueResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsQueuesAddItemToQueueResponse> QueuesAddItemToQueueV1Async (TrebuchetWebApiDataContractsQueuesAddItemToQueueRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Add a Business Object to a queue
        /// </summary>
        /// <remarks>
        /// Operation to add a Business Object to a queue
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object containing all properties necessary to add an item to a queue. All properties are required. The standin key defines the queue to which we want to add the Business Object.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsQueuesAddItemToQueueResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsQueuesAddItemToQueueResponse>> QueuesAddItemToQueueV1AsyncWithHttpInfo (TrebuchetWebApiDataContractsQueuesAddItemToQueueRequest request, string lang = null, string locale = null);
        /// <summary>
        /// Check a Business Object in to a queue
        /// </summary>
        /// <remarks>
        /// Operation to check in a queue item
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request object for checking in an item to a queue. All properties are required except for historyNotes</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsQueuesCheckInQueueItemResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsQueuesCheckInQueueItemResponse> QueuesCheckInQueueItemV1Async (TrebuchetWebApiDataContractsQueuesCheckInQueueItemRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Check a Business Object in to a queue
        /// </summary>
        /// <remarks>
        /// Operation to check in a queue item
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request object for checking in an item to a queue. All properties are required except for historyNotes</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsQueuesCheckInQueueItemResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsQueuesCheckInQueueItemResponse>> QueuesCheckInQueueItemV1AsyncWithHttpInfo (TrebuchetWebApiDataContractsQueuesCheckInQueueItemRequest request, string lang = null, string locale = null);
        /// <summary>
        /// Check a Business Object out of a queue
        /// </summary>
        /// <remarks>
        /// Operation to check out a queue item
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request object for checking out an item from a queue. All properties are required except for historyNotes</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsQueuesCheckOutQueueItemResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsQueuesCheckOutQueueItemResponse> QueuesCheckOutQueueItemV1Async (TrebuchetWebApiDataContractsQueuesCheckOutQueueItemRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Check a Business Object out of a queue
        /// </summary>
        /// <remarks>
        /// Operation to check out a queue item
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request object for checking out an item from a queue. All properties are required except for historyNotes</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsQueuesCheckOutQueueItemResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsQueuesCheckOutQueueItemResponse>> QueuesCheckOutQueueItemV1AsyncWithHttpInfo (TrebuchetWebApiDataContractsQueuesCheckOutQueueItemRequest request, string lang = null, string locale = null);
        /// <summary>
        /// Get available queues.
        /// </summary>
        /// <remarks>
        /// Get available queues for a specific Business Object type based on scope, scope owner, and folder.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to get available queues for.</param>
        /// <param name="scopeowner">The scope owner to get available queues for.</param>
        /// <param name="folder">The folder to get available queues for.  This has to be the folder ID which can be retrieved by doing a getqueues operation without the folder including links option then the links will have the folder IDs.</param>
        /// <param name="links">Whether or not to include links. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsCoreManagerData</returns>
        System.Threading.Tasks.Task<ManagerData> QueuesGetQueuesFolderV1Async (string scope, string scopeowner, string folder, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get available queues.
        /// </summary>
        /// <remarks>
        /// Get available queues for a specific Business Object type based on scope, scope owner, and folder.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to get available queues for.</param>
        /// <param name="scopeowner">The scope owner to get available queues for.</param>
        /// <param name="folder">The folder to get available queues for.  This has to be the folder ID which can be retrieved by doing a getqueues operation without the folder including links option then the links will have the folder IDs.</param>
        /// <param name="links">Whether or not to include links. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsCoreManagerData)</returns>
        System.Threading.Tasks.Task<ApiResponse<ManagerData>> QueuesGetQueuesFolderV1AsyncWithHttpInfo (string scope, string scopeowner, string folder, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get available queues.
        /// </summary>
        /// <remarks>
        /// Get available queues for a specific Business Object type based on scope, and scope owner.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to get available queues for.</param>
        /// <param name="scopeowner">The scope owner to get available queues for.</param>
        /// <param name="links">Whether or not to include links. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsCoreManagerData</returns>
        System.Threading.Tasks.Task<ManagerData> QueuesGetQueuesScopeOwnerV1Async (string scope, string scopeowner, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get available queues.
        /// </summary>
        /// <remarks>
        /// Get available queues for a specific Business Object type based on scope, and scope owner.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to get available queues for.</param>
        /// <param name="scopeowner">The scope owner to get available queues for.</param>
        /// <param name="links">Whether or not to include links. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsCoreManagerData)</returns>
        System.Threading.Tasks.Task<ApiResponse<ManagerData>> QueuesGetQueuesScopeOwnerV1AsyncWithHttpInfo (string scope, string scopeowner, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get available queues.
        /// </summary>
        /// <remarks>
        /// Get available queues for a specific Business Object type based on scope.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to get available queues for.</param>
        /// <param name="links">Whether or not to include links. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsCoreManagerData</returns>
        System.Threading.Tasks.Task<ManagerData> QueuesGetQueuesScopeV1Async (string scope, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get available queues.
        /// </summary>
        /// <remarks>
        /// Get available queues for a specific Business Object type based on scope.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to get available queues for.</param>
        /// <param name="links">Whether or not to include links. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsCoreManagerData)</returns>
        System.Threading.Tasks.Task<ApiResponse<ManagerData>> QueuesGetQueuesScopeV1AsyncWithHttpInfo (string scope, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get available queues.
        /// </summary>
        /// <remarks>
        /// Get available queues for a specific Business Object.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Whether or not to include links. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsCoreManagerData</returns>
        System.Threading.Tasks.Task<ManagerData> QueuesGetQueuesV1Async (bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get available queues.
        /// </summary>
        /// <remarks>
        /// Get available queues for a specific Business Object.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Whether or not to include links. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsCoreManagerData)</returns>
        System.Threading.Tasks.Task<ApiResponse<ManagerData>> QueuesGetQueuesV1AsyncWithHttpInfo (bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Remove an item from a queue
        /// </summary>
        /// <remarks>
        /// Operation to remove an item from a queue
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request object to remove an item from a queue. All properties are required except for historyNotes</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsQueuesRemoveItemFromQueueResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsQueuesRemoveItemFromQueueResponse> QueuesRemoveItemFromQueueV1Async (TrebuchetWebApiDataContractsQueuesRemoveItemFromQueueRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Remove an item from a queue
        /// </summary>
        /// <remarks>
        /// Operation to remove an item from a queue
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request object to remove an item from a queue. All properties are required except for historyNotes</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsQueuesRemoveItemFromQueueResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsQueuesRemoveItemFromQueueResponse>> QueuesRemoveItemFromQueueV1AsyncWithHttpInfo (TrebuchetWebApiDataContractsQueuesRemoveItemFromQueueRequest request, string lang = null, string locale = null);
        #endregion Asynchronous Operations
    }
}