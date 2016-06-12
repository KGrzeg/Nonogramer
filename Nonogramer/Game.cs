using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Nonogramer
{
	public class Game : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		public Map Map { get; private set; }
		public Renderer Renderer { get; private set; }
		public Controler Controler { get; private set; }
		public List<MapData> Maps { get; set; }
		public List<string> Solved { get; set; }

		private bool mapSolved;
		private Canvas canvas;
		private MainWindow root;


		public Game( MainWindow root )
		{
			this.root = root;
			canvas = root.mainCanv;

			Maps = new List<MapData>();
			HardCodedStorage.LoadMapsTo( Maps );

			Solved = new List<string>();

			Map = new Map();
			Map.Load( Maps[0] );

			Renderer = new PaintRenderer( canvas );

			Controler = new Controler( this );
			Controler.Move += new NotificationEventHandler( onMove );
		}

		public void InitializeScreen()
		{
			Renderer.LoadMapData( Map.Data );
			Draw();
		}

		private void onMove( object sender, EventArgs e )
		{
			if( Map.CheckAll() )
				Win();
		}
		private void OnPropertyChanged( string propertyName )
		{
			if( PropertyChanged != null )
				PropertyChanged( this, new PropertyChangedEventArgs( propertyName ) );
		}
		private void Win()
		{
			mapSolved = true;
			if( !Solved.Contains( Map.Data.Name ) )
				Solved.Add( Map.Data.Name );
			SetRenderer( new ViewRenderer( canvas ) );

			if( Map.Data.Name == "Jarofir" )
			{
				var special = new Special();
				special.ShowDialog();
			}


		}

		public void Draw()
		{
			Renderer.Draw( Map.Fields );
		}
		public void ResizeScreen()
		{
			Renderer.Resize();
		}
		public void MouseDown( Canvas sender, MouseButtonEventArgs e )
		{
			if( mapSolved )
				return;

			Canvas canv =  sender;
			Controler.Click( canv, e );
		}
		public void LoadMapData( MapData map )
		{
			Map.Load( map );
			mapSolved = false;
			Renderer = new PaintRenderer( canvas );
			Renderer.LoadMapData( map );
			onMove( this, EventArgs.Empty );
			OnPropertyChanged( "Map" );
		}
		public void ClearScreen()
		{
			Map.Clear();

			if( mapSolved )
			{
				SetRenderer( new PaintRenderer( canvas ) );
				mapSolved = false;
			}
			Draw();

			onMove( this, EventArgs.Empty );
		}
		private void SetRenderer( Renderer rend )
		{
			Renderer = rend;
			InitializeScreen();
		}
	}
}