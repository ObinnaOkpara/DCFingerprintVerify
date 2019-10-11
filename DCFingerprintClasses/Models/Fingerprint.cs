using System;
using System.Collections.Generic;
using System.Text;

namespace DCFingerprintClasses.Models
{
    public class Fingerprint
    {
        public int Id { get; set; }
        public int StafftabId { get; set; }
        public byte[] FPfile { get; set; }
        public DateTime DateAdded { get; set; }

        public Stafftab Staff { get; set; }
    }
}
