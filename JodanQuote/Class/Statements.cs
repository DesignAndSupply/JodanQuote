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
       

        public static string select_quote_report = "SELECT * FROM c_view_project_quotation WHERE([Project ID] = @project_id)";
        public static string select_item_report = "SELECT * FROM C_View_Item_Hardware WHERE(Project_ID = @project_id) Group BY [Item Hardware ID],[Hardware ID],[Category ID],category_id, [Hardware Description],[Hardware Cost],[quantity],[Total Cost],[id],[project_id] ";
        public static string select_quote_item_count = "SELECT [Project ID], [Project Reference],[Customer Name], [Date Created],[Number Of Items],[Total Value] From C_view_item_count WHERE jodan_y_n = @jodan_Y_N Order By[Project ID] Desc";
        public static string select_quote_items = "SELECT [Quote ID],[Item ID] ,[Item Date],[Revision Number] FROM [Jodan_quote].[dbo].[c_view_project_quotation] where [Project ID] = @project_id ORder By [Item ID] DESC";
        public static string select_stock_category = "SELECT * from C_view_stock_category where id =1 or id = 4 or id = 11 or id = 15 or id = 18 or id = 35 or id = 69 or id = 76";
        public static string Search_stock_category = "SELECT * from C_view_hardware WHERE category = @category AND jodan_stock = 1 AND sec_rating_level = @security_rating";
        public static string Search_stock_category_description = "SELECT * from C_view_hardware WHERE category = @category AND Description LIKE '%' + @description + '%'  AND jodan_stock = 1  AND sec_rating_level = @security_rating";
        public static string Search_stock_description = "SELECT * from C_view_hardware WHERE Description LIKE '%' + @description + '%' AND jodan_stock = 1  AND sec_rating_level = @security_rating";

        //main menu search

        public static string search_dates = "SELECT  [Project ID], [Project Reference],[Customer Name], [Date Created],[Number Of Items],[Total Value] From C_view_item_count WHERE [Date Created] >= @start_date AND [Date Created] <= @end_date AND jodan_y_n = @jodan_Y_N Order By[Project ID] Desc";

        public static string search_dates_quote = "SELECT  [Project ID], [Project Reference],[Customer Name], [Date Created],[Number Of Items],[Total Value]From C_view_item_count WHERE [Date Created]  >= @start_date AND [Date Created] <= @end_date AND [Project ID] = @project_id AND jodan_y_n = @jodan_Y_N Order By[Project ID] Desc";

        public static string search_dates_customer = "SELECT  [Project ID], [Project Reference],[Customer Name], [Date Created],[Number Of Items],[Total Value]From C_view_item_count WHERE [Date Created]  >= @start_date AND [Date Created] <= @end_date AND [Customer Name]  like  '%' + @customer + '%'  AND jodan_y_n = @jodan_Y_N Order By[Project ID] Desc";

        public static string search_dates_reference = "SELECT  [Project ID], [Project Reference],[Customer Name], [Date Created],[Number Of Items],[Total Value]From C_view_item_count WHERE [Date Created]  >= @start_date AND [Date Created] <= @end_date AND [Project Reference] like  '%' + @Reference + '%'  AND jodan_y_n = @jodan_Y_N Order By[Project ID] Desc";

        public static string search_quote = "SELECT  [Project ID], [Project Reference],[Customer Name], [Date Created],[Number Of Items],[Total Value]From C_view_item_count WHERE[project id] = @project_id AND jodan_y_n = @jodan_Y_N Order By[Project ID] Desc";

      
        public static string search_quote_customer_reference = "SELECT [Project ID], [Project Reference],[Customer Name], [Date Created],[Number Of Items],[Total Value]From C_view_item_count WHERE [project id] = @project_id  AND  [Customer Name]   like  '%' + @customer + '%' AND jodan_y_n = @jodan_Y_N " +
                                                     "AND [Project Reference]   like  '%' + @Reference + '%'Order By[Project ID] Desc";

        public static string search_quote_reference = "SELECT  [Project ID], [Project Reference],[Customer Name], [Date Created],[Number Of Items],[Total Value] From C_view_item_count WHERE [project id] = @project_id AND jodan_y_n = @jodan_Y_N " +
                                                   "AND [Project Reference]   like  '%' + @Reference + '%' Order By[Project ID] Desc";

        public static string search_customer_reference = "SELECT  [Project ID], [Project Reference],[Customer Name], [Date Created],[Number Of Items],[Total Value] From C_view_item_count WHERE  [Customer Name]   like  '%' + @customer + '%' AND jodan_y_n = @jodan_Y_N " +
                                                   "AND [Project Reference]   like  '%' + @Reference + '%' Order By[Project ID] Desc";

        public static string search_reference = "SELECT [Project ID], [Project Reference],[Customer Name], [Date Created],[Number Of Items],[Total Value]From C_view_item_count WHERE [Project Reference] like  '%' + @Reference + '%'  AND jodan_y_n = @jodan_Y_N " +
                                                  " Order By[Project ID] Desc";


        public static string search_quote_customer = "SELECT  [Project ID], [Project Reference],[Customer Name], [Date Created],[Number Of Items],[Total Value]From C_view_item_count WHERE [project id] = @project_id  AND  [Customer Name]   like  '%' + @customer + '%' AND jodan_y_n = @jodan_Y_N " +
                                                     "Order By[Project ID] Desc";

        public static string search_customer = "SELECT  [Project ID], [Project Reference],[Customer Name], [Date Created],[Number Of Items],[Total Value]From C_view_item_count WHERE [Customer Name] like  '%' + @customer + '%'  AND jodan_y_n = @jodan_Y_N " +
                                                     "Order By[Project ID] Desc";



        public static string view_quote_list = "SELECT id AS [ID],  customer_ref As [Customer], date_created As [Date Created]  from dbo.project ORDER BY [id] DESC ";


        //delete statements

        public static string delete_quote_item = "DELETE From dbo.item Where project_id = @project_id AND item_id = @item_id ";
        public static string delete_item_hardware= "DELETE From dbo.item_hardware Where ID = @ID ";
        public static string delete_multiple_item_hardware = "DELETE From dbo.item_hardware Where item_ID = @ID ";
        public static string delete_item_addon= "DELETE From dbo.item_add_ons Where ID = @ID ";

        //Lookup Values
        public static string select_max_project_id = "SELECT MAX(ID) AS [Project ID] From dbo.project";
        public static string select_max_quote_id = "SELECT TOP (1) ID AS [Quote ID]  FROM dbo.Max_id ";
        public static string select_max_item_id = "SELECT MAX(item_id) AS [Item ID] From dbo.item WHERE Project_id = @project_id";
        public static string select_max_revision_id = "SELECT MAX(Revision_id) As [Revision ID] From dbo.item WHERE Project_id = @project_id AND item_id =@item_ID";
        public static string select_quote_details = "SELECT project_ref,quote_status FROM dbo.project WHERE id =@project_id";
        public static string Select_door_type = "SELECT id, description, double_door FROM dsl.dbo.view_door_styles ORDER BY obsolete";
        public static string select_customer = "SELECT  * From C_View_Jodan_customer";
        public static string select_item_details = "SELECT structual_op_height,structual_op_width,frame_width,frame_height FROM dbo.item WHERE project_id =@project_id AND item_id = @item_id";
        public static string copy_project = " Select * From dbo.project Where id =@project_id";
        public static string copy_item = " Select * From dbo.item Where id =@id";
        public static string copy_item_convert = " Select * From dbo.C_View_Item_Max_revision Where project_id = @project_Id";
        public static string copy_hardware = "SELECT [Hardware Description],[Category ID], [Hardware ID],[Hardware Cost],[Quantity],[Total Cost] from C_VIEW_ITEM_HARDWARE WHERE [Item Hardware ID] = @ID";
        public static string copy_addon = "SELECT item_id,add_on_id,add_on_width,add_on_height,material_id,material_thickness,add_on_material_id,material_cost,labour_hours,labour_cost,position,removable,qty,powder_coated,powder_coat_cost " +
                                                    " ,unit_material_cost from C_VIEW_ITEM_Add_on WHERE Item_ID = @ID";
        public static string select_item_hinge = "SELECT quantity,hardware_cost from dbo.item_hardware WHERE item_id = @item_id  AND category_id = 11  ";
        public static string select_item_seal= "SELECT quantity,hardware_cost from dbo.item_hardware WHERE item_id = @item_id  AND category_id = 40  ";
        public static string Select_materials = "SELECT description, material_id FROM C_View_Item_Material";
        public static string insert_new_project = "Insert into dbo.project (customer_ref, date_created,jodan_y_n) Values (@customer_id, @quote_date,1)";
        public static string insert_new_project_quote = "Insert into dbo.item (item_id ,project_id , item_date, revision_id,created_by,markup_material,markup_hardware,labour_rate) Values (@item_id, @project_id, @item_date, '1',@created_by,@markup_material,@markup_hardware,@labour_rate)";
        public static string revise_item = "Insert into dbo.item (item_id ,project_id , item_date, revision_id,material_id,finish_id,fire_rating_id,security_rating_id,infill_id,door_ref,door_type_id,door_style,structual_op_height,structual_op_width,frame_width,frame_height,jamb_width,jamb_height,finish_description,material_thickness,created_by," +
                                           "markup_material, markup_hardware, labour_rate,hardware_cost,material_cost,labour_cost,security_rating_cost,fire_rating_cost,paint_cost,addon_cost,converted_cost,total_cost)" +
                                           "Values (@item_id ,@project_id , @item_date, @revision_id,@material_id,@finish_id,@fire_rating_id,@security_rating_id,@infill_id,@door_ref,@door_type,@door_style,@structual_op_height,@structual_op_width,@frame_width,@frame_height,@jamb_width,@jamb_height,@finish_description,@material_thickness,@created_by," +
                                           "@markup_material,@markup_hardware,@labour_rate,@hardware_cost,@material_cost,@labour_cost,@security_rating_cost,@fire_rating_cost,@oaint_cost,@addon_cost,@converted_cost,@total_cost)";
        public static string select_setting = "SELECT markup_hardware, markup_material, labour_rate from dbo.setting WHERE ID = 1";
        public static string update_project = "Update dbo.project SET project_ref = @project_ref, quote_status = @quote_status, project_notes = @project_notes, survey_cost = @survey_cost, installation_cost = @installation_cost, delivery_cost= @delivery_cost Where id = @project_id";
        public static string update_quotation_item = "Update dbo.item SET structual_op_height = @structure_height, structual_op_width = @structure_width, fire_rating_cost = @fire_rating_cost, security_rating_cost = @security_rating_cost,jamb_style_id = @jamb_style_id, jamb_width = @jamb_width, jamb_height = @jamb_height," +
                                                     "frame_height = @frame_height, frame_width = @frame_width , door_type_id = @door_type,finish_description = @finish_description, finish_id = @finish_id, material_id = @material_id, fire_rating_id = @fire_id, security_rating_id = @security_rating_id, infill_id = @infill_id, material_thickness = @material_thickness,item_notes = @item_notes,finish_colour =@finish_colour," +
                                                     "markup_hardware = @markup_hardware, markup_material = @markup_material, labour_rate = @labour_rate, hardware_cost = @hardware_cost, material_cost = @material_cost, addon_cost = @addon_cost, labour_cost= @labour_cost, paint_cost = @paint_cost, total_cost = @total_cost , additional_cost = @additional_cost, discount_percentage = @discount_percentage " +
                                                     "Where project_id = @project_id AND Item_id = @item_id AND revision_id = @revision_id";
        public static string update_hardware_item = "Update dbo.item_hardware SET  quantity = @quantity, total_cost = @total_cost WHERE id = @ID";
        public static string update_hinge = "Update dbo.item_hardware SET quantity = @quantity, total_cost = @total_cost WHERE item_id = @item_id AND category_id = 11";
        public static string update_seal_firerated = "Update dbo.item_hardware SET quantity = @quantity,hardware_cost = @hardware_cost, total_cost = @total_cost , hardware_id = 1137,  hardware_description = @hardware_description WHERE item_id = @item_id AND category_id = 40";
        public static string update_seal_non_firerated = "Update dbo.item_hardware SET quantity = @quantity, hardware_cost = @hardware_cost, total_cost = @total_cost , hardware_id = 1244,  hardware_description = @hardware_description WHERE item_id = @item_id AND category_id = 40";
        public static string insert_hardware = "Insert into dbo.item_hardware(item_id,hardware_id,category_id,hardware_description,hardware_cost,quantity,total_cost) Values (@id,@hardware_id,@category_id,@hardware_description,@hardware_cost,@quantity,@total_cost)";
        public static string insert_add_on = "Insert INTO dbo.item_add_ons (item_id,add_on_id,add_on_width,add_on_height,material_id,material_thickness,add_on_material_id,material_cost,labour_hours,labour_cost,position,removable,powder_coated,powder_coat_cost,qty,unit_material_cost)" +
                                                  "VALUES (@quotation_id, @add_on_id, @add_on_width, @add_on_height, @material_id, @material_thickness,  @add_on_material_id, @material_cost, @labour_hours, @labour_cost, @position,@removable, @powder_coated, @powder_coat_cost, @qty, @unit_material_cost)";
        public static string insert_copied_item = "Insert into dbo.item (project_id,item_id ,order_id , item_date ,material_id,finish_id,fire_rating_id,security_rating_id,infill_id,jamb_style_id,item_notes,door_ref ,door_type_id, door_style, structual_op_height, structual_op_width, frame_width, frame_height,jamb_width,jamb_height,finish_description,finish_colour,material_thickness,created_by,revision_id,markup_material,material_cost,markup_hardware,hardware_cost,labour_rate,labour_cost,fire_rating_cost,security_rating_cost,paint_cost,addon_cost,converted_cost,total_cost,additional_cost,discount_percentage) " +
                                                  "Values (@project_id,@item_id,@order_id ,@item_date ,@material_id,@finish_id,@fire_rating_id,@security_rating_id,@infill_id,@jamb_style_id, @item_notes,@door_ref ,@door_type, @door_style, @structual_op_height, @structual_op_width, @frame_width, @frame_height,@jamb_width,@jamb_height,@finish_description,@finish_colour,@material_thickness, @created_by,1,@markup_material,@material_cost,@markup_hardware,@hardware_cost,@labour_rate,@labour_cost,@fire_rating_cost,@security_rating_cost,@paint_cost,@addon_cost,@converted_cost,@total_cost,@additional_cost,@discount_percentage)";
        public static string insert_copied_project = "Insert into dbo.project (customer_ref,site_ref,project_ref,date_created,quote_status,jodan_y_N,convertion_id) Values (@customer_ref,@site_ref,@project_ref,@date_created,@quote_status,@jodan_y_n,@convertion_id)";

        public static string update_settings = "Insert into dbo.Settings(markup_hardware,markup_material,labour_rate,single_extra,double_extra,single_flood_extra,double_flood_extra,date_modified) " +
                                                 "Values(@markup_hardware,@markup_material,@labour_rate,@single_extra,@double_extra,@single_flood_extra,@double_flood_extra,@date_modified)";
        public static string update_stock = "Update dbo.Stock Set jodan_stock = 1 , sec_rating_level = @security_rating WHERE id = @id";
       
        public static string update_stock_null = "Update dbo.Stock Set jodan_stock = NULL , sec_rating_level = @security_rating WHERE id = @id";
        //email

        public static string select_email_recipients = "Select name AS [Name], email As [Email] From Dbo.email_List";


        // update

        public static string update_dimensions = "Update dbo.item set structual_op_height = @height, structual_op_width = @width, frame_height = @frame_height, frame_width = @frame_width WHERE project_id = @project_id AND item_id =@item_id";
    }
}
