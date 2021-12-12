using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    //In a town, there are n people labeled from 1 to n.There is a rumor that one of these people is secretly the town judge.

    //If the town judge exists, then:

    //The town judge trusts nobody.
    //Everybody (except for the town judge) trusts the town judge.
    //There is exactly one person that satisfies properties 1 and 2.
    //You are given an array trust where trust[i] = [ai, bi] representing that the person labeled ai trusts the person labeled bi.

    //Return the label of the town judge if the town judge exists and can be identified, or return -1 otherwise.
    public class Q997EasyTownJudge
    {
        //value estimatted {[1,3],[2,4],[5,3],[4,3]} output estimated=3
        //value estimated {[1,3],[3,2],[2,1]} output = -1
        public static int FindJudge(int N_TownPeople, int[][] trust)
        {
            int[] count = new int[N_TownPeople + 1]; //create count array at stack
            //int[][] some = new int[5][] { new int[2] { 1, 2 }, new int[2] { 3, 2 }, new int[2] { 4, 2 }, new int[2] { 5, 2 }, new int[2] { 7, 2 } };
            //first time loop t= { 1, 2 } t[1]=-1 ,t[2]=1
            //second time loop t={ 3, 2 } t[3]=-1,t[2]=2
            //third time loop t={4,2} t[4]=-1, t[2]=3
            foreach (int[] t in trust)
            {
                count[t[0]]--;
                count[t[1]]++;
            }

            for (int i = 1; i <= N_TownPeople; i++)
            {
                if (count[i] == N_TownPeople - 1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
