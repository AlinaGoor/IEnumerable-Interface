using System;
using System.Collections;

namespace IEnumerablePractice
{
    // Collection of Practice objects. This class
    // implements IEnumerable so that it can be used
    // with ForEach syntax.
    // When you implement IEnumerable, you must also implement IEnumerator.
    public class Practices : IEnumerable
    {
        private Practice[] _practices;
        public Practices(Practice[] pArray)
        {
            _practices = new Practice[pArray.Length];

            for (int i = 0; i < pArray.Length; i++)
            {
                _practices[i] = pArray[i];
            }
        }

        // Implementation for the GetEnumerator method.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            return new PracticeEnumerator(_practices);
        }
    }
}