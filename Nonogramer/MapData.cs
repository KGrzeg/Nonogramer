using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Media;

namespace Nonogramer
{
	public enum Difficulty { Tutorial, Easy, Normal, Hard, VHard};
	public class MapData
	{
		public string Name { get; set; } = "Default";
		public string Author { get; set; } = "Grzesiu";
		public Difficulty Difficulty { get; set; }
		public int Width { get; set; }
		public int Height { get; set; }
		public int[][] Rows { get; set; }
		public int[][] Cols { get; set; }
		public Brush Color {
			get {
				if( color != null )
					return color;
				return Brushes.Black;
			}
			set { color = value; }
		}
			
		private Brush color;

		public string strSize {
			get { return Width.ToString() + "x" + Height.ToString(); }
		}

		public MapData() { }

		public MapData( int[][] rows, int[][] cols, string name, string author, Brush color, Difficulty difficulty )
		{
			Width = cols.GetLength( 0 );
			Height = rows.GetLength( 0 );
			Rows = rows;
			Cols = cols;
			Name = name;
			Author = author;
			Color = color;
			Difficulty = difficulty;
		}
		
		public MapData Clone()
		{
			return new MapData( Rows, Cols, Name, Author, Color, Difficulty );
		}
	}
}
