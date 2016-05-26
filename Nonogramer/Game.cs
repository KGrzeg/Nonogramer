using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Nonogramer {
	public class Game {
		public Map Map { get; set; }
		private Canvas canvas;

		public Game(Canvas canv) {
			Map = new Map();
			canvas = canv;
		}
	}
}
