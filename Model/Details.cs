
namespace ClassLibrary4.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Details
    {
        public int Id { get; set; }
        public int PictureId { get; set; }
        public string eveniment { get; set; }
        public string location { get; set; }
    
        public virtual Picture Picture { get; set; }
    }
}
