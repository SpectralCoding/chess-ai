using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessAI.PieceLogic {
	public class ChessPieceModel {

		public ChessPiece ChessPiece;
		public PieceColor PieceColor;
		public PieceSide PieceSide;
		public string ResourceURI;

		public ChessPieceModel(ChessPiece i_ChessPiece, PieceColor i_PieceColor, PieceSide i_PieceSide) {
			ChessPiece = i_ChessPiece;
			PieceColor = i_PieceColor;
			PieceSide = i_PieceSide;
			string PieceColorStr;
			if (i_PieceColor == PieceColor.White) { PieceColorStr = "White"; } else { PieceColorStr = "Black"; }
			switch (i_ChessPiece) {
				case ChessPiece.King: ResourceURI = @"/ChessAI;component/Resources/Pieces/" + PieceColorStr + "_King.png"; break;
				case ChessPiece.Queen: ResourceURI = @"/ChessAI;component/Resources/Pieces/" + PieceColorStr + "_Queen.png"; break;
				case ChessPiece.Bishop: ResourceURI = @"/ChessAI;component/Resources/Pieces/" + PieceColorStr + "_Bishop.png"; break;
				case ChessPiece.Knight: ResourceURI = @"/ChessAI;component/Resources/Pieces/" + PieceColorStr + "_Knight.png"; break;
				case ChessPiece.Rook: ResourceURI = @"/ChessAI;component/Resources/Pieces/" + PieceColorStr + "_Rook.png"; break;
				case ChessPiece.Pawn: ResourceURI = @"/ChessAI;component/Resources/Pieces/" + PieceColorStr + "_Pawn.png"; break;
			}
		}

	}
}
