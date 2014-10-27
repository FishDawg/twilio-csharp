﻿using System;
using System.Collections.Generic;

namespace Twilio.Wds
{
    /// <summary>
    /// Twilio API call result with paging information.
    /// </summary>
    public class WorkflowResult : TwilioListBase
    {
        /// <summary>
        /// Gets or sets the workflows.
        /// </summary>
        public List<Workflow> Workflows { get; set; }
    }
}

