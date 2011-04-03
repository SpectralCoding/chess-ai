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
using ChessAI.ViewModel;

namespace ChessAI.UserControls {
	/// <summary>
	/// Interaction logic for ChessBoard.xaml
	/// </summary>
	public partial class ChessBoard : UserControl {
		public ChessBoard() {
			InitializeComponent();
		}

		private void UserControl_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e) {
			if (DataContext is ChessBoardViewModel) {
				MakeCheckered();
			}
		}

		private void MakeCheckered() {
			ChessBoardViewModel tempCBVM = (ChessBoardViewModel)DataContext;
			//ChessSquareVM[Col/File][Row/Rank]
			ChessSquareA8.DataContext = tempCBVM.ChessSquareVM[2][9];
			ChessSquareB8.DataContext = tempCBVM.ChessSquareVM[3][9];
			ChessSquareC8.DataContext = tempCBVM.ChessSquareVM[4][9];
			ChessSquareD8.DataContext = tempCBVM.ChessSquareVM[5][9];
			ChessSquareE8.DataContext = tempCBVM.ChessSquareVM[6][9];
			ChessSquareF8.DataContext = tempCBVM.ChessSquareVM[7][9];
			ChessSquareG8.DataContext = tempCBVM.ChessSquareVM[8][9];
			ChessSquareH8.DataContext = tempCBVM.ChessSquareVM[9][9];

			ChessSquareA7.DataContext = tempCBVM.ChessSquareVM[2][8];
			ChessSquareB7.DataContext = tempCBVM.ChessSquareVM[3][8];
			ChessSquareC7.DataContext = tempCBVM.ChessSquareVM[4][8];
			ChessSquareD7.DataContext = tempCBVM.ChessSquareVM[5][8];
			ChessSquareE7.DataContext = tempCBVM.ChessSquareVM[6][8];
			ChessSquareF7.DataContext = tempCBVM.ChessSquareVM[7][8];
			ChessSquareG7.DataContext = tempCBVM.ChessSquareVM[8][8];
			ChessSquareH7.DataContext = tempCBVM.ChessSquareVM[9][8];

			ChessSquareA6.DataContext = tempCBVM.ChessSquareVM[2][7];
			ChessSquareB6.DataContext = tempCBVM.ChessSquareVM[3][7];
			ChessSquareC6.DataContext = tempCBVM.ChessSquareVM[4][7];
			ChessSquareD6.DataContext = tempCBVM.ChessSquareVM[5][7];
			ChessSquareE6.DataContext = tempCBVM.ChessSquareVM[6][7];
			ChessSquareF6.DataContext = tempCBVM.ChessSquareVM[7][7];
			ChessSquareG6.DataContext = tempCBVM.ChessSquareVM[8][7];
			ChessSquareH6.DataContext = tempCBVM.ChessSquareVM[9][7];

			ChessSquareA5.DataContext = tempCBVM.ChessSquareVM[2][6];
			ChessSquareB5.DataContext = tempCBVM.ChessSquareVM[3][6];
			ChessSquareC5.DataContext = tempCBVM.ChessSquareVM[4][6];
			ChessSquareD5.DataContext = tempCBVM.ChessSquareVM[5][6];
			ChessSquareE5.DataContext = tempCBVM.ChessSquareVM[6][6];
			ChessSquareF5.DataContext = tempCBVM.ChessSquareVM[7][6];
			ChessSquareG5.DataContext = tempCBVM.ChessSquareVM[8][6];
			ChessSquareH5.DataContext = tempCBVM.ChessSquareVM[9][6];

			ChessSquareA4.DataContext = tempCBVM.ChessSquareVM[2][5];
			ChessSquareB4.DataContext = tempCBVM.ChessSquareVM[3][5];
			ChessSquareC4.DataContext = tempCBVM.ChessSquareVM[4][5];
			ChessSquareD4.DataContext = tempCBVM.ChessSquareVM[5][5];
			ChessSquareE4.DataContext = tempCBVM.ChessSquareVM[6][5];
			ChessSquareF4.DataContext = tempCBVM.ChessSquareVM[7][5];
			ChessSquareG4.DataContext = tempCBVM.ChessSquareVM[8][5];
			ChessSquareH4.DataContext = tempCBVM.ChessSquareVM[9][5];

			ChessSquareA3.DataContext = tempCBVM.ChessSquareVM[2][4];
			ChessSquareB3.DataContext = tempCBVM.ChessSquareVM[3][4];
			ChessSquareC3.DataContext = tempCBVM.ChessSquareVM[4][4];
			ChessSquareD3.DataContext = tempCBVM.ChessSquareVM[5][4];
			ChessSquareE3.DataContext = tempCBVM.ChessSquareVM[6][4];
			ChessSquareF3.DataContext = tempCBVM.ChessSquareVM[7][4];
			ChessSquareG3.DataContext = tempCBVM.ChessSquareVM[8][4];
			ChessSquareH3.DataContext = tempCBVM.ChessSquareVM[9][4];

			ChessSquareA2.DataContext = tempCBVM.ChessSquareVM[2][3];
			ChessSquareB2.DataContext = tempCBVM.ChessSquareVM[3][3];
			ChessSquareC2.DataContext = tempCBVM.ChessSquareVM[4][3];
			ChessSquareD2.DataContext = tempCBVM.ChessSquareVM[5][3];
			ChessSquareE2.DataContext = tempCBVM.ChessSquareVM[6][3];
			ChessSquareF2.DataContext = tempCBVM.ChessSquareVM[7][3];
			ChessSquareG2.DataContext = tempCBVM.ChessSquareVM[8][3];
			ChessSquareH2.DataContext = tempCBVM.ChessSquareVM[9][3];

			ChessSquareA1.DataContext = tempCBVM.ChessSquareVM[2][2];
			ChessSquareB1.DataContext = tempCBVM.ChessSquareVM[3][2];
			ChessSquareC1.DataContext = tempCBVM.ChessSquareVM[4][2];
			ChessSquareD1.DataContext = tempCBVM.ChessSquareVM[5][2];
			ChessSquareE1.DataContext = tempCBVM.ChessSquareVM[6][2];
			ChessSquareF1.DataContext = tempCBVM.ChessSquareVM[7][2];
			ChessSquareG1.DataContext = tempCBVM.ChessSquareVM[8][2];
			ChessSquareH1.DataContext = tempCBVM.ChessSquareVM[9][2];
		}

	}
}
