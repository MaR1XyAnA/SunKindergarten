//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SunKindergarten.ModelFolder
{
    using System;
    using System.Collections.Generic;
    
    public partial class ResultTable
    {
        public int PersonalNumberResult { get; set; }
        public int PersonalNumberChildrenResult { get; set; }
        public string PersonalNameEvent { get; set; }
        public System.DateTime DataEventResult { get; set; }
        public string PersonalNameEvaluation { get; set; }
    
        public virtual ChildrenTable ChildrenTable { get; set; }
        public virtual EvaluationTables EvaluationTables { get; set; }
        public virtual EventTables EventTables { get; set; }
    }
}
