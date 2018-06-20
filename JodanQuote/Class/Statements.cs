﻿using System;
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
        public static string select_quote_items = "SELECT [Quote ID],[Item ID] ,[Item Date],[Revision Number]  FROM [Jodan_quote].[dbo].[c_view_project_quotation] where [Project ID] = @project_id ORder By [Item ID] DESC";
        public static string select_stock_category = "SELECT * from C_view_stock_category";
        public static string Search_stock_category = "SELECT * from C_view_hardware WHERE category = @category";
        public static string Search_stock_category_description = "SELECT * from C_view_hardware WHERE category = @category AND Description LIKE '%' + @description + '%' ";
        public static string Search_stock_description = "SELECT * from C_view_hardware WHERE Description LIKE '%' + @description + '%' ";
        //main menu search

        public static string search_quote = "SELECT dbo.project.id AS [Project ID], dbo.project.customer_ref AS [Customer],  COUNT(dbo.item.item_id) AS [Number Of Items], dbo.project.date_created As [Date Created] " +
                                            "FROM dbo.project LEFT OUTER JOIN dbo.item ON dbo.project.id = dbo.item.project_id " +
                                            "WHERE dbo.item.id = @quote_id " +
                                            "GROUP BY dbo.item.revision_id, dbo.project.id, dbo.project.date_created, dbo.project.customer_ref";

        public static string search_quote_customer = "SELECT dbo.project.id AS [Project ID], dbo.project.customer_ref AS [Customer],  COUNT(dbo.item.item_id) AS [Number Of Items], dbo.project.date_created As [Date Created] " +
                                                     "FROM dbo.project LEFT OUTER JOIN dbo.item ON dbo.project.id = dbo.item.project_id " +
                                                     "WHERE dbo.item.id  = @quote_id AND  dbo.project.customer_ref  like  '%' + @customer + '%' " +
                                                     "WHERE dbo.item.id  = @quote_id AND  dbo.project.customer_ref  like  '%' + @customer + '%' " +
                                                     "GROUP BY dbo.item.revision_id, dbo.project.id, dbo.project.date_created, dbo.project.customer_ref ";

        public static string search_customer = "SELECT dbo.project.id AS [Project ID], dbo.project.customer_ref AS [Customer],  COUNT(dbo.item.item_id) AS [Number Of Items], dbo.project.date_created As [Date Created] " +
                                               "FROM dbo.project LEFT OUTER JOIN dbo.item ON dbo.project.id = dbo.item.project_id " +
                                               "WHERE  dbo.project.customer_ref like  '%' + @customer + '%' " +
                                               "GROUP BY dbo.item.revision_id, dbo.project.id, dbo.project.date_created, dbo.project.customer_ref ";

        public static string view_quote_list = "SELECT id AS [ID],  customer_ref As [Customer], date_created As [Date Created]  from dbo.project ORDER BY [id] DESC ";


        //delete statements

        public static string delete_quote_item = "DELETE From dbo.item Where Item_id = @item_id AND project_id = @project_Id ";
        public static string delete_item_hardware= "DELETE From dbo.item_hardware Where ID = @ID ";

        //Lookup Values
        public static string select_max_project_id = "SELECT MAX(ID) AS [Project ID] From dbo.project";
        public static string select_max_quote_id = "SELECT MAX(ID) AS [Quote ID] From dbo.item";
        public static string select_max_item_id = "SELECT MAX(item_id) AS [Item ID] From dbo.item WHERE Project_id = @project_id";
        public static string select_max_revision_id = "SELECT MAX(Revision_id) As [Revision ID] From dbo.item WHERE Project_id = @project_id AND item_id =@item_ID";
        public static string select_quote_details = "SELECT project_ref,quote_status FROM dbo.project WHERE id =@project_id";
        public static string Select_door_type = "SELECT id, description, double_door FROM dsl.dbo.view_door_styles ORDER BY obsolete";
        public static string select_customer = "SELECT  dbo.SALES_LEDGER.NAME, dbo.SALES_LEDGER.account_ref FROM dbo.SALES_LEDGER WHERE(((dbo.SALES_LEDGER.flood_flag)= -1) AND((dbo.SALES_LEDGER.cust_lock_flag)= -1))";
        public static string select_item_details = "SELECT structual_op_height,structual_op_width,frame_width,frame_height FROM dbo.item WHERE project_id =@project_id AND item_id = @item_id";
        public static string copy_item = " Select project_id, order_id , item_date ,door_ref ,door_type, door_style, structual_op_height, structual_op_width, frame_width, frame_height,total_cost From dbo.item Where Item_id =@item_id AND project_id = @project_Id";
        public static string copy_hardware = "SELECT [Hardware Description], [Hardware ID],[Hardware Cost],[Quantity],[Total Cost] from C_VIEW_ITEM_HARDWARE WHERE [Project ID] = @project_id AND [ITEM ID] = @item_id";
        public static string Select_materials = "SELECT description, material_id FROM C_View_Item_Material";
        public static string insert_new_project = "Insert into dbo.project (customer_ref, date_created) Values ( @customer_id, @quote_date)";
        public static string insert_new_project_quote = "Insert into dbo.item (item_id ,project_id , item_date, revision_id,created_by,markup_material,markup_hardware,labour_rate) Values (@item_id, @project_id, @item_date, '1',@created_by,@markup_material,@markup_hardware,@labour_rate)";
        public static string revise_item = "Insert into dbo.item (item_id ,project_id , item_date, revision_id,material_id,finish_id,door_ref,door_type,door_style,structual_op_height,structual_op_width,frame_width,frame_height,finish_description,material_thickness,total_cost,created_by," +
                                           "markup_material, markup_hardware, labour_rate )" +
                                          "Values (@item_id ,@project_id , @item_date, @revision_id,@material_id,@finish_id,@door_ref,@door_type,@door_style,@structual_op_height,@structual_op_width,@frame_width,@frame_height,@finish_description,@material_thickness,@total_cost,@created_by" +
                                                     "@markup_material,@markup_hardware,@labour_rate)";
        public static string select_setting = "SELECT markup_hardware, markup_material, labour_rate from dbo.setting WHERE ID = 1";
        public static string update_project = "Update dbo.project SET project_ref = @project_ref, quote_status = @quote_status Where id = @project_id";
        public static string update_quotation_item = "Update dbo.item SET structual_op_height = @structure_height, structual_op_width = @structure_width," +
                                                     "frame_height = @frame_height, frame_width = @frame_width"+
                                                     "material_id = @material_id, material_thickness = @material_thickness" +
                                                     " Where id = @project_id AND Item_id = @item_id";

        public static string insert_hardware = "Insert into dbo.item_hardware(item_id,hardware_id,hardware_description,hardware_cost,quantity,total_cost) Values (@id,@hardware_id,@hardware_description,@hardware_cost,@quantity,@total_cost)";
        public static string insert_copied_item = "Insert into dbo.item (project_id,item_id ,order_id , item_date ,door_ref ,door_type, door_style, structual_op_height, structual_op_width, frame_width, frame_height,total_cost,created_by,revision_id) " +
                                                  "Values (@project_id,@item_id,@order_id ,@item_date ,@door_ref ,@door_type, @door_style, @structual_op_height, @structual_op_width, @frame_width, @frame_height, @total_cost,@created_by,1)";
        //email

        public static string select_email_recipients = "Select name AS [Name], email As [Email] From Dbo.email_List";


        // update

        public static string update_dimensions = "Update dbo.item set structual_op_height = @height, structual_op_width = @width, frame_height = @frame_height, frame_width = @frame_width WHERE project_id = @project_id AND item_id =@item_id";
    }
}
