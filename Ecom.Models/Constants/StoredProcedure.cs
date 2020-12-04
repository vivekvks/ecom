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
        public const string CATEGORYMASTER_GETHIERARCHYJSON = "CategoryMaster_GetHierarchyJson";
        public const string CATEGORYMASTER_ADD = "CategoryMaster_Add";
        public const string CATEGORYMASTER_UPDATE = "CategoryMaster_Update";
        public const string CATEGORYMASTER_DELETE = "CategoryMaster_Delete";
        #endregion

        #region CategoryVarianceDetails
        public const string CATEGORYVARIANCEDETAILS_ADDRANGE = "CategoryVarianceDetails_AddRange";
        public const string CATEGORYVARIANCEDETAILS_GET = "CategoryVarianceDetails_Get";
        #endregion

        #region CategoryAttributeMaster
        public const string CATEGORYATTRIBUTEMASTER_ADDRANGE = "CategoryAttributeMaster_AddRange";
        public const string CATEGORYATTRIBUTEMASTER_GET = "CategoryAttributeMaster_Get";
        #endregion

        #region CategoryReturnMaster
        public const string CATEGORYRETURNMASTER_LIST = "CategoryReturnMaster_List";
        #endregion

        #region VarianceMaster
        public const string VARIANCEMASTER_LIST = "VarianceMaster_List";
        #endregion

        #region ProductListing 
        public const string PRODUCTLISTING_ADDRANGE = "ProductListing_AddRange";
        public const string PRODUCTLISTING_GET = "Product_Get";
        public const string PRODUCTLISTING_UPDATE = "ProductListing_Update";
        public const string PRODUCTLISTING_GETBYUSERID = "ProductListing_GetByUserID";
        public const string PRODUCTLISTING_LOOKUP = "ProductListing_Lookup";
        public const string PRODUCTLISTING_FACETSEARCH = "ProductListing_FacetSearch";
        public const string PRODUCTLISTING_DETAIL_GET = "ProductDetail_Get";
        #endregion

        #region QuestionMaster
        public const string QUESTIONMASTER_GET = "QuestionMaster_Get";
        public const string QUESTIONMASTER_ADD = "QuestionMaster_Add";
        public const string QUESTIONMASTER_UPDATE = "QuestionMaster_Update";
        public const string QUESTIONMASTER_DELETE = "QuestionMaster_Delete";
        public const string QUESTIONMASTER_LIST = "QuestionMaster_List";
        #endregion

        #region AnswerMaster
        public const string ANSWERMASTER_GET = "AnswerMaster_Get";
        public const string ANSWERMASTER_ADD = "AnswerMaster_Add";
        public const string ANSWERMASTER_UPDATE = "AnswerMaster_Update";
        public const string ANSWERMASTER_DELETE = "AnswerMaster_Delete";
        public const string ANSWERREACTION_SAVE = "AnswerReaction_Save";
        #endregion

        #region ReviewMaster
        public const string REVIEWMASTER_LIST = "ReviewMaster_List";
        public const string REVIEWMASTER_ADD = "ReviewMaster_Add";
        public const string REVIEWMASTER_UPDATE = "ReviewMaster_Update";
        public const string REVIEWMASTER_DELETE = "ReviewMaster_Delete";
        public const string REVIEWREACTION_SAVE = "ReviewReaction_Save";
        #endregion

        #region OfferMaster
        public const string OFFERMASTER_LIST = "OfferMaster_List";
        public const string OFFERMASTER_GET = "OfferMaster_Get";
        public const string OFFERMASTER_ADD = "OfferMaster_Add";
        public const string OFFERMASTER_UPDATE = "OfferMaster_Update";
        public const string OFFERMASTER_DELETE = "OfferMaster_Delete";


        #endregion

        #region OrderMaster
        public const string ORDERMASTER_ADD = "OrderMaster_Add";
        #endregion
    }
}
