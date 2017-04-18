#include<iostream>
#include<stdlib.h>
#include<time.h>
using namespace std;
int main()
{
	int k;
	srand(time(0));
	for(k=0;k<10;k++)
	cout<<rand()<<endl;
	return 0;
}
