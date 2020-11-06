#include <iostream>
using namespace std;

int main()
{
	char package;
	int messages;
	int price;
	char choice;
	int save;
	int price2;
	
	do{
	cout << "Which package are you shopping for? (enter A, B, C)? " << endl;
	cin >> package;
	while(package != 'A' && package != 'a' && package != 'B' && package != 'b' && package != 'C' && package != 'c')
	{ 
		cout << "Invalid option enter A/B/C for package or message count. " << endl;
		cout << "Which package are you shopping for? (enter A, B, C)? " << endl;
		cin >> package;
	}
	cout << "How many message units(1 -672)?" << endl;
	cin >> messages;
	while(messages < 1 || messages > 672)
	{
		cout << "Invalid input enter a value 1-672" << endl;
		cout << "How many message units(1 -672)?" << endl;
		cin >> messages;
	}

	 switch (package) {
        case 'A': case 'a':
       	if(messages <= 20)
		{	
			price = 19.99;
		}
		else if(messages > 20)
		{
			price = (messages*.25)+ 19.99;	
		}
		cout<< "The charges are $" << price << endl;
		if (messages >= 100 && messages <=299)
		{
			price2 = (messages*.10)+ 39.99;
			save = price - price2;
			cout << "By switching to Package B you would save $" << save << endl;
		}
		if (messages > 299) 
		{
			save = price - 59.99;
			cout << "By switching to Package C you would save $" << save << endl;
		}
        break;
       
	   case 'B': case 'b': 
        if(messages <= 100)
		{	
			price = 39.99;
		}
		else if(messages > 100)
		{
			price = (messages*.10)+ 39.99;	
		}
		cout<< "The charges are $" << price << endl;
		if (messages >= 300)
		{
			save = price - 59.99;
			cout << "By switching to Package C you would save $" << save << endl;
		}
		if (messages = 20)
		{
			price2 = 19.99;
			save = price - price2;
			cout << "By switching to Package A you would save $" << save << endl;
		}
		else if (messages < 100 && messages > 21)
		{
			price2 = (messages*.25)+ 19.99;
			save = price - price2;
			cout << "By switching to Package A you would save $" << save << endl;
		}
		break;
        
		case 'C': case 'c': 	
		price = 59.99;
		cout<< "The charges are $" << price << endl;			
		if(messages = 100)
		{
			save = price - 39.99;
			cout << "By switching to Package B you would save $" << save << endl;	
		}
		else if(messages > 100 && messages <= 299)
		{
			price2 = (messages*.10)+ 39.99;
			save = price - price2;
			cout << "By switching to Package B you would save $" << save << endl;
		}	
		if (messages = 20)
		{
			price2 = 19.99;
			save = price - price2;
			cout << "By switching to Package A you would save $" << save << endl;
		}
		else if (messages < 100 && messages > 21)
		{
			price2 = (messages*.25)+ 19.99;
			save = price - price2;
			cout << "By switching to Package A you would save $" << save << endl;
		}
		break;
		}
    
	cout << "Continue with new quote Y or N" << endl;
	cin >> choice;
	} while (choice == 'Y' || choice == 'y'); 
		cout << "Program ended." << endl;
    	return 0;
}
