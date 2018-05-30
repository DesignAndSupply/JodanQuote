using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statements
{
    class Statementsclass
    {

        public static string select_quote = "SELECT * from dbo.quotation WHERE project_id = @project_id";


        public static string view_quote_list = "select id AS [ID],  customer_ref As [Customer], date_created As [Date Created]  from dbo.project ORDER BY [id] DESC ";
        public static string select_customer = "SELECT dbo.SALES_LEDGER.ID, dbo.SALES_LEDGER.NAME, dbo.SALES_LEDGER.flood_flag, dbo.SALES_LEDGER.cust_lock_flag FROM dbo.SALES_LEDGER WHERE(((dbo.SALES_LEDGER.flood_flag)= -1) AND((dbo.SALES_LEDGER.cust_lock_flag)= -1))";
        public static string select_max_project_id = "Select MAX(ID) AS [Project ID] From dbo.project";
        public static string select_max_quote_id = "Select MAX(id) AS [Quote ID] From dbo.quotation";
        public static string select_max_item_id = "Select MAX(item_id) AS [Item ID] From dbo.quotation WHERE Project_id = @project_id";
        public static string insert_new_project = "Insert into dbo.project (quote_id, customer_ref, date_created) Values (@quote_id, @customer_id, @quote_date)";
        public static string insert_new_project_quote = "Insert into dbo.quotation (project_id,item_id customer_id, quote_date) Values (@project_id, @item_id, @customer_id, @quote_date)";
        

    }
}
