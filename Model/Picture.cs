
namespace ClassLibrary4.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Picture
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Picture()
        {
            this.People = new HashSet<Person>();
            this.Details = new HashSet<Details>();
        }
    
        public int Id { get; set; }
        public string Path { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Person> People { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Details> Details { get; set; }
    }
}
