#include<iostream>
using namespace std;

class sinifA{
	private:
		int ax,by;
	public:
		sinifA(int a,int b)
		{
			ax=a;
			by=b;
		}
		int size()
		{
			cout<<"ax*by"<<endl;
		}
		friend class sinifB;
};
class sinifB{
	int bx,by,bz;
	public:
		void size(sinifA n)
		{
			bx=n.ax;
			by=n.by;
			bz=2;
			cout<<bx*by*bz<<endl;
		}
};
int main()
{
	sinifA nesneA(5,2);
	nesneA.size();
	sinifB nesneB;
	nesneB.size(nesneA);
	return 0;
}
