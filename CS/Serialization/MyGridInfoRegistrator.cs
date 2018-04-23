using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;

namespace Serialization
{
	public class MyGridInfoRegistrator : GridInfoRegistrator
	{
		public override BaseView CreateView(GridControl grid)
		{
			return new MyGridView(grid as GridControl);
		}

		public override string ViewName
		{
			get
			{
				return "MyGridView";
			}
		}
	}
}
