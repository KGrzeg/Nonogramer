using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Nonogramer {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {

		public int MarginX { get; set; }
		public int MarginY { get; set; }
		public int CellSize { get; set; }
		public Game Game { get; set; }

		public MainWindow() {
			InitializeComponent();

			this.Game = new Game(mainCanv);
		}

		private void redraw() {
			this.mainCanv.Children.Clear();

			var mapFields = Map.Fields;

			for( int i = 0; i < mapFields.GetLength( 0 ); ++i ) {
				for( int j = 0; j < mapFields.GetLength( 1 ); ++j ) {
					Field field = mapFields[i,j];

					if( field == Field.Empty )
						continue;

					Rectangle rect = new Rectangle();
					rect.Width = this.CellSize;
					rect.Height = this.CellSize;
					rect.StrokeThickness = 1;
					rect.Stroke = Brushes.Black;
					switch( field ) {
					case Field.Filled: rect.Fill = Brushes.Black; break;
					case Field.Marked: rect.Fill = Brushes.Gray; break;
					}

					int[] position = cellPos(i,j);
					Canvas.SetLeft( rect, position[0] );
					Canvas.SetTop( rect, position[1] );
					this.mainCanv.Children.Add( rect );
				}
			}
		}
		public void Resize() {
			int w = (int)mainCanv.ActualWidth;
			int h = (int)mainCanv.ActualHeight;
			this.MarginX = (int) ( w * 0.1 );
			this.MarginY = (int) ( h * 0.1 );

			if( Map.SizeX > 0 && Map.SizeY > 0 ) {

				int cellX =  (w - 2 * this.MarginX ) / this.Map.SizeX;
				int cellY =  (h - 2 * this.MarginY ) / this.Map.SizeY;

				this.CellSize = Math.Min( cellX, cellY );
			} else {
				this.CellSize = 0;
			}

		}

		private int[] cellPos( int posX, int posY ) {
			int x = this.MarginX + posX * this.CellSize;
			int y = this.MarginY + posY * this.CellSize;
			return new int[] { x, y };
		}

		private void mainCanv_Initialized( object sender, EventArgs e ) {
			this.Resize();
			this.redraw();
		}

		private void window_loaded( object sender, RoutedEventArgs e ) {
			Map.SetSize( 10 );
			Map.Trought();
			this.Resize();
			this.redraw();
		}

		private void windows_sizeChanged( object sender, SizeChangedEventArgs e ) {
			this.Resize();
			this.redraw();
		}
	}
}
