using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Klasa z jedną metodą, będącą rozwiązaniem zadania Ex3 z Lab 1. Zwraca ilość różnych elementów w podanej tablicy A.
/// </summary>
namespace Lab1
{
    class Ex3
    {
        public int solution(int[] A)
        {
            HashSet<int> set = new HashSet<int>(A);//zamiana tablicy na zbiór, ten konstruktor ma złożoność O(N)
            return set.Count;//zwracam ile elementów posiada zbiór
        }
    }
}
