using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    class PhanTrang
    {
        public static void toGridView(int limit,int start,DataGridView dgv,String tableName)
        {
            DataTable dt = KetNoi.LayDL("select top " + limit + " * from "+ tableName + " where id not in (select top " + start + " id from "+ tableName + " )");
            dgv.DataSource = dt;
        }
        public static void Init(String tableName, int limit,ref int totalRecord,ref double totalPage,DataGridView dgv)
        {
            DataTable dt = KetNoi.LayDL("select top " + limit + " * from " + tableName + "");
            DataTable dt1 = KetNoi.LayDL("select * from "+tableName+"");
            totalRecord = dt1.Rows.Count;
            totalPage = Math.Ceiling((double)totalRecord / limit);
            dgv.DataSource = dt1;
        }
        public static void btnNext(ref int currentPage, double totalPage,int limit,int start,DataGridView dgv,string tableName)
        {
            if (currentPage<totalPage)
            {
                currentPage++;
                start = (currentPage - 1) * limit;
                toGridView(limit, start, dgv, tableName);
            }
            else
            {
                return;
            }
        }
        public static void btnPrev(ref int currentPage, double totalPage, int limit, int start, DataGridView dgv, string tableName)
        {
            if (currentPage>1)
            {
                currentPage--;
                start = (currentPage - 1) * limit;
                toGridView(limit, start, dgv, tableName);
            }
            else
            {
                return;
            }
        }

        public static void btnLast(ref int currentPage, double totalPage, int limit, int start, DataGridView dgv, string tableName)
        {
            currentPage = (int)totalPage;
            start = (currentPage - 1) * limit;
            toGridView(limit, start, dgv, tableName);
        }
        public static void btnFirst(ref int currentPage, double totalPage, int limit, int start, DataGridView dgv, string tableName)
        {
            currentPage = 1;
            start = (currentPage - 1) * limit;
            toGridView(limit, start, dgv, tableName);
        }
    }
}
