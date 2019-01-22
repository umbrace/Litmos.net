using System.Collections.Generic;

namespace LitmosApi.Models
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class User
    {
        private string idField;
        private string userNameField;
        private string firstNameField;
        private string lastNameField;
        private bool activeField;
        private string emailField;
        private string accessLevelField;
        private string brandField;
        private string loginKey;

        /// <remarks/>
        public string Id
        {
            get => idField;
            set => idField = value;
        }

        /// <remarks/>
        public string UserName
        {
            get => userNameField;
            set => userNameField = value;
        }

        /// <remarks/>
        public string FirstName
        {
            get => firstNameField;
            set => firstNameField = value;
        }

        /// <remarks/>
        public string LastName
        {
            get => lastNameField;
            set => lastNameField = value;
        }

        /// <remarks/>
        public bool Active
        {
            get => activeField;
            set => activeField = value;
        }

        /// <remarks/>
        public string Email
        {
            get => emailField;
            set => emailField = value;
        }

        /// <remarks/>
        public string AccessLevel
        {
            get => accessLevelField;
            set => accessLevelField = value;
        }

        /// <remarks/>
        public string Brand
        {
            get => brandField;
            set => brandField = value;
        }

        public string LoginKey
        {
            get => loginKey;
            set => loginKey = value;
        }
    }
}
