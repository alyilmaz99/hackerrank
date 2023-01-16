using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'hanoi' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY posts as parameter.
     */

    public static int hanoi(List<int> posts)
    {
        int counter =0; 
        int catcher = 0;
        
        for(int i =0 ; i< posts.Count ; i++){
            if(posts[i]<=posts[i+1] && i< posts.Count +1){
                catcher = posts[i];
                posts[i] = posts[i+1];
                counter++;
            }else if(posts[i]<=posts[i+2] && i < posts.Count+2){
                catcher = posts[i];
                posts[i] = posts[i+2];
                counter++;
                }
        }
        return counter;
    }  
}


class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> loc = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(locTemp => Convert.ToInt32(locTemp)).ToList();

        int res = Result.hanoi(loc);

        textWriter.WriteLine(res);

        textWriter.Flush();
        textWriter.Close();
    }
}
