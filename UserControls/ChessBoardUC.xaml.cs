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

		private Point FirstPoint = new Point(0,0);

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
			#region ChessSquares (ChessSquareVM[Col/File][Row/Rank])
			ChessSquareA8.DataContext = tempCBVM.ChessSquareVM[0][7];
			ChessSquareB8.DataContext = tempCBVM.ChessSquareVM[1][7];
			ChessSquareC8.DataContext = tempCBVM.ChessSquareVM[2][7];
			ChessSquareD8.DataContext = tempCBVM.ChessSquareVM[3][7];
			ChessSquareE8.DataContext = tempCBVM.ChessSquareVM[4][7];
			ChessSquareF8.DataContext = tempCBVM.ChessSquareVM[5][7];
			ChessSquareG8.DataContext = tempCBVM.ChessSquareVM[6][7];
			ChessSquareH8.DataContext = tempCBVM.ChessSquareVM[7][7];

			ChessSquareA7.DataContext = tempCBVM.ChessSquareVM[0][6];
			ChessSquareB7.DataContext = tempCBVM.ChessSquareVM[1][6];
			ChessSquareC7.DataContext = tempCBVM.ChessSquareVM[2][6];
			ChessSquareD7.DataContext = tempCBVM.ChessSquareVM[3][6];
			ChessSquareE7.DataContext = tempCBVM.ChessSquareVM[4][6];
			ChessSquareF7.DataContext = tempCBVM.ChessSquareVM[5][6];
			ChessSquareG7.DataContext = tempCBVM.ChessSquareVM[6][6];
			ChessSquareH7.DataContext = tempCBVM.ChessSquareVM[7][6];

			ChessSquareA6.DataContext = tempCBVM.ChessSquareVM[0][5];
			ChessSquareB6.DataContext = tempCBVM.ChessSquareVM[1][5];
			ChessSquareC6.DataContext = tempCBVM.ChessSquareVM[2][5];
			ChessSquareD6.DataContext = tempCBVM.ChessSquareVM[3][5];
			ChessSquareE6.DataContext = tempCBVM.ChessSquareVM[4][5];
			ChessSquareF6.DataContext = tempCBVM.ChessSquareVM[5][5];
			ChessSquareG6.DataContext = tempCBVM.ChessSquareVM[6][5];
			ChessSquareH6.DataContext = tempCBVM.ChessSquareVM[7][5];

			ChessSquareA5.DataContext = tempCBVM.ChessSquareVM[0][4];
			ChessSquareB5.DataContext = tempCBVM.ChessSquareVM[1][4];
			ChessSquareC5.DataContext = tempCBVM.ChessSquareVM[2][4];
			ChessSquareD5.DataContext = tempCBVM.ChessSquareVM[3][4];
			ChessSquareE5.DataContext = tempCBVM.ChessSquareVM[4][4];
			ChessSquareF5.DataContext = tempCBVM.ChessSquareVM[5][4];
			ChessSquareG5.DataContext = tempCBVM.ChessSquareVM[6][4];
			ChessSquareH5.DataContext = tempCBVM.ChessSquareVM[7][4];

			ChessSquareA4.DataContext = tempCBVM.ChessSquareVM[0][3];
			ChessSquareB4.DataContext = tempCBVM.ChessSquareVM[1][3];
			ChessSquareC4.DataContext = tempCBVM.ChessSquareVM[2][3];
			ChessSquareD4.DataContext = tempCBVM.ChessSquareVM[3][3];
			ChessSquareE4.DataContext = tempCBVM.ChessSquareVM[4][3];
			ChessSquareF4.DataContext = tempCBVM.ChessSquareVM[5][3];
			ChessSquareG4.DataContext = tempCBVM.ChessSquareVM[6][3];
			ChessSquareH4.DataContext = tempCBVM.ChessSquareVM[7][3];

			ChessSquareA3.DataContext = tempCBVM.ChessSquareVM[0][2];
			ChessSquareB3.DataContext = tempCBVM.ChessSquareVM[1][2];
			ChessSquareC3.DataContext = tempCBVM.ChessSquareVM[2][2];
			ChessSquareD3.DataContext = tempCBVM.ChessSquareVM[3][2];
			ChessSquareE3.DataContext = tempCBVM.ChessSquareVM[4][2];
			ChessSquareF3.DataContext = tempCBVM.ChessSquareVM[5][2];
			ChessSquareG3.DataContext = tempCBVM.ChessSquareVM[6][2];
			ChessSquareH3.DataContext = tempCBVM.ChessSquareVM[7][2];

			ChessSquareA2.DataContext = tempCBVM.ChessSquareVM[0][1];
			ChessSquareB2.DataContext = tempCBVM.ChessSquareVM[1][1];
			ChessSquareC2.DataContext = tempCBVM.ChessSquareVM[2][1];
			ChessSquareD2.DataContext = tempCBVM.ChessSquareVM[3][1];
			ChessSquareE2.DataContext = tempCBVM.ChessSquareVM[4][1];
			ChessSquareF2.DataContext = tempCBVM.ChessSquareVM[5][1];
			ChessSquareG2.DataContext = tempCBVM.ChessSquareVM[6][1];
			ChessSquareH2.DataContext = tempCBVM.ChessSquareVM[7][1];

			ChessSquareA1.DataContext = tempCBVM.ChessSquareVM[0][0];
			ChessSquareB1.DataContext = tempCBVM.ChessSquareVM[1][0];
			ChessSquareC1.DataContext = tempCBVM.ChessSquareVM[2][0];
			ChessSquareD1.DataContext = tempCBVM.ChessSquareVM[3][0];
			ChessSquareE1.DataContext = tempCBVM.ChessSquareVM[4][0];
			ChessSquareF1.DataContext = tempCBVM.ChessSquareVM[5][0];
			ChessSquareG1.DataContext = tempCBVM.ChessSquareVM[6][0];
			ChessSquareH1.DataContext = tempCBVM.ChessSquareVM[7][0];
			#endregion
			#region ChessPieces
			WhiteQueensRookCP.DataContext = tempCBVM.ChessPieceVM[7];
			WhiteQueensKnightCP.DataContext = tempCBVM.ChessPieceVM[5];
			WhiteQueensBishopCP.DataContext = tempCBVM.ChessPieceVM[3];
			WhiteQueenCP.DataContext = tempCBVM.ChessPieceVM[1];
			WhiteKingCP.DataContext = tempCBVM.ChessPieceVM[0];
			WhiteKingsBishopCP.DataContext = tempCBVM.ChessPieceVM[2];
			WhiteKingsKnightCP.DataContext = tempCBVM.ChessPieceVM[4];
			WhiteKingsRookCP.DataContext = tempCBVM.ChessPieceVM[6];
			WhiteQueensRookPawnCP.DataContext = tempCBVM.ChessPieceVM[8];
			WhiteQueensKnightPawnCP.DataContext = tempCBVM.ChessPieceVM[9];
			WhiteQueensBishopPawnCP.DataContext = tempCBVM.ChessPieceVM[10];
			WhiteQueensPawnCP.DataContext = tempCBVM.ChessPieceVM[11];
			WhiteKingsPawnCP.DataContext = tempCBVM.ChessPieceVM[12];
			WhiteKingsBishopPawnCP.DataContext = tempCBVM.ChessPieceVM[13];
			WhiteKingsKnightPawnCP.DataContext = tempCBVM.ChessPieceVM[14];
			WhiteKingsRookPawnCP.DataContext = tempCBVM.ChessPieceVM[15];
			
			BlackQueensRookCP.DataContext = tempCBVM.ChessPieceVM[23];
			BlackQueensKnightCP.DataContext = tempCBVM.ChessPieceVM[21];
			BlackQueensBishopCP.DataContext = tempCBVM.ChessPieceVM[19];
			BlackQueenCP.DataContext = tempCBVM.ChessPieceVM[17];
			BlackKingCP.DataContext = tempCBVM.ChessPieceVM[16];
			BlackKingsBishopCP.DataContext = tempCBVM.ChessPieceVM[18];
			BlackKingsKnightCP.DataContext = tempCBVM.ChessPieceVM[20];
			BlackKingsRookCP.DataContext = tempCBVM.ChessPieceVM[22];
			BlackQueensRookPawnCP.DataContext = tempCBVM.ChessPieceVM[24];
			BlackQueensKnightPawnCP.DataContext = tempCBVM.ChessPieceVM[25];
			BlackQueensBishopPawnCP.DataContext = tempCBVM.ChessPieceVM[26];
			BlackQueensPawnCP.DataContext = tempCBVM.ChessPieceVM[27];
			BlackKingsPawnCP.DataContext = tempCBVM.ChessPieceVM[28];
			BlackKingsBishopPawnCP.DataContext = tempCBVM.ChessPieceVM[29];
			BlackKingsKnightPawnCP.DataContext = tempCBVM.ChessPieceVM[30];
			BlackKingsRookPawnCP.DataContext = tempCBVM.ChessPieceVM[31];
			#endregion
		}

		private void BlackQueensRookCP_MouseDown(object sender, MouseButtonEventArgs e) {
			FirstPoint = this.PointToScreen(Mouse.GetPosition(this));
		}

		private void BlackQueensRookCP_MouseMove(object sender, MouseEventArgs e) {
			if (e.LeftButton == MouseButtonState.Pressed) {
				Point tempPoint = this.PointToScreen(Mouse.GetPosition(this));
				BlackQueensRookCP.Margin = new Thickness(tempPoint.X - FirstPoint.X, tempPoint.Y - FirstPoint.Y, 0, 0);
			}
		}

	}		
}			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			