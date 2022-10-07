#include<iostream>
using namespace std;
main()
{
    int size=0;
    cout<<"Enter the Array size : ";
    cin >> size;
    int array[size];
    for(int x=0;x< size;x++)
    {
        cout <<"Enter the Element : ";
        cin>> array[x];
    }
    bool flag= false;
    int step=0;
    int count=0;
    for(int x=0;x<size;)
    {
        step=x;
        x=x+array[x];
        if(step == x)
        {
            flag=true;
            break;
        }
        count++;
    }
    if(!flag)
    {
        cout<<++count;
    }
    else
    {
            cout<<"No Chance";
    }

}