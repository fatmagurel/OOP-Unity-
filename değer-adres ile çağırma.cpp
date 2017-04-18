#include<iostream>
using namespace std;
void degistir(int x, int y)
{
	int gecici;
	gecici=x;
	x=y;
	y=gecici;
}
void degistir1(int *x, int *y)
{
	int gecici;
	gecici=*x;
	*x=*y;
	*y=gecici;
}
int main()
{
	int a, b;
	a=12;
	b=27;
	cout<<"fonk once a :"<<a<<" b:"<<b<<endl;
	degistir(a,b);
	cout<<"fonk dan sonra a:"<<a<<" b:"<<b<<endl;
	cout<<"fon dan once a:"<<a<<" b:"<<b<<endl;
	degistir1(&a,&b);
	cout<<"fonk dan sonra a:"<<a<<" b:"<<b<<endl;
	return 0;
}
