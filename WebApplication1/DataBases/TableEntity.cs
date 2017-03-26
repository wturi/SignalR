using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication1.Models;
using WebApplication1.SignalR;

namespace WebApplication1.DataBases
{
    public class TableEntity
    {

        /// <summary>
        /// 实现去数据库获取数据，当数据库的数据变化时，客户端也能实时显示
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TableA> GetData()
        {

            using (var sqlConnection = new SqlConnection(DB.ConnectionString))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(@"select [X],[Y],[Z] from [dbo].[TableA]", sqlConnection))
                {
                    sqlCommand.Notification = null;

                    //根据数据库检测到的变化的内容触发OnChange事件
                    SqlDependency dependency = new SqlDependency(sqlCommand);
                    dependency.OnChange += new OnChangeEventHandler(dependency_Onchange);

                    if (sqlConnection.State == ConnectionState.Closed)
                    {
                        sqlConnection.Open();
                    }
                    using (var reader = sqlCommand.ExecuteReader())
                    {
                        return reader.Cast<IDataRecord>().Select(item => new TableA()
                        {
                            X = Convert.ToDecimal(item["X"]),
                            Y = Convert.ToDecimal(item["Y"]),
                            Z = Convert.ToDecimal(item["Z"])
                        }).ToList();
                    }
                }
            }
        }

        public void dependency_Onchange(object sender, SqlNotificationEventArgs e)
        {
            TableAHub.Show();
        }
    }
}