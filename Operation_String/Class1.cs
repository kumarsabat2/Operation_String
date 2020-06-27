using System;
using System.Collections.Generic;
using System.Linq;
using System.Activities;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Operation_String
{
    public class Split : CodeActivity
    {
        [Category("Input")]
        [RequiredArgument]
        public InArgument<string> Main_String { get; set; }

        [Category("Input")]
        [RequiredArgument]
        public InArgument<string> Separator { get; set; }


    }
}
