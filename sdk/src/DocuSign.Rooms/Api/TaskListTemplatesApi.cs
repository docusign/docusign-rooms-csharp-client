/* 
 * DocuSign Rooms API - v2
 *
 * An API for an integrator to access the features of DocuSign Rooms
 *
 * OpenAPI spec version: v2
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using DocuSign.Rooms.Client;
using DocuSign.Rooms.Model;

namespace DocuSign.Rooms.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITaskListTemplatesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Returns all task list templates for the company of the active user.
        /// </summary>
        /// <remarks>
        /// Returns all task list templates for the company of the active user.
        /// </remarks>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">(Required) The globally unique identifier (GUID) for the account.</param>
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns></returns>
        TaskListTemplateList GetTaskListTemplates(string accountId, TaskListTemplatesApi.GetTaskListTemplatesOptions options = null);

        /// <summary>
        /// Returns all task list templates for the company of the active user.
        /// </summary>
        /// <remarks>
        /// Returns all task list templates for the company of the active user.
        /// </remarks>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">(Required) The globally unique identifier (GUID) for the account.</param>
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>ApiResponse of </returns>
        ApiResponse<TaskListTemplateList> GetTaskListTemplatesWithHttpInfo(string accountId, TaskListTemplatesApi.GetTaskListTemplatesOptions options = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Returns all task list templates for the company of the active user.
        /// </summary>
        /// <remarks>
        /// Returns all task list templates for the company of the active user.
        /// </remarks>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">(Required) The globally unique identifier (GUID) for the account.</param>
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>Task of TaskListTemplateList</returns>
        System.Threading.Tasks.Task<TaskListTemplateList> GetTaskListTemplatesAsync(string accountId, TaskListTemplatesApi.GetTaskListTemplatesOptions options = null);

        /// <summary>
        /// Returns all task list templates for the company of the active user.
        /// </summary>
        /// <remarks>
        /// Returns all task list templates for the company of the active user.
        /// </remarks>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">(Required) The globally unique identifier (GUID) for the account.</param>
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>Task of ApiResponse (TaskListTemplateList)</returns>
        System.Threading.Tasks.Task<ApiResponse<TaskListTemplateList>> GetTaskListTemplatesAsyncWithHttpInfo(string accountId, TaskListTemplatesApi.GetTaskListTemplatesOptions options = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TaskListTemplatesApi : ITaskListTemplatesApi
    {
        private DocuSign.Rooms.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskListTemplatesApi"/> class
        /// using AplClient object
        /// </summary>
        /// <param name="aplClient">An instance of AplClient</param>
        /// <returns></returns>
        public TaskListTemplatesApi(DocuSignClient aplClient)
        {
            this.ApiClient = aplClient;

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.ApiClient.GetBasePath();
        }

        /// <summary>
        /// Gets or sets the ApiClient object
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public DocuSignClient ApiClient { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public DocuSign.Rooms.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }


        /// <summary>
        /// Returns all task list templates for the company of the active user. Returns all task list templates for the company of the active user.
        /// </summary>
        public class GetTaskListTemplatesOptions
        {
            /// The starting zero-based index position from which to start returning values. The default is &#x60;0&#x60;. 
            public int? startPosition {get; set;}
            /// The number of results to return. This value must be a number between &#x60;1&#x60; and &#x60;100&#x60; (default). 
            public int? count {get; set;}
        }

        /// <summary>
        /// Returns all task list templates for the company of the active user. Returns all task list templates for the company of the active user.
        /// </summary>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">(Required) The globally unique identifier (GUID) for the account.</param>
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>TaskListTemplateList</returns>
        public TaskListTemplateList GetTaskListTemplates(string accountId, TaskListTemplatesApi.GetTaskListTemplatesOptions options = null)
        {
             ApiResponse<TaskListTemplateList> localVarResponse = GetTaskListTemplatesWithHttpInfo(accountId, options);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns all task list templates for the company of the active user. Returns all task list templates for the company of the active user.
        /// </summary>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">(Required) The globally unique identifier (GUID) for the account.</param>
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>ApiResponse of TaskListTemplateList</returns>
        public ApiResponse<TaskListTemplateList> GetTaskListTemplatesWithHttpInfo(string accountId, TaskListTemplatesApi.GetTaskListTemplatesOptions options = null)
        {
            return GetTaskListTemplatesAsyncWithHttpInfo(accountId, options)
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();
        }

        /// <summary>
        /// Returns all task list templates for the company of the active user. Returns all task list templates for the company of the active user.
        /// </summary>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">(Required) The globally unique identifier (GUID) for the account.</param>
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>Task of TaskListTemplateList</returns>
        public async System.Threading.Tasks.Task<TaskListTemplateList> GetTaskListTemplatesAsync(string accountId, TaskListTemplatesApi.GetTaskListTemplatesOptions options = null)
        {
             ApiResponse<TaskListTemplateList> localVarResponse = await GetTaskListTemplatesAsyncWithHttpInfo(accountId, options);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns all task list templates for the company of the active user. Returns all task list templates for the company of the active user.
        /// </summary>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">(Required) The globally unique identifier (GUID) for the account.</param>
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>Task of ApiResponse (TaskListTemplateList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TaskListTemplateList>> GetTaskListTemplatesAsyncWithHttpInfo(string accountId, TaskListTemplatesApi.GetTaskListTemplatesOptions options = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling TaskListTemplatesApi->GetTaskListTemplates");

            var localVarPath = "/v2/accounts/{accountId}/task_list_templates";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(this.ApiClient.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new List<FileParameter>();
            Object localVarPostBody = null;
            String localVarHttpContentDisposition = string.Empty;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain", 
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", this.ApiClient.ParameterToString(accountId)); // path parameter
            if (options != null)
            {
                if (options.startPosition != null) localVarQueryParams.Add("startPosition", this.ApiClient.ParameterToString(options.startPosition)); // query parameter
                if (options.count != null) localVarQueryParams.Add("count", this.ApiClient.ParameterToString(options.count)); // query parameter
            }

            // authentication (docusignAccessCode) required
            // oauth required
            if (!String.IsNullOrEmpty(this.ApiClient.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.ApiClient.Configuration.AccessToken;
            }

            // make the HTTP request
            DocuSignRequest localVarRequest = this.ApiClient.PrepareRequest(localVarPath, HttpMethod.Get, localVarQueryParams.ToList(), localVarPostBody, localVarHeaderParams.ToList(), localVarFormParams.ToList(), localVarPathParams.ToList(), localVarFileParams, localVarHttpContentType, localVarHttpContentDisposition);
            DocuSignResponse localVarResponse = await this.ApiClient.CallApiAsync(localVarRequest);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetTaskListTemplates", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TaskListTemplateList>(localVarStatusCode, 
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()), 
                (TaskListTemplateList)this.ApiClient.Deserialize(localVarResponse, typeof(TaskListTemplateList)));
        }

    }
}