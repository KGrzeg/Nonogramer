using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Nonogramer
{
	public static class HardCodedStorage
	{
		public static void LoadMapsTo( List<MapData> Maps )
		{
			Maps.Add( new MapData(
				new int[][]{
					new int[] { 1 },
					new int[] { 3 },
					new int[] { 5 },
					new int[] { 2,2 },
					new int[] { 2,2 }
				},
				new int[][]{
					new int[] { 3 },
					new int[] { 4 },
					new int[] { 3 },
					new int[] { 4 },
					new int[] { 3 }
				},
				"House",
				"Grzesiu",
				Brushes.Black,
				Difficulty.Tutorial
			) );
			Maps.Add( new MapData(
				new int[][]{
					new int[] { 5 },
					new int[] { 5 },
					new int[] { 5 },
					new int[] { 5 },
					new int[] { 3 },
					new int[] { 1 }
				},
				new int[][]{
					new int[] { 4 },
					new int[] { 5 },
					new int[] { 6 },
					new int[] { 5 },
					new int[] { 4 }
				},
				"Shield",
				"Grzesiu",
				Brushes.Gray,
				Difficulty.Tutorial
			) );
			Maps.Add( new MapData(
				new int[][]{
					new int[] { 2 },
					new int[] { 2 },
					new int[] { 6 },
					new int[] { 6 },
					new int[] { 2 },
					new int[] { 2 },
					new int[] { 2 },
					new int[] { 2 },
					new int[] { 2 }
				},
				new int[][]{
					new int[] { 2 },
					new int[] { 2 },
					new int[] { 9 },
					new int[] { 9 },
					new int[] { 2 },
					new int[] { 2 }
				},
				"Cross",
				"Grzesiu",
				Renderer.Brown,
				Difficulty.Tutorial
			) );
			Maps.Add( new MapData(
				new int[][]{
					new int[] { 1 },
					new int[] { 8 },
					new int[] { 5 },
					new int[] { 10 },
					new int[] { 1, 2, 2, 1 },
					new int[] { 1, 1, 1 }
				},
				new int[][]{
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
				},
				"Tank",
				"Grzesiu",
				Brushes.Green,
				Difficulty.Normal ) );
			Maps.Add( new MapData(
				new int[][]{
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
				new int[][]{
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
				},
				"Skull",
				"Grzesiu",
				Brushes.Gray,
				Difficulty.Normal
			) );
			Maps.Add( new MapData(
				new int[][]{
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
				new int[][]{
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
				},
				"Duck",
				"Grzesiu",
				Brushes.Yellow,
				Difficulty.Normal ) );
			Maps.Add( new MapData(
				new int[][]{
					new int[] { 1,1 },
					new int[] { 9 },
					new int[] { 13 },
					new int[] { 4,1,1,2 },
					new int[] { 2,1,1,3 },
					new int[] { 2,1,1,2 },
					new int[] { 4,1,1 },
					new int[] { 10 },
					new int[] { 10 },
					new int[] { 1,1,3 },
					new int[] { 2,1,1,2 },
					new int[] { 3,1,1,3 },
					new int[] { 13 },
					new int[] { 10 },
					new int[] { 1,1 }
				},
				new int[][]{
					new int[] { 4,2 },
					new int[] { 5,3 },
					new int[] { 2,2,3 },
					new int[] { 3,2,2 },
					new int[] { 2,2,2 },
					new int[] { 2,2,2 },
					new int[] { 15 },
					new int[] { 2,2,2 },
					new int[] { 2,2,2 },
					new int[] { 15 },
					new int[] { 2,2,2 },
					new int[] { 2,2,2 },
					new int[] { 1,2,2,2 },
					new int[] { 4,5 },
					new int[] { 2,3 }
				},
				"Dollar",
				"Rafafał",
				Brushes.ForestGreen,
				Difficulty.Normal ) );
			Maps.Add( new MapData(
				new int[][]{
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
				new int[][]{
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
				},
				"Roots",
				"Grzesiu",
				Brushes.ForestGreen,
				Difficulty.Normal ) );
			Maps.Add( new MapData(
				new int[][]{
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
				new int[][]{
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
				},
				"Dog",
				"Dagmarcia",
				Brushes.Brown,
				Difficulty.Hard ) );
			Maps.Add( new MapData(
				new int[][]{
					new int[] { 1,1 },
					new int[] { 2,2,1 },
					new int[] { 4,4,2 },
					new int[] { 11,4,1 },
					new int[] { 11,4,1 },
					new int[] { 4,4,4,2 },
					new int[] { 4,1,11 },
					new int[] { 3,3,11 },
					new int[] { 3,3,11 },
					new int[] { 4,2,2,2 },
					new int[] { 6,2,3},
					new int[] { 6,1,4},
					new int[] { 5,7},
					new int[] { 5,5},
					new int[] { 5,6},
					new int[] { 9},
					new int[] { 5,6},
					new int[] { 5,2,4},
					new int[] { 6,1,3,1},
					new int[] { 6,2,4},
					new int[] { 4,2,3,2},
					new int[] { 3,3,11},
					new int[] { 3,3,5,5},
					new int[] { 4,1,7,1,1},
					new int[] { 5,12}
				},
				new int[][]{
					new int[] { 9,9 },
					new int[] { 1,10,9},
					new int[] { 13,9},
					new int[] { 7,6,5,2},
					new int[] { 5,5,4,1},
					new int[] { 3,5,1,5},
					new int[] { 2,4,1,4},
					new int[] { 3,2,1,2},
					new int[] { 6,2,1,2,1},
					new int[] { 10,1,6},
					new int[] { 8,1,5},
					new int[] { 6,1,5},
					new int[] { 1,3,1,4},
					new int[] { 1,4,1,1,1,4},
					new int[] { 7,1,1,3,1,2},
					new int[] { 8,3,1,1,4},
					new int[] { 6,4,4,2,1},
					new int[] { 1,3,5,2,1,4},
					new int[] { 10,7,1},
					new int[] { 12,2,6}
				},
				"Swan",
				"Grzesiu",
				Brushes.Gray,
				Difficulty.Hard ) );
			Maps.Add( new MapData(
				new int[][]{
					new int[] { 1 },
					new int[] { 1 },
					new int[] { 1,2 },
					new int[] { 1,1 },
					new int[] { 1,7 },
					new int[] { 11,8 },
					new int[] { 10,7 },
					new int[] { 11,8 },
					new int[] { 1,7,3,2 },
					new int[] { 1,1,6,4,1,2 },
					new int[] { 3,3 },
					new int[] { 1,1 }
				},
				new int[][]{
					new int[] { 1,3 },
					new int[] { 3,1 },
					new int[] { 3,3 },
					new int[] { 3,1 },
					new int[] { 5 },
					new int[] { 7 },
					new int[] { 2,5 },
					new int[] { 1,5 },
					new int[] { 5 },
					new int[] { 5 },
					new int[] { 4 },
					new int[] { 1 },
					new int[] { 5 },
					new int[] { 6 },
					new int[] { 6 },
					new int[] { 5,1 },
					new int[] { 1,4,3 },
					new int[] { 1,4,1 },
					new int[] { 6 },
					new int[] { 2,3 }
				},
				"Jeep",
				"Grzesiu",
				Brushes.ForestGreen,
				Difficulty.Hard ) );
			Maps.Add( new MapData(
				new int[][]{
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
				new int[][]{
					new int[] { 3 },
					new int[] { 3,1,3 },
					new int[] { 1,1 },
					new int[] { 1,1,1,1 },
					new int[] { 1,1 },
					new int[] { 1,1,1 },
					new int[] { 1,1,1 },
					new int[] { 2,6,2 },
					new int[] { 1,1,1 },
					new int[] { 1,1 },
					new int[] { 1,1 },
					new int[] { 1,1,1,1 },
					new int[] { 1,1 },
					new int[] { 3,1,3 },
					new int[] { 3 }
				},
				"Clock",
				"Grzesiu",
				Brushes.Black,
				Difficulty.VHard ) );
			Maps.Add( new MapData(
				new int[][]{
					new int[] { 5 },
					new int[] { 9 },
					new int[] { 11 },
					new int[] { 6, 3 },
					new int[] { 3, 2 },
					new int[] { 2, 2 },
					new int[] { 2, 2 },
					new int[] { 2, 2 },
					new int[] { 2, 1 },
					new int[] { 4, 3, 2, 1 },
					new int[] { 5, 6 },
					new int[] { 4, 4, 1 },
					new int[] { 1, 1 },
					new int[] { 1, 2, 1 },
					new int[] { 1, 2 },
					new int[] { 1, 4, 1 },
					new int[] { 2, 1 },
					new int[] { 1, 1, 3 },
					new int[] { 1, 6 },
					new int[] { 1, 1, 2 },
					new int[] { 1, 1, 1, 2 },
					new int[] { 2, 1, 3 },
					new int[] { 6, 3, 5 },
					new int[] { 6, 7, 8 },
					new int[] { 8, 2, 11 },
					new int[] { 9, 13 },
					new int[] { 8, 13 },
					new int[] { 8, 14 },
					new int[] { 8, 14 },
					new int[] { 8, 14 },
					new int[] { 8, 15 },
					new int[] { 9, 16 },
					new int[] { 9, 6, 1, 7 },
					new int[] { 9, 5, 7 },
					new int[] { 9, 5, 7 },
					new int[] { 10, 17 },
					new int[] { 10, 18 },
					new int[] { 10, 18 },
					new int[] { 10, 19 },
					new int[] { 10, 19 }
				},
				new int[][]{
					new int[] { 4 },
					new int[] { 9 },
					new int[] { 15 },
					new int[] { 16 },
					new int[] { 16 },
					new int[] { 17 },
					new int[] { 17 },
					new int[] { 17 },
					new int[] { 18 },
					new int[] { 18 },
					new int[] { 4, 1 },
					new int[] { 9, 2 },
					new int[] { 10, 10 },
					new int[] { 4, 3, 1, 3 },
					new int[] { 3, 3, 1, 2 },
					new int[] { 4, 1, 1, 1, 1 },
					new int[] { 4, 1, 1, 1, 1, 1 },
					new int[] { 4, 1, 1, 1, 1, 2, 2 },
					new int[] { 3, 3, 1, 1, 2, 4 },
					new int[] { 3, 2, 2, 4, 7 },
					new int[] { 2, 3, 3, 10 },
					new int[] { 3, 3, 4, 1, 13 },
					new int[] { 6, 1, 2, 1, 16 },
					new int[] { 10, 21 },
					new int[] { 13, 5 },
					new int[] { 12, 5 },
					new int[] { 10, 5 },
					new int[] { 11, 5 },
					new int[] { 9, 5 },
					new int[] { 17 },
					new int[] { 17 },
					new int[] { 16 },
					new int[] { 16 },
					new int[] { 15 },
					new int[] { 15 },
					new int[] { 9 }
				},
				"Jarofir",
				"Grzesiu",
				Brushes.Black,
				Difficulty.VHard
			) );
		}

	}
}
