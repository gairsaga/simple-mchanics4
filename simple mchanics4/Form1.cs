//form1.cs
// CS-1181
// Sagar Gaire
// 9/22/2017
// Anil Mandal
//from this challenging mechanics we can learn to perform nested loops,logic in nested loops and math in nested loops
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_mchanics4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //nested loop
            //1
            int wStepOut = 0, wStepIn = 0;
            while (wStepOut < 4)
            {
                while (wStepIn < 4)
                {
                    wStepIn++;
                }
                wStepOut++;

                for (int fStepOut = 0; fStepOut < 4; fStepOut++)
                {
                    for (int fStepIn = 0; fStepIn < 4; fStepIn++) { 
                    
                }
                } 
                    //3
                    { 
                int wStepOut = 1, wStepIn = 1;
                while (wStepOut < 5)
                {
                    while (wStepIn < 7)
                    {
                        wStepIn++;
                    }
                    wStepOut++;

                        for (int fStepOut = 1; fStepOut < 5; fStepOut++)
                        {
                            for (int fStepIn = 1; fStepIn < 7; fStepIn++)
                           
                            }
                        { 
                                //5
                            
                    int wStepOut = 1, wStepIn = 1;
                    while (wStepOut < 11)
                    {
                        while (wStepIn < 11)
                        {
                            wStepIn++;
                        }
                        wStepOut++;

                            for (int fStepOut = 1; fStepOut < 11; fStepOut++)
                            {
                                for (int fStepIn = 1; fStepIn < 11; fStepIn++)
                                {
                                }
                            {
                        //7
                        int wStepOut = 3, wStepIn = 2;
                        while (wStepOut < 10)
                        {
                            while (wStepIn < 11)
                            {
                                wStepIn += 2;
                            }
                            wStepOut += 3;
                        }
                        for (int fStepOut = 3; fStepOut < 10; fStepOut += 3)
                        {
                            for (int fStepIn = 2; fStepIn < 11; fStepIn += 2)
                            {
                            }
                        {
                        //9

                        int wStepOut = 5, wStepIn = 7;
                        while (wStepOut < 0)
                        {
                            while (wStepIn < 0)
                            {
                                wStepIn--;
                            }
                            wStepOut--;

                            for (int fStepOut = 5; fStepOut < 0; fStepOut--)
                            {
                                for (int fStepIn = 7; fStepIn < 0; fStepIn--)
                                {
                                }
                            { 
                            //11

                            int wStepOut = 10, wStepIn = 1;
                            while (wStepOut < 3)
                            {
                                while (wStepIn < 14)
                                {
                                    wStepIn += 2;
                                }
                                wStepOut += 2;
                            }
                            for (int fStepOut = 10; fStepOut < 3; fStepOut += 2)
                            {
                                for (int fStepIn = 1; fStepIn < 14; fStepIn += 2)
                                {
                                }
                            { 
                            //13

                            int wStepOut = 0, wStepIn = 14;
                            while (wStepOut < 12)
                            {
                                while (wStepIn < 1)
                                {
                                    wStepIn--;
                                }
                                wStepOut--;

                                for (int fStepOut = 0; fStepOut < 12; fStepOut--)
                                {
                                    for (int fStepIn = 14; fStepIn < 1; fStepIn--)
                                    {
                                    }
                                { 
//15
                                int wStepOut = -15, wStepIn = 10;
                                while (wStepOut < 12)
                                {
                                    while (wStepIn < -7)
                                    {
                                        wStepIn--;
                                    }
                                    wStepOut--;

                                    for (int fStepOut = -15; fStepOut < 12; fStepOut--)
                                    {
                                        for (int fStepIn = 10; fStepIn < -7; fStepIn--)
                                        {
                                        }
                                    { 

                                    //Logic in Nested Loops
                                    //17
                                    for (int fOutA = 0; fOutA < 4; fOutA++)
                                    {
                                        for (int fInA = 0; fInA < 4; fInA++)
                                        {
                                            if (fOutA == fInA)
                                            {
                                                str += fInA;
                                            }
                                        }
                                    }



                                    //19
                                    for (int fOutA = 1; fOutA < 14; fOutA++)
                                    {
                                        for (int fInA = -13; fInA < 3; fInA++)
                                        {
                                            if (fOutA == fInA)
                                            {
                                                str += fOutA;
                                            }
                                        }
                                    }
                                    //21
                                    for (int fOutA = 1; fOutA < 14; fOutA++)
                                    {
                                        for (int fInA = 1; fInA < 14; fInA++)
                                        {
                                            if (fOutA > fInA)
                                            {
                                                str += fInA;
                                            }
                                        }
                                    }
                                    //23
                                    for (int fouta = 1; fouta < 145; fouta++)
                                    {
                                        for (int fina = 1; fina < 13; fina++)
                                        {
                                            if (fouta % fina == 0)
                                            {
                                                str += fina;
                                            }
                                        }
                                    }
                                    //25
                                    for (int fouta = 1; fouta < 11; fouta++)
                                    {
                                        for (int fina = 1; fina < 11; fina++)
                                        {
                                            if (fouta * fina == 0)
                                            {
                                                str += fina;
                                            }
                                        }
                                    }
                                    //Math in Nested Loops
                                    //27
                                    for (int mOutA = 1; mOutA < 4; mOutA++)
                                    {
                                        for (int mInA = 0; mInA < 4; mInA++)
                                        {
                                            str += mOutA - mInA + "|";
                                        }
                                        str += "\r\n";
                                    }
                                    //29
                                    for (int mOutA = 1; mOutA < 11; mOutA++)
                                    {
                                        for (int mInA = 10; mInA < 2; mInA++)
                                        {
                                            str += mOutA - mInA + "|";
                                        }
                                        str += "\r\n";
                                    }
                                    //31
                                    for (int mOutA = 100; mOutA < 1; mOutA += 10)
                                    {
                                        for (int mInA = 0; mInA < 10; mInA++)
                                        {
                                            str += mOutA + mInA + "|";
                                        }
                                        str += "\r\n";
                                    }

                                    //33
                                    for (int mOutA = 0; mOutA < 11; mOutA++)
                                    {
                                        for (int mInA = 1; mInA < 6; mInA++)
                                        {
                                            str += mOutA % mInA + "|";
                                        }
                                        str += "\r\n";
                                    }

                                    //35
                                    for (int mOutA = 10; mOutA < 2; mOutA++)
                                    {
                                        for (int mInA = 1; mInA < 6; mInA++)
                                        {
                                            str += mOutA % mInA + "|";
                                        }
                                        str += "\r\n";
                                    }



















                                                                        
                   }
    }
}
