using System.Globalization;

namespace Students.Interfaces
{
    /// <summary>
    /// Service for accessing shared resources.
    /// </summary>
    public interface ISharedResourcesService
    {
        /// <summary>
        /// Gets the resource string associated with the specified resource id.
        /// </summary>
        /// <param name="resourceId">The resource id.</param>
        /// <returns>The resource string in the default culture.</returns>
        string GetString(string resourceId);

        /// <summary>
        /// Gets the resource string associated with the specified resource id and culture info.
        /// </summary>
        /// <param name="resourceId">The resource id.</param>
        /// <param name="cultureInfo">The culture info.</param>
        /// <returns>The resource string in the specified culture.</returns>
        string GetString(string resourceId, CultureInfo cultureInfo);

        /// <summary>
        /// Indexer to get the resource string associated with the specified resource id.
        /// </summary>
        /// <param name="resourceId">The resource id.</param>
        /// <returns>The resource string in the default culture.</returns>
        string this[string resourceId] { get; }
    }
}