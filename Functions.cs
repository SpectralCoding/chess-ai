using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;

namespace ChessAI {
	public static class Functions {

		public static string ULongToBinaryString(ulong value) {
			int ulongsize = sizeof(ulong) * 8;
			StringBuilder ret = new StringBuilder(ulongsize);
			for (int i = 0; i < ulongsize; i++) {
				ret.Insert(0, value & 0x1);
				value >>= 1;
			}
			return ret.ToString();
		}

		public static List<ChessCoord> PossibleMoves(ChessPiece ChessPiece, ChessCoord PieceCoord) {
			List<ChessCoord> returnArr = new List<ChessCoord>();

			return returnArr;
		}

		public static bool IsWhite(int File, int Rank) {
			if ((Rank % 2) == 0) {
				if ((File % 2) == 0) {
					return false;
				} else {
					return true;
				}
			} else {
				if ((File % 2) == 0) {
					return true;
				} else {
					return false;
				}
			}
		}

		public static String FileIndexToLetter(int FileIndex) {
			switch (FileIndex) {
				case 0: return "a";
				case 1: return "b";
				case 2: return "c";
				case 3: return "d";
				case 4: return "e";
				case 5: return "f";
				case 6: return "g";
				case 7: return "h";
				default: return "ERROR";
			}
		}

		/// <summary>
		/// Returns a recursive directory listing for a fold based on a file mask.
		/// </summary>
		/// <param name="Directory">String containing a directory path to recursively list.</param>
		/// <param name="FileMask">File mask for filtering certain files.</param>
		/// <returns>ArrayList containing all files in a directory tree.</returns>
		public static ArrayList RecursiveDirctoryListing(String Directory, String FileMask) {
			ArrayList ReturnList = new ArrayList();
			DirectoryInfo DirInfo = new DirectoryInfo(Directory);
			FileInfo[] FileList = DirInfo.GetFiles(FileMask);
			foreach (FileInfo File in FileList) {
				ReturnList.Add(File.FullName);
			}
			DirectoryInfo[] DirList = DirInfo.GetDirectories();
			foreach (DirectoryInfo Dir in DirList) {
				ReturnList.AddRange(RecursiveDirctoryListing(Dir.FullName, FileMask));
			}
			return ReturnList;
		}

		/// <summary>
		/// Prints an ArrayList object to the console.
		/// </summary>
		/// <param name="InputArray">ArrayList to print.</param>
		public static void PrintArrayList(ArrayList InputArray) {
			Console.WriteLine("Array Output: ");
			for (int i = 0; i < InputArray.Count; i++) {
				Console.WriteLine("[" + i + "] " + InputArray[i]);
			}
		}

		/// <summary>
		/// Dumps a byte[] Array to a file.
		/// </summary>
		/// <param name="inputBytes">byte[] Array to export.</param>
		/// <param name="FileName">Filename to export to.</param>
		public static void DumpByteArrayToFile(byte[] inputBytes, String FileName) {
			File.Delete(FileName);
			FileStream MusicFileFS = new FileStream(FileName, FileMode.Create, FileAccess.ReadWrite);
			if (MusicFileFS.CanWrite) {
				MusicFileFS.Write(inputBytes, 0, inputBytes.Length);
			}
			MusicFileFS.Close();
		}

		/// <summary>
		/// Prints the ASCII values of every character in a character array delimited by a pipe character to the Console.
		/// </summary>
		/// <param name="inputCharArr">String to be split.</param>
		public static void PrintCharArrASCII(char[] inputCharArr) {
			Console.Write("|");
			for (int i = 0; i < inputCharArr.Length; i++) {
				Console.Write(((int)inputCharArr[i]).ToString() + "|");
			}
			Console.WriteLine();
		}

		/// <summary>
		/// Prints the ASCII values of every character in a string delimited by a pipe character to the Console.
		/// </summary>
		/// <param name="inputStr">String to be split.</param>
		public static void PrintStringASCII(String inputStr) {
			char[] charArr = inputStr.ToCharArray();
			Console.Write("|");
			for (int i = 0; i < charArr.Length; i++) {
				Console.Write(((int)charArr[i]).ToString() + "|");
			}
			Console.WriteLine();
		}

		/// <summary>
		/// Removes all newline characters from a string (ASCII 10/13).
		/// </summary>
		/// <param name="inputStr">String to remove characters from.</param>
		/// <returns>String lacking ASCII 10/13.</returns>
		public static String RemoveNewLineChars(String inputStr) {
			if (inputStr != null) {
				return inputStr.Replace(Convert.ToChar(13).ToString(), "").Replace(Convert.ToChar(10).ToString(), "");
			}
			return null;
		}

		/// <summary>
		/// Returns a string containing the inputStrArr String Array with elemented delimited by Delimiter.
		/// </summary>
		/// <param name="inputStrArr">String Array to enumerate.</param>
		/// <param name="Delimiter">Delimiter to interleave between elements.</param>
		/// <returns>String delimited by Delimiter.</returns>
		public static String Implode(String[] inputStrArr, String Delimiter) {
			String returnStr = "";
			foreach (String tempStr in inputStrArr) {
				returnStr += tempStr + Delimiter;
			}
			if (returnStr.Length > Delimiter.Length) {
				returnStr = returnStr.Substring(0, (returnStr.Length - Delimiter.Length));
			}
			return returnStr;
		}


	}
}
