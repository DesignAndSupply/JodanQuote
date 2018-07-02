using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace values
{
    class Valuesclass
    {

        public static int project_id;
        public static int quote_id;
        public static int max_item_id;
        public static int new_item_identifier;
        public static string customer_name;
        public static string customer_account_ref;
        public static int item_id;
        public static int revision_number;
        public static string project_ref;
        public static string quote_status;
        public static int dimension_width = 0;
        public static int dimension_height = 0;
        public static int locked_identifiter;
        public static int id;
        public static int jodan_y_n = 1;
        public static  List<object> Calculate_material_list = new List<object>(new object[] { "project_id", "item_id", "revision_id","Material Description", "Material_thickness", "door_type", "structual_op_width", "structual_op_height", });
    }
}
