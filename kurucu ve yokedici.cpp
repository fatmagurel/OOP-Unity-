#include<iostream>
using namespace std;

class Dortgen{
	private:
		
		int *x,*y,*gen,*yuk;
	public:
		Dortgen();
		Dortgen(int,int,int,int);
		~Dortgen();
		void DegerVer(int,int,int,int);
		int Alan();
};

Dortgen::Dortgen()
{
	x=new int;
	y=new int;
	gen=new int;
	yuk=new int;
	*x=5;
	*y=10;
	*gen=12;
	*yuk=5;
	cout<<"Parametresiz kurucu calisti"<<endl;
}

Dortgen::Dortgen(int a, int b, int c, int d)
{
	x=new int;
	y=new int;
	gen=new int;
	yuk=new int;
	*x=a;
	*y=b;
	*gen=c;
	*yuk=d;
	cout<<"Parametreli kurucu calisti"<<endl;
}

Dortgen::~Dortgen()
{
	delete x,y,gen,yuk;
	cout<<"Yok edici calisti"<<endl;
}

void Dortgen::DegerVer(int e, int f, int g, int h)
{
	*x=e;
	*y=f;
	*gen=g;
	*yuk=h;
}

int Dortgen::Alan()
{
	return *gen*(*yuk);
}

int main()
{
	Dortgen D1,D2(3,4,9,5);
	Dortgen *D3=new Dortgen;
	D1.DegerVer(3,4,6,7);
	D2.DegerVer(2,9,8,3);
	D3->DegerVer(5,5,12,3);
	cout<<"Alan1: "<<D1.Alan()<<endl<<"Alan2: "<<D2.Alan()<<endl<<"Alan3: "<<D3->Alan()<<endl;
	delete D3;
	return 0;
}
