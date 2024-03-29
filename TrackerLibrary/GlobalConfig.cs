﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();  
        public static void InitializeConnecitons (bool database , bool textFiles)
        {

            if (database)
            {
                 // TODO Create SQL Connection
                 SqlConnector sql = new SqlConnector ();
                Connections.Add(sql);
            }
            if (textFiles)
            {
                // TODO Create Text Connection
                TextConnector sql = new TextConnector ();
                Connections.Add(text);
            }
        }
    }
}
