using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLinqSetsApp
{
    internal class Company
    {
        public string? Title { get; set; }

        public override string ToString()
        {
            return $"{Title}";
        }
    }

    class CompanyComparer : IEqualityComparer<Company>
    {
        public bool Equals(Company? x, Company? y)
        {
            return x.Title.Equals(y.Title);
        }

        public int GetHashCode([DisallowNull] Company obj)
        {
            return obj.Title.GetHashCode();
        }
    }
}
