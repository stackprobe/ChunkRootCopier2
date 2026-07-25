using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HLTStudio.CustomControls
{
	public class NoDoubleClickTreeView : TreeView
	{
		protected override void WndProc(ref Message m)
		{
			const int WM_LBUTTONDBLCLK = 0x0203;
			const int WM_RBUTTONDBLCLK = 0x0206;
			const int WM_MBUTTONDBLCLK = 0x0209;

			// ? ダブルクリック -> 無視
			if (
				m.Msg == WM_LBUTTONDBLCLK ||
				m.Msg == WM_RBUTTONDBLCLK ||
				m.Msg == WM_MBUTTONDBLCLK
				)
				return;

			base.WndProc(ref m);
		}
	}
}
