﻿using SQLHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserTask.Library.DataProvider.UserTask
{
    public class deletetask
    {
        public async Task Delete(List<SQLParam> sQLParams) =>
         await new SQLExecuteNonQueryAsync().ExecuteNonQueryAsync("sp_task_delete", sQLParams);
    }
}
