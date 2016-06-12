using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media;

namespace Nonogramer
{
	public class ViewRenderer : Renderer
	{
		/// <summary>
		/// Percent of view, which is used for margin
		/// </summary>
		protected const float marginPercent = 0.05f;
		protected int viewMarginX, viewMarginY;

		public ViewRenderer( Canvas canvas ) : base( canvas )
		{
			if( marginPercent > 0.5 )
				throw new InvalidProgramException( "Invalid marginPercent value (>0.5)" );
			viewMarginX = viewMarginY = 0;
		}

		public override void Resize()
		{
			if( mapData == null )
				return;

			int viewWidth = (int) canvas.ActualWidth;
			int viewHeight = (int) canvas.ActualHeight;

			viewMarginX = (int) ( viewWidth * marginPercent );
			viewMarginY = (int) ( viewHeight * marginPercent );

			int cellW = (viewWidth - viewMarginX * 2) / SizeX;
			int cellH = (viewHeight  - viewMarginY * 2)/ SizeY;

			CellSize = Math.Min( cellW, cellH );
		}

		public override void Draw( Field[,] fields )
		{
			base.Draw( fields );
			drawMapFields( fields );
			drawMapName();
		}

		private void drawMapFields( Field[,] fields )
		{
			for( int i = 0; i < fields.GetLength( 0 ); ++i )
			{
				for( int j = 0; j < fields.GetLength( 1 ); ++j )
				{
					Field field = fields[i,j];

					if( field == Field.Empty )
						continue;

					int[] pos = CellPos(i,j);

					Rectangle drawRect = new Rectangle();
					switch( field )
					{
					case Field.Filled:
						drawRect = Rect( pos[0], pos[1], 0.8, mapData.Color );
						break;
					}

					canvas.Children.Add( drawRect );
				}
			}
		}
		private void drawMapName()
		{
			Label text = Text(mapData.Name);

			SetUIElementPosition( text, 0, viewMarginY + SizeY * CellSize );

			text.Width = viewMarginX * 2 + SizeX * CellSize;
			text.FontSize = viewMarginY * 0.7;
			canvas.Children.Add( text );
		}
		protected new int[] CellPos( int cellX, int cellY )
		{
			int x = cellX * CellSize + viewMarginX;
			int y = cellY * CellSize + viewMarginY;
			return new int[] { x, y };
		}
	}
}
