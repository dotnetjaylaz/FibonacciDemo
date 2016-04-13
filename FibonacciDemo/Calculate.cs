using System;

namespace FibonacciDemo
{
    public class CalculationHelper
    {
        /// <summary>
        /// This will calulate the nth position of the Fibonacci sequence interatively
        /// </summary>
        /// <param name="position">The ordinal position of the Fibonacci sequence.  nth should be between 0 and 46</param>
        /// <returns>The int value of the 0 based position of the Fibonacci sequence.</returns>
        public int CalculateFibonacci(int position)
        {
            //Make sure we don't overflow the int with our calculations
            if (position > 45)
            {
                throw new OverflowException("The position value of " + position + " will overflow the the returned type of int.  Please use a value between 0 and 45");
            }
            //Make sure we don't overflow the int with our calculations
            if (position < 0)
            {
                throw new ArgumentOutOfRangeException("position",position,"The position value of less than 0 is not allowed.  Please use a value between 0 and 45");
            }


            //Start at 1, 1
            int current = 1, nextval = 1;
            //Compute Fibonacci sequence iteratively to the input position.
            for (int i = 0; i < position; i++)
            {
                int previous = current;

                //Set the current to be what we calculated to be the next value on the previous loop
                current = nextval;

                //the current value plus the previous value will be our new next value
                nextval += previous;
            }
            return current;
        }
    }
}