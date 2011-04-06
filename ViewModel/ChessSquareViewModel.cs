using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using ChessAI.SquareLogic;

namespace ChessAI.ViewModel {
	public class ChessSquareViewModel : ViewModelBase {

		private ChessSquareModel m_ChessSquareModel;

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
			private set {
				m_ChessSquareModel.SquareColor = value;
				OnPropertyChanged("SquareColor");
			}
		}
		public bool PossibleMove {
			get { return m_ChessSquareModel.PossibleMove; }
			set {
				m_ChessSquareModel.PossibleMove = value;
				if (value) {
					SquareColor = new SolidColorBrush(Color.FromRgb(0, 0, 0));
				} else {
					if (IsWhite) {
						SquareColor = new SolidColorBrush(Color.FromArgb(255, 255, 206, 158));
					} else {
						SquareColor = new SolidColorBrush(Color.FromArgb(255, 209, 139, 71));
					}
				}
				OnPropertyChanged("PossibleMove");
			}
		}
		#endregion

		public ChessSquareViewModel(int i_File, int i_Rank) {
			m_ChessSquareModel = new ChessSquareModel(i_File, i_Rank);
		}

	}
}
