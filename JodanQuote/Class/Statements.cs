using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statements
{
    class Statementsclass
    {


        public static string quote_pdf_path = @"\\designsvr1\apps\Design and Supply CSharp\Documents\Jodan Quote\Saved\";
       

        public static string select_quote_report = "SELECT [Project Id] ,[Item Id] , [Date Created] FROM [Jodan_quote].[dbo].[c_view_project_quotation] where [Project ID] = @Project";
        public static string select_quote_item_count = "SELECT [Project ID], [Number Of Items],[Customer],[Date Created] From C_view_item_count Order By [Project ID] Desc";
        public static string select_quote_items = "SELECT [Item ID] ,[Item Date] FROM [Jodan_quote].[dbo].[c_view_project_quotation] where [Project ID] = @project_id";

        //main menu search

        public static string search_quote = "SELECT dbo.project.id AS [Project ID], dbo.project.customer_ref AS [Customer],  COUNT(dbo.quotation.item_id) AS [Number Of Items], dbo.project.date_created As [Date Created] " +
                                            "FROM dbo.project LEFT OUTER JOIN dbo.quotation ON dbo.project.id = dbo.quotation.project_id " +
                                            "WHERE dbo.quotation.id = @quote_id " +
                                            "GROUP BY dbo.quotation.revision_id, dbo.project.id, dbo.project.date_created, dbo.project.customer_ref";

        public static string search_quote_customer = "SELECT dbo.project.id AS [Project ID], dbo.project.customer_ref AS [Customer],  COUNT(dbo.quotation.item_id) AS [Number Of Items], dbo.project.date_created As [Date Created] "+
                                                     "FROM dbo.project LEFT OUTER JOIN dbo.quotation ON dbo.project.id = dbo.quotation.project_id " +
                                                     "WHERE dbo.quotation.id  = @quote_id AND  dbo.project.customer_ref  like  '%' + @customer + '%' " +
                                                     "GROUP BY dbo.quotation.revision_id, dbo.project.id, dbo.project.date_created, dbo.project.customer_ref ";

        public static string search_customer = "SELECT dbo.project.id AS [Project ID], dbo.project.customer_ref AS [Customer],  COUNT(dbo.quotation.item_id) AS [Number Of Items], dbo.project.date_created As [Date Created] " +
                                               "FROM dbo.project LEFT OUTER JOIN dbo.quotation ON dbo.project.id = dbo.quotation.project_id " +
                                               "WHERE  dbo.project.customer_ref like  '%' + @customer + '%' " +
                                               "GROUP BY dbo.quotation.revision_id, dbo.project.id, dbo.project.date_created, dbo.project.customer_ref ";

        public static string view_quote_list = "SELECT id AS [ID],  customer_ref As [Customer], date_created As [Date Created]  from dbo.project ORDER BY [id] DESC ";


        //delete statements

        public static string delete_quote_item = "DELETE From dbo.quotation Where Item_id = @item_id AND project_id = @project_Id ";


        //Lookup Values
        public static string select_max_project_id = "SELECT MAX(ID) AS [Project ID] From dbo.project";
        public static string select_max_quote_id = "SELECT MAX(id) AS [Quote ID] From dbo.quotation";
        public static string select_max_item_id = "SELECT MAX(item_id) AS [Item ID] From dbo.quotation WHERE Project_id = @project_id";
        public static string select_quote_details = "SELECT project_ref,quote_status FROM dbo.project WHERE id =@project_id";
        public static string select_customer = "SELECT  dbo.SALES_LEDGER.NAME, dbo.SALES_LEDGER.account_ref FROM dbo.SALES_LEDGER WHERE(((dbo.SALES_LEDGER.flood_flag)= -1) AND((dbo.SALES_LEDGER.cust_lock_flag)= -1))";
        public static string select_item_details = "SELECT structual_op_height,structual_op_width FROM dbo.quotation WHERE project_id =@project_id AND item_id = @item_id";

        public static string insert_new_project = "Insert into dbo.project ( customer_ref, item_date) Values ( @customer_id, @quote_date)";
        public static string insert_new_project_quote = "Insert into dbo.quotation (item_id ,project_id , item_date, revision_id) Values (@item_id, @project_id, @item_date, '1')";

        public static string update_project = "Update dbo.project SET project_ref = @project_ref, quote_status = @quote_status Where id = @project_id";

        //email

        public static string select_email_recipients = "Select name AS [Name], email As [Email] From Dbo.email_List";


        // update

        public static string update_dimensions = "Update dbo.quotation set structual_op_height = @height, structual_op_width = @width WHERE project_id = @project_id AND item_id =@item_id";
    }
}
