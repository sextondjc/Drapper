namespace Sample.Models
{
    /// <summary>
    /// Simple class to hold pagination values. 
    /// </summary>
    public class Pagination
    {
        /// <summary>
        /// Gets or sets the page value. 
        /// </summary>        
        public int Page { get; set; } = 1;

        /// <summary>
        /// Gets or sets the size of the result set to be 
        /// returned. 
        /// </summary>        
        public int Size { get; set; } = 10;

        /// <summary>
        /// Gets or sets the total number of records in
        /// the underlying table. This allows you to determine
        /// how many pages there will be in the set. 
        /// </summary>        
        public int Total { get; set; }

    }
}
