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
    
    public partial class UserEntities : DbContext
    {
        public UserEntities()
            : base("name=UserEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<CHECKUSER_Result> CHECKUSER(string cHECKLOGIN, string cHECKPASSWORD)
        {
            var cHECKLOGINParameter = cHECKLOGIN != null ?
                new ObjectParameter("CHECKLOGIN", cHECKLOGIN) :
                new ObjectParameter("CHECKLOGIN", typeof(string));
    
            var cHECKPASSWORDParameter = cHECKPASSWORD != null ?
                new ObjectParameter("CHECKPASSWORD", cHECKPASSWORD) :
                new ObjectParameter("CHECKPASSWORD", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CHECKUSER_Result>("CHECKUSER", cHECKLOGINParameter, cHECKPASSWORDParameter);
        }
    
        public virtual int DELETEUSER(Nullable<decimal> dELETEID)
        {
            var dELETEIDParameter = dELETEID.HasValue ?
                new ObjectParameter("DELETEID", dELETEID) :
                new ObjectParameter("DELETEID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DELETEUSER", dELETEIDParameter);
        }
    
        public virtual ObjectResult<GETHISTORY_Result> GETHISTORY(Nullable<decimal> gETCLIENTID)
        {
            var gETCLIENTIDParameter = gETCLIENTID.HasValue ?
                new ObjectParameter("GETCLIENTID", gETCLIENTID) :
                new ObjectParameter("GETCLIENTID", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GETHISTORY_Result>("GETHISTORY", gETCLIENTIDParameter);
        }
    
        public virtual int INSERTORDER(Nullable<decimal> iNSERTCARID, Nullable<decimal> iNSERTDRIVERID, Nullable<System.DateTime> iNSERTTIME, Nullable<decimal> iNSERTCLIENTID, Nullable<decimal> iNSERTCOST, string iNSERTFROMLOCATION, string iNSERTTOLOCATION, Nullable<decimal> iNSERTPOINT)
        {
            var iNSERTCARIDParameter = iNSERTCARID.HasValue ?
                new ObjectParameter("INSERTCARID", iNSERTCARID) :
                new ObjectParameter("INSERTCARID", typeof(decimal));
    
            var iNSERTDRIVERIDParameter = iNSERTDRIVERID.HasValue ?
                new ObjectParameter("INSERTDRIVERID", iNSERTDRIVERID) :
                new ObjectParameter("INSERTDRIVERID", typeof(decimal));
    
            var iNSERTTIMEParameter = iNSERTTIME.HasValue ?
                new ObjectParameter("INSERTTIME", iNSERTTIME) :
                new ObjectParameter("INSERTTIME", typeof(System.DateTime));
    
            var iNSERTCLIENTIDParameter = iNSERTCLIENTID.HasValue ?
                new ObjectParameter("INSERTCLIENTID", iNSERTCLIENTID) :
                new ObjectParameter("INSERTCLIENTID", typeof(decimal));
    
            var iNSERTCOSTParameter = iNSERTCOST.HasValue ?
                new ObjectParameter("INSERTCOST", iNSERTCOST) :
                new ObjectParameter("INSERTCOST", typeof(decimal));
    
            var iNSERTFROMLOCATIONParameter = iNSERTFROMLOCATION != null ?
                new ObjectParameter("INSERTFROMLOCATION", iNSERTFROMLOCATION) :
                new ObjectParameter("INSERTFROMLOCATION", typeof(string));
    
            var iNSERTTOLOCATIONParameter = iNSERTTOLOCATION != null ?
                new ObjectParameter("INSERTTOLOCATION", iNSERTTOLOCATION) :
                new ObjectParameter("INSERTTOLOCATION", typeof(string));
    
            var iNSERTPOINTParameter = iNSERTPOINT.HasValue ?
                new ObjectParameter("INSERTPOINT", iNSERTPOINT) :
                new ObjectParameter("INSERTPOINT", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INSERTORDER", iNSERTCARIDParameter, iNSERTDRIVERIDParameter, iNSERTTIMEParameter, iNSERTCLIENTIDParameter, iNSERTCOSTParameter, iNSERTFROMLOCATIONParameter, iNSERTTOLOCATIONParameter, iNSERTPOINTParameter);
        }
    
        public virtual int INSERTUSER(string iNSERTLOGIN, string iNSERTPASSWORD, string iNSERTNAME, string iNSERTSURNAME, string iNSERTNUMBER)
        {
            var iNSERTLOGINParameter = iNSERTLOGIN != null ?
                new ObjectParameter("INSERTLOGIN", iNSERTLOGIN) :
                new ObjectParameter("INSERTLOGIN", typeof(string));
    
            var iNSERTPASSWORDParameter = iNSERTPASSWORD != null ?
                new ObjectParameter("INSERTPASSWORD", iNSERTPASSWORD) :
                new ObjectParameter("INSERTPASSWORD", typeof(string));
    
            var iNSERTNAMEParameter = iNSERTNAME != null ?
                new ObjectParameter("INSERTNAME", iNSERTNAME) :
                new ObjectParameter("INSERTNAME", typeof(string));
    
            var iNSERTSURNAMEParameter = iNSERTSURNAME != null ?
                new ObjectParameter("INSERTSURNAME", iNSERTSURNAME) :
                new ObjectParameter("INSERTSURNAME", typeof(string));
    
            var iNSERTNUMBERParameter = iNSERTNUMBER != null ?
                new ObjectParameter("INSERTNUMBER", iNSERTNUMBER) :
                new ObjectParameter("INSERTNUMBER", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INSERTUSER", iNSERTLOGINParameter, iNSERTPASSWORDParameter, iNSERTNAMEParameter, iNSERTSURNAMEParameter, iNSERTNUMBERParameter);
        }
    
        public virtual int UPDATEUSER(Nullable<decimal> uSERID, string uPDATELOGIN, string uPDATEPASSWORD, string uPDATENAME, string uPDATESURNAME, string uPDATENUMBER)
        {
            var uSERIDParameter = uSERID.HasValue ?
                new ObjectParameter("USERID", uSERID) :
                new ObjectParameter("USERID", typeof(decimal));
    
            var uPDATELOGINParameter = uPDATELOGIN != null ?
                new ObjectParameter("UPDATELOGIN", uPDATELOGIN) :
                new ObjectParameter("UPDATELOGIN", typeof(string));
    
            var uPDATEPASSWORDParameter = uPDATEPASSWORD != null ?
                new ObjectParameter("UPDATEPASSWORD", uPDATEPASSWORD) :
                new ObjectParameter("UPDATEPASSWORD", typeof(string));
    
            var uPDATENAMEParameter = uPDATENAME != null ?
                new ObjectParameter("UPDATENAME", uPDATENAME) :
                new ObjectParameter("UPDATENAME", typeof(string));
    
            var uPDATESURNAMEParameter = uPDATESURNAME != null ?
                new ObjectParameter("UPDATESURNAME", uPDATESURNAME) :
                new ObjectParameter("UPDATESURNAME", typeof(string));
    
            var uPDATENUMBERParameter = uPDATENUMBER != null ?
                new ObjectParameter("UPDATENUMBER", uPDATENUMBER) :
                new ObjectParameter("UPDATENUMBER", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UPDATEUSER", uSERIDParameter, uPDATELOGINParameter, uPDATEPASSWORDParameter, uPDATENAMEParameter, uPDATESURNAMEParameter, uPDATENUMBERParameter);
        }
    
        public virtual ObjectResult<GETCARSNAMES_Result> GETCARSNAMES()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GETCARSNAMES_Result>("GETCARSNAMES");
        }
    
        public virtual int GETDECTYPTEDPASSWORD(string eNCRYPTEDPASSWORD, ObjectParameter dECRYPTEDPASSWORD)
        {
            var eNCRYPTEDPASSWORDParameter = eNCRYPTEDPASSWORD != null ?
                new ObjectParameter("ENCRYPTEDPASSWORD", eNCRYPTEDPASSWORD) :
                new ObjectParameter("ENCRYPTEDPASSWORD", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GETDECTYPTEDPASSWORD", eNCRYPTEDPASSWORDParameter, dECRYPTEDPASSWORD);
        }
    
        public virtual ObjectResult<GETUSER_Result> GETUSER(string gETLOGIN)
        {
            var gETLOGINParameter = gETLOGIN != null ?
                new ObjectParameter("GETLOGIN", gETLOGIN) :
                new ObjectParameter("GETLOGIN", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GETUSER_Result>("GETUSER", gETLOGINParameter);
        }
    }
}
