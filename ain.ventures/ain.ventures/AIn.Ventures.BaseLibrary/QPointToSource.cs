//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AIn.Ventures.BaseLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class QPointToSource
    {
        public System.Guid QPointGUID { get; set; }
        public System.Guid SourceGUID { get; set; }
        public string Query { get; set; }
    
        public virtual QPoint QPoint { get; set; }
        public virtual Source Source { get; set; }
    }
}
