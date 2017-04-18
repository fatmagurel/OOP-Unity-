#include<iostream>
using namespace std;

class Dortgen{
	public:
		int x,y,gen,yuk;
	void DegerVer(int,int,int,int);
	int Alan();
	Dortgen *Buyuk(Dortgen &nesne);
};

void Dortgen::DegerVer(int a, int b, int c, int d)
{
	x=a;
	y=b;
	gen=c;
	yuk=d;
}

int Dortgen::Alan()
{
	return gen*yuk;
}

Dortgen *Dortgen::Buyuk(Dortgen &nesne)
{
	int alan1,alan2;
	alan1=yuk*gen;
	alan2=nesne.yuk*nesne.gen;
	if(alan1>alan2)
	return this;
	else
	return &nesne;
}

int main()
{
	Dortgen D1,D2;
	Dortgen *D3=new Dortgen;
	D1.DegerVer(3,4,7,9);
	D2.DegerVer(7,2,65,60);
	cout<<"Alan1: "<<D1.Alan()<<endl<<"Alan2: "<<D2.Alan()<<endl;
	D3=D2.Buyuk(D1);
	cout<<"x= "<<D3->x<<endl<<"y= "<<D3->y<<endl<<"Alan3: "<<D3->Alan();
	delete D3;
	return 0;
}
