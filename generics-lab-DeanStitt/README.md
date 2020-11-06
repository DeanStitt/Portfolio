# Generics Lab

## Outcomes
* Students have created a generic class
* Students have instatiated a realized instance of a generic class

## Description
Let's go under the (admittedly unrealistic) assumtion that the ArrayList class is too bloated for our needs
We'd like a slimmed down version of that class that only has `add`, `get`, and `min` methods.
Additionally, we want the class to hold no more than 20 elements.

## Tasks
* Create some tests for the class, for example:
	* Be sure to utilize at least two different object types to populate it (String and Integer, for example)
	* Test calling `add` on the 21st element (remember we only want to support up to 20 items)
	* Test calling `get` beyond the index of the last element (should throw exception or display output)
	* Test `min` function
* Create a MyArrayList generic class
	* Create `add` and `get` methods that work on whatever class type is used to instantiate the MyArrayList
		* Be sure to handle out of bounds conditions from your test cases
	* Create a `min` function that returns the minimum element in the list