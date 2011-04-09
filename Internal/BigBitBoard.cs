using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessAI.Internal {
	public class BigBitBoard {
		public bool[] BoardData = new bool[144];

		public BigBitBoard() {
		}

		public BigBitBoard(ulong InitialValue) {
			SetValue(Functions.ULongToBinaryString(InitialValue));
		}

		public BigBitBoard(string InitialValue) {
			SetValue(InitialValue);
		}

		public void SetValue(string BitString) {
			int DataArrStartingPoint = BoardData.Length - BitString.Length;
			int StringIndex = 0;
			for (int DataIndex = DataArrStartingPoint; DataIndex < BoardData.Length; DataIndex++) {
				if (BitString.Substring(StringIndex, 1) == "1") {
					BoardData[DataIndex] = true;
				}
				StringIndex++;
			}
		}

		public BigBitBoard LeftShift(int Digits) {
			BigBitBoard returnBoard = new BigBitBoard();
			Array.Copy(BoardData, Digits, returnBoard.BoardData, 0, BoardData.Length - Digits);
			return returnBoard;
		}

		public BigBitBoard RightShift(int Digits) {
			BigBitBoard returnBoard = new BigBitBoard();
			Array.Copy(BoardData, 0, returnBoard.BoardData, Digits, BoardData.Length - Digits);
			return returnBoard;
		}

		public ulong ToBitBoard() {
			string tempStr = String.Empty;
			for (int i = 26; i < BoardData.Length - 26; i += 12) {
				if (BoardData[i]) { tempStr += "1"; } else { tempStr += "0"; }
				if (BoardData[i + 1]) { tempStr += "1"; } else { tempStr += "0"; }
				if (BoardData[i + 2]) { tempStr += "1"; } else { tempStr += "0"; }
				if (BoardData[i + 3]) { tempStr += "1"; } else { tempStr += "0"; }
				if (BoardData[i + 4]) { tempStr += "1"; } else { tempStr += "0"; }
				if (BoardData[i + 5]) { tempStr += "1"; } else { tempStr += "0"; }
				if (BoardData[i + 6]) { tempStr += "1"; } else { tempStr += "0"; }
				if (BoardData[i + 7]) { tempStr += "1"; } else { tempStr += "0"; }
			}
			return Convert.ToUInt64(tempStr, 2);
		}

		public void PrintBitBoard(int LineLength) {
			string StrToPrint = String.Empty;
			int SubIndex = 0;
			for (int i = 0; i < BoardData.Length; i++) {
				if (BoardData[i]) {
					StrToPrint += "1";
				} else {
					StrToPrint += "0";
				}
				SubIndex++;
				if (SubIndex == LineLength) {
					StrToPrint += "\n";
					SubIndex = 0;
				}
			}
			Console.WriteLine(StrToPrint);
		}

	}
}
