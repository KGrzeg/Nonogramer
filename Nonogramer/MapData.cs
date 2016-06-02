using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Nonogramer {
	public class MapData {
		public string Name { get; set; } = "Default";
		public string Author { get; set; } = "Grzesiu";
		public int Width { get; set; }
		public int Height { get; set; }
		public int[][] Rows { get; set; }
		public int[][] Cols { get; set; }

		public string strSize {
			get { return Width.ToString() + "x" + Height.ToString(); }
		}

		public MapData() { }

		public MapData( int[][] rows, int[][] cols, string name, string author ) {
			Width = cols.GetLength( 0 );
			Height = rows.GetLength( 0 );
			Rows = rows;
			Cols = cols;
			Name = name;
			Author = author;
		}

		public bool SaveToFile( string path ) {
			try {
				XmlSerializer writer = new XmlSerializer(typeof(MapData));

				using( FileStream file = File.Create( path + "//" + Name + ".xml" ) ) {
					writer.Serialize( file, this );
					file.Close();
				}
			} catch( Exception ) {
				return false;
			}
			return true;
		}
		public MapData Clone() {
			return new MapData( Rows, Cols, Name, Author );
		}
	}
}
