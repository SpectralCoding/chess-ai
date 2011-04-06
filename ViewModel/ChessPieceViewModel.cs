using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using ChessAI.PieceLogic;

namespace ChessAI.ViewModel {
	public class ChessPieceViewModel : ViewModelBase {

		private ChessPieceModel m_ChessPieceModel;

		public ChessPiece ChessPiece {
			get { return m_ChessPieceModel.ChessPiece; }
		}
		public PieceColor PieceColor {
			get { return m_ChessPieceModel.PieceColor; }
		}
		public PieceSide PieceSide {
			get { return m_ChessPieceModel.PieceSide; }
		}
		public string ResourceURI {
			get { return m_ChessPieceModel.ResourceURI; }
		}
		public ChessCoord ChessCoord {
			get { return m_ChessPieceModel.ChessCoord; }
			set {
				m_ChessPieceModel.ChessCoord = value;
				OnPropertyChanged("ChessCoord");
				OnPropertyChanged("ChessCoordStr");
				OnPropertyChanged("BoardX");
				OnPropertyChanged("BoardY");
			}
		}
		public ChessCoordStr ChessCoordStr {
			get { return m_ChessPieceModel.ChessCoordStr; }
		}
		public Thickness Margin {
			get { 
				int FileX = (m_ChessPieceModel.ChessCoord.File * 75);
				int RankY = ((7 - m_ChessPieceModel.ChessCoord.Rank) * 75);
				return new Thickness(FileX, RankY, 525 - FileX, 525 - RankY);
			}
		}

		public ChessPieceViewModel(ChessPiece i_ChessPiece, PieceColor i_PieceColor, PieceSide i_PieceSide, int i_File, int i_Rank) {
			ChessCoord tempChessCoord = new ChessCoord();
			tempChessCoord.File = i_File;
			tempChessCoord.Rank = i_Rank;
			m_ChessPieceModel = new ChessPieceModel(i_ChessPiece, i_PieceColor, i_PieceSide, tempChessCoord);
		}

	}
}
