# Searching

## Linear Search
Runtime:

	Worst case: O(n)

	Best case: O(1)

	Average: O(n/2)

Linear search simply loops through every value in the array until it finds the target value.
It is not very efficient unless the data set is very small.

## Binary Search

Runtime: 
	
	Average: O(log n)
	Worst case: O(n)

Binary search requires a sorted data set.
It compares the value in the middle of the data set to the target value.
If the values are the same, it has successfully found the target.
If not, it will determine whether the target is greater than or less than the middle value. 
Then it will repeat (possibly using recursion) and search on progressively smaller halves until the target is found.

## Interpolation Search

Runtime: 
	
	Average: O(log (log n))
	Worst case: O(n)

Interpolation search improves binary search by picking a better "midpoint" for arrays that are uniformly sorted.
Instead of only choosing the middle element, interpolation search chooses its search point based on a key equation. 
This means if a value gives a key close to the last element, the search will start near the end side.

