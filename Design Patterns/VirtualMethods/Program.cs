namespace VirtualMethods
{
    internal class Program
    {
        #region Example1

        class Object
        {
            public string Name { get; set; }
            public Object(string name)
            {
                Name = name;
            }
            public virtual void Move()
            {
                Console.WriteLine(Name);
            }
        }

        class Human : Object
        {
            public int Age { get; set; }

            public Human(int age, string name) : base(name)
            {
                Age = age;
            }
            public override void Move()
            {
                Console.WriteLine(Name + Age);
            }
        }


        class WorkerHuman : Human
        {
            public decimal WorkingPrice { get; set; }
            public Action WorkAction { get; set; }
            public WorkerHuman(Action workAction, int age, string name) : base(age, name)
            {
                WorkAction = workAction;
                WorkingPrice = 5000;
            }

            public void Work()
            {
                WorkAction.Invoke();
            }

            public override void Move()
            {
                Console.WriteLine(Name + Age + WorkingPrice);
            }

        }
        static void InvokeMoveMethods(List<Object> objects)
        {
            foreach (var o in objects)
            {
                o.Move();
            }
        }


        #endregion

        #region Example2

        public class class1
        {
            public virtual string DoSomething()
            {
                return nameof(class1);
            }
        }

        public class class2 : class1
        {
            public override string DoSomething()
            {
                return nameof(class2);
            }
        }

        public class class3 : class2
        {
            public new string DoSomething()
            {
                return nameof(class3);
            }
        }

        #endregion

        static void Main(string[] args)
        {
            #region Example1

            //Object o1 = new Object("Object");
            //Human o2 = new Human(18, "Human");
            //WorkerHuman o3 = new WorkerHuman(() => { Console.WriteLine("Work"); }, 20, "Worker");

            //List<Object> objects = [o1, o2, o3];

            //InvokeMoveMethods(objects);
            #endregion

            #region Example2

            /* 
            If the type of the variable is either class2 or class1 the output will be "class2"
            This is because Class2 is the first parent that implements the method. 
            For example, if Class2 does not override the method, the output will be 'Class1.'" 
            */
            class1 c = new class3(); 
            Console.Write(c.DoSomething()); 
            #endregion

        }
    }
}
