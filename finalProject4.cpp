#include <iostream>

#include <fstream>

#include <string>

#include <map>

#include <iterator>

using namespace ::std;

string fileRead()

{

cout << "Enter the Output File Name \n";

string fileName;

cin >> fileName;

return fileName;

}

int main()

{

string input_File_Name = "TheSales.txt";

string output_File_Name = fileRead();

ifstream fin(input_File_Name.c_str(), std::ios_base::in);

if (!fin.is_open())

{

cout << "Could not open file: " << input_File_Name << endl;

return 1;

}

ofstream fout (output_File_Name.c_str());

if (!fout.is_open())

{

cout << "Could not open file: " << output_File_Name << endl;

return 1;

}

string name;

string text;

ifstream infile;

ifstream readfile;

int weeks, salesPersons;

int i, j, k;

fin >> salesPersons;

fin >> weeks;

double sales[salesPersons][weeks * 5];

string salesPersonNames[salesPersons][3];

double totalSales,avgSales;

fout << salesPersons << "\n";

fout << weeks << "\n";

for (i = 0; i < salesPersons; i++)

{

fin >> salesPersonNames[i][0] >> salesPersonNames[i][1] >> salesPersonNames[i][2];

for (j = 0; j < weeks * 5; j++)

{

fin >> sales[i][j];

}

}

for (i = 0; i < salesPersons; i++)

{

fout << salesPersonNames[i][2] << "\n";

totalSales = sales[i][0] + sales[i][1] + sales[i][2] + sales[i][3] + sales[i][4];

avgSales = (totalSales) / 5;

fout << totalSales << "\n";

fout << avgSales << "\n";

}

fout << "Grand Total sales of All salesPersons Each Week and Avg sales of All salesPersons Each Week" << "\n";

for (i = 0; i < weeks; i++)

{

totalSales = (sales[i][0] + sales[i][1] + sales[i][2]

+ sales[i][3] + sales[i][4] + sales[i][5] + sales[i][6] + sales[i][7]

+ sales[i][8] + sales[i][9]);

avgSales = (totalSales) / (5 * weeks);

fout << totalSales << "\n";

fout << avgSales << "\n";

fout << "**********************\n";

}

fout << " " << std::endl;

fout.close();

}
