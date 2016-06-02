using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nonogramer {

	public enum Field { Empty, Filled, Marked }

	public class Map {

		public Field[,] Fields { get; private set; }
		public MapData Data { get; private set; }

		public int SizeX { get; private set; }
		public int SizeY { get; private set; }
		public Map() {
		}

		public void Load(MapData mapData) {
			Data = mapData;
			SizeX = Data.Width;
			SizeY = Data.Height;
			Fields = new Field[SizeX, SizeY];
			Clear();

			return;
		}
		public void SetField( int cellX, int cellY, Field field ) {
			if( Fields[cellX, cellY] != field )
				Fields[cellX, cellY] = field;
			else
				Fields[cellX, cellY] = Field.Empty;
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

	}
}
