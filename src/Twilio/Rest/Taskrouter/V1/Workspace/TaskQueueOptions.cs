/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Taskrouter.V1.Workspace
{

    /// <summary>
    /// FetchTaskQueueOptions
    /// </summary>
    public class FetchTaskQueueOptions : IOptions<TaskQueueResource>
    {
        /// <summary>
        /// The SID of the Workspace with the TaskQueue to fetch
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// The SID of the resource to
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchTaskQueueOptions
        /// </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the TaskQueue to fetch </param>
        /// <param name="pathSid"> The SID of the resource to  </param>
        public FetchTaskQueueOptions(string pathWorkspaceSid, string pathSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
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
    /// UpdateTaskQueueOptions
    /// </summary>
    public class UpdateTaskQueueOptions : IOptions<TaskQueueResource>
    {
        /// <summary>
        /// The SID of the Workspace with the TaskQueue to update
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// The SID of the resource to update
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// A string to describe the resource
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// A string describing the Worker selection criteria for any Tasks that enter the TaskQueue
        /// </summary>
        public string TargetWorkers { get; set; }
        /// <summary>
        /// The SID of the Activity to assign Workers when a task is reserved for them
        /// </summary>
        public string ReservationActivitySid { get; set; }
        /// <summary>
        /// The SID of the Activity to assign Workers when a task is assigned for them
        /// </summary>
        public string AssignmentActivitySid { get; set; }
        /// <summary>
        /// The maximum number of Workers to create reservations for the assignment of a task while in the queue
        /// </summary>
        public int? MaxReservedWorkers { get; set; }
        /// <summary>
        /// How Tasks will be assigned to Workers
        /// </summary>
        public TaskQueueResource.TaskOrderEnum TaskOrder { get; set; }

        /// <summary>
        /// Construct a new UpdateTaskQueueOptions
        /// </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the TaskQueue to update </param>
        /// <param name="pathSid"> The SID of the resource to update </param>
        public UpdateTaskQueueOptions(string pathWorkspaceSid, string pathSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (TargetWorkers != null)
            {
                p.Add(new KeyValuePair<string, string>("TargetWorkers", TargetWorkers));
            }

            if (ReservationActivitySid != null)
            {
                p.Add(new KeyValuePair<string, string>("ReservationActivitySid", ReservationActivitySid.ToString()));
            }

            if (AssignmentActivitySid != null)
            {
                p.Add(new KeyValuePair<string, string>("AssignmentActivitySid", AssignmentActivitySid.ToString()));
            }

            if (MaxReservedWorkers != null)
            {
                p.Add(new KeyValuePair<string, string>("MaxReservedWorkers", MaxReservedWorkers.ToString()));
            }

            if (TaskOrder != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskOrder", TaskOrder.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// ReadTaskQueueOptions
    /// </summary>
    public class ReadTaskQueueOptions : ReadOptions<TaskQueueResource>
    {
        /// <summary>
        /// The SID of the Workspace with the TaskQueue to read
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// The friendly_name of the TaskQueue resources to read
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The attributes of the Workers to read
        /// </summary>
        public string EvaluateWorkerAttributes { get; set; }
        /// <summary>
        /// The SID of the Worker with the TaskQueue resources to read
        /// </summary>
        public string WorkerSid { get; set; }

        /// <summary>
        /// Construct a new ReadTaskQueueOptions
        /// </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the TaskQueue to read </param>
        public ReadTaskQueueOptions(string pathWorkspaceSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (EvaluateWorkerAttributes != null)
            {
                p.Add(new KeyValuePair<string, string>("EvaluateWorkerAttributes", EvaluateWorkerAttributes));
            }

            if (WorkerSid != null)
            {
                p.Add(new KeyValuePair<string, string>("WorkerSid", WorkerSid.ToString()));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// CreateTaskQueueOptions
    /// </summary>
    public class CreateTaskQueueOptions : IOptions<TaskQueueResource>
    {
        /// <summary>
        /// The SID of the Workspace that the new TaskQueue belongs to
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// A string to describe the resource
        /// </summary>
        public string FriendlyName { get; }
        /// <summary>
        /// A string describing the Worker selection criteria for any Tasks that enter the TaskQueue
        /// </summary>
        public string TargetWorkers { get; set; }
        /// <summary>
        /// The maximum number of Workers to reserve
        /// </summary>
        public int? MaxReservedWorkers { get; set; }
        /// <summary>
        /// How Tasks will be assigned to Workers
        /// </summary>
        public TaskQueueResource.TaskOrderEnum TaskOrder { get; set; }
        /// <summary>
        /// The SID of the Activity to assign Workers when a task is reserved for them
        /// </summary>
        public string ReservationActivitySid { get; set; }
        /// <summary>
        /// The SID of the Activity to assign Workers once a task is assigned to them
        /// </summary>
        public string AssignmentActivitySid { get; set; }

        /// <summary>
        /// Construct a new CreateTaskQueueOptions
        /// </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace that the new TaskQueue belongs to </param>
        /// <param name="friendlyName"> A string to describe the resource </param>
        public CreateTaskQueueOptions(string pathWorkspaceSid, string friendlyName)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            FriendlyName = friendlyName;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (TargetWorkers != null)
            {
                p.Add(new KeyValuePair<string, string>("TargetWorkers", TargetWorkers));
            }

            if (MaxReservedWorkers != null)
            {
                p.Add(new KeyValuePair<string, string>("MaxReservedWorkers", MaxReservedWorkers.ToString()));
            }

            if (TaskOrder != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskOrder", TaskOrder.ToString()));
            }

            if (ReservationActivitySid != null)
            {
                p.Add(new KeyValuePair<string, string>("ReservationActivitySid", ReservationActivitySid.ToString()));
            }

            if (AssignmentActivitySid != null)
            {
                p.Add(new KeyValuePair<string, string>("AssignmentActivitySid", AssignmentActivitySid.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// DeleteTaskQueueOptions
    /// </summary>
    public class DeleteTaskQueueOptions : IOptions<TaskQueueResource>
    {
        /// <summary>
        /// The SID of the Workspace with the TaskQueue to delete
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// The SID of the resource to delete
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteTaskQueueOptions
        /// </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the TaskQueue to delete </param>
        /// <param name="pathSid"> The SID of the resource to delete </param>
        public DeleteTaskQueueOptions(string pathWorkspaceSid, string pathSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
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

}