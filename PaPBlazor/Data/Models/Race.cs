namespace PaPBlazor.Data.Models
{
    /// <summary>
    /// Class representing a race which the player can choose from
    /// </summary>
    public class Race
    {
        /// <summary>
        /// The name of the race
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The abbreviation of the source book where the race is found
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// An array with the possible sizes of the race
        /// </summary>
        public string[] Size { get; set; }

        /// <summary>
        /// An <see cref="AbilityGroup"/> array with the abilities increments/decrements of the race
        /// </summary>
        public AbilityGroup[] Ability { get; set; }

        /// <summary>
        /// The lineage of the race, if any
        /// </summary>
        public object Lineage { get; set; }
    }
}
