using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows;
using System.Windows.Media;

namespace Nonogramer {
	public class Rederer {
		public int MarginX { get; set; }
		public int MarginY { get; set; }
		public int SizeX { get; set; }
		public int SizeY { get; set; }

		public int CellSize { get; set; }

		public bool Solved { get; set; } = false;

		private MapData mapData;
		private Canvas canvas;

		public Rederer( Canvas canvas ) {
			this.canvas = canvas;
		}
		public void LoadMapData( MapData mapData ) {
			this.mapData = mapData;

			SizeX = mapData.Width;
			SizeY = mapData.Height;

			int maxY = 0;
			for( int x = 0; x < SizeX; ++x )
				if( mapData.Cols[x].Length > maxY )
					maxY = mapData.Cols[x].Length;
			int maxX = 0;
			for( int y = 0; y < SizeY; ++y )
				if( mapData.Rows[y].Length > maxX )
					maxX = mapData.Rows[y].Length;

			MarginX = maxX;
			MarginY = maxY;

			Solved = false;

			Resize();
			Draw(); //draw empty map
		}
		public void Resize() {
			if( mapData == null )
				return;

			int viewWidth = (int) canvas.ActualWidth;
			int viewHeight = (int) canvas.ActualHeight;

			int cellsX = MarginX + SizeX;
			int cellsY = MarginY + SizeY;

			//if( cellsX == 0 || cellsY == 0 )
			//	return;

			int cellW = viewWidth / cellsX;
			int cellH = viewHeight / cellsY;

			CellSize = Math.Min( cellW, cellH );
		}
		public void Clear() {
			canvas.Children.Clear();
		}

		public void Draw() {
			Clear();

			drawGrid();
			drawMapDefinition();

		}
		public void Draw( Field[,] fields ) {
			if( mapData == null )
				return;

			if( Solved ) {
				DrawAfterWon( fields );
				return;
			}

			Clear();

			drawGrid();
			drawMapDefinition();
			drawMapFields( fields );

		}
		public void DrawAfterWon( Field[,] fields ) {
			Clear();

			drawGrid();
			drawMapDefinition();
			drawMapFieldsAfterWon( fields );
		}

		private void drawMapFieldsAfterWon( Field[,] fields ) {
			for( int i = 0; i < fields.GetLength( 0 ); ++i ) {
				for( int j = 0; j < fields.GetLength( 1 ); ++j ) {
					Field field = fields[i,j];

					if( field == Field.Empty || field == Field.Marked )
						continue;

					int[] pos = CellPos(i,j);

					if( field == Field.Filled ) {
						Rectangle drawRect = Rect( pos[0], pos[1], 1, Brushes.Black );
						canvas.Children.Add( drawRect );
					}
				}
			}
		}

		private void drawGrid() {
			for( int y = MarginY; y < MarginY + SizeY + 1; ++y ) {
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
			for( int x = MarginX; x < MarginX + SizeX + 1; ++x ) {
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
		private void drawMapFields( Field[,] fields ) {
			for( int i = 0; i < fields.GetLength( 0 ); ++i ) {
				for( int j = 0; j < fields.GetLength( 1 ); ++j ) {
					Field field = fields[i,j];

					if( field == Field.Empty )
						continue;

					int[] pos = CellPos(i,j);

					Rectangle drawRect = new Rectangle();
					switch( field ) {
					case Field.Filled:
						drawRect = Rect( pos[0], pos[1], 0.8, Brushes.Black );
						break;
					case Field.Marked:
						drawRect = Rect( pos[0], pos[1], 0.6, Brushes.SlateGray );
						break;
					default:
						throw new Exception( "Broken map fields" );
					}

					canvas.Children.Add( drawRect );
				}
			}
		}
		private void drawMapDefinition() {
			//wiersze
			for( int j = 0; j < mapData.Rows.Length; ++j ) {
				for( int i = 0; i < mapData.Rows[j].Length; ++i ) {
					int x = (mapData.Rows[j].Length - i) * -1;
					var pos = CellPos(x,j);
					Print( pos[0], pos[1], mapData.Rows[j][i].ToString(), canvas );
				}
			}
			//kolumny
			for( int j = 0; j < mapData.Cols.Length; ++j ) {
				for( int i = 0; i < mapData.Cols[j].Length; ++i ) {
					int y = (mapData.Cols[j].Length - i) * -1;
					var pos = CellPos(j,y);
					Print( pos[0], pos[1], mapData.Cols[j][i].ToString(), canvas );
				}
			}
		}

		private Rectangle Rect( int x, int y, double fill, Brush brush ) {
			if( fill > 1 ) fill = 1;
			if( fill < 0 ) fill = 0;

			Rectangle rect = new Rectangle();

			rect.Width = CellSize * fill;
			rect.Height = CellSize * fill;

			rect.StrokeThickness = 0;
			rect.Fill = brush;

			Canvas.SetLeft( rect, x + CellSize * ( ( 1 - fill ) / 2 ) );
			Canvas.SetTop( rect, y + CellSize * ( ( 1 - fill ) / 2 ) );

			return rect;
		}

		private void Print( double x, double y, string text, Canvas canv ) {
			var label = new Label();

			label.Content = text;
			label.Foreground = Brushes.Brown;

			label.Width = label.Height = CellSize;
			label.HorizontalContentAlignment = HorizontalAlignment.Center;
			label.VerticalContentAlignment = VerticalAlignment.Center;
			label.FontSize = label.Height * .5;

			Canvas.SetLeft( label, x );
			Canvas.SetTop( label, y );

			canv.Children.Add( label );
		}

		public int[] CellPos( int cellX, int cellY ) {
			int x = (MarginX + cellX) * this.CellSize;
			int y = (MarginY + cellY) * this.CellSize;
			return new int[] { x, y };
		}
		public int[] CellAt( double x, double y ) {

			int cX = (int)Math.Floor((decimal)(x / CellSize)) - MarginX;
			int cY = (int)Math.Floor((decimal)(y / CellSize)) - MarginY;

			return new int[] { cX, cY };
		}

	}
}
