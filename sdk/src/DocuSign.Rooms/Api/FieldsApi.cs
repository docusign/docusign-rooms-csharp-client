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
    public interface IFieldsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get details of a specific field set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>/// <param name="fieldSetId"></param>
        
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns></returns>
        FieldSet GetFieldSet (string accountId, Guid? fieldSetId, FieldsApi.GetFieldSetOptions options = null);

        /// <summary>
        /// Get details of a specific field set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>/// <param name="fieldSetId"></param>
        
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>ApiResponse of </returns>
        ApiResponse<FieldSet> GetFieldSetWithHttpInfo (string accountId, Guid? fieldSetId, FieldsApi.GetFieldSetOptions options = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get details of a specific field set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>/// <param name="fieldSetId"></param>
        
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>Task of FieldSet</returns>
        System.Threading.Tasks.Task<FieldSet> GetFieldSetAsync (string accountId, Guid? fieldSetId, FieldsApi.GetFieldSetOptions options = null);

        /// <summary>
        /// Get details of a specific field set.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>/// <param name="fieldSetId"></param>
        
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>Task of ApiResponse (FieldSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<FieldSet>> GetFieldSetAsyncWithHttpInfo (string accountId, Guid? fieldSetId, FieldsApi.GetFieldSetOptions options = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FieldsApi : IFieldsApi
    {
        private DocuSign.Rooms.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldsApi"/> class
        /// using AplClient object
        /// </summary>
        /// <param name="aplClient">An instance of AplClient</param>
        /// <returns></returns>
        public FieldsApi(ApiClient aplClient)
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
        /// Get details of a specific field set. 
        /// </summary>
        public class GetFieldSetOptions
        {
            /// 
            public List<string> fieldsCustomDataFilters {get; set;}
        }

        /// <summary>
        /// Get details of a specific field set. 
        /// </summary>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>/// <param name="fieldSetId"></param>
        
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>FieldSet</returns>
        public FieldSet GetFieldSet (string accountId, Guid? fieldSetId, FieldsApi.GetFieldSetOptions options = null)
        {
             ApiResponse<FieldSet> localVarResponse = GetFieldSetWithHttpInfo(accountId, fieldSetId, options);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get details of a specific field set. 
        /// </summary>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>/// <param name="fieldSetId"></param>
        
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>ApiResponse of FieldSet</returns>
        public ApiResponse< FieldSet > GetFieldSetWithHttpInfo (string accountId, Guid? fieldSetId, FieldsApi.GetFieldSetOptions options = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling FieldsApi->GetFieldSet");
            // verify the required parameter 'fieldSetId' is set
            if (fieldSetId == null)
                throw new ApiException(400, "Missing required parameter 'fieldSetId' when calling FieldsApi->GetFieldSet");

            var localVarPath = "/v2/accounts/{accountId}/field_sets/{fieldSetId}";
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
                "application/json"
            };
            String localVarHttpHeaderAccept = this.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", this.ApiClient.ParameterToString(accountId)); // path parameter
            if (fieldSetId != null) localVarPathParams.Add("fieldSetId", this.ApiClient.ParameterToString(fieldSetId)); // path parameter

            if (options != null)
            {
                if (options.fieldsCustomDataFilters != null) localVarQueryParams.Add("fieldsCustomDataFilters", this.ApiClient.ParameterToString(options.fieldsCustomDataFilters)); // query parameter
            }


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
                Exception exception = ExceptionFactory("GetFieldSet", localVarResponse);
                if (exception != null) throw exception;
            }

            
            // DocuSign: Handle for PDF return types
            if (localVarResponse.ContentType != null && !localVarResponse.ContentType.ToLower().Contains("json"))
            {
                return new ApiResponse<FieldSet>(localVarStatusCode, localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()), (FieldSet) this.ApiClient.Deserialize(localVarResponse.RawBytes, typeof(FieldSet)));
            }
            else
            {
                return new ApiResponse<FieldSet>(localVarStatusCode, localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()), (FieldSet) this.ApiClient.Deserialize(localVarResponse, typeof(FieldSet)));
            }
            
        }

        /// <summary>
        /// Get details of a specific field set. 
        /// </summary>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>/// <param name="fieldSetId"></param>
        
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>Task of FieldSet</returns>
        public async System.Threading.Tasks.Task<FieldSet> GetFieldSetAsync (string accountId, Guid? fieldSetId, FieldsApi.GetFieldSetOptions options = null)
        {
             ApiResponse<FieldSet> localVarResponse = await GetFieldSetAsyncWithHttpInfo(accountId, fieldSetId, options);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get details of a specific field set. 
        /// </summary>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>/// <param name="fieldSetId"></param>
        
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>Task of ApiResponse (FieldSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FieldSet>> GetFieldSetAsyncWithHttpInfo (string accountId, Guid? fieldSetId, FieldsApi.GetFieldSetOptions options = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling FieldsApi->GetFieldSet");
            // verify the required parameter 'fieldSetId' is set
            if (fieldSetId == null)
                throw new ApiException(400, "Missing required parameter 'fieldSetId' when calling FieldsApi->GetFieldSet");

            var localVarPath = "/v2/accounts/{accountId}/field_sets/{fieldSetId}";
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
                "application/json"
            };
            String localVarHttpHeaderAccept = this.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", this.ApiClient.ParameterToString(accountId)); // path parameter
            if (fieldSetId != null) localVarPathParams.Add("fieldSetId", this.ApiClient.ParameterToString(fieldSetId)); // path parameter

            if (options != null)
            {
                if (options.fieldsCustomDataFilters != null) localVarQueryParams.Add("fieldsCustomDataFilters", this.ApiClient.ParameterToString(options.fieldsCustomDataFilters)); // query parameter
            }


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
                Exception exception = ExceptionFactory("GetFieldSet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FieldSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FieldSet) this.ApiClient.Deserialize(localVarResponse, typeof(FieldSet)));
            
        }

    }
}