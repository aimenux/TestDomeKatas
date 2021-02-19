using System;
using System.Collections.Generic;

namespace TestDomeKatas
{
    /// <summary>
    /// A TrainComposition is built by attaching and detaching wagons from the left and the right sides, efficiently with respect to time used.
    /// For example, if we start by attaching wagon 7 from the left followed by attaching wagon 13,
    /// again from the left, we get a composition of two wagons (13 and 7 from left to right).
    /// Now the first wagon that can be detached from the right is 7 and the first that can be detached from the left is 13.
    /// Implement a TrainComposition that models this problem.
    /// </summary>
    public class TrainCompositionKata
    {
        private readonly LinkedList<int> _linkedList;

        public TrainCompositionKata(params int[] items)
        {
            _linkedList = new LinkedList<int>(items ?? Array.Empty<int>());
        }

        public void AttachWagonFromLeft(int wagonId)
        {
            _linkedList.AddFirst(wagonId);
        }

        public void AttachWagonFromRight(int wagonId)
        {
            _linkedList.AddLast(wagonId);
        }

        public int DetachWagonFromLeft()
        {
            if (_linkedList.First == null)
            {
                throw new InvalidOperationException(nameof(DetachWagonFromLeft));
            }

            var first = _linkedList.First.Value;
            _linkedList.RemoveFirst();
            return first;
        }

        public int DetachWagonFromRight()
        {
            if (_linkedList.Last == null)
            {
                throw new InvalidOperationException(nameof(DetachWagonFromRight));
            }

            var last = _linkedList.Last.Value;
            _linkedList.RemoveLast();
            return last;
        }
    }
}
