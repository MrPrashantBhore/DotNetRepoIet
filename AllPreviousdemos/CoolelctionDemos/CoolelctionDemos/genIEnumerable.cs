using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolelctionDemos
{
    //genericIenumerable
    //exposes iterator that facilitates iteration over a colelction. read only
    public class EmployeeCollection<T> : IEnumerable<T>
    {
        List<T> empList = new List<T>();

        public void AddEmployee(T e)
        {
            empList.Add(e);
        }

        public T GetEmployee(int index)
        {
            return empList[index];
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        //Compile time Error

        public void PrintEmployeeData(int index)
        {
            Console.WriteLine(empList[index]);
        }
        public override string ToString()
        {
            return base.ToString();
        }


        //foreach support
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
             return empList.GetEnumerator();
        }
       // IEnumerator IEnumerable.GetEnumerator()
       // {
       //     return empList.GetEnumerator();
       //}

    }


}
