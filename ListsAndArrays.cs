// Arrays
// If you try to modify or add a unwanted item to the array you will get
// `System.IndexOutOfRangeException`

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Init array
            string[] = new string[3];

            food[0] "pizaa";
            food[1] "burger";
            food[2] "ice cream";

            foreach( string item in food)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

    }
}

// Lists are like arrays but are static with a fixed size
// Lists are mutable and can change dynamically
// Import using System.Collections.Generic;

using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Delcalre a list
            // Type - type of obj - name = new List <datatype> - ();
            Lists<string> food = new List<string>();

// Add a item to the list
            food.Add("pizaa");
            food.Add("burgers");
            // Remove an item
            food.Remove("burgers");
            // Get length
            food.Count();
            // Isert at index
            // food.Insert(index, "item")
            food.Insert(0, "fish");
            // Last index of multiple same items
            food.LastIndexOf("burgers");
            // sort alphabeticall
            food.Sort();
            // sort backwards
            food.Reverse();
            // Clear list
            food.Clear();
            // Convert list to array
            string[] foodarray = food.ToArray();
        }
    }
}

// List Methods
// ```cs
// Add(T)	
// Adds an object to the end of the List<T>.

// AddRange(IEnumerable<T>)	
// Adds the elements of the specified collection to the end of the List<T>.

// AsReadOnly()	
// Returns a read-only ReadOnlyCollection<T> wrapper for the current collection.

// BinarySearch(Int32, Int32, T, IComparer<T>)	
// Searches a range of elements in the sorted List<T> for an element using the specified comparer and returns the zero-based index of the element.

// BinarySearch(T)	
// Searches the entire sorted List<T> for an element using the default comparer and returns the zero-based index of the element.

// BinarySearch(T, IComparer<T>)	
// Searches the entire sorted List<T> for an element using the specified comparer and returns the zero-based index of the element.

// Clear()	
// Removes all elements from the List<T>.

// Contains(T)	
// Determines whether an element is in the List<T>.

// ConvertAll<TOutput>(Converter<T,TOutput>)	
// Converts the elements in the current List<T> to another type, and returns a list containing the converted elements.

// CopyTo(Int32, T[], Int32, Int32)	
// Copies a range of elements from the List<T> to a compatible one-dimensional array, starting at the specified index of the target array.

// CopyTo(T[])	
// Copies the entire List<T> to a compatible one-dimensional array, starting at the beginning of the target array.

// CopyTo(T[], Int32)	
// Copies the entire List<T> to a compatible one-dimensional array, starting at the specified index of the target array.

// EnsureCapacity(Int32)	
// Ensures that the capacity of this list is at least the specified capacity. If the current capacity is less than capacity, it is successively increased to twice the current capacity until it is at least the specified capacity.

// Equals(Object)	
// Determines whether the specified object is equal to the current object.

// (Inherited from Object)
// Exists(Predicate<T>)	
// Determines whether the List<T> contains elements that match the conditions defined by the specified predicate.

// Find(Predicate<T>)	
// Searches for an element that matches the conditions defined by the specified predicate, and returns the first occurrence within the entire List<T>.

// FindAll(Predicate<T>)	
// Retrieves all the elements that match the conditions defined by the specified predicate.

// FindIndex(Int32, Int32, Predicate<T>)	
// Searches for an element that matches the conditions defined by the specified predicate, and returns the zero-based index of the first occurrence within the range of elements in the List<T> that starts at the specified index and contains the specified number of elements.

// FindIndex(Int32, Predicate<T>)	
// Searches for an element that matches the conditions defined by the specified predicate, and returns the zero-based index of the first occurrence within the range of elements in the List<T> that extends from the specified index to the last element.

// FindIndex(Predicate<T>)	
// Searches for an element that matches the conditions defined by the specified predicate, and returns the zero-based index of the first occurrence within the entire List<T>.

// FindLast(Predicate<T>)	
// Searches for an element that matches the conditions defined by the specified predicate, and returns the last occurrence within the entire List<T>.

// FindLastIndex(Int32, Int32, Predicate<T>)	
// Searches for an element that matches the conditions defined by the specified predicate, and returns the zero-based index of the last occurrence within the range of elements in the List<T> that contains the specified number of elements and ends at the specified index.

// FindLastIndex(Int32, Predicate<T>)	
// Searches for an element that matches the conditions defined by the specified predicate, and returns the zero-based index of the last occurrence within the range of elements in the List<T> that extends from the first element to the specified index.

// FindLastIndex(Predicate<T>)	
// Searches for an element that matches the conditions defined by the specified predicate, and returns the zero-based index of the last occurrence within the entire List<T>.

// ForEach(Action<T>)	
// Performs the specified action on each element of the List<T>.

// GetEnumerator()	
// Returns an enumerator that iterates through the List<T>.

// GetHashCode()	
// Serves as the default hash function.

// (Inherited from Object)
// GetRange(Int32, Int32)	
// Creates a shallow copy of a range of elements in the source List<T>.

// GetType()	
// Gets the Type of the current instance.

// (Inherited from Object)
// IndexOf(T)	
// Searches for the specified object and returns the zero-based index of the first occurrence within the entire List<T>.

// IndexOf(T, Int32)	
// Searches for the specified object and returns the zero-based index of the first occurrence within the range of elements in the List<T> that extends from the specified index to the last element.

// IndexOf(T, Int32, Int32)	
// Searches for the specified object and returns the zero-based index of the first occurrence within the range of elements in the List<T> that starts at the specified index and contains the specified number of elements.

// Insert(Int32, T)	
// Inserts an element into the List<T> at the specified index.

// InsertRange(Int32, IEnumerable<T>)	
// Inserts the elements of a collection into the List<T> at the specified index.

// LastIndexOf(T)	
// Searches for the specified object and returns the zero-based index of the last occurrence within the entire List<T>.

// LastIndexOf(T, Int32)	
// Searches for the specified object and returns the zero-based index of the last occurrence within the range of elements in the List<T> that extends from the first element to the specified index.

// LastIndexOf(T, Int32, Int32)	
// Searches for the specified object and returns the zero-based index of the last occurrence within the range of elements in the List<T> that contains the specified number of elements and ends at the specified index.

// MemberwiseClone()	
// Creates a shallow copy of the current Object.

// (Inherited from Object)
// Remove(T)	
// Removes the first occurrence of a specific object from the List<T>.

// RemoveAll(Predicate<T>)	
// Removes all the elements that match the conditions defined by the specified predicate.

// RemoveAt(Int32)	
// Removes the element at the specified index of the List<T>.

// RemoveRange(Int32, Int32)	
// Removes a range of elements from the List<T>.

// Reverse()	
// Reverses the order of the elements in the entire List<T>.

// Reverse(Int32, Int32)	
// Reverses the order of the elements in the specified range.

// Sort()	
// Sorts the elements in the entire List<T> using the default comparer.

// Sort(Comparison<T>)	
// Sorts the elements in the entire List<T> using the specified Comparison<T>.

// Sort(IComparer<T>)	
// Sorts the elements in the entire List<T> using the specified comparer.

// Sort(Int32, Int32, IComparer<T>)	
// Sorts the elements in a range of elements in List<T> using the specified comparer.

// ToArray()	
// Copies the elements of the List<T> to a new array.

// ToString()	
// Returns a string that represents the current object.

// (Inherited from Object)
// TrimExcess()	
// Sets the capacity to the actual number of elements in the List<T>, if that number is less than a threshold value.

// TrueForAll(Predicate<T>)	
// Determines whether every element in the List<T> matches the conditions defined by the specified predicate.
// ``` 