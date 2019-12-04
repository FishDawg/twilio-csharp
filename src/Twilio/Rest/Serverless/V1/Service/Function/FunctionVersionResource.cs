/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
/// currently do not have developer preview access, please contact help@twilio.com.
///
/// FunctionVersionResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Serverless.V1.Service.Function
{

    public class FunctionVersionResource : Resource
    {
        public sealed class VisibilityEnum : StringEnum
        {
            private VisibilityEnum(string value) : base(value) {}
            public VisibilityEnum() {}
            public static implicit operator VisibilityEnum(string value)
            {
                return new VisibilityEnum(value);
            }

            public static readonly VisibilityEnum Public = new VisibilityEnum("public");
            public static readonly VisibilityEnum Private = new VisibilityEnum("private");
            public static readonly VisibilityEnum Protected = new VisibilityEnum("protected");
        }

        private static Request BuildReadRequest(ReadFunctionVersionOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Serverless,
                "/v1/Services/" + options.PathServiceSid + "/Functions/" + options.PathFunctionSid + "/Versions",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Retrieve a list of all Function Version resources.
        /// </summary>
        /// <param name="options"> Read FunctionVersion parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of FunctionVersion </returns>
        public static ResourceSet<FunctionVersionResource> Read(ReadFunctionVersionOptions options,
                                                                ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<FunctionVersionResource>.FromJson("function_versions", response.Content);
            return new ResourceSet<FunctionVersionResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all Function Version resources.
        /// </summary>
        /// <param name="options"> Read FunctionVersion parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of FunctionVersion </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<FunctionVersionResource>> ReadAsync(ReadFunctionVersionOptions options,
                                                                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<FunctionVersionResource>.FromJson("function_versions", response.Content);
            return new ResourceSet<FunctionVersionResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Retrieve a list of all Function Version resources.
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to read the Function Version resources from </param>
        /// <param name="pathFunctionSid"> The SID of the function that is the parent of the Function Version resources to read
        ///                       </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of FunctionVersion </returns>
        public static ResourceSet<FunctionVersionResource> Read(string pathServiceSid,
                                                                string pathFunctionSid,
                                                                int? pageSize = null,
                                                                long? limit = null,
                                                                ITwilioRestClient client = null)
        {
            var options = new ReadFunctionVersionOptions(pathServiceSid, pathFunctionSid){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all Function Version resources.
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to read the Function Version resources from </param>
        /// <param name="pathFunctionSid"> The SID of the function that is the parent of the Function Version resources to read
        ///                       </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of FunctionVersion </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<FunctionVersionResource>> ReadAsync(string pathServiceSid,
                                                                                                        string pathFunctionSid,
                                                                                                        int? pageSize = null,
                                                                                                        long? limit = null,
                                                                                                        ITwilioRestClient client = null)
        {
            var options = new ReadFunctionVersionOptions(pathServiceSid, pathFunctionSid){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<FunctionVersionResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<FunctionVersionResource>.FromJson("function_versions", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<FunctionVersionResource> NextPage(Page<FunctionVersionResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Serverless,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<FunctionVersionResource>.FromJson("function_versions", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<FunctionVersionResource> PreviousPage(Page<FunctionVersionResource> page,
                                                                 ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Serverless,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<FunctionVersionResource>.FromJson("function_versions", response.Content);
        }

        private static Request BuildFetchRequest(FetchFunctionVersionOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Serverless,
                "/v1/Services/" + options.PathServiceSid + "/Functions/" + options.PathFunctionSid + "/Versions/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Retrieve a specific Function Version resource.
        /// </summary>
        /// <param name="options"> Fetch FunctionVersion parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of FunctionVersion </returns>
        public static FunctionVersionResource Fetch(FetchFunctionVersionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a specific Function Version resource.
        /// </summary>
        /// <param name="options"> Fetch FunctionVersion parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of FunctionVersion </returns>
        public static async System.Threading.Tasks.Task<FunctionVersionResource> FetchAsync(FetchFunctionVersionOptions options,
                                                                                            ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Retrieve a specific Function Version resource.
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to fetch the Function Version resource from </param>
        /// <param name="pathFunctionSid"> The SID of the function that is the parent of the Function Version resource to fetch
        ///                       </param>
        /// <param name="pathSid"> The SID that identifies the Function Version resource to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of FunctionVersion </returns>
        public static FunctionVersionResource Fetch(string pathServiceSid,
                                                    string pathFunctionSid,
                                                    string pathSid,
                                                    ITwilioRestClient client = null)
        {
            var options = new FetchFunctionVersionOptions(pathServiceSid, pathFunctionSid, pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a specific Function Version resource.
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to fetch the Function Version resource from </param>
        /// <param name="pathFunctionSid"> The SID of the function that is the parent of the Function Version resource to fetch
        ///                       </param>
        /// <param name="pathSid"> The SID that identifies the Function Version resource to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of FunctionVersion </returns>
        public static async System.Threading.Tasks.Task<FunctionVersionResource> FetchAsync(string pathServiceSid,
                                                                                            string pathFunctionSid,
                                                                                            string pathSid,
                                                                                            ITwilioRestClient client = null)
        {
            var options = new FetchFunctionVersionOptions(pathServiceSid, pathFunctionSid, pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a FunctionVersionResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> FunctionVersionResource object represented by the provided JSON </returns>
        public static FunctionVersionResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<FunctionVersionResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The unique string that identifies the Function Version resource
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The SID of the Account that created the Function Version resource
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The SID of the Service that the Function Version resource is associated with
        /// </summary>
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }
        /// <summary>
        /// The SID of the function that is the parent of the function version
        /// </summary>
        [JsonProperty("function_sid")]
        public string FunctionSid { get; private set; }
        /// <summary>
        /// The URL-friendly string by which the function version can be referenced
        /// </summary>
        [JsonProperty("path")]
        public string Path { get; private set; }
        /// <summary>
        /// The access control that determines how the function version can be accessed
        /// </summary>
        [JsonProperty("visibility")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FunctionVersionResource.VisibilityEnum Visibility { get; private set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the Function Version resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The absolute URL of the Function Version resource
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private FunctionVersionResource()
        {

        }
    }

}