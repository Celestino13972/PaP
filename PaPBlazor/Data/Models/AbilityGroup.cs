using System.Linq;

namespace PaPBlazor.Data.Models
{
    /// <summary>
    /// Class representing an ability group
    /// </summary>
    public class AbilityGroup
    {

        #region .: Properties :.

        /// <summary>
        /// The value of the Strength score
        /// </summary>
        public short Str { get; set; }

        /// <summary>
        /// The value of the Dexterity score
        /// </summary>
        public short Dex { get; set; }

        /// <summary>
        /// The value of the Constitution score
        /// </summary>
        public short Con { get; set; }

        /// <summary>
        /// The value of the Intelligence score
        /// </summary>
        public short Int { get; set; }

        /// <summary>
        /// The value of the Wisdom score
        /// </summary>
        public short Wis { get; set; }

        /// <summary>
        /// The value of the Charisma score
        /// </summary>
        public short Cha { get; set; }

        #endregion .: Properties :.

        #region .: Public Methods :.

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            var list = new string[]
            {
                PrintAbility(nameof(Str), Str),
                PrintAbility(nameof(Dex), Dex),
                PrintAbility(nameof(Con), Con),
                PrintAbility(nameof(Int), Int),
                PrintAbility(nameof(Wis), Wis),
                PrintAbility(nameof(Cha), Cha)
            };

            var filteredList = list.Where(item => !string.IsNullOrWhiteSpace(item));

            return filteredList.Any() ? filteredList.Aggregate((x, y) => $"{x}, {y}"): string.Empty;
        }

        #endregion .: Public Methods :.

        #region .: Private Methods :.

        /// <summary>
        /// Prints an ability score if it is greater than zero
        /// </summary>
        /// <param name="name">Name of the parameter</param>
        /// <param name="value">The value of the parameter</param>
        /// <returns>The formated string to print</returns>
        private string PrintAbility(string name, short value) => value > 0 ? $"{name} +{value}" : string.Empty;

        #endregion .: Private Methods :.

    }
}