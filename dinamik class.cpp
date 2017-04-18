#include<iostream>
using namespace std;

class Dortgen{
	int x,y;
	public:
		void DegerVer(int, int);
		int Alan();
};

void Dortgen::DegerVer(int a, int b)
{
	x=a;
	y=b;
}

int Dortgen::Alan()
{
	return x*y;
}

int main()
{
	Dortgen *D1=new Dortgen;
	Dortgen *D2=new Dortgen;
	
	D1->DegerVer(3,4);
	D2->DegerVer(5,8);
	cout<<"Alan1: "<<D1->Alan()<<endl;
	cout<<"Alan2: "<<D2->Alan()<<endl;
	delete D1,D2;
	return 0;
	
}
