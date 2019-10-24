using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MemoInserter20170511
{
    public partial class MemosInserter : Form
    {
        // カラムの末尾
        public static readonly int END_OF_COLUMN = 13;

        // ファイルパス
        private String filePath;

        public MemosInserter()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (filePath == null)
            {
                errorCodeLabel.ForeColor = System.Drawing.Color.Red;
                errorCodeLabel.Text = "Select inserting file.";
                return;
            }

            errorCodeLabel.ForeColor = System.Drawing.Color.Blue;
            errorCodeLabel.Text = "Inserting start...";

            insertData(this.filePath);
        }

        private void insertData(String filePath)
        {

            /***** MEMOSファイルの読み込み Start *****/
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            // エクセルを非表示
            ExcelApp.Visible = false;
            // エクセルファイルのオープン
            Microsoft.Office.Interop.Excel.Workbooks WorkBooks = ExcelApp.Workbooks;
            Microsoft.Office.Interop.Excel.Workbook WorkBook = WorkBooks.Open(filePath);

            // １シート目の選択
            Microsoft.Office.Interop.Excel.Worksheet sheet = WorkBook.Sheets[1];
            sheet.Select();
            /***** MEMOSファイルの読み込み End *****/

            /***** DBにアクセス *****/

            String connectionString = "Data Source=ECOLOGDB2016;Initial Catalog=ECOLOGDBver3;Integrated Security=True;Connection Timeout=60";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                // データ挿入
                try
                {
                    // MEMOSデータの読み込み（ヘッダは除く）
                    for (int i = 2; i <= sheet.UsedRange.Rows.Count; i++)
                    {
                        indexLabel.Text = i + " / " + sheet.UsedRange.Rows.Count;
                        MemosDatum datum = new MemosDatum();

                        for(int j = 1; j <= END_OF_COLUMN; j++)
                        {
                            Microsoft.Office.Interop.Excel.Range range = sheet.Cells[i, j];
                            datum.setDatumByIndex(j, range.Value);
                        }

                        /***** データベースに挿入*****/

                        // トランザクション生成
                        SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();
                        SqlCommand sqlCommand = sqlConnection.CreateCommand();
                        sqlCommand.Transaction = sqlTransaction;

                        try
                        {
                            // 新規にinsert文を発行
                            String sqlIns = getInsertString(datum);
                            sqlCommand.CommandText = sqlIns;
                            // 指定したSQLコマンドを実行してデータを挿入する
                            sqlCommand.ExecuteNonQuery();
                            // 上手くいったらコミット
                            sqlTransaction.Commit();

                            this.successTextBox.AppendText("Success : " + datum.date + ", " + datum.tripDirection + System.Environment.NewLine);
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine(e.Message);
                            this.failedTextBox.AppendText("Failed : " + datum.date + ", " + datum.tripDirection + System.Environment.NewLine);
                            // 失敗すると例外となるのでロールバック
                            sqlTransaction.Rollback();
                        }
                    }
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
            // Workbookを閉じる
            WorkBook.Close();
            WorkBook = null;
            WorkBooks.Close();
            WorkBooks = null;
            // エクセルを閉じる
            ExcelApp.Quit();
            ExcelApp = null;

            errorCodeLabel.Text = "All inserting complete.";
        }

        private String getInsertString(MemosDatum datum)
        {
            String insertQuery;
           if (datum.CH > 0)
            {
                insertQuery = "INSERT INTO MEMOS VALUES('" + datum.date + "','" + datum.tripDirection + "','" + datum.hodogaya + "','" + datum.AC + "','" + datum.defroster + "','" 
                    + datum.timer + "','" + datum.CH + "','" + datum.startGids + "','" + datum.endGids + "','" + datum.averageElectricityExpense + "','" 
                    + datum.electricityExpenseReset + "','" + datum.remarks + "','" + datum.serialNumber + "')";
            }
            else
            {
                insertQuery = "INSERT INTO MEMOS VALUES('" + datum.date + "','" + datum.tripDirection + "','" + datum.hodogaya + "','" + datum.AC + "','" + datum.defroster + "','" 
                    + datum.timer + "'," + "NULL" + ",'" + datum.startGids + "','" + datum.endGids + "','" + datum.averageElectricityExpense + "','" 
                    + datum.electricityExpenseReset + "','" + datum.remarks + "','" + datum.serialNumber + "')";
            }

            return insertQuery;
        }

        private void MemosInserter_DragDrop(object sender, DragEventArgs e)
        {
            // ファイルが渡されていなければ, 何もしない
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;

            // 渡されたファイルに対して処理を行う
            foreach (var filePath in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                errorCodeLabel.Text = "Click Start inserting";
                fileNameLabel.Text = filePath;
                this.filePath = filePath;
            }
        }

        private void MemosInserter_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void MemosInserter_Load(object sender, EventArgs e)
        {

        }
    }
}
