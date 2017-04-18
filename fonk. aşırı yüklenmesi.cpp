#include<iostream>
using namespace std;
void yaz(char);
void yaz();
void yaz(char,int);

int main()
{
	yaz('F');
	yaz();
	yaz('G', 41);
}

void yaz(char ch)
{
	for(int i=0;i<43;i++)
	cout<<ch;
	cout<<endl;
}

void yaz()
{
	for(int j=0;j<25;j++)
	cout<<"*";
	cout<<endl;
}

void yaz(char ch, int n)
{
	for(int k=0;k<n;k++)
	cout<<ch;
	cout<<endl;
}
