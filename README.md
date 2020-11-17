# IsUnique

## Method 1

- Program takes an input string from the user and determines whether or not any of the characters are repeated in the string.
- This is a brute force method that runs 2 nested loops and compares all combinations of 2 characters one by one.
- Time complexity is O(n<sup>2</sup>)

## PEDAC

- P: Determine if all of the characters in a string are unique
- E: "ABCD" -> true
  "ABA" -> false
- D: Input: string
  Output: bool
- A: Nested Loop

  > Loop through all of the characters 0-inputString.Length
  >
  > > Loop through all of the characters until the last after the firstIndex
  > >
  > > > if (inputString[firstIndex] == firstString[lastIndex])
  > > > return false

  > return true if none match

## Method 2

- Time complexity is O(n log n)

- Convert the string to a character array
- sort the character array by ascii value
- Loop through all of the characters in the sorted array and compare it to the next indexed value
- if any match return false
- otherwise return true
