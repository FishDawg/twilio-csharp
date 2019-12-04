/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Serverless.V1.Service
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Retrieve a list of all Builds.
    /// </summary>
    public class ReadBuildOptions : ReadOptions<BuildResource>
    {
        /// <summary>
        /// The SID of the Service to read the Build resources from
        /// </summary>
        public string PathServiceSid { get; }

        /// <summary>
        /// Construct a new ReadBuildOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to read the Build resources from </param>
        public ReadBuildOptions(string pathServiceSid)
        {
            PathServiceSid = pathServiceSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Retrieve a specific Buildn resource.
    /// </summary>
    public class FetchBuildOptions : IOptions<BuildResource>
    {
        /// <summary>
        /// The SID of the Service to fetch the Build resource from
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the Build resource to fetch
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchBuildOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to fetch the Build resource from </param>
        /// <param name="pathSid"> The SID of the Build resource to fetch </param>
        public FetchBuildOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Delete a Build resource.
    /// </summary>
    public class DeleteBuildOptions : IOptions<BuildResource>
    {
        /// <summary>
        /// The SID of the Service to delete the Build resource from
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the Build resource to delete
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteBuildOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to delete the Build resource from </param>
        /// <param name="pathSid"> The SID of the Build resource to delete </param>
        public DeleteBuildOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Create a new Build resource. At least one function version or asset version is required.
    /// </summary>
    public class CreateBuildOptions : IOptions<BuildResource>
    {
        /// <summary>
        /// The SID of the Service to create the Build resource under
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The list of Asset Version resource SIDs to include in the build
        /// </summary>
        public List<string> AssetVersions { get; set; }
        /// <summary>
        /// The list of the Variable resource SIDs to include in the build
        /// </summary>
        public List<string> FunctionVersions { get; set; }
        /// <summary>
        /// A list of objects that describe the Dependencies included in the build
        /// </summary>
        public string Dependencies { get; set; }

        /// <summary>
        /// Construct a new CreateBuildOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to create the Build resource under </param>
        public CreateBuildOptions(string pathServiceSid)
        {
            PathServiceSid = pathServiceSid;
            AssetVersions = new List<string>();
            FunctionVersions = new List<string>();
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (AssetVersions != null)
            {
                p.AddRange(AssetVersions.Select(prop => new KeyValuePair<string, string>("AssetVersions", prop.ToString())));
            }

            if (FunctionVersions != null)
            {
                p.AddRange(FunctionVersions.Select(prop => new KeyValuePair<string, string>("FunctionVersions", prop.ToString())));
            }

            if (Dependencies != null)
            {
                p.Add(new KeyValuePair<string, string>("Dependencies", Dependencies));
            }

            return p;
        }
    }

}