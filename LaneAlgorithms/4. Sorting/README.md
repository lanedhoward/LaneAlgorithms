# Sorting

# Bubble Sort
Runtime: O(n^2)

Memory: O(1)

Bubble sort is a simple sorting algorithm.
It simply loops through the array repeatedly,
swapping adjacent elements that are out of order.

Bubble sort is slow but works fine for lists smaller than 1000 items.
It can also be faster than other algorithms for lists smaller than 5 items.

# Insertion Sort

Runtime: Best case of O(n), worse case O(n^2)

Memory: O(1)

Insertion sort works by going through each item in the array,
and placing it where it needs to go in the left (already sorted/visited) portion of the array.

Insertion sort has a faster best-case scenario than bubble sort, but it still relatively slow for large lists.
Still, it works fine for lists <1000 items, and can even be more efficent than others for lists <10 items.

# Selection Sort

Runtime: O(n^2) on average and worst case

Memory: O(1)

Selection sort searches through the list to find the largest item, and puts that at the end of the list.
Then it repeats, searching for the largest item not yet sorted and moving it into the sorted part of the list.

It has similar performance to insertion sort, with the same use-cases.

# Heap Sort

Runtime: O(n log n)

Memory: O(1)

Heap sort improves on selection sort by keeping the unsorted portion of the algorithm in a Heap.
This means the largest item is found more quickly.

Heap sort first makes the array into a heap. Then, it swaps the root value with the last value in the unsorted portion. Then it restores the heap, and repeats until the array is sorted.

# Quick Sort

Runtime: O(n log n) on average, O(n^2) worst case

Memory: O(1)

Quick sort uses a divide and conquer strategy.
It partitions the array into halves, then sorts halves so all the values in the left are less than the midpoint value, and all the values in the right are greater than the midpoint value.
Then, it calls itself on those halves, using recursion until the list is completely sorted.

Quick sort can be optimized to be much faster than merge sort and heap sort, even though the algorithms have the same asymptotical average.

# Merge Sort

Runtime: average and worst case O(n log n)

Memory: O(n)

Merge sort also uses a divide-and-conquer strategy. 
However, it splits the array into two halves holding an equal number of items.
Then it calls itself recursively on those halves.
Finally, when the recursive calls return, the two sorted halves are combined into a single sorted array.