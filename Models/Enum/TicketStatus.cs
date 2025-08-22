using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace EunigosApi.Models.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TicketStatus
    {
        [Description("New Ticket")]
        new_ticket = 0,

        [Description("Estimated")]
        estimated = 1,

        [Description("In Progress")]
        in_progress = 2,

        [Description("On Hold")]
        on_hold = 3,

        [Description("Completed")]
        completed = 4,

        [Description("Cancelled")]
        cancelled = 5,

        [Description("Archived")]
        archived = 6,

        [Description("Pending")]
        pending = 7
    }
}
