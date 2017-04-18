#include<iostream>
using namespace std;

int main()
{
	int i,n;
	int *p;
	cout<<"Kac sayi gireceksiniz: ";
	cin>>i;
	p=new int[i];
	if(p==0)
	cout<<"Hata! Bellekten yer ayrilmadi...";
	else
	{
	
		for(n=0;n<i;n++)
			{
				cout<<"Sayi gir: ";
				cin>>p[n];
			}
		cout<<"Girdiginiz sayilar: ";
		for(n=0;n<i;n++)
		cout<<p[n]<<",";
		delete[]p;
	}
	return 0;
}
