using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nonogramer {

	public enum Field { Empty, Filled, Marked }

	public class Map {

		public Field[,] Fields { get; set; }
		public MapData Data { get; set; }

		public int SizeX { get; set; }
		public int SizeY { get; set; }
		public Map() {
			this.SetSize( 10 );

			Trought();
		}

		public void Load() {
			int w = 10;
			int h = 10;
			int[][] rows = {
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
			};
			int[][] cols = {
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
			};

			Data = new MapData( w, h, rows, cols );
		}

		public bool CheckAll() {
			for( int x = 0; x < SizeX; ++x ) {
				Field[] data = GetColumn(x);
				int[] mapDefCols = Data.Cols[x];

				if( !CheckSeries( data, mapDefCols ) )
					return false;
			}
			for( int y = 0; y < SizeY; ++y ) {
				Field[] data = GetRow(y);
				int[] mapDefRows = Data.Rows[y];

				if( !CheckSeries( data, mapDefRows ) )
					return false;
			}
			return true;
		}

		public void SetSize( int size ) {
			Fields = new Field[size, size];
			SizeX = this.SizeY = size;
			Clear();
		}
		public void Clear() {
			for( int x = 0; x < Fields.GetLength( 0 ); ++x ) {
				for( int y = 0; y < Fields.GetLength( 1 ); ++y ) {
					Fields[x, y] = Field.Empty;
				}
			}
		}
		public Field[] GetRow( int y ) {
			Field[] ret = new Field[SizeX];
			for( int i = 0; i < SizeX; ++i ) {
				ret[i] = Fields[i, y];
			}
			return ret;
		}
		public Field[] GetColumn( int x ) {
			Field[] ret = new Field[SizeY];
			for( int i = 0; i < SizeY; ++i ) {
				ret[i] = Fields[x, i];
			}
			return ret;
		}

		public bool CheckSeries( Field[] fields, int[] rule ) {
			int filledAmmount = 0;
			int currentSeries = 0;

			for( int i = 0; i < fields.Length; ++i ) {
				if( fields[i] == Field.Filled ) {
					++filledAmmount;
				} else {
					if( filledAmmount == 0 )
						continue;

					if( filledAmmount != rule[currentSeries] )
						return false;

					filledAmmount = 0;
					++currentSeries;

					if( currentSeries == rule.Length )
						return true;
				}
			}

			if( filledAmmount != 0 ) {
				if( filledAmmount != rule[currentSeries] )
					return false;
				filledAmmount = 0;
				++currentSeries;
			}

			if( currentSeries == rule.Length )
				return true;
			return false;
		}
		//DEBUG
		public void Trought() {

			int maxX = Fields.GetLength(0);
			int maxY = Fields.GetLength(1);
			int midX = maxX / 2;
			int midY = maxY / 2;
			Field toMid = Field.Filled;
			Field afterMid = Field.Marked;

			for( int x = 0; x < midX; ++x ) {
				for( int y = 0; y < midY; ++y ) {
					if( x == y )
						Fields[x, y] = toMid;
				}
			}
			for( int x = midX; x < maxX; ++x ) {
				for( int y = midY; y < maxY; ++y ) {
					if( x == y )
						Fields[x, y] = afterMid;
				}
			}
		}

	}
}
