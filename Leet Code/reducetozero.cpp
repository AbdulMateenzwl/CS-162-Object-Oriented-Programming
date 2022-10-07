#include<iostream>
using namespace std;
main()
{
    int x;
    int count=0;
    cout<<"Enter the number";
    cin >> x;
    while(x!=0)
    {
        if(x%2==0)
        {
            x=x/2;
        }
        else
        {
            x--;
        }
        count++;
    }
    cout<<count;
}