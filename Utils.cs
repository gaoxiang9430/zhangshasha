using System.Collections.Generic;
using System.Linq;

namespace CSharpEngine {

    public class Record<T1, T2>{

        public T1 Item1;
        public T2 Item2;
        public Record(T1 item1, T2 item2){
            this.Item1 = item1;
            this.Item2 = item2;
        }
    }

    public class Record<T1, T2, T3>{

        public T1 Item1;
        public T2 Item2;
        public T3 Item3;
        public Record(T1 item1, T2 item2, T3 item3){
            this.Item1 = item1;
            this.Item2 = item2;
            this.Item3 = item3;
        }
    }

}

