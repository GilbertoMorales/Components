using System;
using System.Collections.Generic;

namespace XamarinAuth.Helpers
{
    public abstract partial class OAuth
    {
        public OAuth()
        {
        }

        public string Description
        {
            get;
            set;
        }

        public bool AllowCancel
        {
            get;
            set;
        }
        public string OAuth_IdApplication_IdAPI_KeyAPI_IdClient_IdCustomer
        {
            get;
            set;
        }

        public Uri OAuth_UriAuthorization
        {
            get;
            set;
        }

        public Uri OAuth_UriCallbackAKARedirect
        {
            get;
            set;
        }

        public int OAuth_UriCallbackAKARedirectPort
        {
            get;
            set;
        }

        public string OAuth_UriCallbackAKARedirectPath
        {
            get;
            set;
        }

        public Uri OAuth_UriAccessToken_UriRequestToken
        {
            get;
            set;
        }

        public Dictionary<string, string> AccountProperties
        {
            get;
            set;
        }

        public string HowToMarkDown
        {
            get;
            set;
        }

        public string HowToMarkDownPrivateSecret
        {
            get;
            set;
        }
    }
}
