#include<iostream>
using namespace std;
int main()
{
	int x;
	cout<<"Bir sayi giriniz:";
	cin>>x;
	switch(x)
	{
		case 5:
			cout<<"Sayi 5 tir."<<endl;
			break;
		case 1:
			cout<<"Sayi 1 dir."<<endl;
			break;
		default:
			cout<<"Sayi 5 ya da 1 degildir..";
		return 0;
			
	}
}
