using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Api.V2010.Account.IncomingPhoneNumber.AssignedAddOn 
{

    /// <summary>
    /// AssignedAddOnExtensionResource
    /// </summary>
    public class AssignedAddOnExtensionResource : Resource 
    {
        private static Request BuildFetchRequest(FetchAssignedAddOnExtensionOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/IncomingPhoneNumbers/" + options.PathResourceSid + "/AssignedAddOns/" + options.PathAssignedAddOnSid + "/Extensions/" + options.PathSid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Fetch an instance of an Extension for the Assigned Add-on.
        /// </summary>
        ///
        /// <param name="options"> Fetch AssignedAddOnExtension parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AssignedAddOnExtension </returns> 
        public static AssignedAddOnExtensionResource Fetch(FetchAssignedAddOnExtensionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Fetch an instance of an Extension for the Assigned Add-on.
        /// </summary>
        ///
        /// <param name="options"> Fetch AssignedAddOnExtension parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AssignedAddOnExtension </returns> 
        public static async System.Threading.Tasks.Task<AssignedAddOnExtensionResource> FetchAsync(FetchAssignedAddOnExtensionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Fetch an instance of an Extension for the Assigned Add-on.
        /// </summary>
        ///
        /// <param name="pathResourceSid"> The resource_sid </param>
        /// <param name="pathAssignedAddOnSid"> The assigned_add_on_sid </param>
        /// <param name="pathSid"> The unique Extension Sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AssignedAddOnExtension </returns> 
        public static AssignedAddOnExtensionResource Fetch(string pathResourceSid, string pathAssignedAddOnSid, string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchAssignedAddOnExtensionOptions(pathResourceSid, pathAssignedAddOnSid, pathSid){PathAccountSid = pathAccountSid};
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Fetch an instance of an Extension for the Assigned Add-on.
        /// </summary>
        ///
        /// <param name="pathResourceSid"> The resource_sid </param>
        /// <param name="pathAssignedAddOnSid"> The assigned_add_on_sid </param>
        /// <param name="pathSid"> The unique Extension Sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AssignedAddOnExtension </returns> 
        public static async System.Threading.Tasks.Task<AssignedAddOnExtensionResource> FetchAsync(string pathResourceSid, string pathAssignedAddOnSid, string pathSid, string pathAccountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchAssignedAddOnExtensionOptions(pathResourceSid, pathAssignedAddOnSid, pathSid){PathAccountSid = pathAccountSid};
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadAssignedAddOnExtensionOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/IncomingPhoneNumbers/" + options.PathResourceSid + "/AssignedAddOns/" + options.PathAssignedAddOnSid + "/Extensions.json",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Retrieve a list of Extensions for the Assigned Add-on.
        /// </summary>
        ///
        /// <param name="options"> Read AssignedAddOnExtension parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AssignedAddOnExtension </returns> 
        public static ResourceSet<AssignedAddOnExtensionResource> Read(ReadAssignedAddOnExtensionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<AssignedAddOnExtensionResource>.FromJson("extensions", response.Content);
            return new ResourceSet<AssignedAddOnExtensionResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of Extensions for the Assigned Add-on.
        /// </summary>
        ///
        /// <param name="options"> Read AssignedAddOnExtension parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AssignedAddOnExtension </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<AssignedAddOnExtensionResource>> ReadAsync(ReadAssignedAddOnExtensionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<AssignedAddOnExtensionResource>.FromJson("extensions", response.Content);
            return new ResourceSet<AssignedAddOnExtensionResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Retrieve a list of Extensions for the Assigned Add-on.
        /// </summary>
        ///
        /// <param name="pathResourceSid"> The resource_sid </param>
        /// <param name="pathAssignedAddOnSid"> The assigned_add_on_sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AssignedAddOnExtension </returns> 
        public static ResourceSet<AssignedAddOnExtensionResource> Read(string pathResourceSid, string pathAssignedAddOnSid, string pathAccountSid = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadAssignedAddOnExtensionOptions(pathResourceSid, pathAssignedAddOnSid){PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of Extensions for the Assigned Add-on.
        /// </summary>
        ///
        /// <param name="pathResourceSid"> The resource_sid </param>
        /// <param name="pathAssignedAddOnSid"> The assigned_add_on_sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AssignedAddOnExtension </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<AssignedAddOnExtensionResource>> ReadAsync(string pathResourceSid, string pathAssignedAddOnSid, string pathAccountSid = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadAssignedAddOnExtensionOptions(pathResourceSid, pathAssignedAddOnSid){PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        ///
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<AssignedAddOnExtensionResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<AssignedAddOnExtensionResource>.FromJson("extensions", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        ///
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<AssignedAddOnExtensionResource> NextPage(Page<AssignedAddOnExtensionResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<AssignedAddOnExtensionResource>.FromJson("extensions", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        ///
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<AssignedAddOnExtensionResource> PreviousPage(Page<AssignedAddOnExtensionResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<AssignedAddOnExtensionResource>.FromJson("extensions", response.Content);
        }

        /// <summary>
        /// Converts a JSON string into a AssignedAddOnExtensionResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> AssignedAddOnExtensionResource object represented by the provided JSON </returns> 
        public static AssignedAddOnExtensionResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<AssignedAddOnExtensionResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// A string that uniquely identifies this Extension
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The Account id that has installed this Add-on
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The Phone Number id that has installed this Add-on
        /// </summary>
        [JsonProperty("resource_sid")]
        public string ResourceSid { get; private set; }
        /// <summary>
        /// A string that uniquely identifies the assigned Add-on installation
        /// </summary>
        [JsonProperty("assigned_add_on_sid")]
        public string AssignedAddOnSid { get; private set; }
        /// <summary>
        /// A human-readable description of this Extension
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// A human-readable description of the Extension's Product
        /// </summary>
        [JsonProperty("product_name")]
        public string ProductName { get; private set; }
        /// <summary>
        /// The string that uniquely identifies this Extension
        /// </summary>
        [JsonProperty("unique_name")]
        public string UniqueName { get; private set; }
        /// <summary>
        /// The uri
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; private set; }
        /// <summary>
        /// A Boolean indicating if the Extension will be invoked
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; private set; }

        private AssignedAddOnExtensionResource()
        {

        }
    }

}