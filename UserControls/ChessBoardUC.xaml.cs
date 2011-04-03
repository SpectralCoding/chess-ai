using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChessAI.UserControls {
	/// <summary>
	/// Interaction logic for ChessBoard.xaml
	/// </summary>
	public partial class ChessBoard : UserControl {
		public ChessBoard() {
			InitializeComponent();
		}

		private void UserControl_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e) {
			MakeCheckered();
		}

		private void MakeCheckered() {
			Color WhiteColor = Color.FromRgb(0, 0, 0);
			Color BlackColor = Color.FromRgb(255, 255, 255);
			Console.WriteLine(DataContext);
    		//ChessSquareA8
			//ChessSquareB8
    		//ChessSquareC8
    		//ChessSquareD8
    		//ChessSquareE8
    		//ChessSquareF8
    		//ChessSquareG8
    		//ChessSquareH8
    		//ChessSquareA7
    		//ChessSquareB7
    		//ChessSquareC7
    		//ChessSquareD7
    		//ChessSquareE7
    		//ChessSquareF7
    		//ChessSquareG7
    		//ChessSquareH7
    		//ChessSquareA6
    		//ChessSquareB6
    		//ChessSquareC6
    		//ChessSquareD6
    		//ChessSquareE6
    		//ChessSquareF6
    		//ChessSquareG6
    		//ChessSquareH6
    		//ChessSquareA5
    		//ChessSquareB5
    		//ChessSquareC5
    		//ChessSquareD5
    		//ChessSquareE5
    		//ChessSquareF5
    		//ChessSquareG5
    		//ChessSquareH5
    		//ChessSquareA4
    		//ChessSquareB4
    		//ChessSquareC4
    		//ChessSquareD4
    		//ChessSquareE4
    		//ChessSquareF4
    		//ChessSquareG4
    		//ChessSquareH4
    		//ChessSquareA3
    		//ChessSquareB3
    		//ChessSquareC3
    		//ChessSquareD3
    		//ChessSquareE3
    		//ChessSquareF3
    		//ChessSquareG3
    		//ChessSquareH3
    		//ChessSquareA2
    		//ChessSquareB2
    		//ChessSquareC2
    		//ChessSquareD2
    		//ChessSquareE2
    		//ChessSquareF2
    		//ChessSquareG2
    		//ChessSquareH2
    		//ChessSquareA1
    		//ChessSquareB1
    		//ChessSquareC1
    		//ChessSquareD1
    		//ChessSquareE1
    		//ChessSquareF1
    		//ChessSquareG1
    		//ChessSquareH1
		}

	}
}
