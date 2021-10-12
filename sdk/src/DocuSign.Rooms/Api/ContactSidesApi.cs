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
    public interface IContactSidesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieves the list of valid contact sides.
        /// </summary>
        /// <remarks>
        /// Returns a list of valid contact sides.
        /// </remarks>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        
        
        
        /// <returns></returns>
        GlobalContactSides GetContactSides ();

        /// <summary>
        /// Retrieves the list of valid contact sides.
        /// </summary>
        /// <remarks>
        /// Returns a list of valid contact sides.
        /// </remarks>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        
        
        
        /// <returns>ApiResponse of </returns>
        ApiResponse<GlobalContactSides> GetContactSidesWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Retrieves the list of valid contact sides.
        /// </summary>
        /// <remarks>
        /// Returns a list of valid contact sides.
        /// </remarks>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        
        
        
        /// <returns>Task of GlobalContactSides</returns>
        System.Threading.Tasks.Task<GlobalContactSides> GetContactSidesAsync ();

        /// <summary>
        /// Retrieves the list of valid contact sides.
        /// </summary>
        /// <remarks>
        /// Returns a list of valid contact sides.
        /// </remarks>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        
        
        
        /// <returns>Task of ApiResponse (GlobalContactSides)</returns>
        System.Threading.Tasks.Task<ApiResponse<GlobalContactSides>> GetContactSidesAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ContactSidesApi : IContactSidesApi
    {
        private DocuSign.Rooms.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactSidesApi"/> class
        /// using AplClient object
        /// </summary>
        /// <param name="aplClient">An instance of AplClient</param>
        /// <returns></returns>
        public ContactSidesApi(ApiClient aplClient)
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
        /// Retrieves the list of valid contact sides. Returns a list of valid contact sides.
        /// </summary>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        
        
        
        /// <returns>GlobalContactSides</returns>
        public GlobalContactSides GetContactSides ()
        {
             ApiResponse<GlobalContactSides> localVarResponse = GetContactSidesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves the list of valid contact sides. Returns a list of valid contact sides.
        /// </summary>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        
        
        
        /// <returns>ApiResponse of GlobalContactSides</returns>
        public ApiResponse< GlobalContactSides > GetContactSidesWithHttpInfo ()
        {

            var localVarPath = "/v2/contact_sides";
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
                Exception exception = ExceptionFactory("GetContactSides", localVarResponse);
                if (exception != null) throw exception;
            }

            
            // DocuSign: Handle for PDF return types
            if (localVarResponse.ContentType != null && !localVarResponse.ContentType.ToLower().Contains("json"))
            {
                return new ApiResponse<GlobalContactSides>(localVarStatusCode, localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()), (GlobalContactSides) this.ApiClient.Deserialize(localVarResponse.RawBytes, typeof(GlobalContactSides)));
            }
            else
            {
                return new ApiResponse<GlobalContactSides>(localVarStatusCode, localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()), (GlobalContactSides) this.ApiClient.Deserialize(localVarResponse, typeof(GlobalContactSides)));
            }
            
        }

        /// <summary>
        /// Retrieves the list of valid contact sides. Returns a list of valid contact sides.
        /// </summary>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        
        
        
        /// <returns>Task of GlobalContactSides</returns>
        public async System.Threading.Tasks.Task<GlobalContactSides> GetContactSidesAsync ()
        {
             ApiResponse<GlobalContactSides> localVarResponse = await GetContactSidesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieves the list of valid contact sides. Returns a list of valid contact sides.
        /// </summary>
        /// <exception cref="DocuSign.Rooms.Client.ApiException">Thrown when fails to make API call</exception>
        
        
        
        /// <returns>Task of ApiResponse (GlobalContactSides)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GlobalContactSides>> GetContactSidesAsyncWithHttpInfo ()
        {

            var localVarPath = "/v2/contact_sides";
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
                Exception exception = ExceptionFactory("GetContactSides", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GlobalContactSides>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GlobalContactSides) this.ApiClient.Deserialize(localVarResponse, typeof(GlobalContactSides)));
            
        }

    }
}