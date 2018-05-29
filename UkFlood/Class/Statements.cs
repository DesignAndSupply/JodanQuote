using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statements
{
    class Statementsclass
    {

        public static string select_quote = "SELECT dbo.tbl_door.quote_id, (SELECT Max(v) FROM(VALUES (quote_id), (item_id), (revision_id)) AS value(v)) AS[last_door_ref]," +
                            "(SELECT Max(v) FROM(VALUES (quote_id), (item_id)) AS value(v)) AS[last_description]," +
                            " (SELECT Max(v) FROM(VALUES (quote_id), (item_id)) AS value(v)) AS[last_id] ," +
                            "(SELECT Max(v) FROM(VALUES (quote_id), (item_id)) AS value(v)) AS[last_value]" +
                            "FROM dbo.tbl_door LEFT OUTER JOIN dbo.tbl_door_type ON tbl_door.double_single_id = dbo.tbl_door_type.id " +
                            "WHERE quote_id = @quote_id ORDER BY dbo.tbl_door.quote_id";


        public static string view_quote_list = "select qt_id AS [Quote ID] , customer_name [Customer], quote_ref AS [Quote Reference], date_quote As [Date Quoted], MaxItemID As [No of Items] from dbo.view_quote_list ORDER BY [qt_id] DESC ";

        public static string select_customer = "SELECT dbo.SALES_LEDGER.ACCOUNT_REF, dbo.SALES_LEDGER.NAME, dbo.SALES_LEDGER.flood_flag, dbo.SALES_LEDGER.cust_lock_flag FROM dbo.SALES_LEDGER WHERE(((dbo.SALES_LEDGER.flood_flag)= -1) AND((dbo.SALES_LEDGER.cust_lock_flag)= -1))";

        public static string select_max_id = "Select MAX(ID) AS [Project ID] From dbo.project";


    }
}
