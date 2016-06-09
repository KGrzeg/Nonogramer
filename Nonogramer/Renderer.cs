using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows;
using System.Windows.Media;

namespace Nonogramer
{
	public class Renderer
	{
		public int MarginX { get; set; }
		public int MarginY { get; set; }
		public int SizeX { get; set; }
		public int SizeY { get; set; }

		public int CellSize { get; set; }

		protected MapData mapData;
		protected Canvas canvas;

		public Renderer( Canvas canvas )
		{
			this.canvas = canvas;
		}
		public void LoadMapData( MapData mapData )
		{
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

			Resize();
			Draw(); //draw empty map
		}
		public virtual void Resize()
		{
			if( mapData == null )
				return;

			int viewWidth = (int) canvas.ActualWidth;
			int viewHeight = (int) canvas.ActualHeight;

			int cellsX = MarginX + SizeX;
			int cellsY = MarginY + SizeY;

			int cellW = viewWidth / cellsX;
			int cellH = viewHeight / cellsY;

			CellSize = Math.Min( cellW, cellH );
		}
		public void Clear()
		{
			canvas.Children.Clear();
		}

		public virtual void Draw()
		{
			Clear();
		}
		public virtual void Draw( Field[,] fields )
		{
			if( mapData == null )
				return;
			Draw();
		}

		private void drawMapFieldsAfterWon( Field[,] fields )
		{
			for( int i = 0; i < fields.GetLength( 0 ); ++i )
			{
				for( int j = 0; j < fields.GetLength( 1 ); ++j )
				{
					Field field = fields[i,j];

					if( field == Field.Empty || field == Field.Marked )
						continue;

					int[] pos = CellPos(i,j);

					if( field == Field.Filled )
					{
						Rectangle drawRect = Rect( pos[0], pos[1], 1, Brushes.Black );
						canvas.Children.Add( drawRect );
					}
				}
			}
		}

		protected Rectangle Rect( int x, int y, double fill, Brush brush )
		{
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

		protected void PrintText( double x, double y, string text, Canvas canv )
		{
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

		public int[] CellPos( int cellX, int cellY )
		{
			int x = (MarginX + cellX) * this.CellSize;
			int y = (MarginY + cellY) * this.CellSize;
			return new int[] { x, y };
		}
		public int[] CellAt( double x, double y )
		{

			int cX = (int)Math.Floor((decimal)(x / CellSize)) - MarginX;
			int cY = (int)Math.Floor((decimal)(y / CellSize)) - MarginY;

			return new int[] { cX, cY };
		}

	}
}
