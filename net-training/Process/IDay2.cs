using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_training.Process
{
   public interface IDay2
    {
        int sum(int a, int b);
        int minus(int a, int b);
        int multi(int a, int b);
        float sub(int a, int b);
        int max(int[] nums);
        int min(int[] nums);
        int[] sortAsc(int[] arr);
        int[] sortDesc(int[] arr);
    }
}
