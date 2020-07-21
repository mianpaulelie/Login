using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net;

namespace DesignTask2.Interfaces
{
    public interface ISQLiteInterface
    {
        SQLiteConnection GetSQLiteConnection();
    }
}
