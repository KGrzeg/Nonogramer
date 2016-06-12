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
	public class PaintRenderer : Renderer
	{
		public PaintRenderer( Canvas canvas ) : base( canvas ) { }

		public override void Draw()
		{
			base.Draw();

			drawGrid();
			drawMapDefinition();
		}
		public override void Draw( Field[,] fields )
		{
			base.Draw( fields );

			drawMapFields( fields );

		}

		private void drawGrid()
		{
			for( int y = MarginY; y < MarginY + SizeY + 1; ++y )
			{
				var line = new Line();
				line.X1 = 0;
				line.Y1 = CellSize * y;
				line.X2 = ( MarginX + SizeX ) * CellSize;
				line.Y2 = CellSize * y;
				line.StrokeThickness = 1;
				line.Stroke = Brushes.Gray;
				if( y > MarginY && ( y - MarginY ) % 5 == 0 )
					line.Stroke = Brushes.Black;

				canvas.Children.Add( line );
			}
			for( int x = MarginX; x < MarginX + SizeX + 1; ++x )
			{
				var line = new Line();
				line.X1 = CellSize * x;
				line.Y1 = 0;
				line.X2 = CellSize * x;
				line.Y2 = ( MarginY + SizeY ) * CellSize;
				line.StrokeThickness = 1;
				line.Stroke = Brushes.Gray;
				if( x > MarginX && ( x - MarginX ) % 5 == 0 )
					line.Stroke = Brushes.Black;

				canvas.Children.Add( line );
			}

		}
		private void drawMapFields( Field[,] fields )
		{
			for( int i = 0; i < fields.GetLength( 0 ); ++i )
			{
				for( int j = 0; j < fields.GetLength( 1 ); ++j )
				{
					Field field = fields[i, j];

					if( field == Field.Empty )
						continue;

					int[] pos = CellPos(i, j);

					Rectangle drawRect = new Rectangle();
					switch( field )
					{
					case Field.Filled:
						drawRect = Rect( pos[0], pos[1], 0.8, Brown );
						break;
					case Field.Marked:
						drawRect = Rect( pos[0], pos[1], 0.6, Brushes.SlateGray );
						break;
					}

					canvas.Children.Add( drawRect );
				}
			}
		}
		private void drawMapDefinition()
		{
			for( int j = 0; j < mapData.Rows.Length; ++j )
			{
				for( int i = 0; i < mapData.Rows[j].Length; ++i )
				{
					int x = (mapData.Rows[j].Length - i) * -1;
					var pos = CellPos(x, j);
					PrintText( pos[0], pos[1], mapData.Rows[j][i].ToString(), canvas );
				}
			}
			for( int j = 0; j < mapData.Cols.Length; ++j )
			{
				for( int i = 0; i < mapData.Cols[j].Length; ++i )
				{
					int y = (mapData.Cols[j].Length - i) * -1;
					var pos = CellPos(j, y);
					PrintText( pos[0], pos[1], mapData.Cols[j][i].ToString(), canvas );
				}
			}
		}
	}
}
