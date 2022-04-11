using PaPBlazor.Data.Models;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace PaPBlazor.Data
{
    /// <summary>
    /// Class containing the business logic of the race model
    /// </summary>
    /// <remarks>
    /// <para>Here, the data are read from the json source, converted to an object and return to the view to print it.</para>
    /// <para>The <see cref="GetRacesAsync"/> method is called by the view to get the races from the racesList attribute.</para>
    /// <para>The <see cref="InitializeData"/> method is called by the constructor to populate the racesList attribute with the data from the JSON file.</para>
    /// </remarks>
    public class RacesService
    {

        #region .: Attributes :.

        private Race[] racesList;

        #endregion .: Attributes :.

        #region .: Constructor :.

        /// <summary>
        /// Initializes a new instance of the <see cref="RacesService"/> class and loads the initial data
        /// </summary>
        public RacesService() => InitializeData();

        #endregion .: Constructor :.

        #region .: Private Methods :.

        /// <summary>
        /// Initialize the racesList attribute with the data from the json source
        /// </summary>
        private void InitializeData()
        {
            using var openStream = File.OpenRead("data/sources/races.json");
            var list = JsonSerializer.DeserializeAsync<RaceCatalog>(openStream, new JsonSerializerOptions { PropertyNameCaseInsensitive = true, WriteIndented = true }).Result;
            racesList = list.Race;
        }

        #endregion .: Private Methods :.

        #region .: Public Methods :.

        /// <summary>
        /// Gets a <see cref="Race"/> array with all the races available
        /// </summary>
        /// <returns>The <see cref="Race"/>s list available</returns>
        public Task<Race[]> GetRacesAsync() => Task.FromResult(racesList);

        #endregion .: Public Methods :.

    }
}
