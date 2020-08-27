namespace Ecom.Models.Constants
{
    public static class StoredProcedure
    {
        #region User
        public const string USER_REGISTRATION = "User_Registration";
        public const string USER_GET = "User_Get";
        public const string USER_LOGIN = "User_Login";
        #endregion

        #region company 
        public const string COMPANY_REGISTRATION = "Company_Registration";
        public const string COMPANY_GET = "Company_Get";
        #endregion

        #region CategoryMaster
        public const string CATEGORYMASTER_GET = "CategoryMaster_Get";
        public const string CATEGORYMASTER_ADD = "CategoryMaster_Add";
        public const string CATEGORYMASTER_UPDATE = "CategoryMaster_Update";
        public const string CATEGORYMASTER_DELETE = "CategoryMaster_Delete";
        #endregion

        #region CategoryVarianceDetails
        public const string CATEGORYVARIANCEDETAILS_ADDRANGE = "CategoryVarianceDetails_AddRange";
        #endregion

        #region CategoryAttributeMaster
        public const string CATEGORYATTRIBUTEMASTER_ADDRANGE = "CategoryAttributeMaster_AddRange";
        #endregion
    }
}
