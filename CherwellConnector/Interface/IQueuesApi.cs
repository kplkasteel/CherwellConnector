using CherwellConnector.Client;
using CherwellConnector.Model;

namespace CherwellConnector.Interface
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IQueuesApi : IApiAccessor
    {
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
        /// <returns>AddItemToQueueResponse</returns>
        AddItemToQueueResponse QueuesAddItemToQueueV1 (AddItemToQueueRequest request, string lang = null, string locale = null);

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
        /// <returns>CheckInQueueItemResponse</returns>
        CheckInQueueItemResponse QueuesCheckInQueueItemV1 (CheckInQueueItemRequest request, string lang = null, string locale = null);

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
        /// <returns>CheckOutQueueItemResponse</returns>
        CheckOutQueueItemResponse QueuesCheckOutQueueItemV1 (CheckOutQueueItemRequest request, string lang = null, string locale = null);

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
        /// <returns>ManagerData</returns>
        ManagerData QueuesGetQueuesFolderV1 (string scope, string scopeowner, string folder, bool? links = null, string lang = null, string locale = null);

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
        /// <returns>ManagerData</returns>
        ManagerData QueuesGetQueuesScopeOwnerV1 (string scope, string scopeowner, bool? links = null, string lang = null, string locale = null);

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
        /// <returns>ManagerData</returns>
        ManagerData QueuesGetQueuesScopeV1 (string scope, bool? links = null, string lang = null, string locale = null);

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
        /// <returns>ManagerData</returns>
        ManagerData QueuesGetQueuesV1 (bool? links = null, string lang = null, string locale = null);

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
        /// <returns>RemoveItemFromQueueResponse</returns>
        RemoveItemFromQueueResponse QueuesRemoveItemFromQueueV1 (RemoveItemFromQueueRequest request, string lang = null, string locale = null);
    }
}