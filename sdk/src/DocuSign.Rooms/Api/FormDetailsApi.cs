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
    public interface IFormDetailsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Gets form based on Id.
        /// </summary>
        /// <remarks>
        /// Returns details about a specific form, such as the date it was created and last updated, the number of pages, the form owner, and other information.
        /// </remarks>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">(Required) The globally unique identifier (GUID) for the account.</param>
        /// <param name="formId">Form ID</param>
        /// <returns></returns>
        FormDetails GetFormDetails(string accountId, Guid? formId);

        /// <summary>
        /// Gets form based on Id.
        /// </summary>
        /// <remarks>
        /// Returns details about a specific form, such as the date it was created and last updated, the number of pages, the form owner, and other information.
        /// </remarks>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">(Required) The globally unique identifier (GUID) for the account.</param>
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of </returns>
        ApiResponse<FormDetails> GetFormDetailsWithHttpInfo(string accountId, Guid? formId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Gets form based on Id.
        /// </summary>
        /// <remarks>
        /// Returns details about a specific form, such as the date it was created and last updated, the number of pages, the form owner, and other information.
        /// </remarks>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">(Required) The globally unique identifier (GUID) for the account.</param>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of FormDetails</returns>
        System.Threading.Tasks.Task<FormDetails> GetFormDetailsAsync(string accountId, Guid? formId);

        /// <summary>
        /// Gets form based on Id.
        /// </summary>
        /// <remarks>
        /// Returns details about a specific form, such as the date it was created and last updated, the number of pages, the form owner, and other information.
        /// </remarks>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">(Required) The globally unique identifier (GUID) for the account.</param>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (FormDetails)</returns>
        System.Threading.Tasks.Task<ApiResponse<FormDetails>> GetFormDetailsAsyncWithHttpInfo(string accountId, Guid? formId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FormDetailsApi : IFormDetailsApi
    {
        private DocuSign.Rooms.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FormDetailsApi"/> class
        /// using AplClient object
        /// </summary>
        /// <param name="aplClient">An instance of AplClient</param>
        /// <returns></returns>
        public FormDetailsApi(DocuSignClient aplClient)
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
        /// Gets form based on Id. Returns details about a specific form, such as the date it was created and last updated, the number of pages, the form owner, and other information.
        /// </summary>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">(Required) The globally unique identifier (GUID) for the account.</param>
        /// <param name="formId">Form ID</param>
        /// <returns>FormDetails</returns>
        public FormDetails GetFormDetails(string accountId, Guid? formId)
        {
             ApiResponse<FormDetails> localVarResponse = GetFormDetailsWithHttpInfo(accountId, formId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets form based on Id. Returns details about a specific form, such as the date it was created and last updated, the number of pages, the form owner, and other information.
        /// </summary>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">(Required) The globally unique identifier (GUID) for the account.</param>
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of FormDetails</returns>
        public ApiResponse<FormDetails> GetFormDetailsWithHttpInfo(string accountId, Guid? formId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling FormDetailsApi->GetFormDetails");
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling FormDetailsApi->GetFormDetails");

            var localVarPath = "/v2/accounts/{accountId}/forms/{formId}/details";
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
            if (formId != null) localVarPathParams.Add("formId", this.ApiClient.ParameterToString(formId)); // path parameter

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
                Exception exception = ExceptionFactory("GetFormDetails", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FormDetails>(localVarStatusCode, 
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()), 
                (FormDetails)this.ApiClient.Deserialize(localVarResponse, typeof(FormDetails)));
        }

        /// <summary>
        /// Gets form based on Id. Returns details about a specific form, such as the date it was created and last updated, the number of pages, the form owner, and other information.
        /// </summary>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">(Required) The globally unique identifier (GUID) for the account.</param>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of FormDetails</returns>
        public async System.Threading.Tasks.Task<FormDetails> GetFormDetailsAsync(string accountId, Guid? formId)
        {
             ApiResponse<FormDetails> localVarResponse = await GetFormDetailsAsyncWithHttpInfo(accountId, formId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets form based on Id. Returns details about a specific form, such as the date it was created and last updated, the number of pages, the form owner, and other information.
        /// </summary>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">(Required) The globally unique identifier (GUID) for the account.</param>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (FormDetails)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FormDetails>> GetFormDetailsAsyncWithHttpInfo(string accountId, Guid? formId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling FormDetailsApi->GetFormDetails");
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling FormDetailsApi->GetFormDetails");

            var localVarPath = "/v2/accounts/{accountId}/forms/{formId}/details";
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
            if (formId != null) localVarPathParams.Add("formId", this.ApiClient.ParameterToString(formId)); // path parameter

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
                Exception exception = ExceptionFactory("GetFormDetails", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FormDetails>(localVarStatusCode, 
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()), 
                (FormDetails)this.ApiClient.Deserialize(localVarResponse, typeof(FormDetails)));
        }

    }
}