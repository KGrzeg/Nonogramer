using System;
using System.Collections.Generic;
using System.ComponentModel;
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

	public partial class MainWindow : Window {
		public int MarginX { get; set; }
		public int MarginY { get; set; }
		public int CellSize { get; set; }
		public Game Game { get; set; }

		public MainWindow() {
			InitializeComponent();
			this.DataContext = this;

			this.Game = new Game( this );
		}

		private void window_loaded( object sender, RoutedEventArgs e ) {
			Game.InitializeScreen();

		}

		private void windows_sizeChanged( object sender, SizeChangedEventArgs e ) {
			Game.ResizeScreen();
			Game.Draw();
		}

		private void mainCanv_MouseDown( object sender, MouseButtonEventArgs e ) {
			Game.MouseDown( (Canvas)sender, e );
		}

		private void Button_Click( object sender, RoutedEventArgs e ) {
			Game.ClearScreen();
		}

		private void Button_Click_1( object sender, RoutedEventArgs e ) {
			using( var dialog = new MapChooseWindow( Game.Maps ) ) {
				dialog.ShowDialog();
				if( dialog.ChoosedMap != null )
					Game.LoadMapData( dialog.ChoosedMap );
			}
		}
	}
}
