using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace ChessAI.SquareLogic {
	public class ChessSquareModel {

		#region Private Members
		public int File;
		public int Rank;
		public string FileStr;
		public string RankStr;
		public bool IsWhite;
		public bool PossibleMove;
		public Brush SquareColor;
		#endregion

		public ChessSquareModel(int i_File, int i_Rank) {
			File = i_File;
			Rank = i_Rank;
			PossibleMove = false;
			if ((File > 1) && (File < 10)) {
				FileStr = Functions.FileIndexToLetter(File);
			} else {
				FileStr = "X";
			}
			if ((Rank > 1) && (Rank < 10)) {
				RankStr = (i_Rank - 1).ToString();
			} else {
				RankStr = "0";
			}
			IsWhite = Functions.IsWhite(File, Rank);
			if (IsWhite) {
				SquareColor = new SolidColorBrush(Color.FromArgb(255, 255, 206, 158));
			} else {
				SquareColor = new SolidColorBrush(Color.FromArgb(255, 209, 139, 71));
			}
		}

	}
}
