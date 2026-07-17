using System;
using JPP.Models.Event.Request; // Assuming this is your Event namespace
using JPP.Models.Shared.Requests;

namespace JPP.Commons.Extensions
{
    public static class EventListFilterRequestExtensions
    {
        private static readonly string[] AllowedSortColumns =
        {
            "EventId",
            "EventName",
            "Code",
            "Description"
        };

        public static void NormalizeFilter(this EventListFilterRequest filter)
        {
            ArgumentNullException.ThrowIfNull(filter);

            filter.Keyword = filter.Keyword.NormalizeNullableText();

            filter.NormalizePagingAndSorting(
                defaultSortColumn: "EventName", // Set default to sort by Name based on previous repository logic
                defaultSortDirection: "ASC",
                allowedSortColumns: AllowedSortColumns,
                defaultPageSize: 20,
                maxPageSize: 100);
        }
    }
}