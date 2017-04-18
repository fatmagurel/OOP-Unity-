#include<iostream>
using namespace std;
int k=0;

int main()
{
	int k;
	for(k=0;k<10;k++)
	{
		cout<<"Yerel Degisken   "<<k;
		cout<<"   Global Degisken   "<<::k<<endl;
	}
	::k++;
	cout<<endl;
	cout<<"Donguden sonra\n";
	cout<<"Yerel Degisken= "<<k<<"  Global Degisken= "<<::k<<endl;
	return 0;
}
