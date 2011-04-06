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
			OnPropertyChanged("ChessSquareVM");
			OnPropertyChanged("ChessPieceVM");
		}

		private void InitializeSquares() {
			m_ChessSquareVM = new ObservableCollection<ObservableCollection<ChessSquareViewModel>>();
			ObservableCollection<ChessSquareViewModel> tempRow = new ObservableCollection<ChessSquareViewModel>();
			ChessSquareViewModel tempSquare;
			for (int file = 0; file < 8; file++) {
				for (int rank = 0; rank < 8; rank++) {
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
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.King, PieceColor.White, PieceSide.Kings, 4, 0));		// 0
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Queen, PieceColor.White, PieceSide.Queens, 3, 0));	// 1
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Bishop, PieceColor.White, PieceSide.Kings, 5, 0));	// 2
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Bishop, PieceColor.White, PieceSide.Queens, 2, 0));	// 3
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Knight, PieceColor.White, PieceSide.Kings, 6, 0));	// 4
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Knight, PieceColor.White, PieceSide.Queens, 1, 0));	// 5
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Rook, PieceColor.White, PieceSide.Kings, 7, 0));		// 6
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Rook, PieceColor.White, PieceSide.Queens, 0, 0));		// 7
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Pawn, PieceColor.White, PieceSide.Kings, 4, 1));		// 8
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Pawn, PieceColor.White, PieceSide.Kings, 5, 1));		// 9
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Pawn, PieceColor.White, PieceSide.Kings, 6, 1));		// 10
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Pawn, PieceColor.White, PieceSide.Kings, 7, 1));		// 11
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Pawn, PieceColor.White, PieceSide.Queens, 0, 1));		// 12
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Pawn, PieceColor.White, PieceSide.Queens, 1, 1));		// 13
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Pawn, PieceColor.White, PieceSide.Queens, 2, 1));		// 14
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Pawn, PieceColor.White, PieceSide.Queens, 3, 1));		// 15
			// Initialize All Black Pieces
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.King, PieceColor.Black, PieceSide.Kings, 4, 7));		// 0
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Queen, PieceColor.Black, PieceSide.Queens, 3, 7));	// 1
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Bishop, PieceColor.Black, PieceSide.Kings, 5, 7));	// 2
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Bishop, PieceColor.Black, PieceSide.Queens, 2, 7));	// 3
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Knight, PieceColor.Black, PieceSide.Kings, 6, 7));	// 4
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Knight, PieceColor.Black, PieceSide.Queens, 1, 7));	// 5
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Rook, PieceColor.Black, PieceSide.Kings, 7, 7));		// 6
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Rook, PieceColor.Black, PieceSide.Queens, 0, 7));		// 7
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Pawn, PieceColor.Black, PieceSide.Kings, 4, 6));		// 8
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Pawn, PieceColor.Black, PieceSide.Kings, 5, 6));		// 9
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Pawn, PieceColor.Black, PieceSide.Kings, 6, 6));		// 10
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Pawn, PieceColor.Black, PieceSide.Kings, 7, 6));		// 11
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Pawn, PieceColor.Black, PieceSide.Queens, 0, 6));		// 12
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Pawn, PieceColor.Black, PieceSide.Queens, 1, 6));		// 13
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Pawn, PieceColor.Black, PieceSide.Queens, 2, 6));		// 14
			m_ChessPieceVM.Add(new ChessPieceViewModel(ChessPiece.Pawn, PieceColor.Black, PieceSide.Queens, 3, 6));		// 15
		}

		private void PrintBoardToConsole() {
			for (int file = 0; file < 8; file++) {
				for (int rank = 0; rank < 8; rank++) {
					Console.Write(String.Format("[{0},{1}] ", m_ChessSquareVM[file][rank].FileStr, m_ChessSquareVM[file][rank].RankStr));
				}
				Console.WriteLine();
			}
		}
	}
}
