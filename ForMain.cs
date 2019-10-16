using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateModels
{
    public partial class ForMain : Form
    {
        public ForMain()
        {
            InitializeComponent();
        }
        private void ForMain_Load(object sender, EventArgs e)
        {
            GetDataBases();
        }


        private void cboDataBases_SelectedIndexChanged(object sender, EventArgs e)
        {
            trvDataTable.Nodes.Clear();
            if (cboDataBases.Text.Trim().Equals("--请选择--")) return;
            DBHelper.DataBaseName = cboDataBases.Text;
            DataTable dataTable=GetTable();
            foreach (DataRow row in dataTable.Rows)
            {
                string tableName = row["name"].ToString();
                TreeNode node = new TreeNode();
                node.Text = tableName;
                trvDataTable.Nodes.Add(tableName);
            }
        }
        private void trvDataTable_AfterSelect(object sender, TreeViewEventArgs e)
        {
            dvgDataCount.DataSource = GetColunms();
        }
        private void GetDataBases()
        {
            //查询数据库信息
            string sql = @"select name from sysdatabases 
                                    where [dbid] > 4 ";
            //反复查询数据库
            DataTable dt = DBHelper.GetDataTable(sql);
            DataRow row = dt.NewRow();
            row["name"] = "--请选择--";
            dt.Rows.InsertAt(row, 0);
            cboDataBases.DisplayMember = "name";
            cboDataBases.ValueMember = "name";
            cboDataBases.DataSource = dt;
        }

        private DataTable GetTable()
        {
            //查询数据库信息
            string sql = $"select name from {DBHelper.DataBaseName}..sysobjects where Xtype='u' order by name asc";
            return DBHelper.GetDataTable(sql);
        }

        private DataTable GetColunms()
        {
            string tableName = trvDataTable.SelectedNode.Text;
            string sql = $@"select COLUMN_name as '字段名',data_type as '字段属性' 
                                            from INFORMATION_SCHEMA.COLUMNS
                                            where table_name='{tableName}'";
            return DBHelper.GetDataTable(sql);
        }

        private void butcerate_Click(object sender, EventArgs e)
        {
            if (chkModes.Checked)
            {
                CreateModels();
            }
        }

        private void CreateModels()
        {
            List<string> list = new List<string>();
            list.Add("using System;");
            list.Add("using System.Data;");
            list.Add("using System.Collections.Generic;");
            list.Add("namespace CreateModels");
            list.Add("{");
            list.Add($"public class {trvDataTable.SelectedNode.Text}");
            list.Add("{");
            DataTable dt = dvgDataCount.DataSource as DataTable;
            foreach (DataRow row in dt.Rows)
            {
                string type = Common.SqlTypeToCtype(row["字段属性"].ToString());
                string name = row["字段名"].ToString();
                string attribute ="\t"+ $"public  {type}  {name} {{ get; set; }}";
                list.Add(attribute);
            }
            list.Add("}");
            list.Add("}");
            Common.Write(list, $@"E:\{trvDataTable.SelectedNode.Text}.cs");
        }
    }
}
