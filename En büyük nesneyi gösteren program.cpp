#include<iostream>
using namespace std;

class sinif{
	private:
		int a,b;
	public:
		sinif(int x,int y)
		{
			a=x;
			b=y;
		}
		int size()
		{
			return a*b;
		}
		void compare(sinif n1, sinif n2)
		{
			if(n1.size()>n2.size())
			{
				cout<<"Ilk nesne buyuk"<<n1.size()<<endl;
				cout<<n1.a<<","<<n1.b<<endl;
			}
			else
			cout<<"Ikýncý nesne buyuk"<<n2.size()<<endl;
			cout<<n2.a<<","<<n2.b<<endl;
		}
	
};

int main()
{
	sinif nesne1(12,20);
	sinif nesne2(10,5);
	nesne1.compare(nesne1, nesne2);
	return 0;
}
