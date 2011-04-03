using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

		public ChessPieceViewModel(ChessPiece i_ChessPiece, PieceColor i_PieceColor, PieceSide i_PieceSide) {
			m_ChessPieceModel = new ChessPieceModel(i_ChessPiece, i_PieceColor, i_PieceSide);
		}

	}
}
