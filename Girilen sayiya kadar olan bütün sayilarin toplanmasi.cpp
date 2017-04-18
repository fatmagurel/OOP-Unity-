#include<iostream>
using namespace std;
int main()
{
	int x,toplam=0;
	cout<<"Bir sayi giriniz:\n(Girdiginiz sayiya kadar butun sayilar toplanacak!):";
	cin>>x;
	for(int i=0;i<=x;i++)
	{
	toplam+=i;
	}
	cout<<"Toplam:"<<toplam<<endl;
	return 0;
}
