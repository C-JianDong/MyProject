using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBookkeeping
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnSubmin_Click(object sender, EventArgs e)
        {
            // 获取窗体数据
            List<BookkeepingModel> data = new List<BookkeepingModel> {
               new BookkeepingModel{
                   Type=this.cmbType.Text,
                   Category=this.cmbCategory.Text,
                   Money=Convert.ToDecimal( this.txtMoney.Text),
                   Describe= this.cmbDescribe.Text,
                   CreateTime=DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        }
        };
            string filePath = System.Configuration.ConfigurationManager.AppSettings["FilePath"] + $"{DateTime.Now.Year}年账单.xls";
            //验证路径是否存在
            if (!File.Exists(filePath))
            {
                string a = filePath.Substring(0, filePath.LastIndexOf("\\"));
                //不存在则创建
                Directory.CreateDirectory(filePath.Substring(0, filePath.LastIndexOf("\\")));
            }
            File.AppendAllText(filePath.Replace(".xlsx", "txt").Replace(".xls", "txt"), $"{data.First().CreateTime}#{data.First().Type}#{data.First().Category}#{data.First().Money}元#{data.First().Describe}\r\n");
            if (AsposeCellsHelp.CreateExcel(filePath, data))
            {
                lblResult.Text = "记账成功";
            }
            else
            {
                lblResult.Text = "记账失败";
            }
        }
    }
}
