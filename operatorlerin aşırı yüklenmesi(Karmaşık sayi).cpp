#include<iostream>
using namespace std;

struct KarmasikSayi{
	float reel,sanal;
};

KarmasikSayi operator+ (KarmasikSayi &n1, KarmasikSayi &n2)
{
	KarmasikSayi sonuc;
	sonuc.reel=n1.reel+n2.reel;
	sonuc.sanal=n1.sanal+n2.sanal;
	return sonuc;
}

void yaz(KarmasikSayi c)
{
	cout<<"reel= "<<c.reel<<" sanal= "<<c.sanal<<endl;
}

int main()
{
	KarmasikSayi c1,c2,c3;
	c1.reel=3;
	c1.sanal=-1;
	c2.reel=2.5;
	c2.sanal=0.7;
	c3=c1+c2;
	yaz(c3);
}
