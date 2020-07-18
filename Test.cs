using System;
using System.IO;

namespace CSharpEngine.Tests
{
    public class Test
    {
        public static void Main(string[] args){
            Node A = new Node("f")
                    .AddChild(new Node("d")
                        .AddChild(new Node("a"))
                        .AddChild(new Node("c")
                            .AddChild(new Node("b"))
                        )
                    ).AddChild(new Node("e"));

            Node B = new Node("f")
                    .AddChild(new Node("c")
                        .AddChild(new Node("d")
                            .AddChild(new Node("a"))
                            .AddChild(new Node("b"))
                        )
                    ).AddChild(new Node("e"));

            var shasha = new ZhangShaSha(A, B);
            Console.WriteLine("Distance is:" +shasha.simple_distance());
            var ops = shasha.simple_edit();

            foreach(var op in ops)
               Console.WriteLine("*****************" + op.ToString());
        }
    }
}


