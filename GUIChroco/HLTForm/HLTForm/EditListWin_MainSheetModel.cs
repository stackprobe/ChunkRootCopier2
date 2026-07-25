using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HLTStudio.Commons;

namespace HLTStudio
{
	public class EditListWin_MainSheetModel
	{
		private DataGridView Sheet;

		public EditListWin_MainSheetModel(DataGridView sheet, ContextMenuStrip contextMenu)
		{
			sheet.ContextMenuStrip = contextMenu;

			sheet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
			sheet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellContentClick);
			sheet.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellDoubleClick);
			sheet.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CellMouseDown);
			sheet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);

			sheet.AllowUserToAddRows = false;
			sheet.AllowUserToDeleteRows = false;
			sheet.AllowUserToResizeColumns = false;
			sheet.AllowUserToResizeRows = false;
			sheet.DefaultCellStyle.Font = new Font("メイリオ", 16f, FontStyle.Regular);
			sheet.DefaultCellStyle.SelectionForeColor = Color.Black;
			sheet.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 230, 255);
			sheet.MultiSelect = true;
			sheet.ReadOnly = true;
			sheet.RowHeadersVisible = false;
			sheet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			P_SetDoubleBufferedOn(sheet);

			sheet.RowCount = 0;
			sheet.ColumnCount = 0;

			sheet.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			{
				DataGridViewCheckBoxColumn column = new DataGridViewCheckBoxColumn(); // チェックボックス！

				column.HeaderText = "対象";
				column.Width = 70;
				//column.MinimumWidth = column.Width;
				column.DefaultCellStyle.Font = new Font("メイリオ", 10f, FontStyle.Regular);
				column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
				column.SortMode = DataGridViewColumnSortMode.Programmatic;
				column.Resizable = DataGridViewTriState.True;

				sheet.Columns.Add(column);
			}

			{
				DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();

				column.HeaderText = "パス";
				column.Width = 330;
				//column.MinimumWidth = column.Width;
				column.DefaultCellStyle.Font = new Font("メイリオ", 10f, FontStyle.Regular);
				column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
				column.SortMode = DataGridViewColumnSortMode.Programmatic;
				column.Resizable = DataGridViewTriState.True;

				sheet.Columns.Add(column);
			}

			this.Sheet = sheet;
		}

		private static void P_SetDoubleBufferedOn(DataGridView sheet)
		{
			typeof(DataGridView).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(sheet, true, null);
		}

		// 列インデックス
		//
		private const int COLIDX_対象 = 0;
		private const int COLIDX_パス = 1;

		// 行モデル
		//
		public class Row_t
		{
			public bool 対象;
			public string パス;
		}

		private void CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowidx = e.RowIndex;
			int colidx = e.ColumnIndex;

			if (
				rowidx == -1 ||
				colidx < 0 || this.Sheet.ColumnCount <= colidx
				)
			{
				this.Sort(colidx);
				return;
			}

			if (
				rowidx < 0 || this.Sheet.RowCount <= rowidx ||
				colidx < 0 || this.Sheet.ColumnCount <= colidx
				)
				return;

			if (colidx == COLIDX_対象)
			{
				bool value = (bool)this.Sheet.Rows[rowidx].Cells[colidx].Value;

				value ^= true;

				this.Sheet.Rows[rowidx].Cells[colidx].Value = value;
			}
		}

		private void CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			// コンテンツ部分(テキストなら文字の部分)をクリックしないと発火しない。
		}

		private void CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowidx = e.RowIndex;
			int colidx = e.ColumnIndex;

			if (
				rowidx < 0 || this.Sheet.RowCount <= rowidx ||
				colidx < 0 || this.Sheet.ColumnCount <= colidx
				)
				return;

			/*
			if (colidx != COLIDX_対象)
			{
				// none
			}
			*/
		}

		private void CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			int rowidx = e.RowIndex;
			int colidx = e.ColumnIndex;

			if (
				rowidx < 0 || this.Sheet.RowCount <= rowidx ||
				colidx < 0 || this.Sheet.ColumnCount <= colidx
				)
				return;

			if (e.Button == MouseButtons.Right)
			{
				this.Sheet.Rows[rowidx].Selected = true; // 右クリックメニューのために、右クリックしたときも行選択させる。
			}
		}

		private void MouseDown(object sender, MouseEventArgs e)
		{
			var hit = this.Sheet.HitTest(e.X, e.Y);

			if (hit.Type == DataGridViewHitTestType.None) // ? 余白部分をクリックした。
			{
				this.Sheet.ClearSelection();
			}
		}

		private void InsertRow(int rowidx)
		{
			DataGridViewRow row = new DataGridViewRow();

			row.Height = 30;

			this.Sheet.Rows.Insert(rowidx, row);

			this.SetRow(rowidx, new Row_t()
			{
				対象 = false,
				パス = "",
			});
		}

		private void SetRow(int rowidx, Row_t row)
		{
			this.Sheet.Rows[rowidx].Cells[COLIDX_対象].Value = row.対象;
			this.Sheet.Rows[rowidx].Cells[COLIDX_パス].Value = row.パス;
		}

		private Row_t GetRow(int rowidx)
		{
			return new Row_t()
			{
				対象 = (bool)this.Sheet.Rows[rowidx].Cells[COLIDX_対象].Value,
				パス = (string)this.Sheet.Rows[rowidx].Cells[COLIDX_パス].Value,
			};
		}

		private void Sort(int targetColumnIndex)
		{
			List<Row_t> rows = new List<Row_t>();

			for (int rowidx = 0; rowidx < this.Sheet.RowCount; rowidx++)
				rows.Add(this.GetRow(rowidx));

			Comparison<Row_t> comp;

			switch (targetColumnIndex)
			{
				case COLIDX_対象:
					comp = (a, b) => SCommon.Comp(a, b, v => v.対象 ? 1 : 0, SCommon.Comp);
					break;

				case COLIDX_パス:
					comp = (a, b) => SCommon.Comp(a.パス, b.パス);
					break;

				default:
					throw null; // never
			}
			SortOrder order = this.Sheet.Columns[targetColumnIndex].HeaderCell.SortGlyphDirection;

			if (order == SortOrder.Ascending)
			{
				order = SortOrder.Descending;

				var comp2 = comp;
				comp = (a, b) => comp2(a, b) * -1;
			}
			else
			{
				order = SortOrder.Ascending;
			}
			SCommon.AnzenSort(rows, comp);

			for (int rowidx = 0; rowidx < this.Sheet.RowCount; rowidx++)
				this.SetRow(rowidx, rows[rowidx]);

			for (int colidx = 0; colidx < this.Sheet.ColumnCount; colidx++)
				this.Sheet.Columns[colidx].HeaderCell.SortGlyphDirection = SortOrder.None;

			this.Sheet.Columns[targetColumnIndex].HeaderCell.SortGlyphDirection = order;
			this.Sheet.ClearSelection();
		}

		private IEnumerable<int> GetSelectedRowIndexes()
		{
			for (int rowidx = 0; rowidx < this.Sheet.RowCount; rowidx++)
				if (this.Sheet.Rows[rowidx].Selected)
					yield return rowidx;
		}

		private void AutoResizeColumn(int colidx)
		{
			this.Sheet.Columns[colidx].Width = 1000; // rough width
			this.Sheet.AutoResizeColumn(colidx, DataGridViewAutoSizeColumnMode.AllCells);
		}

		// ====
		// ここまで定番機能
		// ====

		// memo: 選択状態の設定はデフォルトの動作に任せず明示的に設定するべき！

		public void SetRelPaths(string[] relPaths, string[] initialCheckedRelPaths)
		{
			var initialCheckedRelPaths_SA = new SCommon.SortedArray<string>(initialCheckedRelPaths, SCommon.CompIgnoreCase);

			int rowidx = 0;
			foreach (string relPath in relPaths)
			{
				this.InsertRow(rowidx);
				this.SetRow(rowidx, new Row_t()
				{
					対象 = initialCheckedRelPaths_SA.GetIndex(relPath) != -1,
					パス = relPath,
				});

				rowidx++;
			}

			this.AutoResizeColumn(COLIDX_パス);

			this.Sheet.ClearSelection();
		}

		public string[] GetCheckedRelPaths()
		{
			List<string> checkedRelPaths = new List<string>();

			for (int rowidx = 0; rowidx < this.Sheet.RowCount; rowidx++)
			{
				Row_t row = this.GetRow(rowidx);

				if (row.対象)
					checkedRelPaths.Add(row.パス);
			}
			return checkedRelPaths.ToArray();
		}

		public void 選択されている行アクション(Action<Row_t> reaction)
		{
			for (int rowidx = 0; rowidx < this.Sheet.RowCount; rowidx++)
			{
				if (this.Sheet.Rows[rowidx].Selected)
				{
					Row_t row = this.GetRow(rowidx);
					reaction(row);
					this.SetRow(rowidx, row);
				}
			}
		}

		public void Search(string searchWord, SearchCondDlg.MatchType_e matchType)
		{
			for (int rowidx = 0; rowidx < this.Sheet.RowCount; rowidx++)
			{
				Row_t row = this.GetRow(rowidx);
				bool doSelectFlag;

				if (matchType == SearchCondDlg.MatchType_e.完全一致)
					doSelectFlag = row.パス.EqualsIgnoreCase(searchWord);
				else if (matchType == SearchCondDlg.MatchType_e.部分一致)
					doSelectFlag = row.パス.ContainsIgnoreCase(searchWord);
				else if (matchType == SearchCondDlg.MatchType_e.後方一致)
					doSelectFlag = row.パス.EndsWithIgnoreCase(searchWord);
				else
					throw null; // never

				this.Sheet.Rows[rowidx].Selected = doSelectFlag;
			}
		}

		public int Get対象件数()
		{
			int count = 0;

			for (int rowidx = 0; rowidx < this.Sheet.RowCount; rowidx++)
			{
				Row_t row = this.GetRow(rowidx);

				if (row.対象)
					count++;
			}
			return count;
		}
	}
}
