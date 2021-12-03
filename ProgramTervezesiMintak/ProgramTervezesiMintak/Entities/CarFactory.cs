using ProgramTervezesiMintak.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramTervezesiMintak.Entities
{
    class CarFactory :  IToyFactory
    {
        public Toy CreateNew()
        {
            return new Car();
        }
    }
}
