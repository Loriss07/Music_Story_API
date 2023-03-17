using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStory
{
    internal class Class1
    {


        // NOTA: con il codice generato potrebbe essere richiesto almeno .NET Framework 4.5 o .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class item
        {

            private itemLink linkField;

            private byte idField;

            private string nameField;

            private string urlField;

            private byte mainField;

            private string update_dateField;

            private string creation_dateField;

            /// <remarks/>
            public itemLink link
            {
                get
                {
                    return this.linkField;
                }
                set
                {
                    this.linkField = value;
                }
            }

            /// <remarks/>
            public byte id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            public string url
            {
                get
                {
                    return this.urlField;
                }
                set
                {
                    this.urlField = value;
                }
            }

            /// <remarks/>
            public byte main
            {
                get
                {
                    return this.mainField;
                }
                set
                {
                    this.mainField = value;
                }
            }

            /// <remarks/>
            public string update_date
            {
                get
                {
                    return this.update_dateField;
                }
                set
                {
                    this.update_dateField = value;
                }
            }

            /// <remarks/>
            public string creation_date
            {
                get
                {
                    return this.creation_dateField;
                }
                set
                {
                    this.creation_dateField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class itemLink
        {

            private string itemField;

            /// <remarks/>
            public string item
            {
                get
                {
                    return this.itemField;
                }
                set
                {
                    this.itemField = value;
                }
            }
        }




    }
}
