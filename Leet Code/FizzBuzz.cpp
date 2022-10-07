#include<iostream>
using namespace std;
main()
{
    int x=0;
    cout<<"Enter any number : ";
    cin >> x;
    if(x%3==0 && x%5==0)
    {
        cout<<"FizzBuzz";
    }
    else if(x%3==0)
    {
        cout<<"Fizz";
    }
    else if(x%5==0)
    {
        cout<<"Buzz";
    }
    else
    {
        cout<<"..."
    }
}