﻿//Write a function that accepts an array of 10 integers (between 0 and 9), that returns a string of those numbers in the form of a phone number.



int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
string str = " ";

foreach (int n in array)
    str += n.ToString();

Console.WriteLine(string.Format("{0:(###) ###-####}", Convert.ToInt64(str)));