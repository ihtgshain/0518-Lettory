using System;
using System.Collections.Generic;
using System.Text;

namespace prjLettoryApp.model
{
    internal class Lottery
    {
        private int[] _nums = new int[6];
        private bool _sorted = false;
        Random rd = new Random();

        public bool isSorted{get=>_sorted;}
        public int len { get => _nums.Length; }

        public Lottery()
        {
            for(int i = 0; i < _nums.Length; i++)
            {
                int temp = rd.Next(1, 50);
                if (Array.IndexOf(_nums, temp) == -1)
                    _nums[i] = temp;
                else
                    i--;
            }
        }

        public string this [int index]
        {
            get
            {
                if (index >= 0 && index < _nums.Length)
                {
                    int result = _nums[index];
                    return result < 10 ? $"0{result}" : $"{result}";
                }
                else return "";
            }
        }

        public void BubbleSort()
        {
            if (_sorted)    return;

            for (int i = 0; i < _nums.Length; i++)
            {
                for (int j = i + 1; j < _nums.Length; j++)
                {
                    if (_nums[i] > _nums[j])
                    {
                        int big = _nums[i];
                        _nums[i] = _nums[j];
                        _nums[j] = big;
                    }
                }
            }
            _sorted = true;
        }
    }
}
