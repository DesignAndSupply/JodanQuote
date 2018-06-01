using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statements
{
    class Statementsclass
    {

        public static string select_quote = "SELECT ,[Item Id] ,[Revision Id] As [Number Of Revisions] , [Date Created] FROM [Jodan_quote].[dbo].[c_view_project_quotation] where [Quote ID] = @quote_id";
        public static string select_quote_item_count = "SELECT [Project ID], [Quote ID], [Number Of Items],[Customer],[Date Created] From C_view_item_count Order By [Quote ID] Desc";
        public static string select_quote_items = "SELECT item_id As [Item Id] ,revision_id As [Number Of Revisions], quote_date As [Date Created] FROM [Jodan_quote].[dbo].[quotation] where project_id = @project_id";
        //main menu search

        public static string search_quote = "SELECT dbo.quotation.id AS [Quote ID], dbo.project.customer_ref AS [Customer],  COUNT(dbo.quotation.item_id) AS [Number Of Items], dbo.project.date_created As [Date Created] " +
                                            "FROM dbo.project LEFT OUTER JOIN dbo.quotation ON dbo.project.id = dbo.quotation.project_id " +
                                            "WHERE dbo.quotation.id = @quote_id " +
                                            "GROUP BY dbo.quotation.revision_id, dbo.quotation.id, dbo.project.date_created, dbo.project.customer_ref";

        public static string search_quote_customer = "SELECT dbo.quotation.id AS [Quote ID], dbo.project.customer_ref AS [Customer],  COUNT(dbo.quotation.item_id) AS [Number Of Items], dbo.project.date_created As [Date Created] "+
                                                     "FROM dbo.project LEFT OUTER JOIN dbo.quotation ON dbo.project.id = dbo.quotation.project_id " +
                                                     "WHERE dbo.quotation.id  = @quote_id AND  dbo.project.customer_ref  like  '%' + @customer + '%' " +
                                                     "GROUP BY dbo.quotation.revision_id, dbo.quotation.id, dbo.project.date_created, dbo.project.customer_ref ";

        public static string search_customer = "SELECT dbo.quotation.id AS [Quote ID], dbo.project.customer_ref AS [Customer],  COUNT(dbo.quotation.item_id) AS [Number Of Items], dbo.project.date_created As [Date Created] "+
                                               "FROM dbo.project LEFT OUTER JOIN dbo.quotation ON dbo.project.id = dbo.quotation.project_id " +
                                               "WHERE  dbo.project.customer_ref like  '%' + @customer + '%' " +
                                               "GROUP BY dbo.quotation.revision_id, dbo.quotation.id, dbo.project.date_created, dbo.project.customer_ref ";

        public static string view_quote_list = "select id AS [ID],  customer_ref As [Customer], date_created As [Date Created]  from dbo.project ORDER BY [id] DESC ";
        public static string select_customer = "SELECT  dbo.SALES_LEDGER.NAME, dbo.SALES_LEDGER.account_ref FROM dbo.SALES_LEDGER WHERE(((dbo.SALES_LEDGER.flood_flag)= -1) AND((dbo.SALES_LEDGER.cust_lock_flag)= -1))";

        //Lookup Values
        public static string select_max_project_id = "Select MAX(ID) AS [Project ID] From dbo.project";
        public static string select_max_quote_id = "Select MAX(id) AS [Quote ID] From dbo.quotation";
        public static string select_max_item_id = "Select MAX(item_id) AS [Item ID] From dbo.quotation WHERE Project_id = @project_id";
        public static string select_quote_details = "SELECT project_ref,quote_status FROM dbo.quotation WHERE project_id =@project_id";

        public static string insert_new_project = "Insert into dbo.project ( customer_ref, date_created) Values ( @customer_id, @quote_date)";
        public static string insert_new_project_quote = "Insert into dbo.quotation (item_id ,project_id , quote_date, revision_id) Values (@item_id, @project_id, @quote_date, '1')";

        public static string update_project = "Update dbo.quotation SET project_ref = @project_ref, quote_status = @quote_status Where project_id = @project_id";
    }
}
