/* 
 * DocuSign Rooms API - v2
 *
 * An API for an integrator to access the features of DocuSign Rooms
 *
 * OpenAPI spec version: v2
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace DocuSign.Rooms.Client
{
    public interface IHttpClient
    {
        void AddDefaultRequestHeader(string header, string value);

        DocuSignResponse SendRequest(DocuSignRequest request);

        Task<DocuSignResponse> SendRequestAsync(DocuSignRequest request, CancellationToken cancellationToken);
    }
}