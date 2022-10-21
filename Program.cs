﻿/******************************************************************************\
* Name: Jason D. F. D'Oyley
* Date: October 21, 2022
* Assignment: CIS214 Midterm Practical Exam
*
* The main application class must meet the following requirements
* - Print a line that states "Your Name - Midterm Practical Exam"
* - Get 10 integer values from the user and store them in an array or a List
* - Write a method to determine the smallest element in the collection
* - Write a method to determine the largest element in the collection
* - Display the following information for the collection
*   - All the elements in the collection and the index of the element (displayed
*     in columns as shown in the example below)
*   - The smallest element in the collection
*   - The largest element in the collection
\******************************************************************************/

public class Program
{
    static void Main(string[] args)
    {
        // Print a header line
        Console.WriteLine("\nJason D'Oyley - Midterm Practical Exam\n");

        // Get 10 integer values from the user and store them in an array or a
        // List
        List<int> numbers = new List<int>();

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Please enter an integer value: ");
            string? val = Console.ReadLine();
            numbers.Add(Convert.ToInt32(val));
        }
    }
}