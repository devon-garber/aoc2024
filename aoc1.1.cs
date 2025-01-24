﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AocDay1._1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            foreach (string s in System.IO.File.ReadLines("input1.1.txt"))
            {
                string[] both = s.Split("   ");
                left.Add(Int32.Parse(both[0]));
                right.Add(Int32.Parse(both[1]));
            }

            if (left.Count != right.Count)
            {
                throw new InvalidDataException("Not good yo");
            }

            left.Sort();
            right.Sort();
            int totalDistance = 0;
            for (int i = 0; i < left.Count; ++i)
            {
                totalDistance += Math.Abs(left[i] - right[i]);
            }
            Console.WriteLine(totalDistance);
        }
    }
}