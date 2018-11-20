using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Raw
{
	public partial class Form1 : Form
	{
		private string _constr = "Server=192.168.111.100;Database=employees;Uid=winUser;Pwd=1234;charset=utf8";

		public Form1()
		{
			InitializeComponent();
		}

		private void btnSelect_Click(object sender, EventArgs e)
		{
			using (MySqlConnection conn = new MySqlConnection(_constr))
			{
				// 데이터 로드
				MySqlCommand cmd = conn.CreateCommand();
				cmd.CommandText = "select emp_no as '사원', concat(first_name, last_name) as '사용자이름', gender as '성별' from employees limit 1000 ";
				MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
				DataSet ds = new DataSet("employees");

				if (adapter.Fill(ds, "employees") <= 0)
				{
					MessageBox.Show("데이터가 없습니다.", "데이터 조회 오류");
					return;
				}

				// 화면 출력
				lvResult.BeginUpdate();

				foreach (DataColumn column in ds.Tables["employees"].Columns)
					lvResult.Columns.Add(column.ColumnName);

				foreach (DataRow row in ds.Tables["employees"].Rows)
					lvResult.Items.Add(new ListViewItem(Array.ConvertAll<object, string>(row.ItemArray, x=>x.ToString())));

				lvResult.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
				lvResult.EndUpdate();
			}
		}
	}
}
