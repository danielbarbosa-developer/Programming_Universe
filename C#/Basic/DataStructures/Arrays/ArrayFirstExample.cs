//Author: Daniel Barbosa
//This code is part of an initiative to support learning in the area of ​​programming and technology.

/*
All C# program need to initialize or must have a namespace and a class, because this is the 
principal and basic structure of the language.

To learn more about namespaces and classes go to Classes&Objects folder in this repository 
*/

namespace Arrays
{
    /// <summary>
    /// This is our class that contains arrays examples
    /// </summary>
    public class ArrayFirstExample
    {
        /// <summary>
        /// This method (like functions in another languages)
        /// creates a variable that is a array (data structure)
        /// </summary>
        public void CreateIntArray()
        {
            // You can create a array like below

            int[] myIntArray = new int[5]; // you must specify the type and the lenght

            int[] mySecondArray = new int[] {1, 2, 3, 4, 5}; // you may create an array like this and insert its elements directly

            // You can work with array elements (add, remove) specifing the index of the element
            myIntArray[0] = 25; // adding -> Now the element on initial position has the 25 value
        }
    }
}