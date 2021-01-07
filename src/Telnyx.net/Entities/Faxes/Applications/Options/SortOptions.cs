﻿using System.Runtime.Serialization;

namespace Telnyx.net.Entities.Faxes.Applications.Options
{
    /// <summary>
    /// Specifies the sort order for results. By default sorting direction is ascending.
    /// </summary>
    public enum SortOptions
    {
        /// <summary>
        /// Sorts the result by the connection_name field in ascending order.
        /// </summary>
        [EnumMember(Value = "connection_name")]
        ConnectionName = 1,

        /// <summary>
        /// Sorts the result by the connection_name field in descending order.
        /// </summary>
        [EnumMember(Value = "-connection_name")]
        ConnectionNameDESC = 2,

        /// <summary>
        /// Sorts the result by the connection_name field in ascending order.
        /// </summary>
        [EnumMember(Value = "created_at")]
        CreatedAt = 3,

        /// <summary>
        /// Sorts the result by the created_at field in descending order.
        /// </summary>
        [EnumMember(Value = "-created_at")]
        CreatedAtDESC = 4,

        /// <summary>
        /// Sorts the result by the active field in ascending order.
        /// </summary>
        [EnumMember(Value = "active")]
        Active = 5,

        /// <summary>
        /// Sorts the result by the active field in descending order.
        /// </summary>
        [EnumMember(Value = "-active")]
        ActiveDESC = 6,
    }
}
