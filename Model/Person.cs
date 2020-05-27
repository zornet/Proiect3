namespace ClassLibrary4.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Person
    {
        public int Id { get; set; }
        public int PictureId { get; set; }
        public string person_name { get; set; }
    
        public virtual Picture Picture { get; set; }
    }
}
