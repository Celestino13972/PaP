namespace PaPBlazor.Data.Models
{
    /// <summary>
    /// Class representing the catalog of the races
    /// </summary>
    public class RaceCatalog
    {
        /// <summary>
        /// An array of the <see cref="Race"/>s available to the players
        /// </summary>
        public Race[] Race { get; set; }
    }
}
