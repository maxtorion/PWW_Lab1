using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Rozwiązanie Ex1 lab1 "Binary gap"
/// </summary>
namespace Lab1
{
    class Ex1
    {

        public int solution1(int N)
        {
            ///<summary>Metoda, która dla podanej liczby typu int zwraca binary gap</summary>
            ///<param>int N - liczba naturalna z zakresu [1, 2 147 483 647], dla której ma zostać wyliczona binary gap</param>
            ///<returns>liczbę całkowitą reprezentującą największą istniejącą binary gap</returns>

            string bits = Convert.ToString(N,2);// zamiana liczby na binarną reprezentację w łańcuchu string

            

            List<byte> positionsOfOnes = new List<byte>(); //lista, w której przechowywane są indeksy z pozycjami jedynek
            for (byte i = 0; i < bits.Length; i++)
            {
               
                if (bits[i] == '1')//sprawdzenie, czy na danej pozycji jest jedynka
                {
                    
                    positionsOfOnes.Add(i);
                }
            }

            if (positionsOfOnes.Count <= 1)//jeżeli w zapisie bitowym liczby nie ma jedynek lub jest tylko jedna 
            {
                return 0;
            }
            else
            {
                List<byte> listOfGaps = new List<byte>();//lista z poszczególnymi odległościami
                for (byte i = 0; i < positionsOfOnes.Count-1; i++)
                {
                  listOfGaps.Add(Convert.ToByte(Math.Abs( positionsOfOnes[i] - positionsOfOnes[i + 1])));//wartość absolutna odległości pomiędzy indeksami
                }
                return listOfGaps.Max()-1;
            }
            
        }
       
    }
}
