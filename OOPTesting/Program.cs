using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Surya.Learning.OOPTesting.MultipleInheritance.Interfaces;
using Surya.Learning.OOPTesting.MultipleInheritance.Models;
using Surya.Learning.Strings;

namespace Surya.Learning.OOPTesting
    {
    class Program
        {
        static void Main (string[] args)
            {
            SomeThing aThing = new SomeThing ();
            aThing.Move ();
            IMammal mammal = (IMammal)aThing;
            mammal.Move ();
            IResource resource = (IResource)aThing;
            resource.Move ();

			// String reverse test
            Console.WriteLine ("Enter a string to reverse: ");
            String inputString = Console.ReadLine ();
            Console.WriteLine (StringHelper.Reverse (inputString));
            }
        }
    }
