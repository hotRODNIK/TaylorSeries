# TaylorSeries
This repository contains code which implements a Taylor Series for e^x. 
The foundation of this implementation is a doubly-linked list and a SeriesTerm. 
The SeriesTerm object defines a template for what each of term of the series will look like and how it should be definesd.
The LinkedList provides a mechanism by which to store the SeriesTerms and provides functionality for printing and summation of the series.
The TaylorSeries object consists of a LinkedList of SeriesTerms, which one can operate on with various functions embedded in the code.
The Main() function is currently programmed to create a TaylorSeries of a limited number of SeriesTerms (I believe it was 5) and then generates a .csv file of 
OrderedPairs of which one can use to generate a plot of the TaylorSeries approximation in some language such as R or Python. This is accomplished in the following manner.

1. Create a TaylorSeries
2. Initialize an array of x-values
3. Plug those x-values into the TaylorSeries, sum the function to get an approximation for e^x and then save that value in an array of y-values
4. Create an array of OrderedPairs of the x-values and y-values
5. Output the OrderedPairs array to a .csv file

I included the out.csv file which was generated by compiling the source files with Microsoft (R) Visual C# Compiler version 3.0.19.21801 for an x86 system. The executable was run on an Intel Core i7-8550U which implements the x86-64 architecture.
