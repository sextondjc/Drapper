using System.Collections.Generic;

namespace Sample.Models
{
    /// <summary>
    /// A class to support pagination of data, perhaps from a 
    /// client side control.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PagedResult<T>
    {
        /// <summary>
        /// Gets or sets the pagination "metadata".
        /// </summary>
        /// <remarks>
        /// This class is implemented separately 
        /// to allow extending it without having to alter 
        /// pagination support.
        /// </remarks>
        public Pagination Meta { get; set; }

        /// <summary>
        /// Gets or sets the result set of values in the 
        /// pagination operation. 
        /// </summary>        
        public IEnumerable<T> Values { get; set; }
    }
}
