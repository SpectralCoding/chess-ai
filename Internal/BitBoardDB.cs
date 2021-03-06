﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessAI.Internal {
	public static class BitBoardDB {
		public static ulong[] RookAttacks = new ulong[64];
		public static ulong[] KnightAttacks = new ulong[64];

		public static void GenerateAttacks() {
			GenerateRookAttacks();			// Fast
			GenerateKnightAttacks();		// Slow-ish?
		}

		private static void GenerateRookAttacks() {
			int i = 0;
			ulong FileULong;
			for (int File = 0; File < 8; File++) {
				FileULong = 9259542123273814144 >> File;
				for (int Rank = 0; Rank < 8; Rank++) {
					RookAttacks[i] = FileULong | (18374686479671623680 >> (Rank * 8));
					i++;
				}
			}
		}

		private static void GenerateKnightAttacks() {
			int i = 0;
			BigBitBoard InitialKnightPosition = new BigBitBoard("010100000000100010000000000000000000100010000000010100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
			for (int File = 0; File < 8; File++) {
				for (int Rank = 0; Rank < 8; Rank++) {
					KnightAttacks[i] = InitialKnightPosition.RightShift((Rank) + (File * 12)).ToBitBoard();
					i++;
				}
			}
		}

	
		public static void PrintBitBoard(ulong BitBoard) {
			string temp = Functions.ULongToBinaryString(BitBoard);
			Console.WriteLine(
				String.Format(
					"{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n",
					temp.Substring(0, 8),
					temp.Substring(8, 8),
					temp.Substring(16, 8),
					temp.Substring(24, 8),
					temp.Substring(32, 8),
					temp.Substring(40, 8),
					temp.Substring(48, 8),
					temp.Substring(56, 8)
				)
			);
		}



	}
}
