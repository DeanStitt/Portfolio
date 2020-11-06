#include<iostream>
#include<iomanip>
using namespace std;

double hat(double height, double weight);

double jacket(double height, double weight, int age);

double waist(double weight, int age);

int main() 
{        
	char choice;
	int age;
	int height;
	int weight;

cout.setf(ios::fixed);
cout.setf(ios::showpoint);
cout.precision(2);

do {
	cout << "Enter me your height in inches, weight in pounds, and age in years and I will give you your hat size, jacket size(inches at chest) and your waist size in inches.\n" << endl;
	
	cin >> height >> weight >> age;

	cout << endl << "hat size =\n" <<  hat(height, weight) << endl;
	
	cout << "jacket size =\n" << jacket(height, weight, age) << endl;
	
 	cout << "waist in inches =\n" << waist(weight, age) << endl;
 	
	
	cout << "Enter Y or y to repeat, any other character ends: \n" << endl;
	cin >> choice;
} while (choice == 'Y' || choice == 'y'); 
	cout << endl << "Program ended." << endl;
    return 0;
}

double hat(double height, double weight)// height in inches, weight in pounds
{
 	double hat;	

	hat = ((weight/height) * 2.9);//calculate hat
return (hat);
}

double jacket(double height, double weight, int age)
{
	double jacket;
	
	jacket = ((height*weight)/288);//calculate jacket
	
        for(double i=40;i<=age;i=i+10)//loop for over 40
        {
        jacket += 0.125;
        }
return (jacket);
}

double waist(double weight, int age)
{
	double waist;
	
	waist = (weight/5.7);// calculate waist
	
	for(double i=30;i<=age;i+=2)//loop for over 30
	{
	waist += .1;
	}
return (waist);
}
