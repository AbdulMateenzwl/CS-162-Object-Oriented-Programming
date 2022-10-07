#include <iostream>
#include<string>
using  namespace std;
main()
{
    int num=0,count=0;
    cout<<"Enter any number";
    cin >> num;
    for (int i = num; i!=0; i=i/10)
    {
        count++;
    }
    int count1=1;
    string str=to_string(num);
    string ans="";
    string gh="";
    string hg="";
    for(int x=0;x!=str.length();x++)
    {
        count1=1;
        for (int i = 0; i < str.length(); i++)
        {
            int lgth=count1;
            if(str[x]==str[x+1])
            {
                count1++;
                x++;
            }
            if(lgth==count1)
            {
                gh=str[x];
                hg=to_string(count1);
                ans=ans+hg + gh;
                break;
            }
        }
    }
    cout<<ans;
}
