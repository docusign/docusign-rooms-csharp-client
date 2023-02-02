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
    public interface IPropertyTypesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieves the list of valid property types.
        /// </summary>
        /// <remarks>
        /// Returns a list of property types.
        /// </remarks>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        GlobalPropertyTypes GetPropertyTypes();

        /// <summary>
        /// Retrieves the list of valid property types.
        /// </summary>
        /// <remarks>
        /// Returns a list of property types.
        /// </remarks>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of </returns>
        ApiResponse<GlobalPropertyTypes> GetPropertyTypesWithHttpInfo();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Retrieves the list of valid property types.
        /// </summary>
        /// <remarks>
        /// Returns a list of property types.
        /// </remarks>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of GlobalPropertyTypes</returns>
        System.Threading.Tasks.Task<GlobalPropertyTypes> GetPropertyTypesAsync();

        /// <summary>
        /// Retrieves the list of valid property types.
        /// </summary>
        /// <remarks>
        /// Returns a list of property types.
        /// </remarks>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (GlobalPropertyTypes)</returns>
        System.Threading.Tasks.Task<ApiResponse<GlobalPropertyTypes>> GetPropertyTypesAsyncWithHttpInfo();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PropertyTypesApi : IPropertyTypesApi
    {
        private DocuSign.Rooms.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyTypesApi"/> class
        /// using AplClient object
        /// </summary>
        /// <param name="aplClient">An instance of AplClient</param>
        /// <returns></returns>
        public PropertyTypesApi(DocuSignClient aplClient)
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
        /// Retrieves the list of valid property types. Returns a list of property types.
        /// </summary>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>GlobalPropertyTypes</returns>
        public GlobalPropertyTypes GetPropertyTypes()
        {
             ApiResponse<GlobalPropertyTypes> localVarResponse = GetPropertyTypesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves the list of valid property types. Returns a list of property types.
        /// </summary>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of GlobalPropertyTypes</returns>
        public ApiResponse<GlobalPropertyTypes> GetPropertyTypesWithHttpInfo()
        {
            return GetPropertyTypesAsyncWithHttpInfo()
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();
        }

        /// <summary>
        /// Retrieves the list of valid property types. Returns a list of property types.
        /// </summary>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of GlobalPropertyTypes</returns>
        public async System.Threading.Tasks.Task<GlobalPropertyTypes> GetPropertyTypesAsync()
        {
             ApiResponse<GlobalPropertyTypes> localVarResponse = await GetPropertyTypesAsyncWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves the list of valid property types. Returns a list of property types.
        /// </summary>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (GlobalPropertyTypes)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GlobalPropertyTypes>> GetPropertyTypesAsyncWithHttpInfo()
        {

            var localVarPath = "/v2/property_types";
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
            DocuSignRequest localVarRequest = this.ApiClient.PrepareRequest(localVarPath, HttpMethod.Get, localVarQueryParams.ToList(), localVarPostBody, localVarHeaderParams.ToList(), localVarFormParams.ToList(), localVarPathParams.ToList(), localVarFileParams, localVarHttpContentType, localVarHttpContentDisposition);
            DocuSignResponse localVarResponse = await this.ApiClient.CallApiAsync(localVarRequest);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPropertyTypes", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GlobalPropertyTypes>(localVarStatusCode, 
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()), 
                (GlobalPropertyTypes)this.ApiClient.Deserialize(localVarResponse, typeof(GlobalPropertyTypes)));
        }

    }
}