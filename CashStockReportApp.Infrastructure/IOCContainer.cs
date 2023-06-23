using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashStockReportApp.Infrastructure
{
    public class IOCContainer
    {
        private static readonly Dictionary<Type, Func<object>> container = new Dictionary<Type, Func<object>>();

        //Resolve

        public static T Resolve<T> ()
        {
            return (T)container[typeof(T)]();
        }

        public static void Register<T>(Func<object> func)
        {
            if (container.ContainsKey(typeof(T)))
                container.Remove(typeof(T));

            container.Add(typeof(T), func);
        }



    }
}
