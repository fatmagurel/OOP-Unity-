#include<iostream>
using namespace std;
int OrtalamaHesapla(int vize, int final)
{
	float ortalama;
	ortalama=0.4*vize+0.6*final;
	cout<<"Ortalama:"<<ortalama<<endl;	
	return ortalama;
}
int main()
{
	int vize,final,i,ortalama;
	cout<<"Kac not gireceksiniz:";
	cin>>i;
	for(int j=0;j<i;j++)
	{
	cout<<"Vize notunu giriniz:";
	cin>>vize;
	cout<<"Final notunu giriniz:";
	cin>>final;
	ortalama=OrtalamaHesapla(vize,final);
	if(ortalama<=60)
	cout<<"Kaldiniz!"<<endl;
	if(ortalama>60)
	cout<<"Gectiniz..."<<endl;
	}
	return 0;
}
