using System.Data;
using System.Data.OleDb;

namespace Weather.Database
{
    /// <summary>
    /// データベースアクセスクラス
    /// </summary>
    internal class DatabaseAccess
    {
        /// <summary>データベース接続用オブジェクト</summary>
        private OleDbConnection connection = new OleDbConnection();
        /// <summary>テーブル操作実行用オブジェクト</summary>
        private OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
        /// <summary>テーブル操作コマンド</summary>
        private OleDbCommand command = new OleDbCommand();
        /// <summary>データテーブル</summary>
        private DataTable dataTable = new DataTable();

        /// <summary>
        /// 天気コードから、天気名称を取得する。
        /// </summary>
        /// <param name="code">天気コード</param>
        /// <returns>天気名称</returns>
        public string GetValue(string code)
        {
            string? value = string.Empty;
            try
            {
                connection.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ../../../Database/MainDB.accdb";
                connection.Open();
                string sql = "SELECT EXPLANATION, ICON_FILE1, ICON_FILE2 FROM M_WEATHER_DATA WHERE CODE = @CODE";
                command.CommandText = sql;
                command.Connection = connection;

                // SQLインジェクション対策
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@CODE", code);

                dataAdapter.SelectCommand = command;

                // 実行
                dataAdapter.Fill(dataTable);

                DataRow dr = dataTable.Rows[0];
                value = (string)dr.ItemArray[0] + "," + (string)dr.ItemArray[1] + "," + (string)dr.ItemArray[2];

            } catch (Exception ex) {
                value = ex.Message.ToString();
            } finally {
                connection.Close();
            }
            return value;
        }
    }
}
