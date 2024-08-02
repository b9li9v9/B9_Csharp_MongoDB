using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC_Forms
{
    internal class NavOrgUnits
    {
        public List<OrgUnit> RootNodes = new List<OrgUnit> ();
        public List<OrgUnit> SelfNodes = new List<OrgUnit>();
        public List<OrgUnit> ChildNodes = new List<OrgUnit>();

        //public NavOrgUnits()
        //{
        //    RootNodes = new List<OrgUnit>();
        //    SelfNodes = new List<OrgUnit>();
        //    ChildNodes = new List<OrgUnit>();
        //}
    }
}
