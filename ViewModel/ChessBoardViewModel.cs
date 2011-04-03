using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using ChessAI.SquareLogic;

namespace ChessAI.ViewModel {
	public class ChessBoardViewModel : ViewModelBase {

		private ObservableCollection<ObservableCollection<ChessSquareViewModel>> m_ChessSquareVM;
		private ObservableCollection<ChessPieceViewModel> m_ChessPieceVM;

		public ObservableCollection<ObservableCollection<ChessSquareViewModel>> ChessSquareVM {
			get { return m_ChessSquareVM; }
			set {
				m_ChessSquareVM = value;
				OnPropertyChanged("ChessSquareVM");
			}
		}
		public ObservableCollection<ChessPieceViewModel> ChessPieceVM {
			get { return m_ChessPieceVM; }
			set {
				m_ChessPieceVM = value;
				OnPropertyChanged("ChessPieceVM");
			}
		}


		public ChessBoardViewModel() {
			InitializePieces();
			InitializeSquares();
			PlacePieces();
			OnPropertyChanged("ChessSquareVM");
			OnPropertyChanged("ChessPieceVM");
		}

		private void InitializeSquares() {
			m_ChessSquareVM = new ObservableCollection<ObservableCollection<ChessSquareViewModel>>();
			ObservableCollection<ChessSquareViewModel> tempRow = new ObservableCollection<ChessSquareViewModel>();
			ChessSquareViewModel tempSquare;
			for (int file = 0; file < 12; file++) {
				for (int rank = 0; rank < 12; rank++) {
					tempSquare = new ChessSquareViewModel(file, rank);
					tempRow.Add(tempSquare);
				}
				m_ChessSquareVM.Add(tempRow);
				tempRow = new ObservableCollection<ChessSquareViewModel>();
			}
		}

		private void InitializePieces() {
			m_ChessPieceVM = new ObservableCollection<ChessPieceViewModel>();
			// Initialize All White Pieces
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.King, PieceColor.White, PieceSide.Kings));	// 0
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Queen, PieceColor.White, PieceSide.Kings));	// 1
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Bishop, PieceColor.White, PieceSide.Kings));	// 2
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Bishop, PieceColor.White, PieceSide.Queens));	// 3
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Knight, PieceColor.White, PieceSide.Kings));	// 4
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Knight, PieceColor.White, PieceSide.Queens));	// 5
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Rook, PieceColor.White, PieceSide.Kings));	// 6
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Rook, PieceColor.White, PieceSide.Queens));	// 7
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Pawn, PieceColor.White, PieceSide.Kings));	// 8
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Pawn, PieceColor.White, PieceSide.Kings));	// 9
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Pawn, PieceColor.White, PieceSide.Kings));	// 10
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Pawn, PieceColor.White, PieceSide.Kings));	// 11
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Pawn, PieceColor.White, PieceSide.Queens));	// 12
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Pawn, PieceColor.White, PieceSide.Queens));	// 13
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Pawn, PieceColor.White, PieceSide.Queens));	// 14
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Pawn, PieceColor.White, PieceSide.Queens));	// 15
			// Initialize All Black Pieces																		// 
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.King, PieceColor.Black, PieceSide.Kings));	// 16
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Queen, PieceColor.Black, PieceSide.Kings));	// 17
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Bishop, PieceColor.Black, PieceSide.Kings));	// 18
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Bishop, PieceColor.Black, PieceSide.Queens));	// 19
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Knight, PieceColor.Black, PieceSide.Kings));	// 20
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Knight, PieceColor.Black, PieceSide.Queens));	// 21
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Rook, PieceColor.Black, PieceSide.Kings));	// 22
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Rook, PieceColor.Black, PieceSide.Queens));	// 23
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Pawn, PieceColor.Black, PieceSide.Kings));	// 24
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Pawn, PieceColor.Black, PieceSide.Kings));	// 25
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Pawn, PieceColor.Black, PieceSide.Kings));	// 26
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Pawn, PieceColor.Black, PieceSide.Kings));	// 27
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Pawn, PieceColor.Black, PieceSide.Queens));	// 28
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Pawn, PieceColor.Black, PieceSide.Queens));	// 29
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Pawn, PieceColor.Black, PieceSide.Queens));	// 30
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Pawn, PieceColor.Black, PieceSide.Queens));	// 31
		}

		private void PlacePieces() {
			#region White Special Pieces
			m_ChessSquareVM[2][2].ChessPieceVM = m_ChessPieceVM[7];
			m_ChessSquareVM[3][2].ChessPieceVM = m_ChessPieceVM[5];
			m_ChessSquareVM[4][2].ChessPieceVM = m_ChessPieceVM[3];
			m_ChessSquareVM[5][2].ChessPieceVM = m_ChessPieceVM[1];
			m_ChessSquareVM[6][2].ChessPieceVM = m_ChessPieceVM[0];
			m_ChessSquareVM[7][2].ChessPieceVM = m_ChessPieceVM[2];
			m_ChessSquareVM[8][2].ChessPieceVM = m_ChessPieceVM[4];
			m_ChessSquareVM[9][2].ChessPieceVM = m_ChessPieceVM[6];
			#endregion
			#region White Pawns
			m_ChessSquareVM[2][3].ChessPieceVM = m_ChessPieceVM[12];
			m_ChessSquareVM[3][3].ChessPieceVM = m_ChessPieceVM[13];
			m_ChessSquareVM[4][3].ChessPieceVM = m_ChessPieceVM[14];
			m_ChessSquareVM[5][3].ChessPieceVM = m_ChessPieceVM[15];
			m_ChessSquareVM[6][3].ChessPieceVM = m_ChessPieceVM[8];
			m_ChessSquareVM[7][3].ChessPieceVM = m_ChessPieceVM[9];
			m_ChessSquareVM[8][3].ChessPieceVM = m_ChessPieceVM[10];
			m_ChessSquareVM[9][3].ChessPieceVM = m_ChessPieceVM[11];
			#endregion
			#region Black Special Pieces
			m_ChessSquareVM[2][9].ChessPieceVM = m_ChessPieceVM[23];
			m_ChessSquareVM[3][9].ChessPieceVM = m_ChessPieceVM[21];
			m_ChessSquareVM[4][9].ChessPieceVM = m_ChessPieceVM[19];
			m_ChessSquareVM[5][9].ChessPieceVM = m_ChessPieceVM[17];
			m_ChessSquareVM[6][9].ChessPieceVM = m_ChessPieceVM[16];
			m_ChessSquareVM[7][9].ChessPieceVM = m_ChessPieceVM[18];
			m_ChessSquareVM[8][9].ChessPieceVM = m_ChessPieceVM[20];
			m_ChessSquareVM[9][9].ChessPieceVM = m_ChessPieceVM[22];
			#endregion
			#region Black Pawns
			m_ChessSquareVM[2][8].ChessPieceVM = m_ChessPieceVM[28];
			m_ChessSquareVM[3][8].ChessPieceVM = m_ChessPieceVM[29];
			m_ChessSquareVM[4][8].ChessPieceVM = m_ChessPieceVM[30];
			m_ChessSquareVM[5][8].ChessPieceVM = m_ChessPieceVM[31];
			m_ChessSquareVM[6][8].ChessPieceVM = m_ChessPieceVM[24];
			m_ChessSquareVM[7][8].ChessPieceVM = m_ChessPieceVM[25];
			m_ChessSquareVM[8][8].ChessPieceVM = m_ChessPieceVM[26];
			m_ChessSquareVM[9][8].ChessPieceVM = m_ChessPieceVM[27];
			#endregion
		}

	}
}
