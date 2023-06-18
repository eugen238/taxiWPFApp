﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_Work_WPF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class AdminEntities : DbContext
    {
        public AdminEntities()
            : base("name=AdminEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<CHECKADMIN_Result> CHECKADMIN(string cHECKLOGIN, string cHECKPASSWORD)
        {
            var cHECKLOGINParameter = cHECKLOGIN != null ?
                new ObjectParameter("CHECKLOGIN", cHECKLOGIN) :
                new ObjectParameter("CHECKLOGIN", typeof(string));
    
            var cHECKPASSWORDParameter = cHECKPASSWORD != null ?
                new ObjectParameter("CHECKPASSWORD", cHECKPASSWORD) :
                new ObjectParameter("CHECKPASSWORD", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CHECKADMIN_Result>("CHECKADMIN", cHECKLOGINParameter, cHECKPASSWORDParameter);
        }
    
        public virtual int CHECKUSER(string cHECKLOGIN, string cHECKPASSWORD)
        {
            var cHECKLOGINParameter = cHECKLOGIN != null ?
                new ObjectParameter("CHECKLOGIN", cHECKLOGIN) :
                new ObjectParameter("CHECKLOGIN", typeof(string));
    
            var cHECKPASSWORDParameter = cHECKPASSWORD != null ?
                new ObjectParameter("CHECKPASSWORD", cHECKPASSWORD) :
                new ObjectParameter("CHECKPASSWORD", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CHECKUSER", cHECKLOGINParameter, cHECKPASSWORDParameter);
        }
    
        public virtual int DELETECAR(Nullable<decimal> dELETEID)
        {
            var dELETEIDParameter = dELETEID.HasValue ?
                new ObjectParameter("DELETEID", dELETEID) :
                new ObjectParameter("DELETEID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DELETECAR", dELETEIDParameter);
        }
    
        public virtual int DELETEDRIVER(Nullable<decimal> dELETEID)
        {
            var dELETEIDParameter = dELETEID.HasValue ?
                new ObjectParameter("DELETEID", dELETEID) :
                new ObjectParameter("DELETEID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DELETEDRIVER", dELETEIDParameter);
        }
    
        public virtual ObjectResult<GETCARS_Result> GETCARS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GETCARS_Result>("GETCARS");
        }
    
        public virtual ObjectResult<GETDRIVERS_Result> GETDRIVERS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GETDRIVERS_Result>("GETDRIVERS");
        }
    
        public virtual int GETPROFIT(ObjectParameter pROFIT)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GETPROFIT", pROFIT);
        }
    
        public virtual ObjectResult<GETSTATISTICS_Result> GETSTATISTICS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GETSTATISTICS_Result>("GETSTATISTICS");
        }
    
        public virtual int INSERTCAR(string iNSERTMARK, string iNSERTMODEL, Nullable<decimal> iNSERTNUMBEROFCAR)
        {
            var iNSERTMARKParameter = iNSERTMARK != null ?
                new ObjectParameter("INSERTMARK", iNSERTMARK) :
                new ObjectParameter("INSERTMARK", typeof(string));
    
            var iNSERTMODELParameter = iNSERTMODEL != null ?
                new ObjectParameter("INSERTMODEL", iNSERTMODEL) :
                new ObjectParameter("INSERTMODEL", typeof(string));
    
            var iNSERTNUMBEROFCARParameter = iNSERTNUMBEROFCAR.HasValue ?
                new ObjectParameter("INSERTNUMBEROFCAR", iNSERTNUMBEROFCAR) :
                new ObjectParameter("INSERTNUMBEROFCAR", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INSERTCAR", iNSERTMARKParameter, iNSERTMODELParameter, iNSERTNUMBEROFCARParameter);
        }
    
        public virtual int INSERTDRIVER(string iNSERTNAME, string iNSERTSURNAME, string iNSERTEMAIL, Nullable<decimal> iNSERTAGE)
        {
            var iNSERTNAMEParameter = iNSERTNAME != null ?
                new ObjectParameter("INSERTNAME", iNSERTNAME) :
                new ObjectParameter("INSERTNAME", typeof(string));
    
            var iNSERTSURNAMEParameter = iNSERTSURNAME != null ?
                new ObjectParameter("INSERTSURNAME", iNSERTSURNAME) :
                new ObjectParameter("INSERTSURNAME", typeof(string));
    
            var iNSERTEMAILParameter = iNSERTEMAIL != null ?
                new ObjectParameter("INSERTEMAIL", iNSERTEMAIL) :
                new ObjectParameter("INSERTEMAIL", typeof(string));
    
            var iNSERTAGEParameter = iNSERTAGE.HasValue ?
                new ObjectParameter("INSERTAGE", iNSERTAGE) :
                new ObjectParameter("INSERTAGE", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INSERTDRIVER", iNSERTNAMEParameter, iNSERTSURNAMEParameter, iNSERTEMAILParameter, iNSERTAGEParameter);
        }
    
        public virtual int UPDATECAR(Nullable<decimal> uPDATEID, string uPDATEMARK, string uPDATEMODEL, Nullable<decimal> uPDATENUMBEROFCAR)
        {
            var uPDATEIDParameter = uPDATEID.HasValue ?
                new ObjectParameter("UPDATEID", uPDATEID) :
                new ObjectParameter("UPDATEID", typeof(decimal));
    
            var uPDATEMARKParameter = uPDATEMARK != null ?
                new ObjectParameter("UPDATEMARK", uPDATEMARK) :
                new ObjectParameter("UPDATEMARK", typeof(string));
    
            var uPDATEMODELParameter = uPDATEMODEL != null ?
                new ObjectParameter("UPDATEMODEL", uPDATEMODEL) :
                new ObjectParameter("UPDATEMODEL", typeof(string));
    
            var uPDATENUMBEROFCARParameter = uPDATENUMBEROFCAR.HasValue ?
                new ObjectParameter("UPDATENUMBEROFCAR", uPDATENUMBEROFCAR) :
                new ObjectParameter("UPDATENUMBEROFCAR", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UPDATECAR", uPDATEIDParameter, uPDATEMARKParameter, uPDATEMODELParameter, uPDATENUMBEROFCARParameter);
        }
    
        public virtual int UPDATEDRIVER(Nullable<decimal> uPDATEID, string uPDATENAME, string uPDATESURNAME, string uPDATEEMAIL, Nullable<decimal> uPDATEAGE)
        {
            var uPDATEIDParameter = uPDATEID.HasValue ?
                new ObjectParameter("UPDATEID", uPDATEID) :
                new ObjectParameter("UPDATEID", typeof(decimal));
    
            var uPDATENAMEParameter = uPDATENAME != null ?
                new ObjectParameter("UPDATENAME", uPDATENAME) :
                new ObjectParameter("UPDATENAME", typeof(string));
    
            var uPDATESURNAMEParameter = uPDATESURNAME != null ?
                new ObjectParameter("UPDATESURNAME", uPDATESURNAME) :
                new ObjectParameter("UPDATESURNAME", typeof(string));
    
            var uPDATEEMAILParameter = uPDATEEMAIL != null ?
                new ObjectParameter("UPDATEEMAIL", uPDATEEMAIL) :
                new ObjectParameter("UPDATEEMAIL", typeof(string));
    
            var uPDATEAGEParameter = uPDATEAGE.HasValue ?
                new ObjectParameter("UPDATEAGE", uPDATEAGE) :
                new ObjectParameter("UPDATEAGE", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UPDATEDRIVER", uPDATEIDParameter, uPDATENAMEParameter, uPDATESURNAMEParameter, uPDATEEMAILParameter, uPDATEAGEParameter);
        }
    }
}