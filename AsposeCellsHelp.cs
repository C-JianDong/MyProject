using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookkeeping
{
    public static class AsposeCellsHelp
    {
        public static bool CreateExcel(string filePath, List<BookkeepingModel> data)
        {
            try
            {
                bool isExists = File.Exists(filePath);
                // 创建或者打开工作簿
                Workbook book = isExists ? new Workbook(filePath) : new Workbook();

                Worksheet sheet = book.Worksheets[0]; //创建工作表
                Cells cells = sheet.Cells; //单元格
                                           //创建样式
                Aspose.Cells.Style style = book.Styles[book.Styles.Add()];
                style.Borders[Aspose.Cells.BorderType.LeftBorder].LineStyle = Aspose.Cells.CellBorderType.Thin; //应用边界线 左边界线  
                style.Borders[Aspose.Cells.BorderType.RightBorder].LineStyle = Aspose.Cells.CellBorderType.Thin; //应用边界线 右边界线  
                style.Borders[Aspose.Cells.BorderType.TopBorder].LineStyle = Aspose.Cells.CellBorderType.Thin; //应用边界线 上边界线  
                style.Borders[Aspose.Cells.BorderType.BottomBorder].LineStyle = Aspose.Cells.CellBorderType.Thin; //应用边界线 下边界线   
                style.HorizontalAlignment = TextAlignmentType.Center; //单元格内容的水平对齐方式文字居中
                style.Font.Name = "宋体"; //字体
                style.Font.IsBold = true; //设置粗体
                style.Font.Size = 11; //设置字体大小
                                      //style.ForegroundColor = System.Drawing.Color.FromArgb(153, 204, 0); //背景色
                                      //style.Pattern = Aspose.Cells.BackgroundType.Solid; //背景样式
                                      //style.IsTextWrapped = true; //单元格内容自动换行

                //表格填充数据
                // 表头

                string[] tableHead = new string[] { "序号", "类型", "类别", "金额", "描述", "时间" };
                int Colnum = tableHead.Length;//表格列数 
                int Rownum = data.Count();//表格行数 
                                          //生成行 列名行 
                                          // 创建表头
                if (!isExists)
                {
                    for (int i = 0; i < Colnum; i++)
                    {
                        cells[0, i].PutValue(tableHead[i]); //添加表头
                        cells[0, i].SetStyle(style); //添加样式
                                                     //cells.SetColumnWidth(i, data.Columns[i].ColumnName.Length * 2 + 1.5); //自定义列宽
                                                     //cells.SetRowHeight(0, 30); //自定义高
                    }
                }
                // 判断有数据的最后一行是哪一行

                //生成数据行 

                for (int i = 0; i < Rownum; i++)
                {
                    int rowcount = cells.MaxDataRow + 1;
                    cells[rowcount, 0].PutValue(rowcount); //添加数据
                    cells[rowcount, 0].SetStyle(style); //添加样式

                    cells[rowcount, 1].PutValue(data[i].Type); //添加数据
                    cells[rowcount, 1].SetStyle(style); //添加样式

                    cells[rowcount, 2].PutValue(data[i].Category); //添加数据
                    cells[rowcount, 2].SetStyle(style); //添加样式

                    cells[rowcount, 3].PutValue(data[i].Money); //添加数据
                    cells[rowcount, 3].SetStyle(style); //添加样式

                    cells[rowcount, 4].PutValue(data[i].Describe); //添加数据
                    cells[rowcount, 4].SetStyle(style); //添加样式

                    cells[rowcount, 5].PutValue(data[i].CreateTime); //添加数据
                    cells[rowcount, 5].SetStyle(style); //添加样式
                                                        //cells[1 + i, 5].Formula = "=B" + (2 + i) + "+C" + (2 + i);//给单元格设置计算公式，计算班级总人数
                }
                sheet.AutoFitColumns(); //自适应宽
                book.Save(filePath); //保存
                GC.Collect();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
