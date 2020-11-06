
#include <map>

#include <iterator>

#include <iostream>

#include <fstream>

#include <string>


using namespace ::std;

string fileRead()

{

cout << "Enter outfile name:" << endl;

string infileName;

cin >> infileName;

return infileName;

}

int main()

{

string inputFile = "TheSales.txt";

string outputFile = fileRead();

ifstream fin(inputFile.c_str(), std::ios_base::in);

if (!fin.is_open())

{

cout << "Error opening file: " << inputFile << endl;

return 1;

}

ofstream fout (outputFile.c_str());

if (!fout.is_open())

{

cout << "Error opening file: " << outputFile << endl;

return 1;

}

ifstream infile;

ifstream readfile;

int weeks, salesmen, i, j, k, l, m, n;

double totalSalesAll, avgSalesAll;

fin >> salesmen;

fin >> weeks;

double sales[salesmen][weeks][weeks * 5];

string salesName[salesmen][3];

double totalSales[salesmen][weeks],avgSales[salesmen][weeks];

fout << "Number of Sales People: " << salesmen << endl;

fout << "Number of Weeks: " << weeks << endl;

for (i = 0; i < salesmen; i++)

{

fin >> salesName[i][0] >> salesName[i][1] >> salesName[i][2];

for (j = 0; j < weeks; j++)
{
for (k = 0; k < 5; k++)
{

fin >> sales[i][j][k];

}

}

}
for (l = 0; l < salesmen; l++)

{

fout << "  " << salesName[l][2] << endl;

for (m = 0; m < weeks; m++)
{
totalSales[l][m] = sales[l][m][0] + sales[l][m][1] + sales[l][m][2] + sales[l][m][3] + sales[l][m][4];

avgSales[l][m] = (totalSales[l][m]) / 5;

fout << "Week: " << (m + 1) << endl;

fout << "Total Sale: " << totalSales[l][m] << endl;

fout << "Average Sale: " << avgSales[l][m] << "\n" << endl;

}

}

for (i = 0; i < weeks + 1; i++)

{

for (n = 0; n < weeks; n++)

{

totalSalesAll += totalSales[i][n];

avgSalesAll = (totalSalesAll) / (weeks * salesmen);

}

}

fout << "Total Company Sales: " << totalSalesAll << endl;

fout << "Total Average Sales: " << avgSalesAll << endl;

fout.close();

}
