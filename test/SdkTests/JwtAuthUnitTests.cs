using DocuSign.Rooms.Api;
using DocuSign.Rooms.Client;
using DocuSign.Rooms.Client.Auth;
using DocuSign.Rooms.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace SdkTests
{
    [TestClass]
    public class JwtAuthUnitTests
    {
        TestConfig testConfig = new TestConfig();
        [TestInitialize()]
        [TestMethod]
        public void JwtLoginTest()
        {
            testConfig.ApiClient = new ApiClient(testConfig.Host);

            Assert.IsNotNull(testConfig.PrivateKey);

            byte[] privateKeyStream = Convert.FromBase64String(testConfig.PrivateKey);

            var scopes = new List<string>();
            scopes.Add("dtr.company.write");
            scopes.Add("dtr.company.read");
            scopes.Add("dtr.rooms.write");
            scopes.Add("dtr.rooms.read");
            scopes.Add("signature");
            scopes.Add("impersonation");

            OAuth.OAuthToken tokenInfo = testConfig.ApiClient.RequestJWTUserToken(testConfig.IntegratorKey, testConfig.UserId, testConfig.OAuthBasePath, privateKeyStream, testConfig.ExpiresInHours, scopes);

            // the authentication api uses the apiClient (and X-DocuSign-Authentication header) that are set in Configuration object
            OAuth.UserInfo userInfo = testConfig.ApiClient.GetUserInfo(tokenInfo.access_token);

            Assert.IsNotNull(userInfo);
            Assert.IsNotNull(userInfo.Accounts);

            foreach (var item in userInfo.Accounts)
            {
                if (item.IsDefault == "true")
                {
                    testConfig.AccountId = item.AccountId;
                    //testConfig.ApiClient.SetBasePath(item.BaseUri + "/restapi");
                    break;
                }
            }

            Assert.IsNotNull(testConfig.AccountId);
        }

        [TestMethod]
        public void JwtGetRoomsTest()
        {
            // |EnvelopesApi| contains methods related to creating and sending Envelopes (aka signature requests)
            RoomsApi roomsApi = new RoomsApi(testConfig.ApiClient);
            RoomSummaryList rooms = roomsApi.GetRooms(testConfig.AccountId, new RoomsApi.GetRoomsOptions());

            Assert.IsNotNull(rooms);
            Assert.IsNotNull(rooms.Rooms);
        }
        
        [TestMethod]
        public void JwtUpdatePictureTest()
        {
            // |EnvelopesApi| contains methods related to creating and sending Envelopes (aka signature requests)
            RoomsApi roomsApi = new RoomsApi(testConfig.ApiClient);
            roomsApi.UpdatePicture()
            RoomSummaryList rooms = roomsApi.GetRooms(testConfig.AccountId, new RoomsApi.GetRoomsOptions());

            Assert.IsNotNull(rooms);
            Assert.IsNotNull(rooms.Rooms);
        }
    }
}
