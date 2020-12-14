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
    public interface IFormDetailsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Gets form based on Id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>/// <param name="formId">Form ID</param>
        
        
        /// <returns></returns>
        FormDetails GetFormDetails (string accountId, Guid? formId);

        /// <summary>
        /// Gets form based on Id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>/// <param name="formId">Form ID</param>
        
        
        /// <returns>ApiResponse of </returns>
        ApiResponse<FormDetails> GetFormDetailsWithHttpInfo (string accountId, Guid? formId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Gets form based on Id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>/// <param name="formId">Form ID</param>
        
        
        /// <returns>Task of FormDetails</returns>
        System.Threading.Tasks.Task<FormDetails> GetFormDetailsAsync (string accountId, Guid? formId);

        /// <summary>
        /// Gets form based on Id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>/// <param name="formId">Form ID</param>
        
        
        /// <returns>Task of ApiResponse (FormDetails)</returns>
        System.Threading.Tasks.Task<ApiResponse<FormDetails>> GetFormDetailsAsyncWithHttpInfo (string accountId, Guid? formId);
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
        public FormDetailsApi(ApiClient aplClient)
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
        /// Gets form based on Id. 
        /// </summary>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>/// <param name="formId">Form ID</param>
        
        
        /// <returns>FormDetails</returns>
        public FormDetails GetFormDetails (string accountId, Guid? formId)
        {
             ApiResponse<FormDetails> localVarResponse = GetFormDetailsWithHttpInfo(accountId, formId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets form based on Id. 
        /// </summary>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>/// <param name="formId">Form ID</param>
        
        
        /// <returns>ApiResponse of FormDetails</returns>
        public ApiResponse< FormDetails > GetFormDetailsWithHttpInfo (string accountId, Guid? formId)
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
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
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
            if (formId != null) localVarPathParams.Add("formId", this.ApiClient.ParameterToString(formId)); // path parameter



            // authentication (docusignAccessCode) required
            // oauth required
            if (!String.IsNullOrEmpty(this.ApiClient.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.ApiClient.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFormDetails", localVarResponse);
                if (exception != null) throw exception;
            }

            
            // DocuSign: Handle for PDF return types
            if (localVarResponse.ContentType != null && !localVarResponse.ContentType.ToLower().Contains("json"))
            {
                return new ApiResponse<FormDetails>(localVarStatusCode, localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()), (FormDetails) this.ApiClient.Deserialize(localVarResponse.RawBytes, typeof(FormDetails)));
            }
            else
            {
                return new ApiResponse<FormDetails>(localVarStatusCode, localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()), (FormDetails) this.ApiClient.Deserialize(localVarResponse, typeof(FormDetails)));
            }
            
        }

        /// <summary>
        /// Gets form based on Id. 
        /// </summary>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>/// <param name="formId">Form ID</param>
        
        
        /// <returns>Task of FormDetails</returns>
        public async System.Threading.Tasks.Task<FormDetails> GetFormDetailsAsync (string accountId, Guid? formId)
        {
             ApiResponse<FormDetails> localVarResponse = await GetFormDetailsAsyncWithHttpInfo(accountId, formId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets form based on Id. 
        /// </summary>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>/// <param name="formId">Form ID</param>
        
        
        /// <returns>Task of ApiResponse (FormDetails)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FormDetails>> GetFormDetailsAsyncWithHttpInfo (string accountId, Guid? formId)
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
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
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
            if (formId != null) localVarPathParams.Add("formId", this.ApiClient.ParameterToString(formId)); // path parameter



            // authentication (docusignAccessCode) required
            // oauth required
            if (!String.IsNullOrEmpty(this.ApiClient.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.ApiClient.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFormDetails", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FormDetails>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FormDetails) this.ApiClient.Deserialize(localVarResponse, typeof(FormDetails)));
            
        }

    }
}