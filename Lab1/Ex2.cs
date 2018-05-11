using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Klasa z jedną metodą oraz strukturą, 
/// będącą rozwiązaniem zadania Ex2 z Lab 1. Zwraca tablicę o długości N poddanej rotacji K razy.
/// </summary>
namespace Lab1
{
    class Ex2
    {
        public struct Result { //prosta struktura z konstruktorem inicjalizującym i akcesorem
            int[] A;

            public Result(int[]B)
            {
                this.A = B;
            }
            public int[] get_table()
            {
                return this.A;
            }
        }

        public Result solution(int []A, int N, int K) {
            ///<summary>Metoda, która dla podanej tablicy o długości N zwraca tablicę poddaną rotacji K razy.
            ///Do wykonania rotacji wykorzystuje się fakt, iż rotacja K razy oznacza po prostu, iż K elementów tablicy A 
            ///z końca tablicy trafia na jej początek. Aby zatem szybko i efektywnie zrealizować tą operację,
            ///Wystarczy "powycinać" fragmenty o odpowiedniej długości, a następnie połączyć je w odwrotenj kolejności</summary>
            ///<param>int [] A - oryginalna tablica, która będzie poddawana rotacji</param>
            ///<param>int N - długość tablicy A</param>
            ///<param>int K - Ilość rotacji, które trzeba wykonać na tablicy A</param>
            ///<returns>Tablicę o długości N poddaną rotacji K razy</returns>

            int[] part_A=new int[K];//tablica na elementy rotujące
            int[] part_B=new int[N-K];//tablica na elementy nie rotujące

            Array.Copy(A, N - K, part_A, 0, K);//rotacja
            Array.Copy(A, 0, part_B, 0, N - K);//przeniesienie pozostałych elementów do osobnej tablicy

            Result result=new Result(part_A.Concat(part_B).ToArray()); 

            return result;
        }
    }
}
