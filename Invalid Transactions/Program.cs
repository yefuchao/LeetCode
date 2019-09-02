using System;
using System.Collections.Generic;

namespace Invalid_Transactions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var r = InvalidTransactions(new string[] { "bob,627,1973,amsterdam", "alex,387,885,bangkok", "alex,355,1029,barcelona",
               "alex,587,402,bangkok", "chalicefy,973,830,barcelona", "alex,932,86,bangkok", "bob,188,989,amsterdam" });

            //["bob,689,1910,barcelona","bob,832,1726,barcelona","bob,820,596,bangkok"]
            Console.ReadKey();
        }

        public static IList<string> InvalidTransactions(string[] transactions)
        {
            var list = new List<string>();

            var dic = new Dictionary<string, IList<string>>();

            foreach (var tran in transactions)
            {
                var arr = tran.Split(',');

                var name = arr[0];
                var time = int.Parse(arr[1]);
                var amount = int.Parse(arr[2]);
                var area = arr[3];

                //金额超过
                if (amount > 1000)
                {
                    list.Add(tran);

                }

                if (dic.ContainsKey(name))
                {
                    //判断时间
                    var exits = dic[name];

                    foreach (var item in exits)
                    {
                        var arrs = item.Split(',');

                        var subtime = int.Parse(arrs[1]);

                        var subarea = arrs[3];

                        //60分钟内，不同城市发生交易无效

                        if (Math.Abs(time - subtime) <= 60 && area != subarea)
                        {
                            if (!list.Contains(tran))
                            {
                                list.Add(tran);
                            }
                            if (!list.Contains(item))
                            {
                                list.Add(item);
                            }
                        }
                    }

                }


                if (dic.ContainsKey(name))
                {
                    dic[name].Add(tran);
                }
                else
                {
                    dic.Add(name, new List<string> { tran });
                }
            }


            return list;
        }
    }
}
