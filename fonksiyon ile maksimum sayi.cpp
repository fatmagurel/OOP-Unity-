#include<iostream>
using namespace std;
int maksimum(int, int, int);
int main()
{
	int x,y,z;
	cout<<"3 tamsayi giriniz:"<<endl;
	cin>>x>>y>>z;
	cout<<"En buyuk sayi:"<<maksimum(x,y,z)<<"'dir."<<endl;
	return 0;
}
int maksimum(int a, int b, int c)
{
	int maks=a;
	if(b>maks)
	maks=b;
	if(c>maks)
	maks=c;
	return maks;
}
