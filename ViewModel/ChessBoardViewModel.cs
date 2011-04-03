using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using ChessAI.SquareLogic;

namespace ChessAI.ViewModel {
	public class ChessBoardViewModel : ViewModelBase {

		private ObservableCollection<ObservableCollection<ChessSquareViewModel>> m_ChessSquareVM;

		public ObservableCollection<ObservableCollection<ChessSquareViewModel>> ChessSquareVM {
			get {
				return m_ChessSquareVM;
			}
			set {
				m_ChessSquareVM = value;
				OnPropertyChanged("ChessSquareVM");
			}
		}

		public ChessBoardViewModel() {
			m_ChessSquareVM = new ObservableCollection<ObservableCollection<ChessSquareViewModel>>();
			ObservableCollection<ChessSquareViewModel> tempRow = new ObservableCollection<ChessSquareViewModel>();
			ChessSquareViewModel tempSquare;
			for (int file = 0; file < 12; file++) {
				for (int rank = 0; rank < 12; rank++) {
					tempSquare = new ChessSquareViewModel(file, rank);
					tempRow.Add(tempSquare);
				}
				m_ChessSquareVM.Add(tempRow);
				tempRow = new ObservableCollection<ChessSquareViewModel>();
			}
		}

	}
}
