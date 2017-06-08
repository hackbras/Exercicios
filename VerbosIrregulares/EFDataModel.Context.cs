﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VerbosIrregulares
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CSFerramentasEntities : DbContext
    {
        public CSFerramentasEntities()
            : base("name=CSFerramentasEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Verb> Verbs { get; set; }
    
        [DbFunction("CSFerramentasEntities", "fn_verbos")]
        public virtual IQueryable<fn_verbos_Result> fn_verbos(string translate, string baseForm, string pastSimple, string pastParticiple)
        {
            var translateParameter = translate != null ?
                new ObjectParameter("translate", translate) :
                new ObjectParameter("translate", typeof(string));
    
            var baseFormParameter = baseForm != null ?
                new ObjectParameter("baseForm", baseForm) :
                new ObjectParameter("baseForm", typeof(string));
    
            var pastSimpleParameter = pastSimple != null ?
                new ObjectParameter("pastSimple", pastSimple) :
                new ObjectParameter("pastSimple", typeof(string));
    
            var pastParticipleParameter = pastParticiple != null ?
                new ObjectParameter("pastParticiple", pastParticiple) :
                new ObjectParameter("pastParticiple", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fn_verbos_Result>("[CSFerramentasEntities].[fn_verbos](@translate, @baseForm, @pastSimple, @pastParticiple)", translateParameter, baseFormParameter, pastSimpleParameter, pastParticipleParameter);
        }
    
        [DbFunction("CSFerramentasEntities", "fn_word")]
        public virtual IQueryable<fn_word_Result> fn_word(Nullable<int> id_word)
        {
            var id_wordParameter = id_word.HasValue ?
                new ObjectParameter("id_word", id_word) :
                new ObjectParameter("id_word", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fn_word_Result>("[CSFerramentasEntities].[fn_word](@id_word)", id_wordParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> RandomNumber()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("RandomNumber");
        }
    }
}