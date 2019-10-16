using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CreateModels
{
    public class Common
    {
        /// <summary>
        /// 将数据库类型转成C#变量类型
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string SqlTypeToCtype(string type)
        {
            string cType = string.Empty;
            switch (type)
            {
                case "char":
                case "nchar":
                case "varchar":
                case "nvarchar":
                case "text":
                    cType = "string";
                    break;
                case "int":
                    cType = "int";
                    break;
                case "datetime":
                    cType = "DateTime";
                    break;
                case "decimal":
                case "money":
                case "float":
                    cType = "double";
                    break;
                case "bit":
                    cType = "bool";
                    break;
                default:
                    cType = "string";
                    break;
      
            }
            return cType;
        }


        public static void Write(List<string> list, string savePath)
        {
            try
            {
                using (FileStream fs = new FileStream(savePath, FileMode.Create))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        foreach (string item in list)
                        {
                            sw.WriteLine(item);
                        }                           
                    }
                }
               
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
       
        }
    }
}
