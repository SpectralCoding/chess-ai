using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessAI.SquareLogic {
	public class ChessSquareModel {

		#region Private Members
		public int File;
		public int Rank;
		public string FileStr;
		public string RankStr;
		public bool IsWhite;
		#endregion

		public ChessSquareModel(int i_File, int i_Rank) {
			File = i_File;
			Rank = i_Rank;
			FileStr = Functions.FileIndexToLetter(File);
			RankStr = i_Rank.ToString();
			IsWhite = Functions.IsWhite(File, Rank);
		}

	}
}
