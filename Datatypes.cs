using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessAI {
	public enum ChessPiece {
		King,
		Queen,
		Bishop,
		Knight,
		Rook,
		Pawn
	}

	public enum PieceColor {
		White,
		Black
	}

	public enum PieceSide {
		Kings,
		Queens
	}

	public struct ChessCoord {
		public int Rank;
		public int File;
	}

	public struct ChessCoordStr {
		public string Rank;
		public string File;
	}

}
