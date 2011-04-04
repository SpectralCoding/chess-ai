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

	public struct Point {
		int X;
		int Y;
	}

}
