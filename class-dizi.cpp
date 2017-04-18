#include<iostream>
using namespace std;

class Dortgen{
	public:
		int x,y;
		void DegerVer(int, int);
		int Alan()
		{
			return x*y;
		}
};

void Dortgen::DegerVer(int a, int b)
{
	x=a;
	y=b;
}

int main()
{
	Dortgen D1[10];
	D1[0].x=6;
	D1[0].y=8;
	D1[1].DegerVer(7,3);
	D1[2].DegerVer(5,6);
	cout<<"Alan1: "<<D1[0].Alan()<<endl;
	cout<<"Alan2: "<<D1[1].Alan()<<endl;
	cout<<"Alan3: "<<D1[2].Alan()<<endl;
	return 0;
}
