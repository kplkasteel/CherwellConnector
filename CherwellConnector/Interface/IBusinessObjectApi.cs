using System.Collections.Generic;
using CherwellConnector.Client;
using CherwellConnector.Model;


namespace CherwellConnector.Interface
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITrebuchetBusinessObjectApi : IApiAccessor
    {
        /// <summary>
        /// Delete Business Objects in a batch
        /// </summary>
        /// <remarks>
        /// Operation to delete a batch of Business Objects.
        /// </remarks>  
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Specify an array of Business Object IDs and record IDs or public IDs. Use a flag to stop on error or continue on error.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>BatchDeleteResponse</returns>
        BatchDeleteResponse BusinessObjectDeleteBusinessObjectBatchV1 (BatchDeleteRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Delete a Business Object by public ID
        /// </summary>
        /// <remarks>
        /// Operation to delete a Business Object by Business Object ID.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="publicid">Specify the Business Object public ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>DeleteResponse</returns>
        DeleteResponse BusinessObjectDeleteBusinessObjectByPublicIdV1 (string busobid, string publicid, string lang = null, string locale = null);

        /// <summary>
        /// Delete a Business Object by record ID
        /// </summary>
        /// <remarks>
        /// Operation to delete a single Business Object.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="busobrecid"> Specify the Business Object record ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>DeleteResponse</returns>
        DeleteResponse BusinessObjectDeleteBusinessObjectByRecIdV1 (string busobid, string busobrecid, string lang = null, string locale = null);

        /// <summary>
        /// Delete a related Business Object by public ID
        /// </summary>
        /// <remarks>
        /// Operation to delete a related Business Object. (Use \&quot;Unlink Related Business Object\&quot; to unlink two Business Objects rather that deleting the related Business Object.)
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="parentbusobid">Specify the Business Object ID for the parent Business Object.</param>
        /// <param name="parentbusobrecid">Specify the record ID for the parent Business Object</param>
        /// <param name="relationshipid">Specify the Relationship ID for the related Business Object you want to delete.</param>
        /// <param name="publicid">Specify the public ID for the related Business Object you want to delete. Use only for Business Objects with unique public IDs. Use \&quot;Delete a related Business Object by record ID\&quot; when public IDs are not unique.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>SearchesRelatedBusinessObjectResponse</returns>
        SearchesRelatedBusinessObjectResponse BusinessObjectDeleteRelatedBusinessObjectByPublicIdV1 (string parentbusobid, string parentbusobrecid, string relationshipid, string publicid, string lang = null, string locale = null);

         /// <summary>
        /// Delete a related Business Object by record ID
        /// </summary>
        /// <remarks>
        /// Operation to delete a related Business Object. (Use \&quot;Unlink Related Business Object\&quot; to unlink two Business Objects rather that deleting the related Business Object.)
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="parentbusobid">Specify the Business Object ID for the parent Business Object.</param>
        /// <param name="parentbusobrecid">Specify the record ID for the parent Business Object</param>
        /// <param name="relationshipid">Specify the Relationship ID for the related Business Object you want to delete.</param>
        /// <param name="busobrecid">Specify the record ID for the related Business Object you want to delete.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>SearchesRelatedBusinessObjectResponse</returns>
        SearchesRelatedBusinessObjectResponse BusinessObjectDeleteRelatedBusinessObjectByRecIdV1 (string parentbusobid, string parentbusobrecid, string relationshipid, string busobrecid, string lang = null, string locale = null);

     /// <summary>
        /// Get lookup values for fields
        /// </summary>
        /// <remarks>
        /// Operation to get potentially valid values for Business Object fields.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object that specifies the Business Object and fields for which values are to be returned.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>FieldValuesLookupResponse</returns>
        FieldValuesLookupResponse BusinessObjectFieldValuesLookupV1 (FieldValuesLookupRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Retrieve all activities for a business object
        /// </summary>
        /// <remarks>
        /// Operation to retrieve all activities for a business object. Activities are mapped to history tracking business objects.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="busobrecid">Specify the Business Object record ID.</param>
        /// <param name="pageSize">Specify the number of rows to return per page. Maximum value is 2000 per page.</param>
        /// <param name="pageNumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="activityType">The category of activities to retrieve. Will default to All if not specified. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;BusObActivity&gt;</returns>
        List<BusObActivity> BusinessObjectGetActivitiesV1 (string busobid, string busobrecid, int? pageSize, int? pageNumber = null, string activityType = null, string lang = null, string locale = null);

        /// <summary>
        /// Get an imported Business Object attachment
        /// </summary>
        /// <remarks>
        /// Operation to get a Business Object attachment that has been imported into the system.  HTTP Range Header can be used but is optional.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="attachmentid">Specify the internal ID of the attachment record that contains information about the imported file.</param>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="busobrecid">Specify the Business Object record ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>byte[]</returns>
        byte[] BusinessObjectGetBusinessObjectAttachmentByAttachmentIdV1 (string attachmentid, string busobid, string busobrecid, string lang = null, string locale = null);

        /// <summary>
        /// Get attachments by Business Object public ID
        /// </summary>
        /// <remarks>
        /// Operation to get attachments for a Business Object by Business Object ID and public ID.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="publicid">Specify the Business Object public ID for the record that contains the attachments.</param>
        /// <param name="type">Record attachment type: &lt;/br&gt;&lt;/br&gt;None - Not applicable to the REST API. &lt;/br&gt;&lt;/br&gt;File - Linked files. &lt;/br&gt;&lt;/br&gt;FileManagerFile - Imported files.&lt;/br&gt;&lt;/br&gt;BusOb - Attached Business Objects. &lt;/br&gt;&lt;/br&gt;History - Information about the attachment, if any is available. For example, an e-mail message may store the name of an attachment sent.&lt;/br&gt;&lt;/br&gt;Other - Not applicable to the REST API. &lt;/br&gt;</param>
        /// <param name="attachmenttype">For file types, select the type of attachment: &lt;/br&gt;&lt;/br&gt;Imported - Attachment was imported into database. &lt;/br&gt;&lt;/br&gt;Linked - Attachment is linked to an external file. &lt;/br&gt;&lt;/br&gt;URL - Attachment is a URL.</param>
        /// <param name="includelinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>AttachmentsResponse</returns>
        AttachmentsResponse BusinessObjectGetBusinessObjectAttachmentsByIdAndPublicIdV1 (string busobid, string publicid, string type, string attachmenttype, bool? includelinks = null, string lang = null, string locale = null);

        /// <summary>
        /// Get attachments by Business Object record ID
        /// </summary>
        /// <remarks>
        /// Operation to get attachments for a Business Object by Business Object ID and record ID.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="busobrecid">Specify the Business Object record ID.</param>
        /// <param name="type">Record attachment type: &lt;/br&gt;&lt;/br&gt;None - Not applicable to the REST API. &lt;/br&gt;&lt;/br&gt;File - Linked files. &lt;/br&gt;&lt;/br&gt;FileManagerFile - Imported files.&lt;/br&gt;&lt;/br&gt;BusOb - Attached Business Objects. &lt;/br&gt;&lt;/br&gt;History - Information about the attachment, if any is available. For example, an e-mail message may store the name of an attachment sent.&lt;/br&gt;&lt;/br&gt;Other - Not applicable to the REST API. &lt;/br&gt;</param>
        /// <param name="attachmenttype">For file types, select the type of attachment: &lt;/br&gt;&lt;/br&gt;Imported - Attachment was imported into database. &lt;/br&gt;&lt;/br&gt;Linked - Attachment is linked to an external file. &lt;/br&gt;&lt;/br&gt;URL - Attachment is a URL.</param>
        /// <param name="includelinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>AttachmentsResponse</returns>
        AttachmentsResponse BusinessObjectGetBusinessObjectAttachmentsByIdAndRecIdV1 (string busobid, string busobrecid, string type, string attachmenttype, bool? includelinks = null, string lang = null, string locale = null);

        /// <summary>
        /// Get attachments by Business Object name and public ID
        /// </summary>
        /// <remarks>
        /// Operation to get attachments for a Business Object by Business Object Name and public ID.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="publicid">Specify the Business Object public ID for the record that contains the attachments.</param>
        /// <param name="type">Record attachment type: &lt;/br&gt;&lt;/br&gt;None - Not applicable to the REST API. &lt;/br&gt;&lt;/br&gt;File - Linked files. &lt;/br&gt;&lt;/br&gt;FileManagerFile - Imported files.&lt;/br&gt;&lt;/br&gt;BusOb - Attached Business Objects. &lt;/br&gt;&lt;/br&gt;History - Information about the attachment, if any is available. For example, an e-mail message may store the name of an attachment sent.&lt;/br&gt;&lt;/br&gt;Other - Not applicable to the REST API. &lt;/br&gt;</param>
        /// <param name="attachmenttype">For file types, select the type of attachment: &lt;/br&gt;&lt;/br&gt;Imported - Attachment was imported into database. &lt;/br&gt;&lt;/br&gt;Linked - Attachment is linked to an external file. &lt;/br&gt;&lt;/br&gt;URL - Attachment is a URL.</param>
        /// <param name="includelinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>AttachmentsResponse</returns>
        AttachmentsResponse BusinessObjectGetBusinessObjectAttachmentsByNameAndPublicIdV1 (string busobname, string publicid, string type, string attachmenttype, bool? includelinks = null, string lang = null, string locale = null);

        /// <summary>
        /// Get attachments by Business Object name and record ID
        /// </summary>
        /// <remarks>
        /// Operation to get attachments for a Business Object by name and record ID.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="busobrecid">Specify the Business Object record ID.</param>
        /// <param name="type">Record attachment type: &lt;/br&gt;&lt;/br&gt;None - Not applicable to the REST API. &lt;/br&gt;&lt;/br&gt;File - Linked files. &lt;/br&gt;&lt;/br&gt;FileManagerFile - Imported files.&lt;/br&gt;&lt;/br&gt;BusOb - Attached Business Objects. &lt;/br&gt;&lt;/br&gt;History - Information about the attachment, if any is available. For example, an e-mail message may store the name of an attachment sent.&lt;/br&gt;&lt;/br&gt;Other - Not applicable to the REST API. &lt;/br&gt;</param>
        /// <param name="attachmenttype">For file types, select the type of attachment: &lt;/br&gt;&lt;/br&gt;Imported - Attachment was imported into database. &lt;/br&gt;&lt;/br&gt;Linked - Attachment is linked to an external file. &lt;/br&gt;&lt;/br&gt;URL - Attachment is a URL.</param>
        /// <param name="includelinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>AttachmentsResponse</returns>
        AttachmentsResponse BusinessObjectGetBusinessObjectAttachmentsByNameAndRecIdV1 (string busobname, string busobrecid, string type, string attachmenttype, bool? includelinks = null, string lang = null, string locale = null);

        /// <summary>
        /// Get Business Object attachments by request object
        /// </summary>
        /// <remarks>
        /// Operation to get attachments for a Business Object by attachments request object.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="attachmentsRequest">Object with all the parameters to request an attachments list. You can also request a list of types to get more than just one type at a time.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>AttachmentsResponse</returns>
        AttachmentsResponse BusinessObjectGetBusinessObjectAttachmentsV1 (AttachmentsRequest attachmentsRequest, string lang = null, string locale = null);

        /// <summary>
        /// Get a batch of Business Object records
        /// </summary>
        /// <remarks>
        /// Operation that returns a batch of Business Object records that includes a list of field record IDs, display names, and values for each record.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Specify an array of Business Object IDs, record IDs, or public IDs. Use a flag to stop on error or continue on error.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>BatchReadResponse</returns>
        BatchReadResponse BusinessObjectGetBusinessObjectBatchV1 (BatchReadRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Get a Business Object record
        /// </summary>
        /// <remarks>
        /// Operation that returns a Business Object record that includes a list of fields and their record IDs, names, and set values.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="publicid">Specify the Business Object public ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ReadResponse</returns>
        ReadResponse BusinessObjectGetBusinessObjectByPublicIdV1 (string busobid, string publicid, string lang = null, string locale = null);

        /// <summary>
        /// Get a Business Object record
        /// </summary>
        /// <remarks>
        /// Operation that returns a Business Object record that includes a list of fields and their record IDs, names, and set values.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="busobrecid">Specify the Business Object record ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ReadResponse</returns>
        ReadResponse BusinessObjectGetBusinessObjectByRecIdV1 (string busobid, string busobrecid, string lang = null, string locale = null);

        /// <summary>
        /// Get a Business Object by its scan code and Business Object ID
        /// </summary>
        /// <remarks>
        /// Operation to get a Business Object based on its associated scan code and Business Object ID.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scanCode">The scan code for a Business Object record.</param>
        /// <param name="busobid">The Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>BarcodeLookupResponse</returns>
        BarcodeLookupResponse BusinessObjectGetBusinessObjectByScanCodeBusObIdV1 (string scanCode, string busobid, string lang = null, string locale = null);

        /// <summary>
        /// Get a Business Object by its scan code and Business Object name
        /// </summary>
        /// <remarks>
        /// Operation to get a Business Object based on its associated scan code and Business Object name.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="scanCode">The scan code for a Business Object record.</param>
        /// <param name="busobname">The Business Bbject name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>BarcodeLookupResponse</returns>
        BarcodeLookupResponse BusinessObjectGetBusinessObjectByScanCodeBusObNameV1 (string scanCode, string busobname, string lang = null, string locale = null);

        /// <summary>
        /// Get a Business Object schema
        /// </summary>
        /// <remarks>
        /// Operation that returns the schema for a Business Object and, optionally, its related Business Objects.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobId">Specify the Business Object ID.</param>
        /// <param name="includerelationships">Flag to include schemas for related Business Object. Default is false. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>SchemaResponse</returns>
        SchemaResponse BusinessObjectGetBusinessObjectSchemaV1 (string busobId, bool? includerelationships = null, string lang = null, string locale = null);

        /// <summary>
        /// Get Business Object summaries by type
        /// </summary>
        /// <remarks>
        /// Operation that returns a list of Business Object summaries by type (Major, Supporting, Lookup, Groups, and All). 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Use to show:&lt;br /&gt;All - All objects&lt;br /&gt;Major - Major objects only&lt;br /&gt;Supporting - Supporting objects only&lt;br /&gt;Lookup - Lookup objects only&lt;br /&gt;Groups - Groups only</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;Summary&gt;</returns>
        List<Summary> BusinessObjectGetBusinessObjectSummariesV1 (string type, string lang = null, string locale = null);

        /// <summary>
        /// Get a Business Object summary by ID
        /// </summary>
        /// <remarks>
        /// Operation that returns a single Business Object summary by ID.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify a Business Object ID to get its summary.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;Summary&gt;</returns>
        List<Summary> BusinessObjectGetBusinessObjectSummaryByIdV1 (string busobid, string lang = null, string locale = null);

        /// <summary>
        /// Get a Business Object summary by name
        /// </summary>
        /// <remarks>
        /// Operation that returns a single Business Object summary by name.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify a Business Object name to get its summary.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>List&lt;Summary&gt;</returns>
        List<Summary> BusinessObjectGetBusinessObjectSummaryByNameV1 (string busobname, string lang = null, string locale = null);

        /// <summary>
        /// Get Business Object templates for create
        /// </summary>
        /// <remarks>
        /// Operation that returns a template to create Business Objects.  The template includes placeholders for field values. You can then send the template with these values to the Business Object Save operation.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Specify the Business Object ID. Use true to include all required fields or all fields. Specify an optional fields list by adding field names in a comma-delimited list [\&quot;field1\&quot;, \&quot;field2\&quot;]. </param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>TemplateResponse</returns>
        TemplateResponse BusinessObjectGetBusinessObjectTemplateV1 (TemplateRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Get related Business Objects using a request object
        /// </summary>
        /// <remarks>
        /// Operation to get related Business Objects for a specific relationship. Specify a list of fields to include in the response. The order of parameter usage and overrides is: all fields set to true overrides default overrides;  custom grid overrides field list settings.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="relatedBusinessObjectRequest">Request object containing all the possible parameters to get related Business Objects.</param>
        /// <param name="includelinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>SearchesRelatedBusinessObjectResponse</returns>
        SearchesRelatedBusinessObjectResponse BusinessObjectGetRelatedBusinessObjectByRequestV1 (RelatedBusinessObjectRequest relatedBusinessObjectRequest, bool? includelinks = null, string lang = null, string locale = null);

        /// <summary>
        /// Get related Business Objects by ID
        /// </summary>
        /// <remarks>
        /// Operation to get the related objects for a Business Object relationship specifying all fields or default grid as the field to return.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="parentbusobid">Specify the Business Object ID for the parent Business Object.</param>
        /// <param name="parentbusobrecid">Specify the record ID for the parent Business Object.</param>
        /// <param name="relationshipid">Specify the Relationship ID for the related Business Object you want to return.</param>
        /// <param name="pageNumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="pageSize">Specify the number of rows to return per page. (optional)</param>
        /// <param name="allfields">Flag to include all related Business Object fields.  Default is true if not supplied.  If true, then UseDefaultGrid is not used. (optional)</param>
        /// <param name="usedefaultgrid">Flag to trigger the use of the related Business Objects default grid for the list of fields to return. (optional)</param>
        /// <param name="includelinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>SearchesRelatedBusinessObjectResponse</returns>
        SearchesRelatedBusinessObjectResponse BusinessObjectGetRelatedBusinessObjectV1 (string parentbusobid, string parentbusobrecid, string relationshipid, int? pageNumber = null, int? pageSize = null, bool? allfields = null, bool? usedefaultgrid = null, bool? includelinks = null, string lang = null, string locale = null);

        /// <summary>
        /// Get related Business Objects custom grid
        /// </summary>
        /// <remarks>
        /// Operation to get related Business Objects for a specific relationship. Specify a custom grid ID as the fields to return.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="parentbusobid">Specify the Business Object ID for the parent Business Object.</param>
        /// <param name="parentbusobrecid">Specify the record ID for the parent Business Object.</param>
        /// <param name="relationshipid">Specify the Relationship ID for the related Business Object you want to return.</param>
        /// <param name="gridid">Specify the ID for the custom grid that contains the field list.</param>
        /// <param name="pageNumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="pageSize">Specify the number of rows to return per page. (optional)</param>
        /// <param name="includelinks">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>SearchesRelatedBusinessObjectResponse</returns>
        SearchesRelatedBusinessObjectResponse BusinessObjectGetRelatedBusinessObjectWithCustomGridV1 (string parentbusobid, string parentbusobrecid, string relationshipid, string gridid, int? pageNumber = null, int? pageSize = null, bool? includelinks = null, string lang = null, string locale = null);

        /// <summary>
        /// Link related Business Objects
        /// </summary>
        /// <remarks>
        /// Operation to link related Business Objects. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="parentbusobid">Specify the Business Object ID for the parent Business Object.</param>
        /// <param name="parentbusobrecid">Specify the record ID for the parent Business Object.</param>
        /// <param name="relationshipid">Specify the Relationship ID for the related Business Object you want to link.</param>
        /// <param name="busobid">Specify the Business Object ID of the Business Object to be linked.</param>
        /// <param name="busobrecid">Specify the Business Object record ID of the Business Object to be linked.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>SearchesRelatedBusinessObjectResponse</returns>
        SearchesRelatedBusinessObjectResponse BusinessObjectLinkRelatedBusinessObjectByRecIdV1 (string parentbusobid, string parentbusobrecid, string relationshipid, string busobid, string busobrecid, string lang = null, string locale = null);

        /// <summary>
        /// Link related Business Objects
        /// </summary>
        /// <remarks>
        /// Operation to link related Business Objects. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="parentbusobid">Specify the Business Object ID for the parent Business Object.</param>
        /// <param name="parentbusobrecid">Specify the record ID for the parent Business Object.</param>
        /// <param name="relationshipid">Specify the Relationship ID for the related Business Object you want to link.</param>
        /// <param name="busobid">Specify the Business Object ID of the Business Object to be linked.</param>
        /// <param name="busobrecid">Specify the Business Object record ID of the Business Object to be linked.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>ResponseBase</returns>
        ResponseBase BusinessObjectLinkRelatedBusinessObjectByRecIdV2 (string parentbusobid, string parentbusobrecid, string relationshipid, string busobid, string busobrecid, string lang = null, string locale = null);

        /// <summary>
        /// Remove an attachment by Business Object ID and public ID
        /// </summary>
        /// <remarks>
        /// Operation to remove an attachment from a Business Object using the attachment record ID, Business Object ID, and Business Object public ID.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="attachmentid">Specify the internal ID of the attachment record.</param>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="publicid">Specify the Business Object public ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Object</returns>
        object BusinessObjectRemoveBusinessObjectAttachmentByIdAndPublicIdV1 (string attachmentid, string busobid, string publicid, string lang = null, string locale = null);

        /// <summary>
        /// Remove an attachment by Business Object ID and record ID
        /// </summary>
        /// <remarks>
        /// Operation to remove an attachment from a Business Object using the attachment record ID, Business Object ID, and Business Object record ID.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>   
        /// <param name="attachmentid">Specify the internal ID of the attachment record.</param>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="busobrecid">Specify the Business Object record ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Object</returns>
        object BusinessObjectRemoveBusinessObjectAttachmentByIdAndRecIdV1 (string attachmentid, string busobid, string busobrecid, string lang = null, string locale = null);

        /// <summary>
        /// Remove an attachment by Business Object name and public ID
        /// </summary>
        /// <remarks>
        /// Operation to remove an attachment from a Business Object using the attachment record ID, Business Object name, and Business Object record ID.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="attachmentid">Specify the internal ID of the attachment record.</param>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="publicid">Specify the Business Object public ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Object</returns>
        object BusinessObjectRemoveBusinessObjectAttachmentByNameAndPublicIdV1 (string attachmentid, string busobname, string publicid, string lang = null, string locale = null);
        
        /// <summary>
        /// Remove an attachment by Business Object name and record ID
        /// </summary>
        /// <remarks>
        /// Operation to remove an attachment from a Business Object using the attachment record ID, Business Object name, and Business Object public ID.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="attachmentid">Specify the internal ID of the attachment record.</param>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="busobrecid">Specify the Business Object record ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Object</returns>
        object BusinessObjectRemoveBusinessObjectAttachmentByNameAndRecIdV1 (string attachmentid, string busobname, string busobrecid, string lang = null, string locale = null);

        /// <summary>
        /// Attach a Business Object to a Business Object
        /// </summary>
        /// <remarks>
        /// Operation to attach a Business Object to a Business Object. This links the Business Object but does not create a relationship between the two. (Use \&quot;Link Related Business Objects\&quot; to create a relationship.)
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object used to specify the Business Objects to attach. You can use Business Object name or ID and Business Object record ID or public ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>AttachmentsResponse</returns>
        AttachmentsResponse BusinessObjectSaveBusinessObjectAttachmentBusObV1 (SaveBusObAttachmentRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Attach a file via UNC
        /// </summary>
        /// <remarks>
        /// Operation to attach a file to a Business Object via a path (UNC recommended).
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object used to specify the file path (UNC recommended) and the Business Object. You can use Business Object name or ID and Business Object record ID or public ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>AttachmentsResponse</returns>
        AttachmentsResponse BusinessObjectSaveBusinessObjectAttachmentLinkV1 (SaveLinkAttachmentRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Attach a URL path
        /// </summary>
        /// <remarks>
        /// Operation to attach a URL path to a Business Object.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object used to specify the URL path and Business Object. You can use Business Object name or ID and Business Object record ID or public ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>AttachmentsResponse</returns>
        AttachmentsResponse BusinessObjectSaveBusinessObjectAttachmentUrlV1 (SaveUrlAttachmentRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Create or update a batch of Business Objects
        /// </summary>
        /// <remarks>
        /// Operation that creates or updates an array of Business Objects in a batch. To update, specify record ID or public ID. To create, leave record ID and public ID empty.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Specify the array of Business Object templates. </param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>BatchSaveResponse</returns>
        BatchSaveResponse BusinessObjectSaveBusinessObjectBatchV1 (BatchSaveRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Create or Update a Business Object
        /// </summary>
        /// <remarks>
        /// Operation that creates a new Business Object or updates an existing Business Object. To create, leave record ID and public ID empty. Upon creating or saving, a cache key is returned to use for subsequent requests. If the object is not found in the cache with said cache key, specify record ID or public ID to save and return a new cache key. Set persist &#x3D; true, to actually save the Business Object to disk, persist &#x3D; false will just cache it.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Specify a list of fields from a Business Object template. </param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>SaveResponse</returns>
        SaveResponse BusinessObjectSaveBusinessObjectV1 (SaveRequest request, string lang = null, string locale = null);

        /// <summary>
        /// Create or update a related Business Object
        /// </summary>
        /// <remarks>
        /// Operation that creates or updates a related Business Object. To update, specify record ID or public ID. To create, leave record ID and public ID empty.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object specifying the parent the Business Object, the Relationship, and field values for the Business Object to create or update. </param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>RelatedSaveResponse</returns>
        RelatedSaveResponse BusinessObjectSaveRelatedBusinessObjectV1 (RelatedSaveRequest request, string lang = null, string locale = null);

        /// <summary>
        /// UnLink related Business Objects
        /// </summary>
        /// <remarks>
        /// Operation to unlink related Business Objects.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="parentbusobid">Specify the Business Object ID for the parent Business Object.</param>
        /// <param name="parentbusobrecid">Specify the record ID for the parent Business Object.</param>
        /// <param name="relationshipid">Specify the Relationship ID for the related Business Object you want to unlink.</param>
        /// <param name="busobid">Specify the Business Object ID of the Business Object to be unlinked.</param>
        /// <param name="busobrecid">Specify the Business Object record ID of the Business Object to be unlinked.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>SearchesRelatedBusinessObjectResponse</returns>
        SearchesRelatedBusinessObjectResponse BusinessObjectUnLinkRelatedBusinessObjectByRecIdV1 (string parentbusobid, string parentbusobrecid, string relationshipid, string busobid, string busobrecid, string lang = null, string locale = null);

        /// <summary>
        /// Upload an attachment by Business Object ID and public ID
        /// </summary>
        /// <remarks>
        /// Operation to upload an attachment to a Business Object record using a Business Object ID and public ID. The body of the request is the byte array of the file part being uploaded.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="filename">Specify the name of the file being uploaded. If no attachment name is provided, the file name is used.</param>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="publicid">Specify the Business Object public ID  to attach the file to.</param>
        /// <param name="offset">The offset is the starting index of the file part being uploaded.  If this is the first part then the offset will be zero.</param>
        /// <param name="totalsize">The entire file size in bytes.</param>
        /// <param name="attachmentid">Specify the attachment ID of an uploaded file to upload subsequent parts and ensure each part gets appended to the parts that have already been uploaded. (optional)</param>
        /// <param name="displaytext">Specify the attachment name, which is the display text for the attachment record. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>string</returns>
        string BusinessObjectUploadBusinessObjectAttachmentByIdAndPublicIdV1 (byte[] body, string filename, string busobid, string publicid, int? offset, int? totalsize, string attachmentid = null, string displaytext = null, string lang = null, string locale = null);

        /// <summary>
        /// Upload an attachment by Business Object ID and record ID
        /// </summary>
        /// <remarks>
        /// Operation to upload an attachment to a Business Object record using a Business Object ID and record ID. The body of the request is the byte array of the file part being uploaded.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="filename">Specify the name of the file being uploaded. If no attachment name is provided, the file name is used.</param>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="busobrecid">Specify the Business Object record ID to attach the file to.</param>
        /// <param name="offset">The offset is the starting index of the file part being uploaded.  If this is the first part then the offset will be zero.</param>
        /// <param name="totalsize">The entire file size in bytes.</param>
        /// <param name="attachmentid">Specify the attachment ID of an uploaded file to upload subsequent parts and ensure each part gets appended to the parts that have already been uploaded. (optional)</param>
        /// <param name="displaytext">Specify the attachment name, which is the display text for the attachment record. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>string</returns>
        string BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1 (byte[] body, string filename, string busobid, string busobrecid, int? offset, int? totalsize, string attachmentid = null, string displaytext = null, string lang = null, string locale = null);

        /// <summary>
        /// Upload an attachment by Business Object name and public ID
        /// </summary>
        /// <remarks>
        /// Operation to upload an attachment to a Business Object record using a Business Object name and public ID. The body of the request is the byte array of the file part being uploaded.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="filename">Specify the name of the file being uploaded. If no attachment name is provided, the file name is used.</param>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="publicid">Specify the Business Object public ID  to attach the file to.</param>
        /// <param name="offset">The offset is the starting index of the file part being uploaded.  If this is the first part then the offset will be zero.</param>
        /// <param name="totalsize">The entire file size in bytes.</param>
        /// <param name="attachmentid">Specify the attachment ID of an uploaded file to upload subsequent parts and ensure each part gets appended to the parts that have already been uploaded. (optional)</param>
        /// <param name="displaytext">Specify the attachment name, which is the display text for the attachment record. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>string</returns>
        string BusinessObjectUploadBusinessObjectAttachmentByNameAndPublicIdV1 (byte[] body, string filename, string busobname, string publicid, int? offset, int? totalsize, string attachmentid = null, string displaytext = null, string lang = null, string locale = null);

        /// <summary>
        /// Upload an attachment by Business Object name and record ID
        /// </summary>
        /// <remarks>
        /// Operation to upload an attachment to a Business Object record using a Business Object name and record ID. The body of the request is the byte array of the file part being uploaded.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="filename">Specify the name of the file being uploaded. If no attachment name is provided, the file name is used.</param>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="busobrecid">Specify the Business Object record ID to attach the file to.</param>
        /// <param name="offset">The offset is the starting index of the file part being uploaded.  If this is the first part then the offset will be zero.</param>
        /// <param name="totalsize">The entire file size in bytes.</param>
        /// <param name="attachmentid">Specify the attachment ID of an uploaded file to upload subsequent parts and ensure each part gets appended to the parts that have already been uploaded. (optional)</param>
        /// <param name="displaytext">Specify the attachment name, which is the display text for the attachment record. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>string</returns>
        string BusinessObjectUploadBusinessObjectAttachmentByNameAndRecIdV1 (byte[] body, string filename, string busobname, string busobrecid, int? offset, int? totalsize, string attachmentid = null, string displaytext = null, string lang = null, string locale = null);
    }
}