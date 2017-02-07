using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Surya.Learning.OOPTesting.MultipleInheritance.Interfaces;

namespace Surya.Learning.OOPTesting.MultipleInheritance.Models
    {
    class SomeThing : IMammal, IResource
        {
        public void Move ()
            {
            Console.WriteLine ("SomeThing is moving!");
            }

        void IMammal.Move ()
            {
            Console.WriteLine ("Some Mammal is moving!");
            }

        void IResource.Move ()
            {
            Console.WriteLine ("Some Resource is moving!");
            }
        }
    }
