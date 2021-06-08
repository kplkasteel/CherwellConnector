using CherwellConnector.Client;
using CherwellConnector.Model;
using Object = System.Object;

namespace CherwellConnector.Interface
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICoreApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete a gallery image
        /// </summary>
        /// <remarks>
        /// Endpoint to delete a gallery image.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="standinkey">The StandIn key for the gallery image to delete.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns></returns>
        void CoreDeleteGalleryImageByStandInKeyV1 (string standinkey, string lang = null, string locale = null);

        /// <summary>
        /// Delete a gallery image
        /// </summary>
        /// <remarks>
        /// Endpoint to delete a gallery image.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="standinkey">The StandIn key for the gallery image to delete.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> CoreDeleteGalleryImageByStandInKeyV1WithHttpInfo (string standinkey, string lang = null, string locale = null);
        /// <summary>
        /// Get built-in images
        /// </summary>
        /// <remarks>
        /// Operation that gets built-in images. If you are requesting an icon (.ico), you can specify width and height.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Image name and folder location in the Image Manager. Parameter must begin with \&quot;[PlugIn]Images;\&quot; and then a period-separated list of folders. Example: \&quot;[PlugIn]Images;Images.Common.Cherwell.ico\&quot;.</param>
        /// <param name="width">Specify the width (icons only). (optional)</param>
        /// <param name="height">Specify the height (icons only). (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>string</returns>
        string CoreGetGalleryImageV1 (string name, int? width = null, int? height = null, string lang = null, string locale = null);

        /// <summary>
        /// Get built-in images
        /// </summary>
        /// <remarks>
        /// Operation that gets built-in images. If you are requesting an icon (.ico), you can specify width and height.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Image name and folder location in the Image Manager. Parameter must begin with \&quot;[PlugIn]Images;\&quot; and then a period-separated list of folders. Example: \&quot;[PlugIn]Images;Images.Common.Cherwell.ico\&quot;.</param>
        /// <param name="width">Specify the width (icons only). (optional)</param>
        /// <param name="height">Specify the height (icons only). (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> CoreGetGalleryImageV1WithHttpInfo (string name, int? width = null, int? height = null, string lang = null, string locale = null);
        /// <summary>
        /// Get gallery images by scope, scopeowner, and folder
        /// </summary>
        /// <remarks>
        /// Get gallery images for the specified scope, scopeowner, and folder.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to get gallery images for.</param>
        /// <param name="scopeowner">the scopeowner to get gallery images for.</param>
        /// <param name="folder">The folder to get gallery images for.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsCoreManagerData</returns>
        TrebuchetWebApiDataContractsCoreManagerData CoreGetGalleryImagesFolderV1 (string scope, string scopeowner, string folder, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get gallery images by scope, scopeowner, and folder
        /// </summary>
        /// <remarks>
        /// Get gallery images for the specified scope, scopeowner, and folder.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to get gallery images for.</param>
        /// <param name="scopeowner">the scopeowner to get gallery images for.</param>
        /// <param name="folder">The folder to get gallery images for.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsCoreManagerData</returns>
        ApiResponse<TrebuchetWebApiDataContractsCoreManagerData> CoreGetGalleryImagesFolderV1WithHttpInfo (string scope, string scopeowner, string folder, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get gallery images by scope and scopeowner
        /// </summary>
        /// <remarks>
        /// Get all gallery images for the specified scope and scope owner.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to get gallery images for.</param>
        /// <param name="scopeowner">The scopeowner to get gallery images for.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsCoreManagerData</returns>
        TrebuchetWebApiDataContractsCoreManagerData CoreGetGalleryImagesScopeOwnerV1 (string scope, string scopeowner, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get gallery images by scope and scopeowner
        /// </summary>
        /// <remarks>
        /// Get all gallery images for the specified scope and scope owner.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to get gallery images for.</param>
        /// <param name="scopeowner">The scopeowner to get gallery images for.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsCoreManagerData</returns>
        ApiResponse<TrebuchetWebApiDataContractsCoreManagerData> CoreGetGalleryImagesScopeOwnerV1WithHttpInfo (string scope, string scopeowner, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get gallery images by scope
        /// </summary>
        /// <remarks>
        /// Get all gallery images for the specified scope.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to get the images for.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsCoreManagerData</returns>
        TrebuchetWebApiDataContractsCoreManagerData CoreGetGalleryImagesScopeV1 (string scope, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get gallery images by scope
        /// </summary>
        /// <remarks>
        /// Get all gallery images for the specified scope.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to get the images for.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsCoreManagerData</returns>
        ApiResponse<TrebuchetWebApiDataContractsCoreManagerData> CoreGetGalleryImagesScopeV1WithHttpInfo (string scope, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get all gallery images
        /// </summary>
        /// <remarks>
        /// Get all the gallery images in the system.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsCoreManagerData</returns>
        TrebuchetWebApiDataContractsCoreManagerData CoreGetGalleryImagesV1 (bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get all gallery images
        /// </summary>
        /// <remarks>
        /// Get all the gallery images in the system.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsCoreManagerData</returns>
        ApiResponse<TrebuchetWebApiDataContractsCoreManagerData> CoreGetGalleryImagesV1WithHttpInfo (bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get a  stored value
        /// </summary>
        /// <remarks>
        /// Get a stored value by its StandIn key.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="standInKey">The StandIn key for the Stored Value you would like to retrieve.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsCoreStoredValueResponse</returns>
        TrebuchetWebApiDataContractsCoreStoredValueResponse CoreGetStoredValueV1 (string standInKey, string lang = null, string locale = null);

        /// <summary>
        /// Get a  stored value
        /// </summary>
        /// <remarks>
        /// Get a stored value by its StandIn key.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="standInKey">The StandIn key for the Stored Value you would like to retrieve.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsCoreStoredValueResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsCoreStoredValueResponse> CoreGetStoredValueV1WithHttpInfo (string standInKey, string lang = null, string locale = null);
        /// <summary>
        /// Get stored values by folder
        /// </summary>
        /// <remarks>
        /// Get stored values for the specified folder.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope for which to get stored values.</param>
        /// <param name="scopeowner">The scope owner for which to get stored values.</param>
        /// <param name="folder">The folder for which to get stored values.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsCoreManagerData</returns>
        TrebuchetWebApiDataContractsCoreManagerData CoreGetStoredValuesFolderV1 (string scope, string scopeowner, string folder, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get stored values by folder
        /// </summary>
        /// <remarks>
        /// Get stored values for the specified folder.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope for which to get stored values.</param>
        /// <param name="scopeowner">The scope owner for which to get stored values.</param>
        /// <param name="folder">The folder for which to get stored values.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsCoreManagerData</returns>
        ApiResponse<TrebuchetWebApiDataContractsCoreManagerData> CoreGetStoredValuesFolderV1WithHttpInfo (string scope, string scopeowner, string folder, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get stored values by scope owner
        /// </summary>
        /// <remarks>
        /// Get stored values for the specified scope and scope owner.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope for which to get stored values.</param>
        /// <param name="scopeowner">The scope owner for which to get stored values.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsCoreManagerData</returns>
        TrebuchetWebApiDataContractsCoreManagerData CoreGetStoredValuesScopeOwnerV1 (string scope, string scopeowner, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get stored values by scope owner
        /// </summary>
        /// <remarks>
        /// Get stored values for the specified scope and scope owner.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope for which to get stored values.</param>
        /// <param name="scopeowner">The scope owner for which to get stored values.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsCoreManagerData</returns>
        ApiResponse<TrebuchetWebApiDataContractsCoreManagerData> CoreGetStoredValuesScopeOwnerV1WithHttpInfo (string scope, string scopeowner, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get stored values by scope
        /// </summary>
        /// <remarks>
        /// Get all the stored values for the specified scope.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope for which to get stored values.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsCoreManagerData</returns>
        TrebuchetWebApiDataContractsCoreManagerData CoreGetStoredValuesScopeV1 (string scope, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get stored values by scope
        /// </summary>
        /// <remarks>
        /// Get all the stored values for the specified scope.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope for which to get stored values.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsCoreManagerData</returns>
        ApiResponse<TrebuchetWebApiDataContractsCoreManagerData> CoreGetStoredValuesScopeV1WithHttpInfo (string scope, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Gets all the stored values in the system
        /// </summary>
        /// <remarks>
        /// Get all the stored values in the system.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsCoreManagerData</returns>
        TrebuchetWebApiDataContractsCoreManagerData CoreGetStoredValuesV1 (bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Gets all the stored values in the system
        /// </summary>
        /// <remarks>
        /// Get all the stored values in the system.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsCoreManagerData</returns>
        ApiResponse<TrebuchetWebApiDataContractsCoreManagerData> CoreGetStoredValuesV1WithHttpInfo (bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get a list of the views
        /// </summary>
        /// <remarks>
        /// Operation to get a list of views that are configured in the system.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsCoreViewsResponse</returns>
        TrebuchetWebApiDataContractsCoreViewsResponse CoreGetViewsV1 (string lang = null, string locale = null);

        /// <summary>
        /// Get a list of the views
        /// </summary>
        /// <remarks>
        /// Operation to get a list of views that are configured in the system.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsCoreViewsResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsCoreViewsResponse> CoreGetViewsV1WithHttpInfo (string lang = null, string locale = null);
        /// <summary>
        /// Create or update a gallery image
        /// </summary>
        /// <remarks>
        /// Endpoint to Create or update a gallery image. To create a new gallery image leave the StandIn key blank. To update a gallery image provide the StandIn key of the gallery image you want to update.&lt;/br&gt;There are three different ImageTypes allowed: Imported, Url, and File. To use the Imported image type, provide the filename in the Name property, with extension, and provide the image data in a Base64 encoded format in the Base64EncodedImageData property. The max file size is 512k.&lt;/br&gt;To use the Url image type,  provide the full network share path to the file in the Name property, ie: \&quot;\\\\\\\\\\\\\\\\networkshare\\\\\\somefolder\\\\\\somefile.jpg\&quot;. If the file is not accessible to all users it will not visible to all users.&lt;/br&gt;To use the File image type, provide the full path to the file in the Name property, ie: \&quot;C:\\\\\\somefolder\\\\\\somfile.jpg\&quot;. If the file is not accessible to all users it will not visible to all users.&lt;/br&gt;When creating or updating an image, Name and ImageType are always required, and if the image type is \&quot;Imported\&quot;, then the Base64EncodedImageData is also required. &lt;/br&gt;scope, scopeowner, and folder can all be updated independently.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">To create a new gallery image leave the StandIn key blank. To update a gallery image provide the StandIn key of the gallery image you want to update.&lt;/br&gt;There are three different ImageTypes allowed: Imported, Url, and File. To use the Imported image type, provide the filename in the Name property, with extension, and provide the image data in a Base64 encoded format in the Base64EncodedImageData property. The max file size is 512k.&lt;/br&gt;To use the Url image type,  provide the full network share path to the file in the Name property, ie: \&quot;\\\\\\\\\\\\\\\\networkshare\\\\\\somefolder\\\\\\somefile.jpg\&quot;. If the file is not accessible to all users it will not visible to all users.&lt;/br&gt;To use the File image type, provide the full path to the file in the Name property, ie: \&quot;C:\\\\\\somefolder\\\\\\somfile.jpg\&quot;. If the file is not accessible to all users it will not visible to all users.&lt;/br&gt;When creating or updating an image, Name and ImageType are always required, and if the image type is \&quot;Imported\&quot;, then the Base64EncodedImageData is also required. &lt;/br&gt;scope, scopeowner, and folder can all be updated independently.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsCoreSaveGalleryImageResponse</returns>
        TrebuchetWebApiDataContractsCoreSaveGalleryImageResponse CoreSaveGalleryImageV1 (TrebuchetWebApiDataContractsCoreSaveGalleryImageRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Create or update a gallery image
        /// </summary>
        /// <remarks>
        /// Endpoint to Create or update a gallery image. To create a new gallery image leave the StandIn key blank. To update a gallery image provide the StandIn key of the gallery image you want to update.&lt;/br&gt;There are three different ImageTypes allowed: Imported, Url, and File. To use the Imported image type, provide the filename in the Name property, with extension, and provide the image data in a Base64 encoded format in the Base64EncodedImageData property. The max file size is 512k.&lt;/br&gt;To use the Url image type,  provide the full network share path to the file in the Name property, ie: \&quot;\\\\\\\\\\\\\\\\networkshare\\\\\\somefolder\\\\\\somefile.jpg\&quot;. If the file is not accessible to all users it will not visible to all users.&lt;/br&gt;To use the File image type, provide the full path to the file in the Name property, ie: \&quot;C:\\\\\\somefolder\\\\\\somfile.jpg\&quot;. If the file is not accessible to all users it will not visible to all users.&lt;/br&gt;When creating or updating an image, Name and ImageType are always required, and if the image type is \&quot;Imported\&quot;, then the Base64EncodedImageData is also required. &lt;/br&gt;scope, scopeowner, and folder can all be updated independently.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">To create a new gallery image leave the StandIn key blank. To update a gallery image provide the StandIn key of the gallery image you want to update.&lt;/br&gt;There are three different ImageTypes allowed: Imported, Url, and File. To use the Imported image type, provide the filename in the Name property, with extension, and provide the image data in a Base64 encoded format in the Base64EncodedImageData property. The max file size is 512k.&lt;/br&gt;To use the Url image type,  provide the full network share path to the file in the Name property, ie: \&quot;\\\\\\\\\\\\\\\\networkshare\\\\\\somefolder\\\\\\somefile.jpg\&quot;. If the file is not accessible to all users it will not visible to all users.&lt;/br&gt;To use the File image type, provide the full path to the file in the Name property, ie: \&quot;C:\\\\\\somefolder\\\\\\somfile.jpg\&quot;. If the file is not accessible to all users it will not visible to all users.&lt;/br&gt;When creating or updating an image, Name and ImageType are always required, and if the image type is \&quot;Imported\&quot;, then the Base64EncodedImageData is also required. &lt;/br&gt;scope, scopeowner, and folder can all be updated independently.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsCoreSaveGalleryImageResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsCoreSaveGalleryImageResponse> CoreSaveGalleryImageV1WithHttpInfo (TrebuchetWebApiDataContractsCoreSaveGalleryImageRequest request, string lang = null, string locale = null);
        /// <summary>
        /// Create or update a stored value
        /// </summary>
        /// <remarks>
        /// Operation to create or update a stored value. To update, specify the StandIn key for the stored value to update. To create leave StandIn key blank, and provide a name, a scope, a type, and a value.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The stored value to create or update. To update include the StandIn key for the associated stored value. To create, name, scope, type, and value are required.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsCoreStoredValueResponse</returns>
        TrebuchetWebApiDataContractsCoreStoredValueResponse CoreSaveStoredValueV1 (TrebuchetWebApiDataContractsCoreSaveStoredValueRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Create or update a stored value
        /// </summary>
        /// <remarks>
        /// Operation to create or update a stored value. To update, specify the StandIn key for the stored value to update. To create leave StandIn key blank, and provide a name, a scope, a type, and a value.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The stored value to create or update. To update include the StandIn key for the associated stored value. To create, name, scope, type, and value are required.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of TrebuchetWebApiDataContractsCoreStoredValueResponse</returns>
        ApiResponse<TrebuchetWebApiDataContractsCoreStoredValueResponse> CoreSaveStoredValueV1WithHttpInfo (TrebuchetWebApiDataContractsCoreSaveStoredValueRequest request, string lang = null, string locale = null);
        /// <summary>
        /// Set the culture for the current user
        /// </summary>
        /// <remarks>
        /// Operation to update the current users culture by culture code. This returns a new access token that has the updated information in it.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="culturecode">The culture code to set for the current user.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>string</returns>
        string CoreSetCultureV1 (string culturecode, string lang = null, string locale = null);

        /// <summary>
        /// Set the culture for the current user
        /// </summary>
        /// <remarks>
        /// Operation to update the current users culture by culture code. This returns a new access token that has the updated information in it.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="culturecode">The culture code to set for the current user.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> CoreSetCultureV1WithHttpInfo (string culturecode, string lang = null, string locale = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Delete a gallery image
        /// </summary>
        /// <remarks>
        /// Endpoint to delete a gallery image.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="standinkey">The StandIn key for the gallery image to delete.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task CoreDeleteGalleryImageByStandInKeyV1Async (string standinkey, string lang = null, string locale = null);

        /// <summary>
        /// Delete a gallery image
        /// </summary>
        /// <remarks>
        /// Endpoint to delete a gallery image.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="standinkey">The StandIn key for the gallery image to delete.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<object>> CoreDeleteGalleryImageByStandInKeyV1AsyncWithHttpInfo (string standinkey, string lang = null, string locale = null);
        /// <summary>
        /// Get built-in images
        /// </summary>
        /// <remarks>
        /// Operation that gets built-in images. If you are requesting an icon (.ico), you can specify width and height.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Image name and folder location in the Image Manager. Parameter must begin with \&quot;[PlugIn]Images;\&quot; and then a period-separated list of folders. Example: \&quot;[PlugIn]Images;Images.Common.Cherwell.ico\&quot;.</param>
        /// <param name="width">Specify the width (icons only). (optional)</param>
        /// <param name="height">Specify the height (icons only). (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> CoreGetGalleryImageV1Async (string name, int? width = null, int? height = null, string lang = null, string locale = null);

        /// <summary>
        /// Get built-in images
        /// </summary>
        /// <remarks>
        /// Operation that gets built-in images. If you are requesting an icon (.ico), you can specify width and height.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Image name and folder location in the Image Manager. Parameter must begin with \&quot;[PlugIn]Images;\&quot; and then a period-separated list of folders. Example: \&quot;[PlugIn]Images;Images.Common.Cherwell.ico\&quot;.</param>
        /// <param name="width">Specify the width (icons only). (optional)</param>
        /// <param name="height">Specify the height (icons only). (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> CoreGetGalleryImageV1AsyncWithHttpInfo (string name, int? width = null, int? height = null, string lang = null, string locale = null);
        /// <summary>
        /// Get gallery images by scope, scopeowner, and folder
        /// </summary>
        /// <remarks>
        /// Get gallery images for the specified scope, scopeowner, and folder.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to get gallery images for.</param>
        /// <param name="scopeowner">the scopeowner to get gallery images for.</param>
        /// <param name="folder">The folder to get gallery images for.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsCoreManagerData</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsCoreManagerData> CoreGetGalleryImagesFolderV1Async (string scope, string scopeowner, string folder, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get gallery images by scope, scopeowner, and folder
        /// </summary>
        /// <remarks>
        /// Get gallery images for the specified scope, scopeowner, and folder.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to get gallery images for.</param>
        /// <param name="scopeowner">the scopeowner to get gallery images for.</param>
        /// <param name="folder">The folder to get gallery images for.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsCoreManagerData)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsCoreManagerData>> CoreGetGalleryImagesFolderV1AsyncWithHttpInfo (string scope, string scopeowner, string folder, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get gallery images by scope and scopeowner
        /// </summary>
        /// <remarks>
        /// Get all gallery images for the specified scope and scope owner.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to get gallery images for.</param>
        /// <param name="scopeowner">The scopeowner to get gallery images for.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsCoreManagerData</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsCoreManagerData> CoreGetGalleryImagesScopeOwnerV1Async (string scope, string scopeowner, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get gallery images by scope and scopeowner
        /// </summary>
        /// <remarks>
        /// Get all gallery images for the specified scope and scope owner.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to get gallery images for.</param>
        /// <param name="scopeowner">The scopeowner to get gallery images for.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsCoreManagerData)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsCoreManagerData>> CoreGetGalleryImagesScopeOwnerV1AsyncWithHttpInfo (string scope, string scopeowner, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get gallery images by scope
        /// </summary>
        /// <remarks>
        /// Get all gallery images for the specified scope.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to get the images for.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsCoreManagerData</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsCoreManagerData> CoreGetGalleryImagesScopeV1Async (string scope, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get gallery images by scope
        /// </summary>
        /// <remarks>
        /// Get all gallery images for the specified scope.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to get the images for.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsCoreManagerData)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsCoreManagerData>> CoreGetGalleryImagesScopeV1AsyncWithHttpInfo (string scope, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get all gallery images
        /// </summary>
        /// <remarks>
        /// Get all the gallery images in the system.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsCoreManagerData</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsCoreManagerData> CoreGetGalleryImagesV1Async (bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get all gallery images
        /// </summary>
        /// <remarks>
        /// Get all the gallery images in the system.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsCoreManagerData)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsCoreManagerData>> CoreGetGalleryImagesV1AsyncWithHttpInfo (bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get a  stored value
        /// </summary>
        /// <remarks>
        /// Get a stored value by its StandIn key.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="standInKey">The StandIn key for the Stored Value you would like to retrieve.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsCoreStoredValueResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsCoreStoredValueResponse> CoreGetStoredValueV1Async (string standInKey, string lang = null, string locale = null);

        /// <summary>
        /// Get a  stored value
        /// </summary>
        /// <remarks>
        /// Get a stored value by its StandIn key.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="standInKey">The StandIn key for the Stored Value you would like to retrieve.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsCoreStoredValueResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsCoreStoredValueResponse>> CoreGetStoredValueV1AsyncWithHttpInfo (string standInKey, string lang = null, string locale = null);
        /// <summary>
        /// Get stored values by folder
        /// </summary>
        /// <remarks>
        /// Get stored values for the specified folder.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope for which to get stored values.</param>
        /// <param name="scopeowner">The scope owner for which to get stored values.</param>
        /// <param name="folder">The folder for which to get stored values.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsCoreManagerData</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsCoreManagerData> CoreGetStoredValuesFolderV1Async (string scope, string scopeowner, string folder, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get stored values by folder
        /// </summary>
        /// <remarks>
        /// Get stored values for the specified folder.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope for which to get stored values.</param>
        /// <param name="scopeowner">The scope owner for which to get stored values.</param>
        /// <param name="folder">The folder for which to get stored values.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsCoreManagerData)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsCoreManagerData>> CoreGetStoredValuesFolderV1AsyncWithHttpInfo (string scope, string scopeowner, string folder, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get stored values by scope owner
        /// </summary>
        /// <remarks>
        /// Get stored values for the specified scope and scope owner.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope for which to get stored values.</param>
        /// <param name="scopeowner">The scope owner for which to get stored values.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsCoreManagerData</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsCoreManagerData> CoreGetStoredValuesScopeOwnerV1Async (string scope, string scopeowner, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get stored values by scope owner
        /// </summary>
        /// <remarks>
        /// Get stored values for the specified scope and scope owner.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope for which to get stored values.</param>
        /// <param name="scopeowner">The scope owner for which to get stored values.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsCoreManagerData)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsCoreManagerData>> CoreGetStoredValuesScopeOwnerV1AsyncWithHttpInfo (string scope, string scopeowner, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get stored values by scope
        /// </summary>
        /// <remarks>
        /// Get all the stored values for the specified scope.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope for which to get stored values.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsCoreManagerData</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsCoreManagerData> CoreGetStoredValuesScopeV1Async (string scope, bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Get stored values by scope
        /// </summary>
        /// <remarks>
        /// Get all the stored values for the specified scope.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope for which to get stored values.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsCoreManagerData)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsCoreManagerData>> CoreGetStoredValuesScopeV1AsyncWithHttpInfo (string scope, bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Gets all the stored values in the system
        /// </summary>
        /// <remarks>
        /// Get all the stored values in the system.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsCoreManagerData</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsCoreManagerData> CoreGetStoredValuesV1Async (bool? links = null, string lang = null, string locale = null);

        /// <summary>
        /// Gets all the stored values in the system
        /// </summary>
        /// <remarks>
        /// Get all the stored values in the system.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Flag to include hyperlinks in results. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsCoreManagerData)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsCoreManagerData>> CoreGetStoredValuesV1AsyncWithHttpInfo (bool? links = null, string lang = null, string locale = null);
        /// <summary>
        /// Get a list of the views
        /// </summary>
        /// <remarks>
        /// Operation to get a list of views that are configured in the system.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsCoreViewsResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsCoreViewsResponse> CoreGetViewsV1Async (string lang = null, string locale = null);

        /// <summary>
        /// Get a list of the views
        /// </summary>
        /// <remarks>
        /// Operation to get a list of views that are configured in the system.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsCoreViewsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsCoreViewsResponse>> CoreGetViewsV1AsyncWithHttpInfo (string lang = null, string locale = null);
        /// <summary>
        /// Create or update a gallery image
        /// </summary>
        /// <remarks>
        /// Endpoint to Create or update a gallery image. To create a new gallery image leave the StandIn key blank. To update a gallery image provide the StandIn key of the gallery image you want to update.&lt;/br&gt;There are three different ImageTypes allowed: Imported, Url, and File. To use the Imported image type, provide the filename in the Name property, with extension, and provide the image data in a Base64 encoded format in the Base64EncodedImageData property. The max file size is 512k.&lt;/br&gt;To use the Url image type,  provide the full network share path to the file in the Name property, ie: \&quot;\\\\\\\\\\\\\\\\networkshare\\\\\\somefolder\\\\\\somefile.jpg\&quot;. If the file is not accessible to all users it will not visible to all users.&lt;/br&gt;To use the File image type, provide the full path to the file in the Name property, ie: \&quot;C:\\\\\\somefolder\\\\\\somfile.jpg\&quot;. If the file is not accessible to all users it will not visible to all users.&lt;/br&gt;When creating or updating an image, Name and ImageType are always required, and if the image type is \&quot;Imported\&quot;, then the Base64EncodedImageData is also required. &lt;/br&gt;scope, scopeowner, and folder can all be updated independently.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">To create a new gallery image leave the StandIn key blank. To update a gallery image provide the StandIn key of the gallery image you want to update.&lt;/br&gt;There are three different ImageTypes allowed: Imported, Url, and File. To use the Imported image type, provide the filename in the Name property, with extension, and provide the image data in a Base64 encoded format in the Base64EncodedImageData property. The max file size is 512k.&lt;/br&gt;To use the Url image type,  provide the full network share path to the file in the Name property, ie: \&quot;\\\\\\\\\\\\\\\\networkshare\\\\\\somefolder\\\\\\somefile.jpg\&quot;. If the file is not accessible to all users it will not visible to all users.&lt;/br&gt;To use the File image type, provide the full path to the file in the Name property, ie: \&quot;C:\\\\\\somefolder\\\\\\somfile.jpg\&quot;. If the file is not accessible to all users it will not visible to all users.&lt;/br&gt;When creating or updating an image, Name and ImageType are always required, and if the image type is \&quot;Imported\&quot;, then the Base64EncodedImageData is also required. &lt;/br&gt;scope, scopeowner, and folder can all be updated independently.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsCoreSaveGalleryImageResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsCoreSaveGalleryImageResponse> CoreSaveGalleryImageV1Async (TrebuchetWebApiDataContractsCoreSaveGalleryImageRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Create or update a gallery image
        /// </summary>
        /// <remarks>
        /// Endpoint to Create or update a gallery image. To create a new gallery image leave the StandIn key blank. To update a gallery image provide the StandIn key of the gallery image you want to update.&lt;/br&gt;There are three different ImageTypes allowed: Imported, Url, and File. To use the Imported image type, provide the filename in the Name property, with extension, and provide the image data in a Base64 encoded format in the Base64EncodedImageData property. The max file size is 512k.&lt;/br&gt;To use the Url image type,  provide the full network share path to the file in the Name property, ie: \&quot;\\\\\\\\\\\\\\\\networkshare\\\\\\somefolder\\\\\\somefile.jpg\&quot;. If the file is not accessible to all users it will not visible to all users.&lt;/br&gt;To use the File image type, provide the full path to the file in the Name property, ie: \&quot;C:\\\\\\somefolder\\\\\\somfile.jpg\&quot;. If the file is not accessible to all users it will not visible to all users.&lt;/br&gt;When creating or updating an image, Name and ImageType are always required, and if the image type is \&quot;Imported\&quot;, then the Base64EncodedImageData is also required. &lt;/br&gt;scope, scopeowner, and folder can all be updated independently.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">To create a new gallery image leave the StandIn key blank. To update a gallery image provide the StandIn key of the gallery image you want to update.&lt;/br&gt;There are three different ImageTypes allowed: Imported, Url, and File. To use the Imported image type, provide the filename in the Name property, with extension, and provide the image data in a Base64 encoded format in the Base64EncodedImageData property. The max file size is 512k.&lt;/br&gt;To use the Url image type,  provide the full network share path to the file in the Name property, ie: \&quot;\\\\\\\\\\\\\\\\networkshare\\\\\\somefolder\\\\\\somefile.jpg\&quot;. If the file is not accessible to all users it will not visible to all users.&lt;/br&gt;To use the File image type, provide the full path to the file in the Name property, ie: \&quot;C:\\\\\\somefolder\\\\\\somfile.jpg\&quot;. If the file is not accessible to all users it will not visible to all users.&lt;/br&gt;When creating or updating an image, Name and ImageType are always required, and if the image type is \&quot;Imported\&quot;, then the Base64EncodedImageData is also required. &lt;/br&gt;scope, scopeowner, and folder can all be updated independently.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsCoreSaveGalleryImageResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsCoreSaveGalleryImageResponse>> CoreSaveGalleryImageV1AsyncWithHttpInfo (TrebuchetWebApiDataContractsCoreSaveGalleryImageRequest request, string lang = null, string locale = null);
        /// <summary>
        /// Create or update a stored value
        /// </summary>
        /// <remarks>
        /// Operation to create or update a stored value. To update, specify the StandIn key for the stored value to update. To create leave StandIn key blank, and provide a name, a scope, a type, and a value.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The stored value to create or update. To update include the StandIn key for the associated stored value. To create, name, scope, type, and value are required.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsCoreStoredValueResponse</returns>
        System.Threading.Tasks.Task<TrebuchetWebApiDataContractsCoreStoredValueResponse> CoreSaveStoredValueV1Async (TrebuchetWebApiDataContractsCoreSaveStoredValueRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Create or update a stored value
        /// </summary>
        /// <remarks>
        /// Operation to create or update a stored value. To update, specify the StandIn key for the stored value to update. To create leave StandIn key blank, and provide a name, a scope, a type, and a value.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The stored value to create or update. To update include the StandIn key for the associated stored value. To create, name, scope, type, and value are required.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (TrebuchetWebApiDataContractsCoreStoredValueResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TrebuchetWebApiDataContractsCoreStoredValueResponse>> CoreSaveStoredValueV1AsyncWithHttpInfo (TrebuchetWebApiDataContractsCoreSaveStoredValueRequest request, string lang = null, string locale = null);
        /// <summary>
        /// Set the culture for the current user
        /// </summary>
        /// <remarks>
        /// Operation to update the current users culture by culture code. This returns a new access token that has the updated information in it.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="culturecode">The culture code to set for the current user.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> CoreSetCultureV1Async (string culturecode, string lang = null, string locale = null);

        /// <summary>
        /// Set the culture for the current user
        /// </summary>
        /// <remarks>
        /// Operation to update the current users culture by culture code. This returns a new access token that has the updated information in it.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="culturecode">The culture code to set for the current user.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> CoreSetCultureV1AsyncWithHttpInfo (string culturecode, string lang = null, string locale = null);
        #endregion Asynchronous Operations
    }
}