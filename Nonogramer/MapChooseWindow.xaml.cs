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
using System.Windows.Shapes;

namespace Nonogramer
{

	public partial class MapChooseWindow : Window, IDisposable
	{

		public MapData ChoosedMap { get; set; }
		private List<MapData> maps;

		public MapChooseWindow( List<MapData> maps )
		{
			InitializeComponent();
			this.maps = maps;
			ChoosedMap = null;
		}

		private void Window_Loaded( object sender, RoutedEventArgs e )
		{
			foreach( MapData map in maps )
			{
				lbMaps.Items.Add( map.Name );
			}
		}

		private void btnClose_Click( object sender, RoutedEventArgs e )
		{
			this.Close();
		}

		private void btnLoad_Click( object sender, RoutedEventArgs e )
		{
			if( lbMaps.SelectedItem != null )
			{
				ChoosedMap = maps.First( m => m.Name == (string) lbMaps.SelectedItem ).Clone();
				this.Close();
			}
			else
			{
				MessageBox.Show( "Musisz wybrać obraz do załadowania!", "nie wybrano mapy" );
			}
		}

		private void btnLoadFromFile_Click( object sender, RoutedEventArgs e )
		{
			throw new NotImplementedException();
		}

		public void Dispose()
		{

		}
	}
}
