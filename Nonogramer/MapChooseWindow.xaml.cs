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
			for( int i = 1; i <= maps.Count; i++ )
			{
				lbMaps.Items.Add( "Image: #" + i.ToString() );
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
				ChoosedMap = maps[lbMaps.SelectedIndex].Clone();
				this.Close();
			}
			else
			{
				MessageBox.Show( "Please choose a map!", "Incorrect choose." );
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
