using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class SqlConnector  IDataConnection
    {
        /// <summary>
        /// Saves a new price to the database
        /// </summary>
        /// <param name="model"></param>
        /// <returns>the price information including the unique identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)    
        {
            model.Id=1;
            return model
        }
    }
}
