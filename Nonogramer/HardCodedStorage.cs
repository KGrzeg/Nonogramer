using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nonogramer {
	public static class HardCodedStorage {
		public static void LoadMapsTo( List<MapData> Maps ) {
			Maps.Add( new MapData {
				Name = "Default 1 [Czacha]",
				Author = "Grzesiu",
				Rows = new int[][]{
					new int[] { 3 },
					new int[] { 7 },
					new int[] { 2, 1, 2 },
					new int[] { 1, 1, 1, 1, 1 },
					new int[] { 9 },
					new int[] { 3, 1, 3 },
					new int[] { 1, 3, 1 },
					new int[] { 1, 1 },
					new int[] { 1, 5 },
					new int[] { 2 }
				},
				Cols = new int[][]{
					new int[] { 2 },
					new int[] { 4, 1 },
					new int[] { 2, 4 },
					new int[] { 1, 3, 1 },
					new int[] { 2, 1, 1, 1 },
					new int[] { 7, 1  },
					new int[] { 2, 1, 1, 1 },
					new int[] { 1, 3, 1 },
					new int[] { 2, 4 },
					new int[] { 4 }
				}
			}.Clone() );
			Maps.Add( new MapData {
				Name = "Default 2 [Czołgieł]",
				Author = "Grzesiu",
				Rows = new int[][]{
					new int[] { 1 },
					new int[] { 8 },
					new int[] { 5 },
					new int[] { 10 },
					new int[] { 1, 2, 2, 1 },
					new int[] { 1, 1, 1 }
				},
				Cols = new int[][]{
					new int[] { 1, 1 },
					new int[] { 1, 2 },
					new int[] { 1, 1, 1 },
					new int[] { 1, 2 },
					new int[] { 4 },
					new int[] { 3, 1 },
					new int[] { 5 },
					new int[] { 4 },
					new int[] { 2,1 },
					new int[] { 2 }
				}
			}.Clone() );
			Maps.Add( new MapData {
				Name = "Default 3 [Kaczeł]",
				Author = "Grzesiu",
				Rows = new int[][]{
				new int[] { 4 },
				new int[] { 1,2 },
				new int[] { 5 },
				new int[] { 3,1 },
				new int[] { 3,2 },
				new int[] { 2,5 },
				new int[] { 6,2 },
				new int[] { 3,3 },
				new int[] { 4,3 },
				new int[] { 7 }
			},
				Cols = new int[][]{
					new int[] { 1,3 },
					new int[] { 3,6 },
					new int[] { 1,8 },
					new int[] { 5,1,2 },
					new int[] { 4,1,1 },
					new int[] { 2,1 },
					new int[] { 1,2 },
					new int[] { 1,3 },
					new int[] { 5 },
					new int[] { 5 }
				}
			}.Clone() );
			Maps.Add( new MapData {
				Name = "Default 4 [Piesełkę]",
				Author = "Dagmarcia",
				Rows = new int[][]{
					new int[] { 2,2 },
					new int[] { 2,2 },
					new int[] { 1,1,1,1 },
					new int[] { 1,1 },
					new int[] { 4 },
					new int[] { 1,1 },
					new int[] { 1,2,1 },
					new int[] { 1,1 },
					new int[] { 4 }
				},
				Cols = new int[][]{
					new int[] { 2 },
					new int[] { 2 },
					new int[] { 1,3 },
					new int[] { 3,1 },
					new int[] { 1,1,1 },
					new int[] { 1,1,1 },
					new int[] { 3,1 },
					new int[] { 1,3 },
					new int[] { 2 },
					new int[] { 2 }
				}
			}.Clone() );
			Maps.Add( new MapData {
				Name = "Default 5 [Drzewełkę]",
				Author = "Grzesiu",
				Rows = new int[][]{
					new int[] { 2 },
					new int[] { 4 },
					new int[] { 1,4,1 },
					new int[] { 10 },
					new int[] { 12 },
					new int[] { 12 },
					new int[] { 3,2,3 },
					new int[] { 2 },
					new int[] { 2 },
					new int[] { 5,5 },
					new int[] { 5,5 },
					new int[] { 4,1,5 },
					new int[] { 3,1,1,4 },
					new int[] { 2,2,1,4 },
					new int[] { 1,1,1,2,3 },
					new int[] { 1,1,2,1,3 }
				},
				Cols = new int[][]{
					new int[] { 2,7 },
					new int[] { 4,5 },
					new int[] { 5,4,2 },
					new int[] { 4,3,1 },
					new int[] { 5,2,4 },
					new int[] { 9,1,1 },
					new int[] { 9,3 },
					new int[] { 5,3,2 },
					new int[] { 4,5 },
					new int[] { 5,7 },
					new int[] { 4,7 },
					new int[] { 2,7 }
				}
			}.Clone() );
			Maps.Add( new MapData {
				Name = "Default 5 [Zegarełkę]",
				Author = "Grzesiu",
				Rows = new int[][]{
					new int[] { 3 },
					new int[] { 3,1,3 },
					new int[] { 1,1 },
					new int[] { 1,1,1,1,1 },
					new int[] { 1,1,1 },
					new int[] { 1,1,1 },
					new int[] { 1,1,1 },
					new int[] { 2,4,2 },
					new int[] { 1,1,1 },
					new int[] { 1,1 },
					new int[] { 1,1 },
					new int[] { 1,1,1,1 },
					new int[] { 1,1 },
					new int[] { 3,1,3 },
					new int[] { 3 }
				},
				Cols = new int[][]{
					new int[] { 3 },
					new int[] { 3,1,3 },
					new int[] { 1,1,1,1 },
					new int[] { 1,1 },
					new int[] { 1,1 },
					new int[] { 1,1,1 },
					new int[] { 1,1,1 },
					new int[] { 2,6,2 },
					new int[] { 1,1,1 },
					new int[] { 1,1,1 },
					new int[] { 1,1,1 },
					new int[] { 1,1,1,1 },
					new int[] { 1,1 },
					new int[] { 3,1,3 },
					new int[] { 3 }
				}
			}.Clone() );
		}
	}
}
