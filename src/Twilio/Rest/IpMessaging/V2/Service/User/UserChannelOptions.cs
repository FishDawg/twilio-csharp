/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.IpMessaging.V2.Service.User
{

    /// <summary>
    /// List all Channels for a given User.
    /// </summary>
    public class ReadUserChannelOptions : ReadOptions<UserChannelResource>
    {
        /// <summary>
        /// The SID of the Service to read the resources from
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the User to fetch the User Channel resources from
        /// </summary>
        public string PathUserSid { get; }

        /// <summary>
        /// Construct a new ReadUserChannelOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to read the resources from </param>
        /// <param name="pathUserSid"> The SID of the User to fetch the User Channel resources from </param>
        public ReadUserChannelOptions(string pathServiceSid, string pathUserSid)
        {
            PathServiceSid = pathServiceSid;
            PathUserSid = pathUserSid;
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
    /// FetchUserChannelOptions
    /// </summary>
    public class FetchUserChannelOptions : IOptions<UserChannelResource>
    {
        /// <summary>
        /// The SID of the Service to fetch the User Channel resource from
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the User to fetch the User Channel resource from
        /// </summary>
        public string PathUserSid { get; }
        /// <summary>
        /// The SID of the Channel that has the User Channel to fetch
        /// </summary>
        public string PathChannelSid { get; }

        /// <summary>
        /// Construct a new FetchUserChannelOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to fetch the User Channel resource from </param>
        /// <param name="pathUserSid"> The SID of the User to fetch the User Channel resource from </param>
        /// <param name="pathChannelSid"> The SID of the Channel that has the User Channel to fetch </param>
        public FetchUserChannelOptions(string pathServiceSid, string pathUserSid, string pathChannelSid)
        {
            PathServiceSid = pathServiceSid;
            PathUserSid = pathUserSid;
            PathChannelSid = pathChannelSid;
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
    /// Removes User from selected Channel.
    /// </summary>
    public class DeleteUserChannelOptions : IOptions<UserChannelResource>
    {
        /// <summary>
        /// The SID of the Service to read the resources from
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the User to fetch the User Channel resources from
        /// </summary>
        public string PathUserSid { get; }
        /// <summary>
        /// The SID of the Channel the resource belongs to
        /// </summary>
        public string PathChannelSid { get; }

        /// <summary>
        /// Construct a new DeleteUserChannelOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to read the resources from </param>
        /// <param name="pathUserSid"> The SID of the User to fetch the User Channel resources from </param>
        /// <param name="pathChannelSid"> The SID of the Channel the resource belongs to </param>
        public DeleteUserChannelOptions(string pathServiceSid, string pathUserSid, string pathChannelSid)
        {
            PathServiceSid = pathServiceSid;
            PathUserSid = pathUserSid;
            PathChannelSid = pathChannelSid;
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
    /// UpdateUserChannelOptions
    /// </summary>
    public class UpdateUserChannelOptions : IOptions<UserChannelResource>
    {
        /// <summary>
        /// The SID of the Service to update the resource from
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the User to update the User Channel resource from
        /// </summary>
        public string PathUserSid { get; }
        /// <summary>
        /// The SID of the Channel with the User Channel resource to update
        /// </summary>
        public string PathChannelSid { get; }
        /// <summary>
        /// The push notification level to assign to the User Channel
        /// </summary>
        public UserChannelResource.NotificationLevelEnum NotificationLevel { get; }

        /// <summary>
        /// Construct a new UpdateUserChannelOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to update the resource from </param>
        /// <param name="pathUserSid"> The SID of the User to update the User Channel resource from </param>
        /// <param name="pathChannelSid"> The SID of the Channel with the User Channel resource to update </param>
        /// <param name="notificationLevel"> The push notification level to assign to the User Channel </param>
        public UpdateUserChannelOptions(string pathServiceSid,
                                        string pathUserSid,
                                        string pathChannelSid,
                                        UserChannelResource.NotificationLevelEnum notificationLevel)
        {
            PathServiceSid = pathServiceSid;
            PathUserSid = pathUserSid;
            PathChannelSid = pathChannelSid;
            NotificationLevel = notificationLevel;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (NotificationLevel != null)
            {
                p.Add(new KeyValuePair<string, string>("NotificationLevel", NotificationLevel.ToString()));
            }

            return p;
        }
    }

}