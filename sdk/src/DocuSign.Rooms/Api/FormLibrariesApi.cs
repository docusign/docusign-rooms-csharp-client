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
    public interface IFormLibrariesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Gets a paged list of forms libraries.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>
        
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns></returns>
        FormLibrarySummaryList GetFormLibraries (string accountId, FormLibrariesApi.GetFormLibrariesOptions options = null);

        /// <summary>
        /// Gets a paged list of forms libraries.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>
        
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>ApiResponse of </returns>
        ApiResponse<FormLibrarySummaryList> GetFormLibrariesWithHttpInfo (string accountId, FormLibrariesApi.GetFormLibrariesOptions options = null);
        /// <summary>
        /// Gets a paged list of forms in a forms library.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>/// <param name="formLibraryId">Library Id</param>
        
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns></returns>
        FormSummaryList GetFormLibraryForms (string accountId, Guid? formLibraryId, FormLibrariesApi.GetFormLibraryFormsOptions options = null);

        /// <summary>
        /// Gets a paged list of forms in a forms library.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>/// <param name="formLibraryId">Library Id</param>
        
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>ApiResponse of </returns>
        ApiResponse<FormSummaryList> GetFormLibraryFormsWithHttpInfo (string accountId, Guid? formLibraryId, FormLibrariesApi.GetFormLibraryFormsOptions options = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Gets a paged list of forms libraries.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>
        
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>Task of FormLibrarySummaryList</returns>
        System.Threading.Tasks.Task<FormLibrarySummaryList> GetFormLibrariesAsync (string accountId, FormLibrariesApi.GetFormLibrariesOptions options = null);

        /// <summary>
        /// Gets a paged list of forms libraries.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>
        
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>Task of ApiResponse (FormLibrarySummaryList)</returns>
        System.Threading.Tasks.Task<ApiResponse<FormLibrarySummaryList>> GetFormLibrariesAsyncWithHttpInfo (string accountId, FormLibrariesApi.GetFormLibrariesOptions options = null);
        /// <summary>
        /// Gets a paged list of forms in a forms library.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>/// <param name="formLibraryId">Library Id</param>
        
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>Task of FormSummaryList</returns>
        System.Threading.Tasks.Task<FormSummaryList> GetFormLibraryFormsAsync (string accountId, Guid? formLibraryId, FormLibrariesApi.GetFormLibraryFormsOptions options = null);

        /// <summary>
        /// Gets a paged list of forms in a forms library.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>/// <param name="formLibraryId">Library Id</param>
        
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>Task of ApiResponse (FormSummaryList)</returns>
        System.Threading.Tasks.Task<ApiResponse<FormSummaryList>> GetFormLibraryFormsAsyncWithHttpInfo (string accountId, Guid? formLibraryId, FormLibrariesApi.GetFormLibraryFormsOptions options = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FormLibrariesApi : IFormLibrariesApi
    {
        private DocuSign.Rooms.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FormLibrariesApi"/> class
        /// using AplClient object
        /// </summary>
        /// <param name="aplClient">An instance of AplClient</param>
        /// <returns></returns>
        public FormLibrariesApi(ApiClient aplClient)
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
        /// Gets a paged list of forms libraries. 
        /// </summary>
        public class GetFormLibrariesOptions
        {
            /// Default value is 100 and max value is 100 
            public int? count {get; set;}
            /// Default value is 0 
            public int? startPosition {get; set;}
        }

        /// <summary>
        /// Gets a paged list of forms libraries. 
        /// </summary>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>
        
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>FormLibrarySummaryList</returns>
        public FormLibrarySummaryList GetFormLibraries (string accountId, FormLibrariesApi.GetFormLibrariesOptions options = null)
        {
             ApiResponse<FormLibrarySummaryList> localVarResponse = GetFormLibrariesWithHttpInfo(accountId, options);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets a paged list of forms libraries. 
        /// </summary>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>
        
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>ApiResponse of FormLibrarySummaryList</returns>
        public ApiResponse< FormLibrarySummaryList > GetFormLibrariesWithHttpInfo (string accountId, FormLibrariesApi.GetFormLibrariesOptions options = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling FormLibrariesApi->GetFormLibraries");

            var localVarPath = "/v2/accounts/{accountId}/form_libraries";
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

            if (options != null)
            {
                if (options.count != null) localVarQueryParams.Add("count", this.ApiClient.ParameterToString(options.count)); // query parameter
                if (options.startPosition != null) localVarQueryParams.Add("startPosition", this.ApiClient.ParameterToString(options.startPosition)); // query parameter
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
                Exception exception = ExceptionFactory("GetFormLibraries", localVarResponse);
                if (exception != null) throw exception;
            }

            
            // DocuSign: Handle for PDF return types
            if (localVarResponse.ContentType != null && !localVarResponse.ContentType.ToLower().Contains("json"))
            {
                return new ApiResponse<FormLibrarySummaryList>(localVarStatusCode, localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()), (FormLibrarySummaryList) this.ApiClient.Deserialize(localVarResponse.RawBytes, typeof(FormLibrarySummaryList)));
            }
            else
            {
                return new ApiResponse<FormLibrarySummaryList>(localVarStatusCode, localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()), (FormLibrarySummaryList) this.ApiClient.Deserialize(localVarResponse, typeof(FormLibrarySummaryList)));
            }
            
        }

        /// <summary>
        /// Gets a paged list of forms libraries. 
        /// </summary>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>
        
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>Task of FormLibrarySummaryList</returns>
        public async System.Threading.Tasks.Task<FormLibrarySummaryList> GetFormLibrariesAsync (string accountId, FormLibrariesApi.GetFormLibrariesOptions options = null)
        {
             ApiResponse<FormLibrarySummaryList> localVarResponse = await GetFormLibrariesAsyncWithHttpInfo(accountId, options);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets a paged list of forms libraries. 
        /// </summary>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>
        
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>Task of ApiResponse (FormLibrarySummaryList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FormLibrarySummaryList>> GetFormLibrariesAsyncWithHttpInfo (string accountId, FormLibrariesApi.GetFormLibrariesOptions options = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling FormLibrariesApi->GetFormLibraries");

            var localVarPath = "/v2/accounts/{accountId}/form_libraries";
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

            if (options != null)
            {
                if (options.count != null) localVarQueryParams.Add("count", this.ApiClient.ParameterToString(options.count)); // query parameter
                if (options.startPosition != null) localVarQueryParams.Add("startPosition", this.ApiClient.ParameterToString(options.startPosition)); // query parameter
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
                Exception exception = ExceptionFactory("GetFormLibraries", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FormLibrarySummaryList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FormLibrarySummaryList) this.ApiClient.Deserialize(localVarResponse, typeof(FormLibrarySummaryList)));
            
        }


        /// <summary>
        /// Gets a paged list of forms in a forms library. 
        /// </summary>
        public class GetFormLibraryFormsOptions
        {
            /// Default value is 100 and max value is 100 
            public int? count {get; set;}
            /// Default value is 0 
            public int? startPosition {get; set;}
        }

        /// <summary>
        /// Gets a paged list of forms in a forms library. 
        /// </summary>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>/// <param name="formLibraryId">Library Id</param>
        
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>FormSummaryList</returns>
        public FormSummaryList GetFormLibraryForms (string accountId, Guid? formLibraryId, FormLibrariesApi.GetFormLibraryFormsOptions options = null)
        {
             ApiResponse<FormSummaryList> localVarResponse = GetFormLibraryFormsWithHttpInfo(accountId, formLibraryId, options);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets a paged list of forms in a forms library. 
        /// </summary>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>/// <param name="formLibraryId">Library Id</param>
        
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>ApiResponse of FormSummaryList</returns>
        public ApiResponse< FormSummaryList > GetFormLibraryFormsWithHttpInfo (string accountId, Guid? formLibraryId, FormLibrariesApi.GetFormLibraryFormsOptions options = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling FormLibrariesApi->GetFormLibraryForms");
            // verify the required parameter 'formLibraryId' is set
            if (formLibraryId == null)
                throw new ApiException(400, "Missing required parameter 'formLibraryId' when calling FormLibrariesApi->GetFormLibraryForms");

            var localVarPath = "/v2/accounts/{accountId}/form_libraries/{formLibraryId}/forms";
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
            if (formLibraryId != null) localVarPathParams.Add("formLibraryId", this.ApiClient.ParameterToString(formLibraryId)); // path parameter

            if (options != null)
            {
                if (options.count != null) localVarQueryParams.Add("count", this.ApiClient.ParameterToString(options.count)); // query parameter
                if (options.startPosition != null) localVarQueryParams.Add("startPosition", this.ApiClient.ParameterToString(options.startPosition)); // query parameter
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
                Exception exception = ExceptionFactory("GetFormLibraryForms", localVarResponse);
                if (exception != null) throw exception;
            }

            
            // DocuSign: Handle for PDF return types
            if (localVarResponse.ContentType != null && !localVarResponse.ContentType.ToLower().Contains("json"))
            {
                return new ApiResponse<FormSummaryList>(localVarStatusCode, localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()), (FormSummaryList) this.ApiClient.Deserialize(localVarResponse.RawBytes, typeof(FormSummaryList)));
            }
            else
            {
                return new ApiResponse<FormSummaryList>(localVarStatusCode, localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()), (FormSummaryList) this.ApiClient.Deserialize(localVarResponse, typeof(FormSummaryList)));
            }
            
        }

        /// <summary>
        /// Gets a paged list of forms in a forms library. 
        /// </summary>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>/// <param name="formLibraryId">Library Id</param>
        
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>Task of FormSummaryList</returns>
        public async System.Threading.Tasks.Task<FormSummaryList> GetFormLibraryFormsAsync (string accountId, Guid? formLibraryId, FormLibrariesApi.GetFormLibraryFormsOptions options = null)
        {
             ApiResponse<FormSummaryList> localVarResponse = await GetFormLibraryFormsAsyncWithHttpInfo(accountId, formLibraryId, options);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets a paged list of forms in a forms library. 
        /// </summary>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId"></param>/// <param name="formLibraryId">Library Id</param>
        
        /// <param name="options">Options for modifying the behavior of the function.</param>
        /// <returns>Task of ApiResponse (FormSummaryList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FormSummaryList>> GetFormLibraryFormsAsyncWithHttpInfo (string accountId, Guid? formLibraryId, FormLibrariesApi.GetFormLibraryFormsOptions options = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling FormLibrariesApi->GetFormLibraryForms");
            // verify the required parameter 'formLibraryId' is set
            if (formLibraryId == null)
                throw new ApiException(400, "Missing required parameter 'formLibraryId' when calling FormLibrariesApi->GetFormLibraryForms");

            var localVarPath = "/v2/accounts/{accountId}/form_libraries/{formLibraryId}/forms";
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
            if (formLibraryId != null) localVarPathParams.Add("formLibraryId", this.ApiClient.ParameterToString(formLibraryId)); // path parameter

            if (options != null)
            {
                if (options.count != null) localVarQueryParams.Add("count", this.ApiClient.ParameterToString(options.count)); // query parameter
                if (options.startPosition != null) localVarQueryParams.Add("startPosition", this.ApiClient.ParameterToString(options.startPosition)); // query parameter
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
                Exception exception = ExceptionFactory("GetFormLibraryForms", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FormSummaryList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FormSummaryList) this.ApiClient.Deserialize(localVarResponse, typeof(FormSummaryList)));
            
        }

    }
}