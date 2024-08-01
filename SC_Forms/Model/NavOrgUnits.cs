using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC_Forms
{
    internal class NavOrgUnits
    {
        public List<OrgUnit> RootNodes { get; set; }
        public List<OrgUnit> SelfNodes { get; set; }
        public List<OrgUnit> ChildNodes { get; set; }

        //public NavOrgUnits()
        //{
        //    RootNodes = new List<OrgUnit>();
        //    SelfNodes = new List<OrgUnit>();
        //    ChildNodes = new List<OrgUnit>();
        //}
    }
}
