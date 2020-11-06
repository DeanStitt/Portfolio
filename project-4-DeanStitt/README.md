# Project-4
## Grade Distribution Curve

Due: **2018-10-28 23:59CDT**

## Overview
In an effort to assess the efficacy of teaching, it is often crucial to perform some basic data analysis on student grades.
If students are all scoring really high, it's likely that the course isn't challenging the majority of students.
If students are generally scoring very low, it can indicate poor instruction, unfair evaluation, or overreaching course goals.

For this programming assignment, you will be creating a tool that can read in student grade data and,
1. Determine which students would successfully pass a course
2. Display summary data in the form of a histogram distribution
3. Store the results to an output file for off-line retrieval

## Learning Outcomes
The focus of this assignment is on the following learning outcomes:
* Demonstrate competence in collections such as arrays
* Develop programs that persist data by performing file input and output
* Demonstrate the skills to define subclasses and utilize inheritance and polymorphism
* Apply string formatting and padding techniques in order to enhance data display

## Assignment
Create a program that can read, parse, and analyze student grade data.
* Your program shall prompt the user for the name of a file to read, e.g. `grades.csv`.
* Your program shall check if the file exists and is available to read.
	* If not, it should handle that gracefully and prompt the user for a different file.
* The format of the file is [shown below](##sample-input) - file distributed with this description.
* Process the input file (details below).
* Create an output file of the report, thus persisting the execution of the program.

### Filtering data
1. If a score exists in the file that is not between 0 and 100, discard all data for that student.
2. If a student is excluded by the above rule, they should not be part of the summary data for the class.

Your program shall prompt the user to enter in the level of granularity of the output.
Thus, if the user enters "10", the final histogram should be grouped into 10 bins (0<= SCORE < 10, 10 <= SCORE < 20, ..., 90 <= SCORE <= 100).


## Sample input
The first line in the input file is a header row.
All subsequent lines contain student data and scores.
#### Project_4.csv
```
Student,Scholarship requirement,,,,,,,,,,,
Caron Devers,75,89,91,99,94,89,88,96,95,92,91,91
Kylie Whitham,,74,78,81,76,70,76,74,68,81,72,70
Tami Davenport,90,84,82,88,83,80,95,90,81,89,83,80
In Desilets,,77,66,54,51,110,69,53,69,54,71,65
Roma Skelton,,68,69,76,65,67,65,77,71,75,66,66
Diana Barletta,,96,92,97,94,96,98,98,92,100,99,90
Debroah Darrell,,53,57,51,41,51,46,46,40,55,54,45
Marcelina Mccain,,97,91,91,93,98,88,99,91,95,92,95
Shirely Gisi,70,72,85,80,83,84,81,72,84,73,76,80
Monique Montesdeoca,90,81,84,92,79,81,76,85,81,83,86,83
Shana Harrill,,77,76,-3,80,75,77,79,62,55,75,63
Luigi Botello,,63,70,70,68,74,76,70,63,64,64,64
Heidy Filippi,80,87,91,88,99,98,89,93,93,91,93,94
Nadine Broadnax,,43,42,42,56,39,4,18,50,20,10,24
Olen Brand,85,95,93,97,86,88,84,85,87,84,100,95
Nancee Farnsworth,,71,69,75,70,68,83,78,74,70,84,72
Valentine Lamontagne,,87,89,86,86,86,86,85,91,94,85,85
Sherley Slinkard,,76,76,77,78,80,69,79,77,78,76,73
Lovie Peppler,,68,65,58,57,62,67,58,75,64,71,72
Carlota Peltz,70,81,78,75,86,72,66,77,79,83,83,76
Professor Fancy-Pants,100,100,100,100,100,100,100,100,100,100,100,100
```


## Student types
Note that some records in the data above have a number listed under "Scholarship requirement".
These students must achieve the minimum score denoted in that row to be considered a "passing" student in addition to the minimum score required for all students.
Students without scholarship demands need only obtain a minimum score of 60 to be considered passing.
* The previous statement may or may not align with your syllabus, or in-major requirements and is not meant to be considered advice.

## Structure
![Comic about Ohm's Law](https://imgs.xkcd.com/comics/ohm.png)

You have the power to create your own program structure, with some restrictions.
Unlike in previous projects, you will not be given UML or function names that you need to define.
As you continue to mature as a software developer, you will need to be able to determine for yourself what program structure best suits the problem.
Be sure to clearly document your code and give variables and functions meaningful names in order to make your code highly readable.

The above comes with one caveat, however.
Note that students with scholarship needs are particular types of students, with different data and output needs from other students.
Before you write your first line of code, get out a sheet of paper and draft the UML for your project.
This will not be something you need to give to me, but ensuring that your program is thought out will save you far more time than it takes to sketch out the UML.
It is much simpler to update your sketch than it to refactor entire classes or code structure.
Keep in mind the tenets of _inheritance_ and _polymorphism_ to simplify your life and [**maximize your grade**](#rubric).

## Output
The output consists of three main parts and shall be stored in a file whose name specified by the user:
1. Student rows in the input that contain invalid data (score not between 0 and 100) shall print a notice stating "Invalid score of -12 for Dave Thomas", where "-12" is the offending datum and "Dave Thomas" is the student's name.
	1. You can assume that the data will be integers. No handling of type errors is required.
2. Students with valid data should call a `toString()` function which outputs their name, average for the course, and whether or not they passed.
If they would have passed if not for scholarship requirements, state that as well.
3. A [histogram](https://en.wikipedia.org/wiki/Histogram) of the student data partitioned into the number of bins defined by the user.


## Sample Program run
`Input the name of the input file: `**Project_4.csv**\
`Input the name of the output file: `**output.txt**\
`Enter the number of bins for the histogram: `**10**

## Sample output
Assuming the user entered `output.txt` when prompted for an output file, here is what the results should be when run against the [sample input](#sample-input) given:
#### output.txt
```
Caron Devers has a course average of 92 - PASS
Kylie Whitham has a course average of 74 - PASS
Tami Davenport has a course average of 85 - FAIL due to not meeting scholarship minimum of 90
Invalid score of 110 for In Desilets
Roma Skelton has a course average of 69 - PASS
Diana Barletta has a course average of 95 - PASS
Debroah Darrell has a course average of 49 - FAIL
Marcelina Mccain has a course average of 93 - PASS
Shirely Gisi has a course average of 79 - PASS
Monique Montesdeoca has a course average of 82 - FAIL due to not meeting scholarship minimum of 90
Invalid score of -3 for Shana Harrill
Luigi Botello has a course average of 67 - PASS
Heidy Filippi has a course average of 92 - PASS
Nadine Broadnax has a course average of 31 - FAIL
Olen Brand has a course average of 90 - PASS
Nancee Farnsworth has a course average of 74 - PASS
Valentine Lamontagne has a course average of 87 - PASS
Sherley Slinkard has a course average of 76 - PASS
Lovie Peppler has a course average of 65 - PASS
Carlota Peltz has a course average of 77 - PASS
Professor Fancy-Pants has a course average of 100 - PASS


                                                * 
                                      *         * 
                                      *         * 
                                 *    *    *    * 
                                 *    *    *    * 
                  *    *         *    *    *    * 

0    10   20   30   40   50   60   70   80   90   100  

```

## Submission

1.	Follow the commenting and style requirements provided on Canvas.
2.	Remove any package statements from the top of your Java source code files if they exist.
3.	Push your committed repository code to the Github classroom.

## Rubric:

Grading Area | Weight
------------ | ------
Code format (documentation, indentation, capitalization, etc.) | 10
File input for invalid file name | 5
File input for file which cannot open (invalid permissions) | 5
Parsing invalid student data row | 10
Parsing valid student row | 10
Output written to file specified by user | 10
Output for all students (as individuals) | 10
Histogram formatting correct | 20
Histogram bins reflect user input | 10
Code is well structured using OOP | 10
