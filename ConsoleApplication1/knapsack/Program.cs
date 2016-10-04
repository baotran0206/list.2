using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knapsack
{
    public class Program
    {
       public static void Main(string[] args)
        {

             int N = Int.parseInt(args[0]); 
    int W = Int.parseInt(args[1]); 

    int[] profit = new int[N + 1];
    int[] weight = new int[N + 1];

   
    for (int n = 1; n <= N; n++) {
        profit[n] = (int) (Math.random() * 1000);
        weight[n] = (int) (Math.random() * W);
    }
    int[][] opt = new int[N + 1][W + 1];
    Boolean[][] sol = new Boolean[N + 1][W + 1];

    for (int n = 1; n <= N; n++) {
        for (int w = 1; w <= W; w++) {

          
            int option1 = opt[n - 1][w];

       
            int option2 = Int.MIN_Giatri;
            if (weight[n] <= w)
                option2 = profit[n] + opt[n - 1][w - weight[n]];

        
            opt[n][w] = Math.max(option1, option2);
            sol[n][w] = (option2 > option1);
        }
    }


    Boolean[] take = new Boolean[N + 1];
    for (int n = N, w = W; n > 0; n--) {
        if (sol[n][w]) {
            take[n] = true;
            w = w - weight[n];
        } else {
            take[n] = false;
        }
    }
   Console.Write("item" + "\t" + "profit" + "\t" + "weight" + "\t"
            + "take");
    for (int n = 1; n <= N; n++) {
     Console.Write(n + "\t" + profit[n] + "\t" + weight[n] + "\t"
                + take[n]);
    }
        }
    }
}
