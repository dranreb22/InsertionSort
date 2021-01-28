# INSERTION SORT
A C# program done as a class assignment for Design Patterns and Algorithms to read data 
from a file and sort numbers using a merging algorithm, with worst/best/average case 
time complexity of O(N*log N). Space complexity is O(N) because it is a recursive function. 
This is preferred where space is not a problem, where the data set is large, 
or the dataset is believed to be largely unsorted. The program also incorporates time tracking
to see how long, in minutes:seconds:milliseconds the dataset took.


## Getting Started
1. Clone or download the the program. Unzip the download.
2. Open/import the project through Visual Studio Community 2019
3. Gather a data set with number of lines equaling the number input at the console.
4. Run the program and test functionality.

## Built With
* Visual Studio Community 2019 - Enables the use of creating C#, .NET, and WPF Applications.

## Author
Bernard Georges

## License
GNU General Public License v3.0 - See License file

## Acknowledgments
*Dr. Kagdi for assigning the the work and providing us with potential solutions through pseudocode.
*Visual Studio Community 2019

## Key Programming Concepts Utilized
* Insertion Sorting, whereby the algorithm iterates through an array
	and moves up to 1 element per iteration, sorting from left to right.
* File input and output - Reading from a pre-existing file stored within another directory
	and creating a file, then appending to the file in the bin directory of the same project.