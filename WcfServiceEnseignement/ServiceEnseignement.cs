using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceEnseignement
{
  
    public class ServiceEnseignement : IServiceEnseignement
    {
        DataClassesEnseignementDataContext l = new DataClassesEnseignementDataContext();
        public List<Eleve> getByCNE(string s)
        {
            return (from p in l.Eleve where p.CNE == s select p).ToList();
        }
    }
}
