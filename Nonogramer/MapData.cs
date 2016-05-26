using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nonogramer {
	public class MapData {
		public int Width { get; set; }
		public int Height { get; set; }
		public int[][] Rows { get; set; }
		public int[][] Cols { get; set; }

		public MapData() { }
		public MapData( int width, int height, int[][] rows, int[][] cols ) {
			Width = width;
			Height = height;
			Rows = rows;
			Cols = cols;
		}
	}
}
