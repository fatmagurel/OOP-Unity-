#include<iostream>
using namespace std;

struct Mat{
	int x,y;
	void operator++(){
		cout<<x<<","<<y<<endl;
		x++;y++;
	}
	void operator++(int){
		cout<<x<<","<<y<<endl;
		x++; y++;
	}
}m1;
int main()
{
	m1.x=5;
	m1.y=5;
	++m1;
	m1.x--;
	cout<<m1.x<<endl;
	++m1;
	m1++;
	m1.x++;
	cout<<m1.x<<endl;
	m1++;
	return 0;
}
