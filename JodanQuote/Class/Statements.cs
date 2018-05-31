using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statements
{
    class Statementsclass
    {

        public static string select_quote = "SELECT TOP 1000 [item_id] As [Item ID],[revision_id] As [Number Of Revisions] FROM [Jodan_quote].[dbo].[c_view_project_quotation] where id = @project_id";
        public static string select_quote_item_count = "SELECT dbo.quotation.id AS [Quote ID], dbo.project.customer_ref AS [Customer],  COUNT(dbo.quotation.item_id) AS [Number Of Items], dbo.project.date_created As [Date Created] FROM dbo.project INNER JOIN dbo.quotation ON dbo.project.id = dbo.quotation.project_id " +
                                                        "GROUP BY dbo.quotation.revision_id, dbo.quotation.id, dbo.project.date_created, dbo.project.customer_ref";
        //main menu search

        public static string search_quote = "select id AS [ID],  customer_ref As [Customer], date_created As [Date Created]  from dbo.project Where  id = @project_id ORDER BY [id] DESC";
        public static string search_quote_customer = "select id AS [ID],  customer_ref As [Customer], date_created As [Date Created]  from dbo.project AND Where Customer_ref  like  '%' + @customer + '%'  And id = @project_id ORDER BY [id] DESC";
        public static string search_customer = "select id AS [ID],  customer_ref As [Customer], date_created As [Date Created]  from dbo.project  Where Customer_ref  like  '%' + @customer + '%'ORDER BY [id] DESC";
        public static string view_quote_list = "select id AS [ID],  customer_ref As [Customer], date_created As [Date Created]  from dbo.project ORDER BY [id] DESC ";
        public static string select_customer = "SELECT  dbo.SALES_LEDGER.NAME, dbo.SALES_LEDGER.account_ref FROM dbo.SALES_LEDGER WHERE(((dbo.SALES_LEDGER.flood_flag)= -1) AND((dbo.SALES_LEDGER.cust_lock_flag)= -1))";

        //Lookup Values
        public static string select_max_project_id = "Select MAX(ID) AS [Project ID] From dbo.project";
        public static string select_max_quote_id = "Select MAX(id) AS [Quote ID] From dbo.quotation";
        public static string select_max_item_id = "Select MAX(item_id) AS [Item ID] From dbo.quotation WHERE Project_id = @project_id";


        public static string insert_new_project = "Insert into dbo.project ( customer_ref, date_created) Values ( @customer_id, @quote_date)";
        public static string insert_new_project_quote = "Insert into dbo.quotation (item_id ,project_id , quote_date, revision_id) Values ( @item_id, @project_id, @quote_date, '1')";
        

    }
}
