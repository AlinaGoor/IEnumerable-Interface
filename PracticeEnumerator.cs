using System;
using System.Collections;

namespace IEnumerablePractice
{
    public class PracticeEnumerator : IEnumerator
    {
        public Practice[] Practices;
        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        private int position = -1;
        public PracticeEnumerator(Practice[] listPractices)
        {
            Practices = listPractices;
        }

        public bool MoveNext()
        {
            position++;
            return (position < Practices.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public object Current
        {
            get
            {
                try
                {
                    return Practices[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}