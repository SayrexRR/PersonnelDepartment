using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelDepartment.Models
{
    public struct Passport
    {
        public string DocumentNumber {  get; set; }
        public string Series { get; set; }
        public DateOnly DateOfBirth { get; set; }

        public Passport(string documentNumber)
        {
            DocumentNumber = documentNumber;
        }

        public Passport(string documentNumber, string series) : this(documentNumber)
        {
            Series = series;
        }

        public Passport(string documentNumber, string series, DateOnly dateOfBirth) : this(documentNumber, series)
        {
            DateOfBirth = dateOfBirth;
        }

        public override string ToString()
        {
            if (string.IsNullOrEmpty(Series))
            {
                return DocumentNumber;
            }

            return $"{Series} {DocumentNumber}";
        }
    }
}
