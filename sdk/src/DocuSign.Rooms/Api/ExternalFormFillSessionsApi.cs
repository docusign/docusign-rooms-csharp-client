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
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using DocuSign.Rooms.Client;
using DocuSign.Rooms.Model;

namespace DocuSign.Rooms.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IExternalFormFillSessionsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Creates an external form fill session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>
        /// <param name="body"> (optional)</param>
        
        /// <returns></returns>
        ExternalFormFillSession CreateExternalFormFillSession (string accountId, ExternalFormFillSessionForCreate body = null);

        /// <summary>
        /// Creates an external form fill session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>
        /// <param name="body"> (optional)</param>
        
        /// <returns>ApiResponse of </returns>
        ApiResponse<ExternalFormFillSession> CreateExternalFormFillSessionWithHttpInfo (string accountId, ExternalFormFillSessionForCreate body = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Creates an external form fill session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>
        /// <param name="body"> (optional)</param>
        
        /// <returns>Task of ExternalFormFillSession</returns>
        System.Threading.Tasks.Task<ExternalFormFillSession> CreateExternalFormFillSessionAsync (string accountId, ExternalFormFillSessionForCreate body = null);

        /// <summary>
        /// Creates an external form fill session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>
        /// <param name="body"> (optional)</param>
        
        /// <returns>Task of ApiResponse (ExternalFormFillSession)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExternalFormFillSession>> CreateExternalFormFillSessionAsyncWithHttpInfo (string accountId, ExternalFormFillSessionForCreate body = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ExternalFormFillSessionsApi : IExternalFormFillSessionsApi
    {
        private DocuSign.Rooms.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalFormFillSessionsApi"/> class
        /// using AplClient object
        /// </summary>
        /// <param name="aplClient">An instance of AplClient</param>
        /// <returns></returns>
        public ExternalFormFillSessionsApi(ApiClient aplClient)
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
            return this.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Gets or sets the ApiClient object
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient { get; set; }

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
        /// Creates an external form fill session. 
        /// </summary>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>
        /// <param name="body"> (optional)</param>
        
        /// <returns>ExternalFormFillSession</returns>
        public ExternalFormFillSession CreateExternalFormFillSession (string accountId, ExternalFormFillSessionForCreate body = null)
        {
             ApiResponse<ExternalFormFillSession> localVarResponse = CreateExternalFormFillSessionWithHttpInfo(accountId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Creates an external form fill session. 
        /// </summary>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>
        /// <param name="body"> (optional)</param>
        
        /// <returns>ApiResponse of ExternalFormFillSession</returns>
        public ApiResponse< ExternalFormFillSession > CreateExternalFormFillSessionWithHttpInfo (string accountId, ExternalFormFillSessionForCreate body = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling ExternalFormFillSessionsApi->CreateExternalFormFillSession");

            var localVarPath = "/v2/accounts/{accountId}/external_form_fill_sessions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(this.ApiClient.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

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
                "text/json"
            };
            String localVarHttpHeaderAccept = this.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", this.ApiClient.ParameterToString(accountId)); // path parameter


            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (docusignAccessCode) required
            // oauth required
            if (!String.IsNullOrEmpty(this.ApiClient.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.ApiClient.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateExternalFormFillSession", localVarResponse);
                if (exception != null) throw exception;
            }

            
            // DocuSign: Handle for PDF return types
            if (localVarResponse.ContentType != null && !localVarResponse.ContentType.ToLower().Contains("json"))
            {
                return new ApiResponse<ExternalFormFillSession>(localVarStatusCode, localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()), (ExternalFormFillSession) this.ApiClient.Deserialize(localVarResponse.RawBytes, typeof(ExternalFormFillSession)));
            }
            else
            {
                return new ApiResponse<ExternalFormFillSession>(localVarStatusCode, localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()), (ExternalFormFillSession) this.ApiClient.Deserialize(localVarResponse, typeof(ExternalFormFillSession)));
            }
            
        }

        /// <summary>
        /// Creates an external form fill session. 
        /// </summary>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>
        /// <param name="body"> (optional)</param>
        
        /// <returns>Task of ExternalFormFillSession</returns>
        public async System.Threading.Tasks.Task<ExternalFormFillSession> CreateExternalFormFillSessionAsync (string accountId, ExternalFormFillSessionForCreate body = null)
        {
             ApiResponse<ExternalFormFillSession> localVarResponse = await CreateExternalFormFillSessionAsyncWithHttpInfo(accountId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Creates an external form fill session. 
        /// </summary>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>
        /// <param name="body"> (optional)</param>
        
        /// <returns>Task of ApiResponse (ExternalFormFillSession)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExternalFormFillSession>> CreateExternalFormFillSessionAsyncWithHttpInfo (string accountId, ExternalFormFillSessionForCreate body = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling ExternalFormFillSessionsApi->CreateExternalFormFillSession");

            var localVarPath = "/v2/accounts/{accountId}/external_form_fill_sessions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(this.ApiClient.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

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
                "text/json"
            };
            String localVarHttpHeaderAccept = this.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", this.ApiClient.ParameterToString(accountId)); // path parameter


            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (docusignAccessCode) required
            // oauth required
            if (!String.IsNullOrEmpty(this.ApiClient.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.ApiClient.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateExternalFormFillSession", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ExternalFormFillSession>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExternalFormFillSession) this.ApiClient.Deserialize(localVarResponse, typeof(ExternalFormFillSession)));
            
        }

    }
}