using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillEditor.Modele_xD
{
    public class UserFormCreateSkocznias
    {
        public InRun inRunMarks { get; set; }
    }

    public class InRun
    {
        public List<string> Profile { get; set; }
        public List<string> track { get; set; }
        public List<string> guardrail { get; set; }
        //...
        //Tu reszte tej klaski
    }
}
