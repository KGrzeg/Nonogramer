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
		private List<string> solved;

		public MapChooseWindow( List<MapData> maps, List<string> solved )
		{
			InitializeComponent();
			this.maps = maps;
			this.solved = solved;
			ChoosedMap = null;
		}
		private void FillListBox()
		{
			for( int i = 0; i < maps.Count; i++ )
			{
				string difficulty = "";
				switch( maps[i].Difficulty )
				{
				case Difficulty.Tutorial: difficulty = "Tutorial"; break;
				case Difficulty.Easy: difficulty = "Easy"; break;
				case Difficulty.Normal: difficulty = "Normal"; break;
				case Difficulty.Hard: difficulty = "Hard"; break;
				case Difficulty.VHard: difficulty = "Very Hard"; break;
				}
				if( solved.Contains( maps[i].Name ) )
					lbMaps.Items.Add( string.Format( "#{0} [{2}] {1} ", ( i + 1 ).ToString(), maps[i].Name, difficulty ) );
				else
					lbMaps.Items.Add( string.Format( "#{0} [{1}] ??? ", ( i + 1 ).ToString(), difficulty ) );
			}
		}
		private void Window_Loaded( object sender, RoutedEventArgs e )
		{
			FillListBox();
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
		

		public void Dispose()
		{

		}

		private void btnClose_Reset( object sender, RoutedEventArgs e )
		{
			solved.Clear();
			lbMaps.Items.Clear();
			FillListBox();
		}
	}
}
