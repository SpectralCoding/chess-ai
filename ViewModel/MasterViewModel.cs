using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessAI.ViewModel {
	public class MasterViewModel : ViewModelBase {

		private ChessBoardViewModel m_ChessBoardVM;

		public ChessBoardViewModel ChessBoardVM {
			get {
				return m_ChessBoardVM;
			}
			set {
				m_ChessBoardVM = value;
				OnPropertyChanged("ChessBoardVM");
			}
		}

		public MasterViewModel() {
			#region Member Instantiation
			ChessBoardVM = new ChessBoardViewModel();
			#endregion
		}

	}
}
