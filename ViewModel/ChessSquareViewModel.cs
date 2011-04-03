using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using ChessAI.SquareLogic;

namespace ChessAI.ViewModel {
	public class ChessSquareViewModel : ViewModelBase {

		private ChessSquareModel m_ChessSquareModel;
		private ChessPieceViewModel m_ChessPieceVM;

		#region Public Properties
		public int File {
			get { return m_ChessSquareModel.File; }
		}
		public int Rank {
			get { return m_ChessSquareModel.Rank; }
		}
		public string FileStr {
			get { return m_ChessSquareModel.FileStr; }
		}
		public string RankStr {
			get { return m_ChessSquareModel.RankStr; }
		}
		public bool IsWhite {
			get { return m_ChessSquareModel.IsWhite; }
		}
		public Brush SquareColor {
			get { return m_ChessSquareModel.SquareColor; }
		}
		public ChessPieceViewModel ChessPieceVM {
			get { return m_ChessPieceVM; }
		}
		#endregion

		public ChessSquareViewModel(int i_File, int i_Rank) {
			m_ChessSquareModel = new ChessSquareModel(i_File, i_Rank);
		}

	}
}
