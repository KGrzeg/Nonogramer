using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace Nonogramer {

	public delegate void NotificationEventHandler( object sender, EventArgs e );

	public class Controler {

		private Game game;

		public event NotificationEventHandler Move;

		public Controler( Game game ) {
			this.game = game;
		}

		public void Click( Canvas canv, MouseButtonEventArgs e ) {
			if( e.LeftButton != MouseButtonState.Pressed && e.RightButton != MouseButtonState.Pressed )
				return;

			var pos = e.GetPosition(canv);
			var cellPos = game.Renderer.CellAt(pos.X, pos.Y);

			//komórka poza mapą lub na legendzie
			if( cellPos[0] < 0 || cellPos[1] < 0 ||
					cellPos[0] > game.Renderer.SizeX - 1 ||
					cellPos[1] > game.Renderer.SizeY - 1 )
				return;

			if( e.LeftButton == MouseButtonState.Pressed )
				game.Map.SetField( cellPos[0], cellPos[1], Field.Filled );
			else
				game.Map.SetField( cellPos[0], cellPos[1], Field.Marked );
			onChanged( EventArgs.Empty );
			game.Draw();
		}

		private void onChanged( EventArgs e ) {
			if( Move != null )
				Move( this, e );
		}

	}
}
