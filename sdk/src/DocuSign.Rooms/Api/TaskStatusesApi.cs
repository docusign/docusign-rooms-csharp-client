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
    public interface ITaskStatusesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieves the list of valid task statuses.
        /// </summary>
        /// <remarks>
        /// Returns a list of valid task statuses.
        /// </remarks>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        GlobalTaskStatuses GetTaskStatuses();

        /// <summary>
        /// Retrieves the list of valid task statuses.
        /// </summary>
        /// <remarks>
        /// Returns a list of valid task statuses.
        /// </remarks>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of </returns>
        ApiResponse<GlobalTaskStatuses> GetTaskStatusesWithHttpInfo();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Retrieves the list of valid task statuses.
        /// </summary>
        /// <remarks>
        /// Returns a list of valid task statuses.
        /// </remarks>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of GlobalTaskStatuses</returns>
        System.Threading.Tasks.Task<GlobalTaskStatuses> GetTaskStatusesAsync();

        /// <summary>
        /// Retrieves the list of valid task statuses.
        /// </summary>
        /// <remarks>
        /// Returns a list of valid task statuses.
        /// </remarks>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (GlobalTaskStatuses)</returns>
        System.Threading.Tasks.Task<ApiResponse<GlobalTaskStatuses>> GetTaskStatusesAsyncWithHttpInfo();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TaskStatusesApi : ITaskStatusesApi
    {
        private DocuSign.Rooms.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskStatusesApi"/> class
        /// using AplClient object
        /// </summary>
        /// <param name="aplClient">An instance of AplClient</param>
        /// <returns></returns>
        public TaskStatusesApi(DocuSignClient aplClient)
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
        /// Retrieves the list of valid task statuses. Returns a list of valid task statuses.
        /// </summary>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>GlobalTaskStatuses</returns>
        public GlobalTaskStatuses GetTaskStatuses()
        {
             ApiResponse<GlobalTaskStatuses> localVarResponse = GetTaskStatusesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves the list of valid task statuses. Returns a list of valid task statuses.
        /// </summary>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of GlobalTaskStatuses</returns>
        public ApiResponse<GlobalTaskStatuses> GetTaskStatusesWithHttpInfo()
        {

            var localVarPath = "/v2/task_statuses";
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

            // authentication (docusignAccessCode) required
            // oauth required
            if (!String.IsNullOrEmpty(this.ApiClient.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.ApiClient.Configuration.AccessToken;
            }


            // make the HTTP request
            DocuSignRequest localVarRequest = this.ApiClient.PrepareRequest(localVarPath, new HttpMethod("GET"), localVarQueryParams.ToList(), localVarPostBody, localVarHeaderParams.ToList(), localVarFormParams.ToList(), localVarPathParams.ToList(), localVarFileParams, localVarHttpContentType, localVarHttpContentDisposition);
            DocuSignResponse localVarResponse = this.ApiClient.CallApi(localVarRequest);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetTaskStatuses", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GlobalTaskStatuses>(localVarStatusCode, 
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()), 
                (GlobalTaskStatuses)this.ApiClient.Deserialize(localVarResponse, typeof(GlobalTaskStatuses)));
        }

        /// <summary>
        /// Retrieves the list of valid task statuses. Returns a list of valid task statuses.
        /// </summary>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of GlobalTaskStatuses</returns>
        public async System.Threading.Tasks.Task<GlobalTaskStatuses> GetTaskStatusesAsync()
        {
             ApiResponse<GlobalTaskStatuses> localVarResponse = await GetTaskStatusesAsyncWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves the list of valid task statuses. Returns a list of valid task statuses.
        /// </summary>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (GlobalTaskStatuses)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GlobalTaskStatuses>> GetTaskStatusesAsyncWithHttpInfo()
        {

            var localVarPath = "/v2/task_statuses";
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

            // authentication (docusignAccessCode) required
            // oauth required
            if (!String.IsNullOrEmpty(this.ApiClient.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.ApiClient.Configuration.AccessToken;
            }


            // make the HTTP request
            DocuSignRequest localVarRequest = this.ApiClient.PrepareRequest(localVarPath, new HttpMethod("GET"), localVarQueryParams.ToList(), localVarPostBody, localVarHeaderParams.ToList(), localVarFormParams.ToList(), localVarPathParams.ToList(), localVarFileParams, localVarHttpContentType, localVarHttpContentDisposition);
            DocuSignResponse localVarResponse = await this.ApiClient.CallApiAsync(localVarRequest);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetTaskStatuses", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GlobalTaskStatuses>(localVarStatusCode, 
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()), 
                (GlobalTaskStatuses)this.ApiClient.Deserialize(localVarResponse, typeof(GlobalTaskStatuses)));
        }

    }
}