namespace LitmosApi.Models
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Users
    {

        private User[] _field;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("User")]
        public User[] User
        {
            get => _field;
            set => _field = value;
        }
    }

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

        public string LoginKey
        {
            get => loginKey;
            set => loginKey = value;
        }
    }


}
